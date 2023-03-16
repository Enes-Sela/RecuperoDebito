using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaDebitoGITHUB
{
    internal class Scuola
    {
        List<BranchAlunno> elencoAlunni = new List<BranchAlunno>();

        internal string NomeScuola { get; set; }
        internal int OrarioApertura { get; set; }
        internal int OrarioChiusura { get; set; }

        public void AggiuntaAlunno() 
        {
            elencoAlunni.Add(new BranchAlunno());
        }

        public void RicercaAlunniCognome(BranchAlunno cognome) 
        {
            for (int i = 0; i < elencoAlunni.Count; i++)
            {
                if (elencoAlunni.Contains(cognome))
                {
                    cognome = elencoAlunni[i];
                }
            }    
        }

        public void RicercaAlunniEtà(BranchAlunno alunno) 
        {
            for (int i = 0; i < elencoAlunni.Count; i++)
            {
                if (elencoAlunni.Contains(alunno))
                {
                    alunno.EtàAlunno = elencoAlunni.Count();    
                }
            }
        }

        public void TotaleAlunni() 
        {
            for (int i = 0; i < elencoAlunni.Count; i++)
            {
                int totaleAlunni = 0;
                totaleAlunni = elencoAlunni.Count;
            }
        }
    }
}
