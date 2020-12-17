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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        string pathVodka = @"D:\Vodka.txt";
        string pathTequila = @"D:\Tequila.txt";
        string pathCerveza = @"D:\Cerveza.txt";
        string pathRon = @"D:\Ron.txt";
        string pathWhiskey = @"D:\Whiskey.txt";
        string pathVino = @"D:\Vino.txt";
        string pathOtros = @"D:\Otros.txt";
        string pathVentas= @"D:\Venta.txt";
        public Page1()
        {
            InitializeComponent();
        }

        private void ButtonModificar_Click(object sender, RoutedEventArgs e)
        {
            if (Interaction.InputBox("Usuario", "Usuario", "", -1, -1) == "admin" && Interaction.InputBox("Usuario", "Password", "", -1, -1) == "admin")
            {
                ModificarTragos v1 = new ModificarTragos();
                v1.Show();
            }
        }

        private void ButtonIngresar_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxLicores.Text == "Vodka")
            {
                CargarVodka();
            }
            if (ComboBoxLicores.Text == "Tequila")
            {
                CargarTequila();
            }
            if (ComboBoxLicores.Text == "Cerveza")
            {
                CargarCerveza();
            }
            if (ComboBoxLicores.Text == "Ron")
            {   
                CargarRon();
            }
            if (ComboBoxLicores.Text == "Whiskey")
            {
                CargarWhiskey();
            }
            if (ComboBoxLicores.Text == "Vino")
            {
                CargarVino();
            }
            if (ComboBoxLicores.Text == "Otros")
            {
                CargarOtros();
            }
        }
        private void CargarOtros()
        {
            ListBoxMostrar.Items.Clear();
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathOtros);
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
        private void CargarVino()
        {
            ListBoxMostrar.Items.Clear();
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathVino);
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
        private void CargarWhiskey()
        {
            ListBoxMostrar.Items.Clear();
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathWhiskey);
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
        private void CargarRon()
        {
            ListBoxMostrar.Items.Clear();
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathRon);
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
        private void CargarCerveza()
        {
            ListBoxMostrar.Items.Clear();
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathCerveza);
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
        private void CargarTequila()
        {
            ListBoxMostrar.Items.Clear();
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathTequila);
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
        private void CargarVodka()
        {
            ListBoxMostrar.Items.Clear();
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathVodka);
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
            mostrarPrecioTrago();
        }
        private void mostrarPrecioTrago()
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
