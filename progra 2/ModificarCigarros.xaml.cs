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
namespace progra_2
{
    /// <summary>
    /// Interaction logic for ModificarCigarros.xaml
    /// </summary>
    public partial class ModificarCigarros : Window
    {
        string pathAux = @"d:\auxiliar.txt";
        string pathMarlboro = @"D:\Marlboro.txt";
        string pathPall_Mall  = @"D:\Pall Mall.txt";
        string pathCamel = @"D:\Camel.txt";
        string pathDerby = @"D:\Derby.txt";
        int idMarlboro = 1;
        int idPall_Mall = 1;
        int idCamel = 1;
        int idDerby = 1;
        int idMarlboroN = 1;
        int idPall_MallN = 1;
        int idCamelN = 1;
        int idDerbyN = 1;
        
        public ModificarCigarros()
        {
            InitializeComponent();
        }

        private void ButtonCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (TexBoxProductoNuevo.Text != "" && TexBoxPrecio.Text != "")
            {
                if (ComboBoxLicores.Text == "Marlboro")
                {
                    Marlboro();
                }
                if (ComboBoxLicores.Text == "Pall Mall")
                {
                    Pall_Mall();
                }
                if (ComboBoxLicores.Text == "Camel")
                {
                    Camel();
                }
                if (ComboBoxLicores.Text == "Derby")
                {
                    Derby();
                }
            }
            else
            {
                MessageBox.Show("No puede registrar productos en blanco");
            }
        }

        private void Marlboro()
        {
            try
            {
                //Vamos a usar la clase StreamWrite para crear el archivo
                StreamWriter tuberia;
                //Primero debemos de ver si ya existe
                if (File.Exists(pathMarlboro))
                {
                    tuberia = File.AppendText(pathMarlboro);
                    //el archivo existe:
                    //la estructura del archivo sera:
                    // nombre/carrera/semestre
                    tuberia.WriteLine(idMarlboro + "M" + "/" + TexBoxProductoNuevo.Text + "/" + TexBoxPrecio.Text + "/" + ComboBoxLicores.Text);
                    tuberia.Close();
                    idMarlboro++;
                    LabelIDNuevo.Content = idMarlboro.ToString() + "O";
                }

                else
                {
                    //no existe, hay que crearlo:
                    StreamWriter tuberiaCrear = File.CreateText(pathMarlboro);
                    tuberiaCrear.Close();
                    MessageBox.Show("Se creo el archivo con exito");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }

        private void Pall_Mall()
        {
            try
            {
                //Vamos a usar la clase StreamWrite para crear el archivo
                StreamWriter tuberia;
                //Primero debemos de ver si ya existe
                if (File.Exists(pathPall_Mall))
                {
                    tuberia = File.AppendText(pathPall_Mall);
                    //el archivo existe:
                    //la estructura del archivo sera:
                    // nombre/carrera/semestre
                    tuberia.WriteLine(idPall_Mall + "PM" + "/" + TexBoxProductoNuevo.Text + "/" + TexBoxPrecio.Text + "/" + ComboBoxLicores.Text);
                    tuberia.Close();
                    idPall_Mall++;
                    LabelIDNuevo.Content = idPall_Mall.ToString() + "VI";
                }

                else
                {
                    //no existe, hay que crearlo:
                    StreamWriter tuberiaCrear = File.CreateText(pathPall_Mall);
                    tuberiaCrear.Close();
                    MessageBox.Show("Se creo el archivo con exito");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }

        private void Camel()
        {
            try
            {
                //Vamos a usar la clase StreamWrite para crear el archivo
                StreamWriter tuberia;
                //Primero debemos de ver si ya existe
                if (File.Exists(pathCamel))
                {
                    tuberia = File.AppendText(pathCamel);
                    //el archivo existe:
                    //la estructura del archivo sera:
                    // nombre/carrera/semestre
                    tuberia.WriteLine(idCamel + "C" + "/" + TexBoxProductoNuevo.Text + "/" + TexBoxPrecio.Text + "/" + ComboBoxLicores.Text);
                    tuberia.Close();
                    idCamel++;
                    LabelIDNuevo.Content = idCamel.ToString() + "W";
                }

                else
                {
                    //no existe, hay que crearlo:
                    StreamWriter tuberiaCrear = File.CreateText(pathCamel);
                    tuberiaCrear.Close();
                    MessageBox.Show("Se creo el archivo con exito");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }

        private void Derby()
        {
            try
            {
                //Vamos a usar la clase StreamWrite para crear el archivo
                StreamWriter tuberia;
                //Primero debemos de ver si ya existe
                if (File.Exists(pathDerby))
                {
                    tuberia = File.AppendText(pathDerby);
                    //el archivo existe:
                    //la estructura del archivo sera:
                    // nombre/carrera/semestre
                    tuberia.WriteLine(idDerby + "D" + "/" + TexBoxProductoNuevo.Text + "/" + TexBoxPrecio.Text + "/" + ComboBoxLicores.Text);
                    tuberia.Close();
                    idDerby++;
                    LabelIDNuevo.Content = idDerby.ToString() + "R";
                }

                else
                {
                    //no existe, hay que crearlo:
                    StreamWriter tuberiaCrear = File.CreateText(pathDerby);
                    tuberiaCrear.Close();
                    MessageBox.Show("Se creo el archivo con exito");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }

        private void ButtonModificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string id = TextBoxBuscarId.Text;
                MessageBoxResult resultado = (MessageBox.Show("¿Estas seguro de modificarlos datos del Producto?", "Confirmar", MessageBoxButton.OKCancel, MessageBoxImage.Question));
                if (resultado == MessageBoxResult.OK)
                {
                    if (texboxNuevoNombre.Text != "" && TexboxNuevoPrecio.Text != "")
                    {
                        CrearAuxiliar();
                        //Metodo para buscar:
                        if (ComboBoxLicoresModificar.Text == "Marlboro")
                        {
                            EditMarlboro(id);
                        }
                        if (ComboBoxLicoresModificar.Text == "Pall Mall")
                        {
                            EditPall_Mall(id);
                        }
                        if (ComboBoxLicoresModificar.Text == "Camel")
                        {
                            EditCamel(id);
                        }
                        if (ComboBoxLicoresModificar.Text == "Derby")
                        {
                            EditDerby(id);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No puede modificar el producto si no pone el nuevo nombre y/o precio");
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }

        }
        private void EditMarlboro(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathMarlboro);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[0] == id && encontrado == false)
                {
                    //quiere decir que se encontro al estudiante
                    encontrado = true;
                    //leer los datos de la IU y enviarlo al archivo auxiliar:
                    string nuevaLinea = idMarlboroN + "N.M" + "/" + texboxNuevoNombre.Text + "/" + TexboxNuevoPrecio.Text + "/" + ComboBoxLicoresModificar.Text;
                    Nueva(nuevaLinea);
                    idMarlboroN++;
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
                MessageBox.Show("El Producto no existe..");
            }
            else
            {
                //si habia el estudiante:
                File.Delete(pathMarlboro);
                File.Move(pathAux, pathMarlboro);
                MessageBox.Show("Producto modificado con exito..");
                CargarMalboro();

            }

            File.Delete(pathAux);
        }
        private void CargarMalboro()
        {
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathMarlboro);
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
        private void EditPall_Mall(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathPall_Mall);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[0] == id && encontrado == false)
                {
                    //quiere decir que se encontro al estudiante
                    encontrado = true;
                    //leer los datos de la IU y enviarlo al archivo auxiliar:
                    string nuevaLinea = idPall_MallN + "N.PM" + "/" + texboxNuevoNombre.Text + "/" + TexboxNuevoPrecio.Text + "/" + ComboBoxLicoresModificar.Text;
                    Nueva(nuevaLinea);
                    idPall_MallN++;
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
                MessageBox.Show("El Producto no existe..");
            }
            else
            {
                //si habia el estudiante:
                File.Delete(pathPall_Mall);
                File.Move(pathAux, pathPall_Mall);
                MessageBox.Show("Producto modificado con exito..");
                CargarPall_Mall();

            }

            File.Delete(pathAux);
        }
        private void CargarPall_Mall()
        {
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathPall_Mall);
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
        private void EditCamel(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathCamel);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[0] == id && encontrado == false)
                {
                    //quiere decir que se encontro al estudiante
                    encontrado = true;
                    //leer los datos de la IU y enviarlo al archivo auxiliar:
                    string nuevaLinea = idCamelN + "N.C" + "/" + texboxNuevoNombre.Text + "/" + TexboxNuevoPrecio.Text + "/" + ComboBoxLicoresModificar.Text;
                    Nueva(nuevaLinea);
                    idCamelN++;
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
                MessageBox.Show("El Producto no existe..");
            }
            else
            {
                //si habia el estudiante:
                File.Delete(pathCamel);
                File.Move(pathAux, pathCamel);
                MessageBox.Show("Producto modificado con exito..");
                CargarCamel();

            }

            File.Delete(pathAux);
        }
        private void CargarCamel()
        {
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathCamel);
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
        private void EditDerby(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathDerby);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[0] == id && encontrado == false)
                {
                    //quiere decir que se encontro al estudiante
                    encontrado = true;
                    //leer los datos de la IU y enviarlo al archivo auxiliar:
                    string nuevaLinea = idDerbyN + "N.D" + "/" + texboxNuevoNombre.Text + "/" + TexboxNuevoPrecio.Text + "/" + ComboBoxLicoresModificar.Text;
                    Nueva(nuevaLinea);
                    idDerbyN++;
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
                MessageBox.Show("El Producto no existe..");
            }
            else
            {
                //si habia el estudiante:
                File.Delete(pathDerby);
                File.Move(pathAux, pathDerby);
                MessageBox.Show("Producto modificado con exito..");
                CargarDerby();

            }

            File.Delete(pathAux);
        }
        private void CargarDerby()
        {
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathDerby);
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

        private void ButtonEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string id = TextBoxBuscarId.Text;
                string nombre = TextBoxNombre.Text;
                MessageBoxResult resultado = (MessageBox.Show("¿Estas seguro de eliminar el producto?", "Confirmar", MessageBoxButton.OKCancel, MessageBoxImage.Question));
                if (resultado == MessageBoxResult.OK)
                {
                    //Primero debemos crear un archivo de texto auxiliar:
                    CrearAuxiliar();
                    if (id != "" && nombre != "" && ComboBoxLicoresEliminar.Text == "Marlboro")
                    {
                        BuscarMarlboro(nombre);
                    }
                    else
                    {
                        if (id != "" && nombre == "")
                        {
                            BuscarMarlboroID(id);
                        }
                        else
                        {
                            BuscarMarlboro(nombre);
                        }
                    }
                    if (id != "" && nombre != "" && ComboBoxLicoresEliminar.Text == "Pall Mall")
                    {
                        BuscarPall_Mall(nombre);
                    }
                    else
                    {
                        if (id != "" && nombre == "")
                        {
                            BuscarPall_MallID(id);
                        }
                        else
                        {
                            BuscarPall_Mall(nombre);
                        }
                    }
                    if (id != "" && nombre != "" && ComboBoxLicoresEliminar.Text == "Camel")
                    {
                        BuscarCamel(nombre);
                    }
                    else
                    {
                        if (id != "" && nombre == "")
                        {
                            BuscarCamelID(id);
                        }
                        else
                        {
                            BuscarCamel(nombre);
                        }
                    }
                    if (id != "" && nombre != "" && ComboBoxLicoresEliminar.Text == "Derby")
                    {
                        BuscarDerby(nombre);
                    }
                    else
                    {
                        if (id != "" && nombre == "")
                        {
                            BuscarDerbyID(id);
                        }
                        else
                        {
                            BuscarDerby(nombre);
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private void BuscarMarlboroID(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathMarlboro);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[0] == id && encontrado == false)
                {
                    encontrado = true;
                    MessageBox.Show("Producto eliminado con exito");
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
                MessageBox.Show("El producto no existe ... ");
            }
            else
            {
                //si habia el estudiante:
                File.Delete(pathMarlboro);
                File.Move(pathAux, pathMarlboro);
            }

            File.Delete(pathAux);

        }

        private void BuscarMarlboro(string nombre)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathMarlboro);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[1] == nombre && encontrado == false)
                {
                    encontrado = true;
                    MessageBox.Show("Producto eliminado con exito");
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
                MessageBox.Show("El producto no existe ... ");
            }
            else
            {
                //si habia el estudiante:
                File.Delete(pathMarlboro);
                File.Move(pathAux, pathMarlboro);
            }

            File.Delete(pathAux);

        }
        private void BuscarPall_MallID(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathPall_Mall);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[0] == id && encontrado == false)
                {
                    encontrado = true;
                    MessageBox.Show("Producto eliminado con exito");
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
                MessageBox.Show("El producto no existe ... ");
            }
            else
            {
                //si habia el estudiante:
                File.Delete(pathPall_Mall);
                File.Move(pathAux, pathPall_Mall);
            }

            File.Delete(pathAux);

        }

        private void BuscarPall_Mall(string nombre)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathPall_Mall);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[1] == nombre && encontrado == false)
                {
                    encontrado = true;
                    MessageBox.Show("Producto eliminado con exito");
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
                MessageBox.Show("El producto no existe ... ");
            }
            else
            {
                //si habia el estudiante:
                File.Delete(pathPall_Mall);
                File.Move(pathAux, pathPall_Mall);
            }

            File.Delete(pathAux);

        }
        private void BuscarCamelID(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathCamel);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[0] == id && encontrado == false)
                {
                    encontrado = true;
                    MessageBox.Show("Producto eliminado con exito");
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
                MessageBox.Show("El producto no existe ... ");
            }
            else
            {
                //si habia el estudiante:
                File.Delete(pathCamel);
                File.Move(pathAux, pathCamel);
            }

            File.Delete(pathAux);

        }

        private void BuscarCamel(string nombre)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathCamel);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[1] == nombre && encontrado == false)
                {
                    encontrado = true;
                    MessageBox.Show("Producto eliminado con exito");
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
                MessageBox.Show("El producto no existe ... ");
            }
            else
            {
                //si habia el estudiante:
                File.Delete(pathCamel);
                File.Move(pathAux, pathCamel);
            }

            File.Delete(pathAux);

        }
        private void BuscarDerbyID(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathDerby);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[0] == id && encontrado == false)
                {
                    encontrado = true;
                    MessageBox.Show("Producto eliminado con exito");
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
                MessageBox.Show("El producto no existe ... ");
            }
            else
            {
                //si habia el estudiante:
                File.Delete(pathDerby);
                File.Move(pathAux, pathDerby);
            }

            File.Delete(pathAux);

        }

        private void BuscarDerby(string nombre)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathDerby);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[1] == nombre && encontrado == false)
                {
                    encontrado = true;
                    MessageBox.Show("Producto eliminado con exito");
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
                MessageBox.Show("El producto no existe ... ");
            }
            else
            {
                //si habia el estudiante:
                File.Delete(pathDerby);
                File.Move(pathAux, pathDerby);
            }

            File.Delete(pathAux);
        }
    }
}
