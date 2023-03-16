using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDebitoGITHUB
{
    internal class BranchAlunno
    {
        internal string NomeAlunno { get; set; }
        internal string CognomeAlunno { get; set; }
        internal string CittàDiResidenza { get; set; }
        internal int EtàAlunno { get; set; }

        public string ToString() 
        {
            string informazioniAlunno = "L'alunno si chiama : " + NomeAlunno + "\n" + "Il suo cognome è : " + CognomeAlunno + "\n" + "Ha : " + EtàAlunno + "anni" + "\n" + "E vive a : " + CittàDiResidenza;
            return informazioniAlunno;
        }

        public string Classi(int EtàAlunno) 
        {
            string classe = "";

            if (EtàAlunno < 16)
            {
                classe = "Questo alunno è del Biennio";
            }
            else if (EtàAlunno >= 16)
            {
                classe = "Questo alunno è del Triennio"; 
            }
            return classe;
        }

    }
}
