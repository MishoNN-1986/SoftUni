﻿using _07._InfernoInfinity.Contracts;
using _07._InfernoInfinity.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07._InfernoInfinity.Models.Gems
{
    public abstract class Gem : IGem, IQualitativeGem
    {
        protected Gem(GemClarity clarity, int strength, int agility, int vitality)
        {
            this.Clarity = clarity;
            this.Strength = strength + (int)Clarity;
            this.Agility = agility + (int)Clarity;
            this.Vitality = vitality + (int)Clarity;
        }

        public int Strength { get; private set; }

        public int Agility { get; private set; }

        public int Vitality { get; private set; }

        public GemClarity Clarity { get; private set; }
    }
}
