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

namespace indovinailnumero_giusti
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

        int numeroDaIndovinare;
        int numero;
        private void btnrandom_Click(object sender, RoutedEventArgs e)
        {
            numero = = int.Parse(txtnumero.Text);
            Random r = new Random();
            numeroDaIndovinare = r.Next(0, numero);
            txtnumeroimmaginato.IsEnabled = true;
        }

        private void btnreset_Click(object sender, RoutedEventArgs e)
        {
            txtnumero.Clear();
            txtnumeroimmaginato.Clear();
            lblrisultato.Content = "";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int numeroimmaginato = int.Parse(txtnumeroimmaginato.Text);
            int tentativi = int.Parse(txttentativi.Text);
            if (lblgiro)
            {
                lblgiro.Text = "LA ROULETTE STA GIRANDO PIGIA INDOVINA PER FERMARLA!!";
            }
            if (numeroDaIndovinare == numeroimmaginato)
            {
                lblrisultato.Content = "ESATTO... Fortuna del pincipiante";
            }
            else if (numeroDaIndovinare < numeroimmaginato)
            {
                lblrisultato.Content = "MI DISPIACE RITENTA... Comunque il numero è più piccolo";
                tentativi = tentativi - 1;
            }
            else
            {
                lblrisultato.Content = "MI DISPIACE RITENTA... Comunque il numero è più grande";
                tentativi = tentativi - 1;
            }
            if (tentativi == 0)
            {
                MessageBox.Show("GAME OVER", "NABBO", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            txttentativi.Text = tentativi.ToString();
            if (numero > numeroimmaginato)
            {
                MessageBox.Show("IMPOSSIBILE", "FA IL SERIO", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
