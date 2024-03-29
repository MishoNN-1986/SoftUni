﻿namespace VaporStore.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Data;
    using Newtonsoft.Json;
    using VaporStore.Data.Models;
    using VaporStore.Data.Models.Enums;
    using VaporStore.DataProcessor.ImportDtos;

    public static class Deserializer
    {
        public static string ImportGames(VaporStoreDbContext context, string jsonString)
        {
            var gamesDto = JsonConvert.DeserializeObject<ImportGameDto[]>(jsonString);

            var sb = new StringBuilder();
            var games = new List<Game>();

            foreach (var gameDto in gamesDto)
            {
                if (!IsValid(gameDto) || gameDto.Tags.Count == 0)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }
                var game = new Game
                {
                    Name = gameDto.Name,
                    Price = gameDto.Price,
                    ReleaseDate = DateTime.ParseExact(gameDto.ReleaseDate, "yyyy-MM-dd", CultureInfo.InvariantCulture)
                };

                var developer = GetDeveloper(context, gameDto.Developer);
                var genre = GetGenre(context, gameDto.Genre);

                game.Developer = developer;
                game.Genre = genre;

                foreach (var currentTag in gameDto.Tags) //пълним mapping table
                {
                    var tag = GetTag(context, currentTag);

                    game.GameTags.Add(new GameTag
                    {
                        Game = game,
                        Tag = tag
                    });
                }

                games.Add(game);
                sb.AppendLine($"Added {game.Name} ({game.Genre.Name}) with {game.GameTags.Count} tags");
            }

            context.Games.AddRange(games);
            context.SaveChanges();

            string result = sb.ToString().TrimEnd();

            return result;
        }

        public static string ImportUsers(VaporStoreDbContext context, string jsonString)
        {
            var usersDto = JsonConvert.DeserializeObject<ImportUserDto[]>(jsonString);

            var sb = new StringBuilder();
            var users = new List<User>();

            foreach (var userDto in usersDto)
            {
                if (!IsValid(userDto) || !userDto.Cards.All(IsValid))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                bool isValidEnum = true;

                foreach (var cardDto in userDto.Cards)
                {
                    var cardType = Enum.TryParse<CardType>(cardDto.Type, out CardType test);

                    if (!cardType)
                    {
                        isValidEnum = false;
                        break;
                    }

                }

                if (!isValidEnum)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var user = new User
                {
                    FullName = userDto.FullName,
                    UserName = userDto.UserName,
                    Age = userDto.Age,
                    Email = userDto.Email
                };

                foreach (var cardDto in userDto.Cards)
                {

                    user.Cards.Add(new Card
                    {
                        Number = cardDto.Number,
                        Cvc = cardDto.Cvc,
                        Type = Enum.Parse<CardType>(cardDto.Type)
                    });
                }

                users.Add(user);
                sb.AppendLine($"Imported {user.UserName} with {user.Cards.Count} cards");
            }

            context.Users.AddRange(users);
            context.SaveChanges();

            string result = sb.ToString().TrimEnd();

            return result;
        }

        public static string ImportPurchases(VaporStoreDbContext context, string xmlString)
        {
            var xmlSerializer = new XmlSerializer(typeof(ImportPurchaseDto[]), new XmlRootAttribute("Purchases"));
            var purchasesDto = (ImportPurchaseDto[])xmlSerializer.Deserialize(new StringReader(xmlString));

            var sb = new StringBuilder();
            var purchases = new List<Purchase>();

            foreach (var purchaseDto in purchasesDto)
            {
                if (!IsValid(purchasesDto))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }
                var isValidEnum = Enum.TryParse<PurchaseType>(purchaseDto.Type, out PurchaseType purchaseType);

                if (!isValidEnum)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var game = context.Games.FirstOrDefault(x => x.Name == purchaseDto.Title);
                var card = context.Cards.FirstOrDefault(x => x.Number == purchaseDto.Card);

                if (game == null || card == null)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                var purchase = new Purchase
                {
                    Type = purchaseType,
                    Date = DateTime.ParseExact(purchaseDto.Date, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                    ProductKey = purchaseDto.Key,
                    Game = game,
                    Card = card
                };

                purchases.Add(purchase);
                sb.AppendLine($"Imported {purchase.Game.Name} for {purchase.Card.User.UserName}");
            }

            context.Purchases.AddRange(purchases);
            context.SaveChanges();

            string result = sb.ToString().TrimEnd();

            return result;
        }

        private static Tag GetTag(VaporStoreDbContext context, string currentTag)
        {
            var tag = context.Tags.FirstOrDefault(x => x.Name == currentTag);

            if (tag == null)
            {
                tag = new Tag
                {
                    Name = currentTag
                };

                context.Tags.Add(tag);
                context.SaveChanges();
            }

            return tag;
        }

        private static Genre GetGenre(VaporStoreDbContext context, string gameDtoGenre)
        {
            var genre = context.Genres.FirstOrDefault(x => x.Name == gameDtoGenre);
            if (genre == null)
            {
                genre = new Genre
                {
                    Name = gameDtoGenre
                };

                context.Genres.Add(genre);
                context.SaveChanges();
            }

            return genre;
        }

        private static Developer GetDeveloper(VaporStoreDbContext context, string gameDtoDeveloper)
        {
            var developer = context.Developers.FirstOrDefault(x => x.Name == gameDtoDeveloper);

            if (developer == null)
            {
                developer = new Data.Models.Developer
                {
                    Name = gameDtoDeveloper,
                };

                context.Developers.Add(developer); //в практиката не е ок, но за изпита става
                context.SaveChanges();
            }

            return developer;
        }

        private static bool IsValid(object entity)
        {
            var validationContext = new ValidationContext(entity);
            var validationResult = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(entity, validationContext, validationResult, true);

            return isValid;
        }
    }
}