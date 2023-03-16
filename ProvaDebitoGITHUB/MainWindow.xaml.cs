using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProvaDebitoGITHUB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<BranchAlunno> elencoAlunni = new List<BranchAlunno>(1000);

        private void NuovoAlunno(object sender, RoutedEventArgs e)
        {
            BranchAlunno alunno1 = new BranchAlunno();

            nome.Text = alunno1.NomeAlunno;
            cognome.Text = alunno1.CognomeAlunno;
            età.Text = alunno1.EtàAlunno.ToString();
            cittàResidenza.Text = alunno1.CittàDiResidenza;

            alunno1.ToString();
        }

        private void AggiuntaAlunno(object sender, RoutedEventArgs e)
        {
            BranchAlunno alunno2 = new BranchAlunno();

            nome.Text = alunno2.NomeAlunno;
            cognome.Text = alunno2.CognomeAlunno;
            età.Text = alunno2.EtàAlunno.ToString();
            cittàResidenza.Text = alunno2.CittàDiResidenza;

            Scuola s1 = new Scuola();
            s1.AggiuntaAlunno();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BranchAlunno alunno3 = new BranchAlunno();

            età.Text = alunno3.EtàAlunno.ToString();

            Scuola s1 = new Scuola();
            s1.RicercaAlunniEtà(alunno3);
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < elencoAlunni.Count; i++)
            {
                alunnitotali.Text = elencoAlunni.Count.ToString();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
