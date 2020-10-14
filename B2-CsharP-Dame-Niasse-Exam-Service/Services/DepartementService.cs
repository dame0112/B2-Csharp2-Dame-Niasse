using B2_CsharP_Dame_Niasse_Exam_Service.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace B2_CsharP_Dame_Niasse_Exam_Service.Services.Service
{
    
        public class DepartementService
        {
            private DemandeALutilisateur _demandeALutilisateur;

            public DepartementService(DemandeALutilisateur demandealutilisateur)
            {
                this._demandeALutilisateur = demandealutilisateur;
            }
            public Departement ajouterDepartement()
            {
                Departement d = new Departement();
                d.nom = _demandeALutilisateur.saisieNom("Saisissez le nom de votre departement");
                d.numD = _demandeALutilisateur.saisieEntier("Saisissez le code du departement");

                return d;
            }
            public void calculNbtotalHabs(List<Ville> listcommunes)
            {
                int Nbtot = 0;
                foreach (Ville v in listcommunes)
                {
                    Nbtot = Nbtot + v.NbHab;
                }
                var culture = CultureInfo.GetCultureInfo("en-GB");
                string nb = string.Format(culture, "{0:n0}", Nbtot);
                nb = nb.Replace(",", ".");
                string message = "Nombre total d'habitants: " + nb;
                Console.WriteLine(message);
            }

            public void afficheDepartement(List<Departement> listdepartement, List<Ville> listeville)
            {
                Console.WriteLine("Departements:");
                foreach (Departement d in listdepartement)
                {
                    string message = "Nom: " + d.nom + ", code: " + d.numD;
                    Console.WriteLine(message);
                }
                Console.WriteLine("commune:");
                foreach (Ville v in listeville)
                {
                    string message_p1 = "Nom: " + v.Nom + " Code Postal: " + v.CodePost;
                    string message_p2 = "Nombre d'habitants: " + v.NbHab;
                    Console.WriteLine(message_p1);
                    Console.WriteLine(message_p2);
                }
            }
        }
    }