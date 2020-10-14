using System;
using System.Collections.Generic;
using System.Globalization;
using B2_CsharP_Dame_Niasse_Exam_Service.Services;
using B2_CsharP_Dame_Niasse_Exam_Service.Services.Service;

namespace B2_CsharP_Dame_Niasse_Exam_Service
{
    class Program
    {

            private static DemandeALutilisateur _DemandeALutilisateur = new DemandeALutilisateur();
        static void Main(string[] args)
        {
            DemandeALutilisateur _DemandeALutilisateur = new DemandeALutilisateur();

            DepartementService _DepartementService = new DepartementService(_DemandeALutilisateur);
            VilleService _VilleService = new VilleService(_DemandeALutilisateur, _DepartementService);
            HabitantService _HabitanService = new HabitantService(_DemandeALutilisateur, _VilleService);
      
        List<Ville> listVille = new List<Ville>();
        
        while (true)
        {
            string choixUtilisateur = MenuUtilisateur();

            if (choixUtilisateur == "1")
            {
                _HabitanService.CreatHabitants();
            }
            else if (choixUtilisateur == "2")
            {
                _HabitanService.AfficheHabitants();
            }
            else if (choixUtilisateur == "3")
            {
               
                _VilleService.ajouterVille();
            }
            else if (choixUtilisateur == "4")
            {
                    _VilleService.AfficheVilles();
                }
            else if (choixUtilisateur == "5")
            {
                _DepartementService.CreeDepartement();
                
            }
                else if (choixUtilisateur == "6")
                {
                    _DepartementService.AfficheDepartements();

                }
                
                else if (choixUtilisateur == "Q")
            {
                break;
            }
            else
            {
                Console.WriteLine("Je n'ai pas compris");
            }
        }
    }

    private static string MenuUtilisateur()
    {
        Console.WriteLine("Que voulez-vous faire ?");
        Console.WriteLine("1. Créer un habitant d'une ville");
        Console.WriteLine("2. Afficher la des habitants d'une ville");
        Console.WriteLine("3. Créer une ville");
        Console.WriteLine("4. Afficher la liste des villes");
        Console.WriteLine("5. Créer un departement");
        Console.WriteLine("6. afficher la liste des departement");
        Console.WriteLine("Q. Quitter");
        string choixUtilisateur = _DemandeALutilisateur.saisieNom("");
        return choixUtilisateur;
    }




    public static void affiche(List<Ville> listVilles)
    {
        Console.WriteLine("la Liste des villes est:");
        foreach (Ville v in listVilles)
        {
            var culture = CultureInfo.GetCultureInfo("en-GB");
            string nb = string.Format(culture, "{0:n0}", v.NbHab);
            nb = nb.Replace(",", ".");
            string message_p1 = "Nom: " + v.Nom + " Code Postal: " + v.CodePost;
            string message_p2 = "Nombre d'habitants: " + nb;
            Console.WriteLine(message_p1);
            Console.WriteLine(message_p2);
        }
    }

    public static void calculNbtotalHabs(List<Ville> listVilles)
    {
        int Nbtot = 0;
        foreach (Ville v in listVilles)
        {
            Nbtot = Nbtot + v.NbHab;
        }
        var culture = CultureInfo.GetCultureInfo("en-GB");
        string nb = string.Format(culture, "{0:n0}", Nbtot);
        nb = nb.Replace(",", ".");
        string message = "Nombre total d'habitants: " + nb;
        Console.WriteLine(message);
    }
}
}
