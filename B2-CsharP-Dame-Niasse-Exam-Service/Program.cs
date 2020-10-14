using System;
using System.Collections.Generic;
using System.Globalization;
using B2_CsharP_Dame_Niasse_Exam_Service.Model;
using B2_CsharP_Dame_Niasse_Exam_Service.Service;
using B2_CsharP_Dame_Niasse_Exam_Service.Services;
using B2_CsharP_Dame_Niasse_Exam_Service.Services.Service;

namespace B2_CsharP_Dame_Niasse_Exam_Service
{
    
        class Program
        {
            private static DemandeALutilisateur _DemandeALutilisateur = new DemandeALutilisateur();
            private static DepartementService _departementService = new DepartementService(_DemandeALutilisateur);
            private static VilleService _VilleService = new VilleService(_DemandeALutilisateur, _departementService);
        private static RegionService _RegionService = new RegionService(_DemandeALutilisateur,_departementService, _VilleService);
        static void Main(string[] args)
            {
                List<Ville> listVille = new List<Ville>();
                List<Departement> listdepartement = new List<Departement>();
                List<Region> listRegion = new List<Region>();

            while (true)
                {
                    string choix = Menu();

                    if (choix == "1")
                    {
                        Ville v = _VilleService.ajouterVille();
                        listVille.Add(v);
                    }
                    else if (choix == "2")
                    {
                        _VilleService.affiche(listVille, listdepartement);
                    }
                    else if (choix == "3")
                    {
                        _VilleService.calculNbtotalHabs(listVille);
                    }
                    else if (choix == "4")
                    {
                        Departement d = _departementService.ajouterDepartement();
                        listdepartement.Add(d);
                    }
                
                else if (choix == "5")
                    {
                        _departementService.afficheDepartement(listdepartement, listVille);
                    }
                else if (choix == "6")
                {
                    Region r = _RegionService.ajouterRegion();
                    listRegion.Add(r);
                }
                else if (choix == "7")
                {
                    _RegionService.afficheRegion(listdepartement, listVille, listRegion);
                }
                else if (choix == "Q" || choix == "q")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Je n'ai pas compris");
                    }
                }
            }
            public static string Menu()
            {
                Console.WriteLine("Bienvenue dans l'application de gestion de communes");
                Console.WriteLine("Que voulez-vous faire");
                Console.WriteLine("1.Créer une nouvelle villes");
                Console.WriteLine("2.Afficher l'ensemble des villes");
                Console.WriteLine("3.Afficher le nombre total d'habitants");
                Console.WriteLine("4.Ajouter un Departement");
                Console.WriteLine("5.Afficher les departements");
                Console.WriteLine("6.ajouter une region");
                Console.WriteLine("7.Afficher les regions");
                Console.WriteLine("Q.Quitter");
                string choix = Console.ReadLine();
                return choix;
            }
        }
    }
