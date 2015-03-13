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
        private String lieuDit;
        private String commune;//Le nom de la commune d'appartenance;
        private String nomExploitation;//le nom de l'exploitation agricole;
        private int habitation;
        private int perimetreProtectionRapproche;
        private int perimetreProtectionEloigne;
        private int captageEau;
        private int zoneInondable;
        private int coursEau;
        private String commentaire;

        #endregion
       
        public Champ(int id, String nom, String inseeCommune, String lieuDit, int habitation,
            int perimetreRapproche, int perimetreEloigne, int captageEau, int zoneInondable,
            int coursEau, String commentaire, String commune, String nomExploitation)
        {
            this.id = id;
            this.nom = nom;
            this.lieuDit = lieuDit;
            this.habitation = habitation;
            this.perimetreProtectionEloigne = perimetreEloigne;
            this.perimetreProtectionRapproche = perimetreRapproche;
            this.captageEau = captageEau;
            this.zoneInondable = zoneInondable;
            this.coursEau = coursEau;
            this.commentaire = commentaire;
            this.commune = commune;
            this.nomExploitation = nomExploitation;
        }

        #region Accesseurs

        public int Id{
            get { return this.id; }
            set { this.id = value; }
        }

        public String Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        #endregion

    }
}
