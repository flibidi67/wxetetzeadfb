using System;
using System.Data;
using System.Data.Common;
using System.Configuration;
using System.Xml;
using CG67.Bamboue.Domaine;

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

        #region Udpate
        public static void UpdateBase(String CommandText, ConnectionStringSettings connectionString)
        {
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

                command.ExecuteNonQuery();

                connection.Close();
                connection.Dispose();
            }
        }

        #endregion

        #region Export XML
        public static void ExportXML(Champ champ)
        {
            XmlTextWriter writer = new XmlTextWriter(champ.Nom + ".xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);

            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Champ");
            
            CreateNode("Nom", champ.Nom, writer);
            CreateNode("Commune", champ.Commune, writer);
            CreateNode("Lieu dit", champ.LieuDit, writer);

            writer.WriteStartElement("Contrainte");

            CreateNode("Habitation", OuiOuNon(champ.Habitation), writer);
            CreateNode("Captage d'eau", OuiOuNon(champ.CaptageEau), writer);
            CreateNode("ZoneInondable", OuiOuNon(champ.ZoneInondable), writer);
            CreateNode("Cours d'eau", OuiOuNon(champ.CoursEau), writer);

            writer.WriteEndElement();//fin balise contrainte
            writer.WriteEndDocument();//fin balise champ
            writer.Close();
        }

        public static void CreateNode(string nomBalise, string valeur, XmlTextWriter writer)
        {
            writer.WriteStartElement(nomBalise);
            writer.WriteString(valeur);
            writer.WriteEndElement();
        }
        public static String OuiOuNon(int v)
        {
            if (v == 0)
            {
                return "Non";
            }
            else
            {
                return "Oui";
            }
        }
        #endregion
    }
}