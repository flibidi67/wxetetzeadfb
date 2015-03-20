using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CG67.Bamboue.Domaine;
using CG67.Bamboue.AccesDonnees;

namespace CG67.Bamboue.Services
{
    class ServiceInstallation
    {
        DonneesInstallation donneesInstallation = new DonneesInstallation();
         #region Constructeur
        public ServiceInstallation() { }

        #endregion

        public Installation GetInstallations()
        {
            Installation installation = new Installation();

            DataSet ds = donneesInstallation.GetToutesInstallations();

            if (ds != null)
            {
                int idInstallation = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray.GetValue(0).ToString());
                String nom = (String)ds.Tables[0].Rows[0].ItemArray.GetValue(1);
                installation = new Installation(idInstallation, nom);
            }
            return installation;
        }
    }
}
