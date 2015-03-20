using System;
using System.Data;
using System.Data.Common;
using System.Configuration;

namespace CG67.Bamboue.Utilities
{
    public class Utilitaire
    {
        #region BuildDataSet

        public static DataSet BuildDataSet(String CommandText, ConnectionStringSettings connectionString)
        {
            DataSet ds = null;
            DbProviderFactory factory = DbProviderFactories.GetFactory(connectionString.ProviderName);

            using (IDbConnection connection = factory.CreateConnection())
            {
                //attribution de la chaine de connexion a l'objet de connexion
                connection.ConnectionString = connectionString.ConnectionString;
                connection.Open();

                //création et configuration de l'objet commande
                IDbCommand command = factory.CreateCommand();
                command.CommandText = CommandText;
                command.Connection = connection;

                IDbDataAdapter sqlAdapt = factory.CreateDataAdapter();
                sqlAdapt.SelectCommand = command;
                ds = new DataSet("dataset");

                sqlAdapt.Fill(ds);
                connection.Close();
                connection.Dispose();
            }
            return ds;
        }

        #endregion

        #region Export XML

        #endregion
    }
}