using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenShark
{
    public class Measurement
    {
        public Measurement(string name, DateTime date, string value)
        {
            this.Name = name;
            this.Date = date;
            this.Value = value;
        }

        public string Name { get; set; }


        public DateTime Date { get; set; }


        public string Value { get; set; }

    }
}
