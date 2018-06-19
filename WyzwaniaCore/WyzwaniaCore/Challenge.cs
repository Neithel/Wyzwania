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

        private TimeSpan duration = new TimeSpan(0);

        private int exp;

        private DateTime startDay;

        private DateTime endDay;

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

        public DateTime StartDay
        {
            get
            {
                return this.startDay;
            }
            set
            {
                this.startDay = DateTime.Today;
            }
        }

        public TimeSpan Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        public DateTime EndDay
        {
            get
            {
                return this.endDay;
            }
            set
            {
                this.endDay = this.StartDay.Add(duration);
            }
        }

        public Challenge(string name, int quantityDays, int exp = 10)
        {
            this.Name = name;
            this.QuantityDays = quantityDays;
            this.Exp = exp;
            this.CurrentDay = 0;
            this.startDay = DateTime.Today;
            //this.Duration = this.Duration(QuantityDays);
        }

        public int HowManyMoreDays()
        {
            return this.QuantityDays-currentDay;
        }

    }
}
