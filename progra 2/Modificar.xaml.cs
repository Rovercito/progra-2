using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace progra_2
{
    /// <summary>
    /// Interaction logic for Modificar.xaml
    /// </summary>
    public partial class Modificar : Window
    {
        string path = @"d:\Usuarios.txt";
        string pathAux = @"d:\auxiliar.txt";
        public Modificar()
        {
            InitializeComponent();
        }

        private void ButtonCerrar_Click(object sender, RoutedEventArgs e)
        {
           CrearUsuarios v1 = new CrearUsuarios();
            v1.Show();
            this.Close();
        }

        private void ButtonModificar_Click(object sender, RoutedEventArgs e)
        {
            string nombre = TextBoxBuscarUsuario.Text;
            try
            {
                MessageBoxResult resultado = (MessageBox.Show("¿Estas seguro de modificarlos datos del Usuario?", "Confirmar", MessageBoxButton.OKCancel, MessageBoxImage.Question));
                if (resultado == MessageBoxResult.OK)
                {
                    //Primero debemos crear un archivo de texto auxiliar:
                    CrearAuxiliar();
                    //Metodo para buscar el estudiante:
                    Editar(nombre);
                }

            }
            catch (Exception)
            {
                throw;
            }

        }
        private void Editar(string nombre)
        {
            string linea;
            string[] palabras = new string[5];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(path);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[0] == nombre && encontrado == false)
                {
                    //quiere decir que se encontro al estudiante
                    encontrado = true;
                    //leer los datos de la IU y enviarlo al archivo auxiliar:
                    string nuevaLinea = TextBoxNuevoUsuario.Text + "/" + TextBoxPrimerApellido.Text + "/" + TextBoxSegundoApellido.Text+"/"+TextBoxCi.Text+"/"+PasswordBoxNuevo.Password;
                    Nueva(nuevaLinea);
                }
                else
                {
                    Nueva(linea);
                }
                linea = tuberia.ReadLine();
            }
            tuberia.Close();
            if (encontrado == false)
            {
                MessageBox.Show("El Usuario no existe..");
            }
            else
            {
                //si habia el estudiante:
                File.Delete(path);
                File.Move(pathAux, path);
                MessageBox.Show("Usuario modificado con exito..");
                Cargar();
                CrearUsuarios v1 = new CrearUsuarios();
                v1.Show();
                this.Close();

            }

            File.Delete(pathAux);

        }
        private void Nueva(string linea)
        {
            StreamWriter tuberia = File.AppendText(pathAux);
            tuberia.WriteLine(linea);
            tuberia.Close();
        }

        private void CrearAuxiliar()
        {
            try
            {
                if (!(File.Exists(pathAux)))
                {
                    CrearArchivoAuxiliar();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CrearArchivoAuxiliar()
        {
            StreamWriter tuberia = File.CreateText(pathAux);
            tuberia.Close();
        }
        private void Cargar()
        {
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(path);
                string lineas, separador = "/";
                lineas = tuberia.ReadLine();
                while (lineas != null)
                {
                    lineas = tuberia.ReadLine();
                }
                tuberia.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }

        private void ButtonEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nombre = TextBoxBuscarUsuario.Text;
                MessageBoxResult resultado = (MessageBox.Show("¿Estas seguro de eliminar al Usuario?", "Confirmar", MessageBoxButton.OKCancel, MessageBoxImage.Question));
                if (resultado == MessageBoxResult.OK)
                {
                    //Primero debemos crear un archivo de texto auxiliar:
                    CrearAuxiliar();
                    //Metodo para buscar
                    BuscarUsuario(nombre);
                    
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void BuscarUsuario(string nombre)
        {
            string linea;
            string[] palabras = new string[5];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(path);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[0] == nombre && encontrado == false)
                {
                    encontrado = true;
                    MessageBox.Show("Usuario eliminado con exito");
                }
                else
                {
                    Nueva(linea);
                }
                linea = tuberia.ReadLine();
            }
            tuberia.Close();
            if (encontrado == false)
            {
                MessageBox.Show("El usuario no existe ... ");
            }
            else
            {
                //si habia el estudiante:
                File.Delete(path);
                File.Move(pathAux, path);
            }

            File.Delete(pathAux);

        }
    }
}
