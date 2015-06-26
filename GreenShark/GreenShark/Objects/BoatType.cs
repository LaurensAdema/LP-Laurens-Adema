using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenShark
{
    public class BoatType
    {
        public BoatType(int id, string type, int velocity, int maxPersons)
        {
            this.ID = id;
            this.Type = type;
            this.Velocity = velocity;
            this.MaxPersons = maxPersons;
        }

        public BoatType(int id)
        {
            this.ID = id;
        }

        public int ID { get; set; }


        public string Type { get; set; }


        public int Velocity { get; set; }


        public int MaxPersons { get; set; }

        public override string ToString()
        {
            return Type;
        }
    }
}
