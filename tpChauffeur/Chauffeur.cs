using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace tpChauffeur
{
    internal class Chauffeur
    {
        private string Nom;
        private string Prenom;
        private int NumeroLicense;
        private bool EstDisponible;
        private string MissionActuelle;

        public Chauffeur(string unNom,string unPrenom,int unNumeroLicense,string uneMissionActuelle) 
        {
            this.Nom = unNom;
            this.Prenom = unPrenom;
            this.NumeroLicense = unNumeroLicense;
            this.EstDisponible = true;
            this.MissionActuelle = uneMissionActuelle;
        }

        public void AfficherInfos()
        {
            Console.WriteLine($"{this.Nom} , {this.Prenom} , {this.NumeroLicense} , {this.EstDisponible} , {this.MissionActuelle} ");
        }

        public void AssignerMission(string uneMissionActuelle)
        {
            if (this.MissionActuelle != string.Empty)
            {
                Console.WriteLine(uneMissionActuelle);
            }
            else
            {
                this.MissionActuelle = uneMissionActuelle;
            }
        }

        public void TerminerMission()
        {
            this.MissionActuelle = string.Empty;

        }

        public void setNom(string unNom)
        {
            this.Nom = unNom;
        }

        public string getNom()
        {
            return this.Nom;
        }

        public void setPrenom(string unPrenom)
        {
            this.Prenom=unPrenom;
        }

        public string getPrenom()
        {
            return (string)this.Prenom;
        }

        public void setNumeroLicense(int numeroLicense)
        {
            this.NumeroLicense = numeroLicense;
        }

        public int getNumeroLicense()
        {
            return this.NumeroLicense;
        }

        public void setEstDisponible(bool estFisponible)
        {
            this.EstDisponible = estFisponible;
        }

        public bool getEstDisponible()
        {
            return this.EstDisponible;
        }

        public void setMissionActuelle(string uneMissionActuelle)
        {
            this.MissionActuelle = uneMissionActuelle;
        }

        public string getMissionActuelle()
        {
            return this.MissionActuelle;
        }
    }
}
