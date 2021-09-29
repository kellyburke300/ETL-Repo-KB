using System;

namespace FarmSystem.Test1.Model
{
    public abstract class Animal
    {
        public Animal(int NoOfLegs = 4)
        {
            this.Id = Guid.NewGuid().ToString();
            this.NoOfLegs = NoOfLegs;
        }

        public Animal(string Id, int NoOfLegs = 4)
        {
            this.Id = Id;
            this.NoOfLegs = NoOfLegs;
        }

        private string _id;
        private int _noOfLegs;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }


        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = 4;
            }
        }


        public abstract string Talk();

        public string Run()
        {
            return this.GetType().Name + " is running";
        }
    }
}
