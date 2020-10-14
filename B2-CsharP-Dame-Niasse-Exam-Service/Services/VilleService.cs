using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using B2_CsharP_Dame_Niasse_Exam_Service.Model;
using B2_CsharP_Dame_Niasse_Exam_Service.Services.Service;

namespace B2_CsharP_Dame_Niasse_Exam_Service.Services
{

        public class VilleService
        {

            private DemandeALutilisateur _demandeALutilisateur;
            private DepartementService _departementService;

            public VilleService(DemandeALutilisateur demandealutilisateur, DepartementService departementService)
            {
                this._demandeALutilisateur = demandealutilisateur;
                this._departementService = departementService;
            }
            public Ville ajouterVille()
            {

               Ville v = new Ville();
               v.Nom = _demandeALutilisateur.saisieNom("Quel est le nom de votre ville ?");
               v.CodePost = _demandeALutilisateur.saisieEntier("Quel est de code postal ?");
               v.NbHab = _demandeALutilisateur.saisieEntier("Combie y a-t-il d'habitants ?");





                return v;
            }



            public void calculNbtotalHabs(List<Ville> listVille)
            {
                int Nbtot = 0;
                foreach (Ville v in listVille)
                {
                    Nbtot = Nbtot + v.NbHab;
                }
                var culture = CultureInfo.GetCultureInfo("en-GB");
                string nb = string.Format(culture, "{0:n0}", Nbtot);
                nb = nb.Replace(",", ".");
                string message = "Nombre total d'habitants: " + nb;
                Console.WriteLine(message);
            }
            public void affiche(List<Ville> listVille, List<Departement> listdepartement)
            {
                Console.WriteLine("Liste des villes :");


                foreach (Ville v  in listVille)
                {
                    var culture = CultureInfo.GetCultureInfo("en-GB");
                    string nb = string.Format(culture, "{0:n0}", v.NbHab);
                    nb = nb.Replace(",", ".");
                    string message_p1 = "Nom: " + v.Nom + " Code Postal: " + v.CodePost;
                    string message_p2 = "Nombre d'habitants: " + nb;
                    Console.WriteLine(message_p1);
                    Console.WriteLine(message_p2);
                }
                Console.WriteLine("Departements:");
                foreach (Departement d in listdepartement)
                {
                    string message = "Nom: " + d.nom + ", code: " + d.numD;
                    Console.WriteLine(message);
                }

            }
        }
    }
