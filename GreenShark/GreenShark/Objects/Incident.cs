using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenShark
{
    public class Incident
    {
        public Incident(DateTime id, int date, string description)
        {
            this.ID = id;
            this.Date = date;
            this.Description = description;
        }

        public DateTime ID { get; set; }


        public int Date { get; set; }


        public string Description { get; set; }

    }
}
