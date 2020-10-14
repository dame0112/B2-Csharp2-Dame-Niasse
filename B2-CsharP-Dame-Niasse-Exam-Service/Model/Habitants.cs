using System;
using System.Collections.Generic;
using System.Text;

namespace B2_CsharP_Dame_Niasse_Exam_Service.Model
{
    public class Habitants
    {
        public string nom;
        public int age;

        public List<Ville> Villes { get; set; }
    }
}
