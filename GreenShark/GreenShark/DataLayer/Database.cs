namespace GreenShark
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Text;

    using Oracle.ManagedDataAccess.Client;

    #endregion

    public abstract class Database
    {
        private const bool localhost = false;

        protected internal OracleConnection Con { get; set; }

        protected internal void OpenConnection()
        {
            if (this.Con == null)
            {
                this.Con = new OracleConnection();
            }

            if (this.Con.State == ConnectionState.Closed)
            {
                try
                {
                    this.Con.ConnectionString = localhost ? "User Id=Tweakers;Password=Welkom01;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SID=xe)));" : "User Id=dbi324942;Password=FSM6BF1PUf;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.15.50)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=fhictora)));";
                    this.Con.Open();
                }
                catch (OracleException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        protected internal void CloseConnection()
        {
            this.Con.Close();
        }

        protected internal void Delete(string table, int ID)
        {
            try
            {
                this.OpenConnection();
                OracleCommand deleteCommand = new OracleCommand("DELETE FROM {0} WHERE ID = :delID", this.Con);
                deleteCommand.Parameters.Add(":delID", ID);
                deleteCommand.CommandType = CommandType.Text;
                deleteCommand.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected internal int Add(string table, List<string> rowList, List<OracleParameter> parameterList, bool getID)
        {
            int returnValue = -1;

            try
            {
                string CommandText = string.Format("INSERT INTO {0} (", table);
                foreach (string row in rowList)
                {
                    CommandText = string.Format(rowList[0] == row ? "{0}\"{1}\"" : "{0},\"{1}\"", CommandText, row);
                }

                CommandText = string.Format("{0}) VALUES (", CommandText);

                foreach (string row in rowList)
                {
                    CommandText = string.Format(rowList[0] == row ? "{0}:{1}" : "{0},:{1}", CommandText, row);
                }

                CommandText = string.Format("{0})", CommandText);
                this.OpenConnection();
                OracleCommand insertCommand = new OracleCommand(CommandText, this.Con);
                foreach (OracleParameter parameter in parameterList)
                {
                    insertCommand.Parameters.Add(parameter);
                }

                insertCommand.CommandType = CommandType.Text;
                insertCommand.ExecuteNonQuery();

                returnValue = 0;

                if (getID)
                {
                    List<OracleParameter> idParameter = new List<OracleParameter>();
                    idParameter.Add(new OracleParameter(":tabel", table));
                    OracleDataReader getIDBack = this.Read("SELECT MAX(ID) FROM :tabel", idParameter);
                    if (getIDBack != null)
                    {
                        if (getIDBack.HasRows)
                        {
                            while (getIDBack.Read())
                            {
                                returnValue = Convert.ToInt32(getIDBack["ID"]);
                            }
                        }

                        getIDBack.Close();
                    }

                    this.CloseConnection();
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.CloseConnection();
            }
            return returnValue;
        }

        protected internal bool Edit(string table, List<string> rowList, List<OracleParameter> parameterList, int ID)
        {
            bool succes = false;
            try
            {
                StringBuilder commandBuilder = new StringBuilder();

                commandBuilder.Append(string.Format("UPDATE {0} SET", table));

                int index = 0;
                foreach (string row in rowList)
                {
                    commandBuilder.Append(string.Format(" \"{0}\" = :{0}", row));
                    if (index < (rowList.Count - 1))
                    {
                        commandBuilder.Append(" AND ");
                    }

                    index++;
                }

                commandBuilder.Append(string.Format(" WHERE ID = {0}", ID));
                this.OpenConnection();
                OracleCommand editCommand = new OracleCommand(commandBuilder.ToString(), this.Con);
                foreach (OracleParameter parameter in parameterList)
                {
                    editCommand.Parameters.Add(parameter);
                }

                editCommand.CommandType = CommandType.Text;
                editCommand.ExecuteNonQuery();
                succes = true;
            }
            catch (OracleException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.CloseConnection();
            }
            return succes;
        }

        protected internal OracleDataReader Read(string selectQuery, List<OracleParameter> parameters)
        {
            OracleDataReader result = null;
            try
            {
                this.OpenConnection();
                OracleCommand selectCommand = new OracleCommand(selectQuery, this.Con);

                if (parameters != null)
                {
                    foreach (OracleParameter parameter in parameters)
                    {
                        selectCommand.Parameters.Add(parameter);
                    }
                }

                selectCommand.CommandType = CommandType.Text;
                result = selectCommand.ExecuteReader();
            }
            catch (OracleException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            return result;
        }
    }
}