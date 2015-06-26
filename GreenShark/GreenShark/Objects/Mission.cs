using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Device.Location;

namespace GreenShark
{
    public class Mission
    {
        public Mission(int id, Boat boat, DateTime leaveDate, string discription, GeoCoordinate location, BoatType boatType, List<Material> materials, List<FunctionEmployee> employees, string report)
        {
            this.ID = id;
            this.Boat = boat;
            this.LeaveDate = leaveDate;
            this.Discription = discription;
            this.Location = location;
            this.BoatType = boatType;
            this.Materials = materials;
            this.Employees = employees;
            this.Report = report;
        }

        public Mission(DateTime leaveDate, string discription, GeoCoordinate location, BoatType boatType, List<Material> materials, List<FunctionEmployee> employees)
        {
            this.LeaveDate = leaveDate;
            this.Discription = discription;
            this.Location = location;
            this.BoatType = boatType;
            this.Materials = materials;
            this.Employees = employees;
        }

        public int ID { get; set; }


        public Boat Boat { get; set; }


        public DateTime LeaveDate { get; set; }


        public string Discription { get; set; }


        public GeoCoordinate Location { get; set; }


        public BoatType BoatType { get; set; }

        public System.Collections.Generic.List<Material> Materials { get; set; }


        public System.Collections.Generic.List<GreenShark.FunctionEmployee> Employees { get; set; }

        public string Report { get; set; }

        public override string ToString()
        {
            return String.Format("{0}:  Vertrek datum: {1}  Coordinaten:{2}  Boot: ", ID, LeaveDate.ToShortDateString(), Location);
        }
    }
}
