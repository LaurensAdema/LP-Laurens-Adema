using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;

namespace GreenShark
{
    public class Boat
    {
        public Boat(int id, string name, BoatType type, List<Material> materials, List<Employee> crew, GeoCoordinate location)
        {
            this.ID = id;
            this.Name = name;
            this.Type = type;
            this.Materials = materials;
            this.Crew = crew;
            this.Location = location;
        }

        public int ID { get; set; }


        public string Name { get; set; }


        public BoatType Type { get; set; }


        public System.Collections.Generic.List<Material> Materials { get; set; }


        public List<Employee> Crew { get; set; }


        public GeoCoordinate Location { get; set; }

    }
}
