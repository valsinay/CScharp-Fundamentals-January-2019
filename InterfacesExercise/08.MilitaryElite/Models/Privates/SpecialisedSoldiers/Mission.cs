﻿using _08.MilitaryElite.Contracts.Privates.SpecialisedSoldiers;
using System;

namespace _08.MilitaryElite.Models.Privates.SpecialisedSoldiers
{
    public class Mission : IMission
    {
        private string state;

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; private set; }

        public string State
        {
            get => this.state;
            set
            {
                if (value != "inProgress" && value != "Finished")
                {
                    throw new ArgumentException("Invalid State!");
                }
                this.state = value;
            }
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
