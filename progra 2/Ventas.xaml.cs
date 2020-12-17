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
using System.IO;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;


namespace progra_2
{
    /// <summary>
    /// Interaction logic for Ventas.xaml
    /// </summary>
    public partial class Ventas : Window
    {
        string pathVentas = @"D:\Venta.txt";
        string pathAux = @"d:\auxiliar.txt";
        public Ventas()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            MainWindow v = new MainWindow();
            v.Show();
            this.Close();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (ComboBox1.Text == "Licores")
            {
                frame1.NavigationService.Navigate(new Page1());
            }
            if (ComboBox1.Text == "Cigarros")
            {
                frame1.NavigationService.Navigate(new Cigarro());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListBoxVenta.Items.Clear();
            string[] palabras;
            try
            {
                bool encontrado = false;
                StreamReader tuberia;
                tuberia = File.OpenText(pathVentas);
                string linea, separdor = "/";
                linea = tuberia.ReadLine();
                while (linea != null)
                {
                    palabras = Regex.Split(linea, separdor);
                    //ListBoxPrueba.Items.Add(palabras[0]+ "/" + palabras[1]+ "/"+ palabras[2]);
                    ListBoxVenta.Items.Add(linea);

                    linea = tuberia.ReadLine();

                }
                tuberia.Close();

            }
            catch (Exception)
            {
            }
            ListBoxVenta.Items.Remove("");
        }

        private void ButtinTotal_Click(object sender, RoutedEventArgs e)
        {
            string[] palabras;
            try
            {
                double precioTotal = 0;
                bool encontrado = false;
                StreamReader tuberia;
                tuberia = File.OpenText(pathVentas);
                string linea, separdor = "/";
                linea = tuberia.ReadLine();
                while (linea != null)
                {
                    palabras = Regex.Split(linea, separdor);
                    //ListBoxPrueba.Items.Add(palabras[0]+ "/" + palabras[1]+ "/"+ palabras[2]);
                    precioTotal = precioTotal + int.Parse(palabras[2]);
                    linea = tuberia.ReadLine();

                }
                tuberia.Close();
                MessageBox.Show(precioTotal.ToString()+"Bs.");
            }
            catch (Exception)
            {
            }
        }

        private void ButtonNuevaVenta_Click(object sender, RoutedEventArgs e)
        {
            File.Delete(pathVentas);
            StreamWriter tuberiaCrear = File.CreateText(pathVentas);
            tuberiaCrear.Close();
            ListBoxVenta.Items.Clear();
        }
     
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Quiens v3 = new Quiens();
            v3.Show();
            this.Close();
        }
    }
}
