using desafio.BLL.Interface;
using Ninject;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace desafio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IPotencia _potencia;
        private readonly ITempo _tempo;

        public MainWindow(ITempo tempo, IPotencia potencia)
        {
            InitializeComponent();
            _tempo = tempo;
            _potencia = potencia;
        }

        private void Iniciar(object sender, RoutedEventArgs e)
        {
            string tempoString = InputTempo.Text;
            string potenciaString = InputPotencia.Text;
            int tempo, potencia;

            TratarDados(tempoString, potenciaString, out tempo, out potencia);
            Validar(tempo, potencia);
        }

        private static void TratarDados(string tempoString, string potenciaString, out int tempo, out int potencia)
        {
            if (string.IsNullOrEmpty(tempoString))
                tempo = 30;
            else
                tempo = int.Parse(tempoString);

            if (string.IsNullOrEmpty(potenciaString))
                potencia = 10;
            else
                potencia = int.Parse(potenciaString);
        }

        private void Validar(int tempo, int potencia)
        {
            try
            {
                _tempo.ValidarTempo(tempo);
                _potencia.ValidarPotencia(potencia);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.ParamName);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Os valores devem ser numéricos.");
                return;
            }
        }

        private void PausaCancela(object sender, RoutedEventArgs e)
        {

        }
    }
}