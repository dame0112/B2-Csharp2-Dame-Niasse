using System;
using System.Collections.Generic;
using System.Text;

namespace B2_CsharP_Dame_Niasse_Exam_Service.Model
{
    public class Region
    {
        public int codeR;
        public string nomR;

        public List<Ville> Villes { get; set; }
        public List<Departement> Departements { get; set; }

    }
}
