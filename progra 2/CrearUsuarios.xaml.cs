﻿using System;
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

namespace progra_2
{
    /// <summary>
    /// Interaction logic for CrearUsuarios.xaml
    /// </summary>
    public partial class CrearUsuarios : Window
    {
        string path = @"D:\Usuarios.txt";
        public CrearUsuarios()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                MainWindow v1 = new MainWindow();
                v1.Show();
                this.Close();
        }

        private void ButtonReiniciar_Click(object sender, RoutedEventArgs e)
        {
                TextBoxNombre.Clear();
                TextBoxPrimer.Clear();
                TextBoxSegundo.Clear();
                TextBoxCi.Clear();
                Password.Clear();
        }

        private void ButtonRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxNombre.Text == "" && TextBoxPrimer.Text == "" && TextBoxSegundo.Text == "" && TextBoxCi.Text == "" && Password.Password == "")
            {
                MessageBox.Show("No puede dejar en blanco los espacios");
            }
            else
            {
                try
                {
                    //Vamos a usar la clase StreamWrite para crear el archivo
                    StreamWriter tuberia;
                    //Primero debemos de ver si ya existe
                    if (File.Exists(path))
                    {
                        tuberia = File.AppendText(path);
                        //el archivo existe:
                        //la estructura del archivo sera:
                        // nombre/carrera/semestre
                        tuberia.WriteLine(TextBoxNombre.Text + "/" + TextBoxPrimer.Text + "/" + TextBoxSegundo.Text + "/" + TextBoxCi.Text+"/"+Password.Password);
                        tuberia.Close();
                        MessageBox.Show("Nuevo Usuario creado con exito");
                    }

                    else
                    {
                        //no existe, hay que crearlo:
                        StreamWriter tuberiaCrear = File.CreateText(path);
                        tuberiaCrear.Close();
                        MessageBox.Show("Se creo el archivo con exito");

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error " + ex.Message);
                }
            }
            TextBoxNombre.Clear();
            TextBoxPrimer.Clear();
            TextBoxSegundo.Clear();
            TextBoxCi.Clear();
            Password.Clear();
        }
    private void ButtonModificar_Click(object sender, RoutedEventArgs e)
        {
            
            if(Interaction.InputBox("Usuario", "Usuario", "", -1, -1)=="admin"&& Interaction.InputBox("Usuario", "Password", "", -1, -1)=="admin")
            {

               Modificar v1 = new Modificar();
               v1.Show();
                this.Close();
            }

        }
    }
}
