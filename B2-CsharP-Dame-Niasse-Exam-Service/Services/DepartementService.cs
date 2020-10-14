using B2_CsharP_Dame_Niasse_Exam_Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace B2_CsharP_Dame_Niasse_Exam_Service.Services.Service
{
    public class DepartementService
    {
        public DemandeALutilisateur _DemandeALutilisateur;
        List<Departement> Listedepartement = new List<Departement>();
       


        public DepartementService(DemandeALutilisateur demandeALutilisateur)
        {
            this._DemandeALutilisateur = demandeALutilisateur;
        }

        public Departement CreeDepartement()
        {
            Departement d = new Departement();
            d.nom = _DemandeALutilisateur.saisieNom("Nom du departement");
            d.numD = _DemandeALutilisateur.saisieEntier("Numeros de departement");
            Departements.Add(d);
            return d;
        }

        public Departement DemandeDepartement()
        {

            Departement result = null;
            while (result == null)
            {
                string saisieUtilisateur = _DemandeALutilisateur.saisieNom("nom du departement ?");
                foreach (Departement d in this.Departements)
                {
                    if (d.nom == saisieUtilisateur)
                    {
                        result = d;
                    }
                }
            }

            return result;
        }

        public void AfficheDepartements()
        {
            foreach (Departement d in ListeDepartement)
            {

                Console.WriteLine("Les departements: ");

               
            }
        }
    }
   
}
