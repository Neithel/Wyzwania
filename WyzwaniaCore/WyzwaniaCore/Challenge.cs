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

        private TimeSpan totalDuration = new TimeSpan(0);

        private int exp;

        private DateTime startDay;

        private DateTime endDay;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
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
            private set
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
            private set
            {
                if (value != 0)
                    this.exp = value;
                else this.exp = 10;
            }
        }

        public int CurrentDay
        {
            get
            {
                return this.currentDay;
            }
            private set
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
            private set
            {
                this.startDay = value;
            }
        }

        public TimeSpan TotalDuration
        {
            get
            {
                return this.totalDuration;
            }
            private set
            {
                this.totalDuration = value;
            }
        }

        public DateTime EndDay
        {
            get
            {
                return this.endDay;
            }
            private set
            {
                this.endDay = value;
            }
        }

        public Challenge(string name, int quantityDays, int exp = 10)
        {
            this.Name = name;
            this.QuantityDays = quantityDays;
            this.Exp = exp;
            this.CurrentDay = 0;
            this.StartDay = DateTime.Today;
            this.TotalDuration = new TimeSpan(QuantityDays,0,0,0);
            this.EndDay = this.StartDay.Add(TotalDuration);
        }

        public TimeSpan HowManyMoreDays(DateTime dt)
        {
            return this.EndDay - dt;
        }

    }
}
