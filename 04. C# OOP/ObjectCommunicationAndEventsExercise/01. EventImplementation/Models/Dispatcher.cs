﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _01._EventImplementation
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs e);

    public class Dispatcher
    {
        private string name;
        public event NameChangeEventHandler NameChange;

        public string Name
        {
            get => this.name;
            set
            {
                this.name = value;
                OnNameChange(new NameChangeEventArgs(value));
            }
        }

        public void OnNameChange(NameChangeEventArgs args)
        {
            NameChange?.Invoke(this, args);
        }
    }
}
