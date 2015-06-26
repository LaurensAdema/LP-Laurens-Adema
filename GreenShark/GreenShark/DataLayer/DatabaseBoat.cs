using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenShark
{
    using System.Device.Location;

    using Oracle.ManagedDataAccess.Client;

    public class DatabaseBoat : Database
    {
        public List<Boat> GetBoats()
        {
            List<Boat> boats = new List<Boat>();

            string missionQuery =
                "SELECT * FROM BOOT";

            OracleDataReader getAllBoats = this.Read(missionQuery, new List<OracleParameter>());
            if (getAllBoats != null)
            {
                if (getAllBoats.HasRows)
                {
                    while (getAllBoats.Read())
                    {
                        int id = Convert.ToInt32(getAllBoats["ID"]);
                        int boatTypeID = Convert.ToInt32(getAllBoats["bootTypeID"]);
                        string name = Convert.ToString(getAllBoats["naam"]);
                        double locationX = Convert.ToDouble(getAllBoats["locatieX"]);
                        double locationY = Convert.ToDouble(getAllBoats["locatieY"]);
                        GeoCoordinate location = new GeoCoordinate(locationX, locationY);

                        boats.Add(new Boat(id, name, GetBoatType(boatTypeID),  null, null, location));
                    }

                }
                getAllBoats.Close();
            }

            this.CloseConnection();

            return boats;
        }

        private BoatType GetBoatType(int ID)
        {
            BoatType boattype = null;

            string missionQuery =
                "SELECT * FROM BOOTTYPE WHERE ID = :searchID";
            List<OracleParameter> parameters = new List<OracleParameter>();
            parameters.Add(new OracleParameter(":searchID", ID));

            OracleDataReader getBoatType = this.Read(missionQuery, parameters);
            if (getBoatType != null)
            {
                if (getBoatType.HasRows)
                {
                    while (getBoatType.Read())
                    {
                        int id = Convert.ToInt32(getBoatType["ID"]);
                        string type = Convert.ToString(getBoatType["type"]);
                        int velocity = Convert.ToInt32(getBoatType["snelheid"]);
                        int maxPersons = Convert.ToInt32(getBoatType["maxPersonen"]);

                        boattype = new BoatType(id, type, velocity, maxPersons);
                        break;
                    }

                }
                getBoatType.Close();
            }

            this.CloseConnection();

            return boattype;
        }

        public List<BoatType> GetBoatTypes()
        {
            List<BoatType> boatTypes = new List<BoatType>();

            string missionQuery =
                "SELECT * FROM BOOTTYPE";

            OracleDataReader getBoatType = this.Read(missionQuery, new List<OracleParameter>());
            if (getBoatType != null)
            {
                if (getBoatType.HasRows)
                {
                    while (getBoatType.Read())
                    {
                        int id = Convert.ToInt32(getBoatType["ID"]);
                        string type = Convert.ToString(getBoatType["type"]);
                        int velocity = Convert.ToInt32(getBoatType["snelheid"]);
                        int maxPersons = Convert.ToInt32(getBoatType["maxPersonen"]);

                        boatTypes.Add(new BoatType(id, type, velocity, maxPersons));
                    }

                }
                getBoatType.Close();
            }

            this.CloseConnection();

            return boatTypes;
        }

        public void DeleteBoat(int ID)
        {
            throw new System.NotImplementedException();
        }

        public void ChangeBoat(Boat boat)
        {
            throw new System.NotImplementedException();
        }

        public void AddBoat(Boat boat)
        {
            throw new System.NotImplementedException();
        }
    }
}
