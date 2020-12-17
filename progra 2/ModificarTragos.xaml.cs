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
    /// Interaction logic for ModificarTragos.xaml
    /// </summary>
    public partial class ModificarTragos : Window
    {
        string pathAux = @"d:\auxiliar.txt";
        string pathVodka = @"D:\Vodka.txt";
        string pathTequila = @"D:\Tequila.txt";
        string pathCerveza = @"D:\Cerveza.txt";
        string pathRon = @"D:\Ron.txt";
        string pathWhiskey = @"D:\Whiskey.txt";
        string pathVino = @"D:\Vino.txt";
        string pathOtros = @"D:\Otros.txt";
        int idVodka = 1;
        int idTequila = 1;
        int idCerveza = 1;
        int idRon = 1;
        int idWhiskey = 1;
        int idVino = 1;
        int idOtros = 1;
        int idVodkaN = 1;
        int idTequilaN = 1;
        int idCervezaN = 1;
        int idRonN = 1;
        int idWhiskeyN = 1;
        int idVinoN = 1;
        int idOtrosN = 1;
        public ModificarTragos()
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
                if (ComboBoxLicores.Text == "Vodka")
                {
                    Vodka();
                }
                if (ComboBoxLicores.Text == "Tequila")
                {
                    Tequila();
                }
                if (ComboBoxLicores.Text == "Cerveza")
                {
                    Cerveza();
                }
                if (ComboBoxLicores.Text == "Ron")
                {
                    Ron();
                }
                if (ComboBoxLicores.Text == "Whiskey")
                {
                    Whiskey();
                }
                if (ComboBoxLicores.Text == "Vino")
                {
                    Vino();
                }
                if (ComboBoxLicores.Text == "Otros")
                {
                    Otros();
                }
            }
            else
            {
                MessageBox.Show("No puede registrar productos en blanco");
            }
        }

        private void Otros()
        {
            try
            {
                //Vamos a usar la clase StreamWrite para crear el archivo
                StreamWriter tuberia;
                //Primero debemos de ver si ya existe
                if (File.Exists(pathOtros))
                {
                    tuberia = File.AppendText(pathOtros);
                    //el archivo existe:
                    //la estructura del archivo sera:
                    // nombre/carrera/semestre
                    tuberia.WriteLine(idOtros + "O" + "/" + TexBoxProductoNuevo.Text + "/" + TexBoxPrecio.Text + "/" + ComboBoxLicores.Text);
                    tuberia.Close();
                    idOtros++;
                    LabelIDNuevo.Content = idOtros.ToString() + "O";
                }

                else
                {
                    //no existe, hay que crearlo:
                    StreamWriter tuberiaCrear = File.CreateText(pathOtros);
                    tuberiaCrear.Close();
                    MessageBox.Show("Se creo el archivo con exito");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }

        private void Vino()
        {
            try
            {
                //Vamos a usar la clase StreamWrite para crear el archivo
                StreamWriter tuberia;
                //Primero debemos de ver si ya existe
                if (File.Exists(pathVino))
                {
                    tuberia = File.AppendText(pathVino);
                    //el archivo existe:
                    //la estructura del archivo sera:
                    // nombre/carrera/semestre
                    tuberia.WriteLine(idVino + "VI" + "/" + TexBoxProductoNuevo.Text + "/" + TexBoxPrecio.Text + "/" + ComboBoxLicores.Text);
                    tuberia.Close();
                    idVino++;
                    LabelIDNuevo.Content = idVino.ToString() + "VI";
                }

                else
                {
                    //no existe, hay que crearlo:
                    StreamWriter tuberiaCrear = File.CreateText(pathVino);
                    tuberiaCrear.Close();
                    MessageBox.Show("Se creo el archivo con exito");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }

        private void Whiskey()
        {
            try
            {
                //Vamos a usar la clase StreamWrite para crear el archivo
                StreamWriter tuberia;
                //Primero debemos de ver si ya existe
                if (File.Exists(pathWhiskey))
                {
                    tuberia = File.AppendText(pathWhiskey);
                    //el archivo existe:
                    //la estructura del archivo sera:
                    // nombre/carrera/semestre
                    tuberia.WriteLine(idWhiskey + "W" + "/" + TexBoxProductoNuevo.Text + "/" + TexBoxPrecio.Text + "/" + ComboBoxLicores.Text);
                    tuberia.Close();
                    idWhiskey++;
                    LabelIDNuevo.Content = idWhiskey.ToString() + "W";
                }

                else
                {
                    //no existe, hay que crearlo:
                    StreamWriter tuberiaCrear = File.CreateText(pathWhiskey);
                    tuberiaCrear.Close();
                    MessageBox.Show("Se creo el archivo con exito");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }

        private void Ron()
        {
            try
            {
                //Vamos a usar la clase StreamWrite para crear el archivo
                StreamWriter tuberia;
                //Primero debemos de ver si ya existe
                if (File.Exists(pathRon))
                {
                    tuberia = File.AppendText(pathRon);
                    //el archivo existe:
                    //la estructura del archivo sera:
                    // nombre/carrera/semestre
                    tuberia.WriteLine(idRon + "R" + "/" + TexBoxProductoNuevo.Text + "/" + TexBoxPrecio.Text + "/" + ComboBoxLicores.Text);
                    tuberia.Close();
                    idRon++;
                    LabelIDNuevo.Content = idRon.ToString() + "R";
                }

                else
                {
                    //no existe, hay que crearlo:
                    StreamWriter tuberiaCrear = File.CreateText(pathRon);
                    tuberiaCrear.Close();
                    MessageBox.Show("Se creo el archivo con exito");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }

        private void Cerveza()
        {
            try
            {
                //Vamos a usar la clase StreamWrite para crear el archivo
                StreamWriter tuberia;
                //Primero debemos de ver si ya existe
                if (File.Exists(pathCerveza))
                {
                    tuberia = File.AppendText(pathCerveza);
                    //el archivo existe:
                    //la estructura del archivo sera:
                    // nombre/carrera/semestre
                    tuberia.WriteLine(idCerveza + "C" + "/" + TexBoxProductoNuevo.Text + "/" + TexBoxPrecio.Text + "/" + ComboBoxLicores.Text);
                    tuberia.Close();
                    idCerveza++;
                    LabelIDNuevo.Content = idCerveza.ToString() + "C";
                }

                else
                {
                    //no existe, hay que crearlo:
                    StreamWriter tuberiaCrear = File.CreateText(pathCerveza);
                    tuberiaCrear.Close();
                    MessageBox.Show("Se creo el archivo con exito");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }
        private void Tequila()
        {
            try
            {
                //Vamos a usar la clase StreamWrite para crear el archivo
                StreamWriter tuberia;
                //Primero debemos de ver si ya existe
                if (File.Exists(pathTequila))
                {
                    tuberia = File.AppendText(pathTequila);
                    //el archivo existe:
                    //la estructura del archivo sera:
                    // nombre/carrera/semestre
                    tuberia.WriteLine(idTequila + "T" + "/" + TexBoxProductoNuevo.Text + "/" + TexBoxPrecio.Text + "/" + ComboBoxLicores.Text);
                    tuberia.Close();
                    idTequila++;
                    LabelIDNuevo.Content = idTequila.ToString() + "T";
                }

                else
                {
                    //no existe, hay que crearlo:
                    StreamWriter tuberiaCrear = File.CreateText(pathTequila);
                    tuberiaCrear.Close();
                    MessageBox.Show("Se creo el archivo con exito");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }
        }

        private void Vodka()
        {
            try
            {
                //Vamos a usar la clase StreamWrite para crear el archivo
                StreamWriter tuberia;
                //Primero debemos de ver si ya existe
                if (File.Exists(pathVodka))
                {
                    tuberia = File.AppendText(pathVodka);
                    //el archivo existe:
                    //la estructura del archivo sera:
                    // nombre/carrera/semestre
                    tuberia.WriteLine(idVodka + "V" + "/" + TexBoxProductoNuevo.Text + "/" + TexBoxPrecio.Text + "/" + ComboBoxLicores.Text);
                    tuberia.Close();
                    idVodka++;
                    LabelIDNuevo.Content = idVodka.ToString() + "V";
                }

                else
                {
                    //no existe, hay que crearlo:
                    StreamWriter tuberiaCrear = File.CreateText(pathVodka);
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
                        if (ComboBoxLicoresModificar.Text == "Vodka")
                        {
                            EditVodka(id);
                        }
                        if (ComboBoxLicoresModificar.Text == "Tequila")
                        {
                            EditTequila(id);
                        }
                        if (ComboBoxLicoresModificar.Text == "Cerveza")
                        {
                            EditCerveza(id);
                        }
                        if (ComboBoxLicoresModificar.Text == "Ron")
                        {
                            EditRon(id);
                        }
                        if (ComboBoxLicoresModificar.Text == "Whiskey")
                        {
                            EditWiskey(id);
                        }
                        if (ComboBoxLicoresModificar.Text == "Vino")
                        {
                            EditVino(id);
                        }
                        if (ComboBoxLicoresModificar.Text == "Otros")
                        {
                            EditOtros(id);
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
        private void EditOtros(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathOtros);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[0] == id && encontrado == false)
                {
                    //quiere decir que se encontro al estudiante
                    encontrado = true;
                    //leer los datos de la IU y enviarlo al archivo auxiliar:
                    string nuevaLinea = idOtrosN+"N.O" + "/" + texboxNuevoNombre.Text + "/" + TexboxNuevoPrecio.Text + "/" + ComboBoxLicoresModificar.Text;
                    Nueva(nuevaLinea);
                    idOtrosN++;
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
                File.Delete(pathOtros);
                File.Move(pathAux, pathOtros);
                MessageBox.Show("Producto modificado con exito..");
                CargarOtros();

            }

            File.Delete(pathAux);
        }
        private void CargarOtros()
        {
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathOtros);
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
        private void EditVino(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathVino);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[0] == id && encontrado == false)
                {
                    //quiere decir que se encontro al estudiante
                    encontrado = true;
                    //leer los datos de la IU y enviarlo al archivo auxiliar:
                    string nuevaLinea = idVinoN+"N.V" + "/" + texboxNuevoNombre.Text + "/" + TexboxNuevoPrecio.Text + "/" + ComboBoxLicoresModificar.Text;
                    Nueva(nuevaLinea);
                    idVinoN++;
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
                File.Delete(pathVino);
                File.Move(pathAux, pathVino);
                MessageBox.Show("Producto modificado con exito..");
                CargarVino();

            }

            File.Delete(pathAux);
        }
        private void CargarVino()
        {
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathVino);
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
        private void EditWiskey(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathWhiskey);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[0] == id && encontrado == false)
                {
                    //quiere decir que se encontro al estudiante
                    encontrado = true;
                    //leer los datos de la IU y enviarlo al archivo auxiliar:
                    string nuevaLinea = idWhiskeyN+"N.W" + "/" + texboxNuevoNombre.Text + "/" + TexboxNuevoPrecio.Text + "/" + ComboBoxLicoresModificar.Text;
                    Nueva(nuevaLinea);
                    idWhiskeyN++;
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
                File.Delete(pathWhiskey);
                File.Move(pathAux, pathWhiskey);
                MessageBox.Show("Producto modificado con exito..");
                CargarWhiskey();

            }

            File.Delete(pathAux);
        }
        private void CargarWhiskey()
        {
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathWhiskey);
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
        private void EditRon(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathRon);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[0] == id && encontrado == false)
                {
                    //quiere decir que se encontro al estudiante
                    encontrado = true;
                    //leer los datos de la IU y enviarlo al archivo auxiliar:
                    string nuevaLinea = idRonN+"N.R" + "/" + texboxNuevoNombre.Text + "/" + TexboxNuevoPrecio.Text + "/" + ComboBoxLicoresModificar.Text;
                    Nueva(nuevaLinea);
                    idRonN++;
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
                File.Delete(pathRon);
                File.Move(pathAux, pathRon);
                MessageBox.Show("Producto modificado con exito..");
                CargarRon();

            }

            File.Delete(pathAux);
        }
        private void CargarRon()
        {
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathRon);
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
        private void EditCerveza(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathCerveza);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[0] == id && encontrado == false)
                {
                    //quiere decir que se encontro al estudiante
                    encontrado = true;
                    //leer los datos de la IU y enviarlo al archivo auxiliar:
                    string nuevaLinea = idCervezaN+"N.C" + "/" + texboxNuevoNombre.Text + "/" + TexboxNuevoPrecio.Text + "/" + ComboBoxLicoresModificar.Text;
                    Nueva(nuevaLinea);
                    idCervezaN++;
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
                File.Delete(pathCerveza);
                File.Move(pathAux, pathCerveza);
                MessageBox.Show("Producto modificado con exito..");
                CargarCerveza();

            }

            File.Delete(pathAux);
        }
        private void CargarCerveza()
        {
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathCerveza);
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
        private void EditTequila(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathTequila);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[0] == id && encontrado == false)
                {
                    //quiere decir que se encontro al estudiante
                    encontrado = true;
                    //leer los datos de la IU y enviarlo al archivo auxiliar:
                    string nuevaLinea = idTequilaN+"N.T" + "/" + texboxNuevoNombre.Text + "/" + TexboxNuevoPrecio.Text + "/" + ComboBoxLicoresModificar.Text;
                    Nueva(nuevaLinea);
                    idTequilaN++;
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
                File.Delete(pathTequila);
                File.Move(pathAux, pathTequila);
                MessageBox.Show("Producto modificado con exito..");
                CargarTequila();

            }

            File.Delete(pathAux);
        }
        private void CargarTequila()
        {
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathTequila);
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
        private void EditVodka(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathVodka);
            linea = tuberia.ReadLine();
            while (linea != null)
            {
                palabras = linea.Split(separador);
                if (palabras[0] == id && encontrado == false)
                {
                    //quiere decir que se encontro al estudiante
                    encontrado = true;
                    //leer los datos de la IU y enviarlo al archivo auxiliar:
                    string nuevaLinea = idVodkaN+"N.VO" + "/" + texboxNuevoNombre.Text + "/" + TexboxNuevoPrecio.Text + "/" + ComboBoxLicoresModificar.Text;
                    Nueva(nuevaLinea);
                    idVodkaN++;
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
                File.Delete(pathVodka);
                File.Move(pathAux, pathVodka);
                MessageBox.Show("Producto modificado con exito..");
                CargarVodka();

            }

            File.Delete(pathAux);

        }
        private void CargarVodka()
        {
            string[] palabras;
            try
            {
                StreamReader tuberia;
                tuberia = File.OpenText(pathVodka);
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
                    if (id != "" && nombre != "" && ComboBoxLicoresEliminar.Text== "Vodka")
                    {
                        BuscarVodka(nombre);
                    }
                    else
                    {
                        if (id != "" && nombre == "")
                        {
                            BuscarVodkaID(id);
                        }
                        else
                        {
                            BuscarVodka(nombre);
                        }
                    }
                    if (id != "" && nombre != "" && ComboBoxLicoresEliminar.Text == "Tequila")
                    {
                        BuscarTequila(nombre);
                    }
                    else
                    {
                        if (id != "" && nombre == "")
                        {
                            BuscarTequilaID(id);
                        }
                        else
                        {
                            BuscarTequila(nombre);
                        }
                    }
                    if (id != "" && nombre != "" && ComboBoxLicoresEliminar.Text == "Cerveza")
                    {
                        BuscarCerveza(nombre);
                    }
                    else
                    {
                        if (id != "" && nombre == "")
                        {
                            BuscarCervezaID(id);
                        }
                        else
                        {
                            BuscarCerveza(nombre);
                        }
                    }
                    if (id != "" && nombre != "" && ComboBoxLicoresEliminar.Text == "Ron")
                    {
                        BuscarRon(nombre);
                    }
                    else
                    {
                        if (id != "" && nombre == "")
                        {
                            BuscarRonID(id);
                        }
                        else
                        {
                            BuscarRon(nombre);
                        }
                    }
                    if (id != "" && nombre != "" && ComboBoxLicoresEliminar.Text == "Whiskey")
                    {
                        BuscarWhiskey(nombre);
                    }
                    else
                    {
                        if (id != "" && nombre == "")
                        {
                            BuscarWhiskeyID(id);
                        }
                        else
                        {
                            BuscarWhiskey(nombre);
                        }
                    }
                    if (id != "" && nombre != "" && ComboBoxLicoresEliminar.Text == "Vino")
                    {
                        BuscarVino(nombre);
                    }
                    else
                    {
                        if (id != "" && nombre == "")
                        {
                            BuscarVinoID(id);
                        }
                        else
                        {
                            BuscarVino(nombre);
                        }
                    }
                    if (id != "" && nombre != "" && ComboBoxLicoresEliminar.Text == "Otros")
                    {
                        BuscarOtros(nombre);
                    }
                    else
                    {
                        if (id != "" && nombre == "")
                        {
                            BuscarOtrosID(id);
                        }
                        else
                        {
                            BuscarOtros(nombre);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private void BuscarOtrosID(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathOtros);
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
                File.Delete(pathOtros);
                File.Move(pathAux, pathOtros);
            }

            File.Delete(pathAux);

        }

        private void BuscarOtros(string nombre)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathOtros);
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
                File.Delete(pathOtros);
                File.Move(pathAux, pathOtros);
            }

            File.Delete(pathAux);

        }
        private void BuscarVinoID(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathVino);
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
                File.Delete(pathVino);
                File.Move(pathAux, pathVino);
            }

            File.Delete(pathAux);

        }

        private void BuscarVino(string nombre)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathVino);
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
                File.Delete(pathVino);
                File.Move(pathAux, pathVino);
            }

            File.Delete(pathAux);

        }
        private void BuscarWhiskeyID(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathWhiskey);
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
                File.Delete(pathWhiskey);
                File.Move(pathAux, pathWhiskey);
            }

            File.Delete(pathAux);

        }

        private void BuscarWhiskey(string nombre)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathWhiskey);
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
                File.Delete(pathWhiskey);
                File.Move(pathAux, pathWhiskey);
            }

            File.Delete(pathAux);

        }
        private void BuscarRonID(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathRon);
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
                File.Delete(pathRon);
                File.Move(pathAux, pathRon);
            }

            File.Delete(pathAux);

        }

        private void BuscarRon(string nombre)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathRon);
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
                File.Delete(pathRon);
                File.Move(pathAux, pathRon);
            }

            File.Delete(pathAux);

        }
        private void BuscarCervezaID(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathCerveza);
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
                File.Delete(pathCerveza);
                File.Move(pathAux, pathCerveza);
            }

            File.Delete(pathAux);

        }

        private void BuscarCerveza(string nombre)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathCerveza);
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
                File.Delete(pathCerveza);
                File.Move(pathAux, pathCerveza);
            }

            File.Delete(pathAux);

        }
        private void BuscarTequilaID(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathTequila);
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
                File.Delete(pathTequila);
                File.Move(pathAux, pathTequila);
            }

            File.Delete(pathAux);

        }

        private void BuscarTequila(string nombre)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathTequila);
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
                File.Delete(pathTequila);
                File.Move(pathAux, pathTequila);
            }

            File.Delete(pathAux);

        }
        private void BuscarVodkaID(string id)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathVodka);
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
                File.Delete(pathVodka);
                File.Move(pathAux, pathVodka);
            }

            File.Delete(pathAux);

        }

        private void BuscarVodka(string nombre)
        {
            string linea;
            string[] palabras = new string[4];
            char separador = '/';
            bool encontrado = false;
            StreamReader tuberia = File.OpenText(pathVodka);
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
                File.Delete(pathVodka);
                File.Move(pathAux, pathVodka);
            }

            File.Delete(pathAux);

        }
    }
 }