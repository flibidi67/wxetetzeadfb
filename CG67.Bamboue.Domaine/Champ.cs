using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG67.Bamboue.Domaine
{
    public class Champ
    {

        #region Propriété

        private int id;
        private String nom;
        private String inseeCommunne;
        private String lieuDit;
        private int numChampllotRPG;
        private int habitation;
        private int perimetreProtectionRapporche;
        private int perimetreProtectionEloigne;
        private int captageEau;
        private int zoneInondable;
        private int coursEau;
        private int valide;
        private String commentaire;
        private int actif;
        private String codeImportSANDRE;
        private int id_champ_pbou;

        #endregion
       
        public Champ(int id, String nom, String inseeCommune, String lieuDit, int num, int habitation,
            int perimetreRapproche, int perimetreEloigne, int captageEau, int zoneInondable,
            int coursEau, int valide, String commentaire, int actif, String code, int idChamp)
        {

        }

        #region Accesseurs

        public int Id{
            get { return this.id; }
            set { this.id = value; }
        }

        #endregion

    }
}
