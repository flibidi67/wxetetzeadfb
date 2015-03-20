using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG67.Bamboue.Domaine
{
    public class Installation
    {
        #region Propriétés
        private int idInstallation;
        private int idTypeInstallation;
        private int idAdresse;
        private string nom;
        private int capaciteTraitement;
        private string commentaire;
        #endregion

        #region Constructeur
        public Installation(int idInstallation, int idTypeInstallation, int idAdresse, string nom, int capaciteTraitement, string commentaire)
        {
            this.idInstallation = idInstallation;
            this.idTypeInstallation = idTypeInstallation;
            this.idAdresse = idAdresse;
            this.nom = nom;
            this.capaciteTraitement = capaciteTraitement;
            this.commentaire = commentaire;
        }

        public Installation(int idInstallation, string nom)
        {
            this.idInstallation = idInstallation;
            this.nom = nom;
        }

        public Installation() { }
        #endregion 

        #region Accesseurs
        public int IdInstallation
        {
            get { return this.idInstallation; }
            set { this.idInstallation = value; }
        }

        public int IdTypeInstallation
        {
            get { return this.idTypeInstallation; }
            set { this.idTypeInstallation = value; }
        }
        public int IdAdresse
        {
            get { return this.idAdresse; }
            set { this.idAdresse = value; }
        }

        public String Nom
        {
            get { return this.nom; }
            set { this.nom = value == null ? String.Empty : value.Trim(); }
        }

        public int CapaciteTraitement
        {
            get { return this.capaciteTraitement; }
            set { this.capaciteTraitement = value; }
        }

        public String Commentaire
        {
            get { return this.commentaire; }
            set { this.commentaire = value == null ? String.Empty : value.Trim(); }
        }
        #endregion

    }
}
