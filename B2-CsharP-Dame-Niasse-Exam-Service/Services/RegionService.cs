using B2_CsharP_Dame_Niasse_Exam_Service.Model;
using B2_CsharP_Dame_Niasse_Exam_Service.Services;
using B2_CsharP_Dame_Niasse_Exam_Service.Services.Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace B2_CsharP_Dame_Niasse_Exam_Service.Service
{
    public class RegionService
    {
        private DemandeALutilisateur _DemandeALutilisateur;
        private DepartementService _departementServices;
        private VilleService _VilleService;

        public RegionService(DemandeALutilisateur demandealutilisateur, DepartementService departementServices, VilleService communeService)
        {
            this._DemandeALutilisateur = demandealutilisateur;
            this._departementServices = departementServices;
            this._VilleService = communeService;
        }
        public Region ajouterRegion()
        {
            Region r = new Region();
            r.nomR = _DemandeALutilisateur.saisieNom("Saisissez le nom de votre region");
            r.codeR = _DemandeALutilisateur.saisieEntier("Saisissez le code du region");

            return r;
        }

        public void calculNbtotalHabs(List<Ville> listvilles)
        {
            int Nbtot = 0;
            foreach (Ville v in listvilles)
            {
                Nbtot = Nbtot + v.NbHab;
            }
            var culture = CultureInfo.GetCultureInfo("en-GB");
            string nb = string.Format(culture, "{0:n0}", Nbtot);
            nb = nb.Replace(",", ".");
            string message = "Nombre total d'habitants: " + nb;
            Console.WriteLine(message);
        }
        public void afficheRegion(List<Departement> listdepartement, List<Ville> listeville, List<Region> listregion)
        {
            Console.WriteLine("Departements:");
            foreach(Region r in listregion)
            {
                string message = "Nom: " + r.nomR + ", code: " + r.codeR;
                Console.WriteLine(message);
            }
            Console.WriteLine("commune:");
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
