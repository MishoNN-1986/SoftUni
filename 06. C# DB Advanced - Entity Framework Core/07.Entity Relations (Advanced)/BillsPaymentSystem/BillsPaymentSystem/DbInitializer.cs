﻿using BillsPaymentSystem.Data;
using BillsPaymentSystem.Models;
using BillsPaymentSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BillsPaymentSystem.App
{
    public class DbInitializer
    {
        public static void Seed(BillsPaymentSystemContext context)
        {
            SeedUsers(context);

            SeedCreditCards(context);

            SeedBankAccounts(context);

            SeedPaymentMethods(context);
        }

        private static void SeedPaymentMethods(BillsPaymentSystemContext context)
        {
            var paymentMethods = new List<PaymentMethod>();

            for (int i = 0; i < 3; i++)
            {
                var paymentMethod = new PaymentMethod()
                {
                    UserId = new Random().Next(1, 5),
                    Type = (PaymentType)new Random().Next(0, 2),
                };

                if (i % 3 == 0)
                {
                    paymentMethod.CreditCardId = new Random().Next(1, 5);
                    paymentMethod.BankAccountId = new Random().Next(1, 5);
                }
                else if (i % 2 == 0)
                {
                    paymentMethod.CreditCardId = new Random().Next(1, 5);
                }
                else
                {
                    paymentMethod.BankAccountId = new Random().Next(1, 5);
                }


                if (!IsValid(paymentMethod))
                {
                    continue;
                }

                //var user = context.Users.Find(paymentMethod.UserId);
                //var creditCard = context.Users.Find(paymentMethod.CreditCardId);
                //var bankAccount = context.Users.Find(paymentMethod.BankAccountId);

                //if(user == null)
                //{
                //    continue;
                //}

                paymentMethods.Add(paymentMethod);
            }

            context.PaymentMethods.AddRange(paymentMethods);
            context.SaveChanges();
        }

        private static void SeedBankAccounts(BillsPaymentSystemContext context)
        {
            var bankAccounts = new List<BankAccount>();

            for (int i = 0; i < 8; i++)
            {
                var bankAccount = new BankAccount()
                {
                    Balance = new Random().Next(-250, 250),
                    BankName = "Bank" + i,
                    SWIFT = "SWIFT" + i + 1
                };

                if (!IsValid(bankAccount))
                {
                    continue;
                }

                bankAccounts.Add(bankAccount);
            }

            context.BankAccounts.AddRange(bankAccounts);
            context.SaveChanges();
        }

        private static void SeedCreditCards(BillsPaymentSystemContext context)
        {
            var creditCards = new List<CreditCard>();

            for (int i = 0; i < 8; i++)
            {
                var creditCard = new CreditCard()
                {
                    Limit = new Random().Next(-25000, 250000),
                    MoneyOwed = new Random().Next(-25000, 250000),
                    ExpirationDate = DateTime.Now.AddDays(new Random().Next(-200, 200))
                };

                if (!IsValid(creditCard))
                {
                    continue;
                }

                creditCards.Add(creditCard);
            }
            context.CreditCards.AddRange(creditCards);
            context.SaveChanges();
        }

        private static void SeedUsers(BillsPaymentSystemContext context)
        {
            string[] firstNames =
            {
                "Gosho",
                "Pesho",
                "Ivan",
                "Kiro",
                null,
                ""
            };

            string[] lastNames =
            {
                "Goshev",
                "Peshov",
                "Ivanov",
                "Kirev",
                null,
                ""
            };

            string[] emails =
            {
                "gosho@abv.bg",
                "pesho@abv.bg",
                "ivan@abv.bg",
                "kiro@abv.bg",
                null,
                "ERROR"
            };

            string[] passwords =
            {
                "A123466656.Ddd",
                "A1236664h.ghnJhn",
                "A54466654g.fffKnf",
                "A5556666hhh.Lk",
                null,
                "ERROR"
            };

            List<User> users = new List<User>();

            for (int i = 0; i < firstNames.Length; i++)
            {
                var user = new User
                {
                    FirstName = firstNames[i],
                    LastName = lastNames[i],
                    Email = emails[i],
                    Password = passwords[i]
                };

                if (!IsValid(user))
                {
                    continue;
                }

                users.Add(user);
            }

            context.Users.AddRange(users);
            context.SaveChanges();
        }

        private static bool IsValid(object entity)
        {
            var ValidationContext = new ValidationContext(entity);
            var validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(entity, ValidationContext, validationResults, true);

            return isValid;
        }
    }
}
