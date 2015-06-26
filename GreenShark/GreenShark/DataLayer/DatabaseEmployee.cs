using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenShark
{
    using System.Device.Location;

    using Oracle.ManagedDataAccess.Client;

    public class DatabaseEmployee : Database
    {
        public List<Employee> GetEmployees()
        {
            throw new System.NotImplementedException();
        }

        public List<FunctionEmployee> GetFunctionEmployees()
        {
            List<FunctionEmployee> functions = new List<FunctionEmployee>();

            string missionQuery =
                "SELECT * FROM FUNCTIEMEDEWERKER";

            OracleDataReader getAllFunctions = this.Read(missionQuery, new List<OracleParameter>());
            if (getAllFunctions != null)
            {
                if (getAllFunctions.HasRows)
                {
                    while (getAllFunctions.Read())
                    {
                        int id = Convert.ToInt32(getAllFunctions["ID"]);
                        string function = Convert.ToString(getAllFunctions["functie"]);

                        functions.Add(new FunctionEmployee(function,id));
                    }

                }
                getAllFunctions.Close();
            }

            this.CloseConnection();

            return functions;
        }

        public void DeleteEmployee(int ID)
        {
            throw new System.NotImplementedException();
        }

        public void ChangeEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public void AddEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}
