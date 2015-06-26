using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenShark
{
    using System.Device.Location;

    using Oracle.ManagedDataAccess.Client;

    public class DatabaseMission : Database
    {
        public void PrintReport(int ID, string path)
        {
            throw new System.NotImplementedException();
        }

        public List<Incident> GetIncidents()
        {
            throw new System.NotImplementedException();
        }

        public List<Measurement> GetMeasurements(int ID)
        {
            throw new System.NotImplementedException();
        }

        public List<Mission> GetMissions()
        {
            List<Mission> missions = new List<Mission>();

            string missionQuery =
                "SELECT * FROM MISSIE";

            OracleDataReader getAllMissions = this.Read(missionQuery, new List<OracleParameter>());
            if (getAllMissions != null)
            {
                if (getAllMissions.HasRows)
                {
                    while (getAllMissions.Read())
                    {
                        Mission mission = null;

                        int missionID = Convert.ToInt32(getAllMissions["ID"]);
                        int boatID = Convert.ToInt32(getAllMissions["bootID"]);
                        DateTime leaveDate = Convert.ToDateTime(getAllMissions["vertrekDatum"]);
                        string description = Convert.ToString(getAllMissions["beschrijving"]);
                        double locationX = Convert.ToDouble(getAllMissions["locatieX"]);
                        double locationY = Convert.ToDouble(getAllMissions["locatieY"]);
                        GeoCoordinate location = new GeoCoordinate(locationX, locationY);
                        string report = Convert.ToString(getAllMissions["verslag"]);
                        char type = Convert.ToChar(getAllMissions["soort"]);

                        switch (type)
                        {
                            case 'H':
                                string hopeQuery = "SELECT * FROM M_HOPE WHERE MissieID = :missionID";
                                List<OracleParameter> hopeParameters = new List<OracleParameter>();
                                hopeParameters.Add(new OracleParameter(":missionID", missionID));
                                OracleDataReader getHope = this.Read(hopeQuery, hopeParameters);
                                if (getHope != null)
                                {
                                    if (getHope.HasRows)
                                    {
                                        while (getHope.Read())
                                        {
                                            int hopeID = Convert.ToInt32(getHope["ID"]);
                                            DateTime returnDate = Convert.ToDateTime(getHope["terugkomstDatum"]);
                                            bool approved = Convert.ToChar(getHope["goed"]) == 'Y';
                                            mission = new HOPE(missionID,null,leaveDate,description,location,new BoatType(boatID), null, null, report, hopeID, returnDate, approved, null);

                                            break;
                                        }

                                    }
                                    getHope.Close();
                                }
                                break;
                            case 'S':
                                string sinQuery = "SELECT * FROM M_SIN WHERE MissieID = :missionID";
                                List<OracleParameter> sinParameters = new List<OracleParameter>();
                                sinParameters.Add(new OracleParameter(":missionID", missionID));
                                OracleDataReader getSin = this.Read(sinQuery, sinParameters);
                                if (getSin != null)
                                {
                                    if (getSin.HasRows)
                                    {
                                        while (getSin.Read())
                                        {
                                            int sinID = Convert.ToInt32(getSin["ID"]);
                                            mission = new SIN(missionID, null, leaveDate, description, location, new BoatType(boatID), null, null, report,sinID, null);
                                            break;
                                        }

                                    }
                                    getSin.Close();
                                }
                                break;
                        }
                        missions.Add(mission);
                    }

                }
                getAllMissions.Close();
            }

            this.CloseConnection();

            return missions;
        }

        public void DeleteMeasurement(int ID)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteMission(string ID)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteMissionProfile(int ID)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteIncident(int ID)
        {
            throw new System.NotImplementedException();
        }

        public void ChangeMeasurement(Measurement measurement)
        {
            throw new System.NotImplementedException();
        }

        public void ChangeMission(Mission mission)
        {
            throw new System.NotImplementedException();
        }

        public void ChangeMissionProfile(MissionProfile missionProfile)
        {
            throw new System.NotImplementedException();
        }

        public void ChangeIncident(Incident incident)
        {
            throw new System.NotImplementedException();
        }

        public void ApproveMission(int ID)
        {
            throw new System.NotImplementedException();
        }

        public void AddMeasurement(int ID, Measurement measurement)
        {
            throw new System.NotImplementedException();
        }

        public int AddMission(Mission mission)
        {
            List<string> rowListMission = new List<string>();
            rowListMission.Add("bootID");
            rowListMission.Add("bootTypeID");
            rowListMission.Add("vertrekDatum");
            rowListMission.Add("beschrijving");
            rowListMission.Add("locatieX");
            rowListMission.Add("locatieY");
            rowListMission.Add("soort");

            List<OracleParameter> parametersMission = new List<OracleParameter>();
            parametersMission.Add(new OracleParameter(":bootID", mission.Boat.ID));
            parametersMission.Add(new OracleParameter(":bootTypeID", mission.BoatType.ID));
            parametersMission.Add(new OracleParameter(":vertrekDatum", mission.LeaveDate));
            parametersMission.Add(new OracleParameter(":beschrijving", mission.Discription));
            parametersMission.Add(new OracleParameter(":locatieX", mission.Location.Latitude));
            parametersMission.Add(new OracleParameter(":locatieY", mission.Location.Longitude));

            int id = Add("MISSIE", rowListMission, parametersMission, true);

            //TODO
            //waardes van materialen ect opslaan.

            return id;
        }

        public void AddHOPE(HOPE hope)
        {
            int id = AddMission(hope as Mission);
            if (id > 0)
            {
                List<string> rowListHope = new List<string>();
                rowListHope.Add("missieID");
                rowListHope.Add("terugkomstDatum");

                List<OracleParameter> parametersHope = new List<OracleParameter>();
                parametersHope.Add(new OracleParameter(":missieID", id));
                parametersHope.Add(new OracleParameter(":terugkomstDatum", hope.ReturnDate));
            }
        }

        public void AddSIN(SIN sin)
        {
            throw new System.NotImplementedException();
        }

        public void AddMissionProfile(MissionProfile missionProfile)
        {
            throw new System.NotImplementedException();
        }

        public void AddIncident(string ID, Incident incident)
        {
            throw new System.NotImplementedException();
        }
    }
}
