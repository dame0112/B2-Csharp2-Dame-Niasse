using System;
using System.Collections.Generic;
using System.Text;

namespace B2_CsharP_Dame_Niasse_Exam_Service.Model
{
    public class Region
    {
        public string nom;
        public int numR;
        public List<Departement> departements { get; set; }
    }
}
