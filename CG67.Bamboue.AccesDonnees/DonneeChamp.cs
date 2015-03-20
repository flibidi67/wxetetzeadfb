using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;


namespace CG67.Bamboue.AccesDonnees
{
    class DonneeChamp
    {
        ConnectionStringSettings connec = new ConnectionStringSettings("bamboue", ConfigurationManager.ConnectionStrings["bamboueConnectionString"].ConnectionString);

        public DataSet GetChampParIdInstallation(int id)
        {
            String query = "SELECT * FROM Champ c, Champ_Install i WHERE c.IdChamp = i.IdChamp AND i.IdInstallation = " + id.ToString();
            DataSet ds = Utilities.Utilitaire.BuildDataSet(query, connec);
            return ds;
        }
    }
}
