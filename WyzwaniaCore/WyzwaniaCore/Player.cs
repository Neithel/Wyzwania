using System;
using System.Collections.Generic;
using System.Text;

namespace WyzwaniaCore
{
    class Player
    {

        private string name;
        private int level = 1;
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (this.name != null)
                    this.name = value;
                else
                    this.name = "Janusz";
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }
            private set
            {
                    this.level = value;
            }
        }

        public Player(string name)
        {
            this.Name = name;
        }


    }
}
