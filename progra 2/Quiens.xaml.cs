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
using System.Windows.Shapes;

namespace progra_2
{
    /// <summary>
    /// Lógica de interacción para Quiens.xaml
    /// </summary>
    public partial class Quiens : Window
    {
        public Quiens()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Ventas v1 = new Ventas();
            v1.Show();
            this.Close();
        }
    }
}
