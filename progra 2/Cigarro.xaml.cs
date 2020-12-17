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
    /// Interaction logic for Cigarro.xaml
    /// </summary>
    public partial class Cigarro : Page
    {
        string pathAux = @"d:\auxiliar.txt";
        string pathMarlboro = @"D:\Marlboro.txt";
        string pathPall_Mall = @"D:\Pall Mall.txt";
        string pathCamel = @"D:\Camel.txt";
        string pathDerby = @"D:\Derby.txt";
        string pathVentas = @"D:\Venta.txt";
        public Cigarro()
        {
            InitializeComponent();
        }
        private void ButtonModificar_Click(object sender, RoutedEventArgs e)
        {
            if (Interaction.InputBox("Usuario", "Usuario", "", -1, -1) == "admin" && Interaction.InputBox("Usuario", "Password", "", -1, -1) == "admin")
            {
                ModificarCigarros v1 = new ModificarCigarros();
                v1.Show();
            }
        }
        private void ButtonIngresar_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxLicores.Text == "Marlboro")
            {
                CargarMarlboro();
            }
            if (ComboBoxLicores.Text == "Pall Mall")
            {
                CargarPall_Mall();
            }
            if (ComboBoxLicores.Text == "Camel")
            {
                CargarCamel();
            }
            if (ComboBoxLicores.Text == "Derby")
            {
                CargarDerby();
            }

        }
        private void CargarMarlboro()
        {
            ListBoxMostrar.Items.Clear();
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathMarlboro);
                string lineas, separador = "/";
                lineas = tuberia.ReadLine();
                while (lineas != null)
                {

                    ListBoxMostrar.Items.Add(lineas);
                    lineas = tuberia.ReadLine();
                }
                tuberia.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }
        private void CargarPall_Mall()
        {
            ListBoxMostrar.Items.Clear();
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathPall_Mall);
                string lineas, separador = "/";
                lineas = tuberia.ReadLine();
                while (lineas != null)
                {

                    ListBoxMostrar.Items.Add(lineas);
                    lineas = tuberia.ReadLine();
                }
                tuberia.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }
        private void CargarCamel()
        {
            ListBoxMostrar.Items.Clear();
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathCamel);
                string lineas, separador = "/";
                lineas = tuberia.ReadLine();
                while (lineas != null)
                {

                    ListBoxMostrar.Items.Add(lineas);
                    lineas = tuberia.ReadLine();
                }
                tuberia.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }
        private void CargarDerby()
        {
            ListBoxMostrar.Items.Clear();
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathDerby);
                string lineas, separador = "/";
                lineas = tuberia.ReadLine();
                while (lineas != null)
                {

                    ListBoxMostrar.Items.Add(lineas);
                    lineas = tuberia.ReadLine();
                }
                tuberia.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Vamos a usar la clase StreamWrite para crear el archivo
                StreamWriter tuberia;
                //Primero debemos de ver si ya existe
                if (File.Exists(pathVentas))
                {
                    tuberia = File.AppendText(pathVentas);
                    //el archivo existe:
                    //la estructura del archivo sera:
                    // nombre/carrera/semestre
                    tuberia.WriteLine(ListBoxMostrar.SelectedItem);
                    tuberia.Close();
                }

                else
                {
                    //no existe, hay que crearlo:
                    StreamWriter tuberiaCrear = File.CreateText(pathVentas);
                    tuberiaCrear.Close();
                    MessageBox.Show("Se creo el archivo con exito");

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
            mostrarPrecioCigarro();
        }
 
        private void mostrarPrecioCigarro()
        {
            ListBoxPrueba.Items.Clear();
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

                    ListBoxPrueba.Items.Add(linea);

                    linea = tuberia.ReadLine();

                }
                tuberia.Close();
            }
            catch (Exception)
            {
            }
            ListBoxPrueba.Items.Remove("");
        }
    }
}

   