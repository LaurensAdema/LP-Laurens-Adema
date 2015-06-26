using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenShark
{
    public class Administration
    {
        public Administration(Employee employeeInlog)
        {
            employee = employeeInlog;
        }

        private readonly Employee employee;

        public void LogOut()
        {
            throw new System.NotImplementedException();
        }

        public List<Mission> GetMissions()
        {
            throw new System.NotImplementedException();
        }

        public List<Measurement> GetMeasurements(int ID)
        {
            throw new System.NotImplementedException();
        }

        public List<Incident> GetIncidents()
        {
            throw new System.NotImplementedException();
        }

        public void ApproveMission(int ID)
        {
            throw new System.NotImplementedException();
        }

        public void PrintReport(int ID, string path)
        {
            throw new System.NotImplementedException();
        }

        public void ChangeMission(Mission mission)
        {
            throw new System.NotImplementedException();
        }

        public void AddIncident(string ID, Incident incident)
        {
            throw new System.NotImplementedException();
        }

        public void AddMeasurement(int ID, Measurement measurement)
        {
            throw new System.NotImplementedException();
        }

        public void AddMission(Mission mission)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteMission(string ID)
        {
            throw new System.NotImplementedException();
        }

        public void ChangeIncident(Incident incident)
        {
            throw new System.NotImplementedException();
        }

        public void ChangeMeasurement(Measurement measurement)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteMeasurement(int ID)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteIncident(int ID)
        {
            throw new System.NotImplementedException();
        }

        public void AddMissionProfile(MissionProfile missionProfile)
        {
            throw new System.NotImplementedException();
        }

        public void ChangeMissionProfile(MissionProfile missionProfile)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteMissionProfile(int ID)
        {
            throw new System.NotImplementedException();
        }

        public void AddEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public List<Employee> GetEmployees()
        {
            throw new System.NotImplementedException();
        }

        public void ChangeEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteEmployee(int ID)
        {
            throw new System.NotImplementedException();
        }

        public void AddBoat(Boat boat)
        {
            throw new System.NotImplementedException();
        }

        public List<Boat> GetBoats()
        {
            throw new System.NotImplementedException();
        }

        public void ChangeBoat(Boat boat)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteBoat(int ID)
        {
            throw new System.NotImplementedException();
        }

        public void AddMaterial(Material material)
        {
            throw new System.NotImplementedException();
        }

        public List<Material> GetMaterials()
        {
            throw new System.NotImplementedException();
        }

        public void ChangeMaterial(Material material)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteMaterial(int ID)
        {
            throw new System.NotImplementedException();
        }
    }
}
