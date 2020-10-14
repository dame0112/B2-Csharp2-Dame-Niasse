using B2_CsharP_Dame_Niasse_Exam_Service.Model;

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace B2_CsharP_Dame_Niasse_Exam_Service.Services.Service
{
    public class HabitantService
    {
        private DemandeALutilisateur _DemandeALutilisateur;
        private VilleService _VilleService;
        private List<Habitants> ListeHabitants = new List<Habitants>();

        public HabitantService(DemandeALutilisateur demandeALutilisateur, VilleService VilleService)
        {
            _DemandeALutilisateur = demandeALutilisateur;
            _VilleService = VilleService;
        }

        public void AfficheHabitants()
        {
            foreach (Habitants h in ListeHabitants)
            {
                Console.WriteLine(h.nom);
                Console.WriteLine("Les villes: ");

                if (h.Villes != null)
                {
                    foreach (Ville v in h.Villes)
                    {
                        Console.WriteLine(v.Nom);
                    }
                }
            }
        }

        public Habitants CreatHabitants()
        {
            Habitants h = new Habitants();

            h.nom = _DemandeALutilisateur.saisieNom("Nom de l'habitant :");
            h.age = _DemandeALutilisateur.saisieEntier("Quel as tu :");
           
            return h;
        }

    }
}
