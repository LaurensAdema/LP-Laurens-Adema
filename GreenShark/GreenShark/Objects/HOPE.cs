using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenShark
{
    using System.Device.Location;

    public class HOPE : Mission
    {
        public HOPE(int id, Boat boat, DateTime leaveDate, string discription, GeoCoordinate location, BoatType boatType, List<Material> materials, List<FunctionEmployee> employees, string report, int hopeID, DateTime returnDate, bool approved, List<Measurement> measurements)
            : base(id, boat, leaveDate, discription, location, boatType, materials, employees, report)
        {
            this.ID = hopeID;
            this.ReturnDate = returnDate;
            this.Approved = approved;
            this.Measurements = measurements;
        }

        public HOPE(DateTime leaveDate, string discription, GeoCoordinate location, BoatType boatType, List<Material> materials, List<FunctionEmployee> employees, DateTime returnDate)
            : base(leaveDate, discription, location, boatType, materials, employees)
        {
            this.ReturnDate = returnDate;
        }

        public int ID { get; set; }

        public DateTime ReturnDate { get; set; }


        public bool Approved { get; set; }


        public List<Measurement> Measurements { get; set; }

    }
}
