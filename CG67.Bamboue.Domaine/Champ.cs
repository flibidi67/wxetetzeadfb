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

        #region Constructeur

        public Champ(int id, String nom, String lieuDit, int habitation,
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

        #endregion

        #region Accesseurs

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public String Nom
        {
            get { return this.nom; }
            set { this.nom = value == null ? String.Empty : value.Trim(); }
        }

        public String LieuDit
        {
            get { return this.lieuDit; }
            set { this.lieuDit = value == null ? String.Empty : value.Trim(); }
        }

        public int Habitation
        {
            get { return this.habitation; }
            set { this.habitation = value; }
        }

        public int PerimetreProtectionEloigne
        {
            get { return this.perimetreProtectionEloigne; }
            set { this.perimetreProtectionEloigne = value; }
        }

        public int PerimetreProtectionRapproche
        {
            get { return this.perimetreProtectionRapproche; }
            set { this.perimetreProtectionRapproche = value; }
        }

        public int CaptageEau
        {
            get { return this.captageEau; }
            set { this.captageEau = value; }
        }

        public int ZoneInondable
        {
            get { return this.zoneInondable; }
            set { this.zoneInondable = value; }
        }

        public int CoursEau
        {
            get { return this.coursEau; }
            set { this.coursEau = value; }
        }

        public String Commentaire
        {
            get { return this.commentaire; }
            set { this.commentaire = value == null ? String.Empty : value.Trim(); }
        }

        public String Commune
        {
            get { return this.commune; }
            set { this.commune = value == null ? String.Empty : value.Trim(); }
        }

        public String NomExploitation
        {
            get { return this.nomExploitation; }
            set
            {
                this.nomExploitation = value == null ? String.Empty : value.Trim();
            }
        }

        #endregion
    }
}
