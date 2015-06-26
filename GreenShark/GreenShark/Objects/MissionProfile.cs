using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenShark
{
    public class MissionProfile
    {
        public MissionProfile(int id, List<Material> materials, BoatType boatType, List<FunctionEmployee> employees)
        {
            this.ID = id;
            this.Materials = materials;
            this.BoatType = boatType;
            this.Employees = employees;
        }

        public int ID { get; set; }


        public List<Material> Materials { get; set; }


        public BoatType BoatType { get; set; }


        public System.Collections.Generic.List<GreenShark.FunctionEmployee> Employees { get; set; }

    }
}
