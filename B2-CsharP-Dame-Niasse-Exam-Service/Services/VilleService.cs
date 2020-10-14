using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace B2_CsharP_Dame_Niasse_Exam_Service.Services
{
    
    
        public class VilleService
        {

            private DemandeALutilisateur _demandeALutilisateur;

            public VilleService(DemandeALutilisateur demandealutilisateur, Service.DepartementService _DepartementService)
            {
                this._demandeALutilisateur = demandealutilisateur;
            }
            public Ville ajouterVille()
            {
                Ville c = new Ville();
                c.Nom = _demandeALutilisateur.saisieNom("Quel est le nom de votre ville ?");
                c.CodePost = _demandeALutilisateur.saisieEntier("Quel est de code postal ?");
                c.NbHab = _demandeALutilisateur.saisieEntier("Combie y a-t-il d'habitants ?");

                return c;
            }

            public void calculNbtotalHabs(List<Ville> listvilles)
            {
                int Nbtot = 0;
                foreach (Ville c in listvilles)
                {
                    Nbtot = Nbtot + c.NbHab;
                }
                var culture = CultureInfo.GetCultureInfo("en-GB");
                string nb = string.Format(culture, "{0:n0}", Nbtot);
                nb = nb.Replace(",", ".");
                string message = "Nombre total d'habitants: " + nb;
                Console.WriteLine(message);
            }

            public void affiche(List<Ville> listvilles)
            {
                Console.WriteLine("Liste des villes créées:");
                foreach (Ville c in listvilles)
                {
                    var culture = CultureInfo.GetCultureInfo("en-GB");
                    string nb = string.Format(culture, "{0:n0}", c.NbHab);
                    nb = nb.Replace(",", ".");
                    string message_p1 = "Nom: " + c.Nom + " Code Postal: " + c.CodePost;
                    string message_p2 = "Nombre d'habitants: " + nb;
                    Console.WriteLine(message_p1);
                    Console.WriteLine(message_p2);
                }
            }
        }
    }