using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenShark
{
    using System.Device.Location;

    public class SIN : Mission
    {
        public SIN(int id, Boat boat, DateTime leaveDate, string discription, GeoCoordinate location, BoatType boatType, List<Material> materials, List<FunctionEmployee> employees, string report, int sinID, List<Incident> incidents)
            : base(id, boat, leaveDate, discription, location, boatType, materials, employees, report)
        {
            this.ID = sinID;
            this.Incidents = incidents;
        }

        public SIN(DateTime leaveDate, string discription, GeoCoordinate location, BoatType boatType, List<Material> materials, List<FunctionEmployee> employees)
            : base(leaveDate, discription, location, boatType, materials, employees)
        {
        }

        public int ID { get; set; }


        public List<Incident> Incidents { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
