﻿using _08._MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _08._MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int code)
        : base(id, firstName, lastName)
        {
            this.Code = code;
        }

        public int Code { get; private set; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .Append($"Code Number: {Code}");

            return builder.ToString();
        }
    }
}
