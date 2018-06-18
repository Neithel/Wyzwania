using System;
using System.Collections.Generic;
using System.Text;

namespace WyzwaniaCore
{
    class Challenge
    {
        private int currentDay=0;

        private string name;

        private int quantityDays;

        private int exp;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int QuantityDays
        {
            get
            {
                return this.quantityDays;
            }
            set
            {
                this.quantityDays = value;
            }
        }

        public int Exp
        {
            get
            {
                return this.exp;
            }
            set
            {
                this.exp = value;
            }
        }

        public int CurrentDay
        {
            get
            {
                return this.currentDay;
            }
            set
            {
                this.currentDay = value;
            }
        }


        public Challenge(string name, int quantityDays, int exp)
        {
            this.Name = name;
            this.QuantityDays = quantityDays;
            this.Exp = exp;
            this.CurrentDay = 0;
        }

        public int HowManyMoreDays()
        {
            return this.QuantityDays-currentDay;
        }

    }
}
