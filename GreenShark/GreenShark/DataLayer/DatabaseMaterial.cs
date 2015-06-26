using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenShark
{
    using Oracle.ManagedDataAccess.Client;

    public class DatabaseMaterial : Database
    {
        public void DeleteMaterial(int ID)
        {
            throw new System.NotImplementedException();
        }

        public List<Material> GetMaterials()
        {
            List<Material> materials = new List<Material>();

            string materialQuery =
                "SELECT * FROM MATERIAAL";

            OracleDataReader getMaterials = this.Read(materialQuery, new List<OracleParameter>());
            if (getMaterials != null)
            {
                if (getMaterials.HasRows)
                {
                    while (getMaterials.Read())
                    {
                        int id = Convert.ToInt32(getMaterials["ID"]);
                        string name = Convert.ToString(getMaterials["naam"]);

                        materials.Add(new Material(id, name));
                    }

                }
                getMaterials.Close();
            }

            this.CloseConnection();

            return materials;
        }

        public void ChangeMaterial(Material material)
        {
            throw new System.NotImplementedException();
        }

        public void AddMaterial(Material material)
        {
            throw new System.NotImplementedException();
        }
    }
}
