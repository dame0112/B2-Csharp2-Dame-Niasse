using System;
using System.Collections.Generic;
using System.Text;

namespace B2_CsharP_Dame_Niasse_Exam_Service.Model

{
    public class Departement
    {
        public string nom;
        public int numD;
        public List<Ville> Villes { get; set; }
    }
}
