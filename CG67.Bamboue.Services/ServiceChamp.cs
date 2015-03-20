using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CG67.Bamboue.Domaine;
using CG67.Bamboue.Services;
using System.Data;

namespace CG67.Bamboue.Services
{
    class ServiceChamp
    {
        #region Constructeur
        public ServiceChamp() { }

        #endregion

        public Champ GetChampsParId(int id)
        {
            Champ champ = null;

            DataSet ds = null;//DonneeChamp.GetChampParId(id);

            if(ds != null){
                
                int idChamp = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray.GetValue(0).ToString());
                String nom = (String)ds.Tables[0].Rows[0].ItemArray.GetValue(1);
                String lieuDit = (String)ds.Tables[0].Rows[0].ItemArray.GetValue(2);
                String commune = (String)ds.Tables[0].Rows[0].ItemArray.GetValue(3); ;//Le nom de la commune d'appartenance;
                String nomExploitation = (String)ds.Tables[0].Rows[0].ItemArray.GetValue(4);;//le nom de l'exploitation agricole;
                int habitation = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray.GetValue(5).ToString());
                int perimetreProtectionRapproche = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray.GetValue(6).ToString());
                int perimetreProtectionEloigne = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray.GetValue(7).ToString());
                int captageEau = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray.GetValue(8).ToString());
                int zoneInondable = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray.GetValue(9).ToString());
                int coursEau = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray.GetValue(10).ToString());
                String commentaire = (String)ds.Tables[0].Rows[0].ItemArray.GetValue(11);

                champ = new Champ(idChamp, nom, lieuDit, habitation, perimetreProtectionRapproche, perimetreProtectionEloigne,
                    captageEau, zoneInondable, coursEau, commentaire, commune, nomExploitation);

            }

            return champ;
        }
    }
}
