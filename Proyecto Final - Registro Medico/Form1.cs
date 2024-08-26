using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final___Registro_Medico
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// Iniciamos la Tabla de Datos y las funciones de Leer y Escribir el archivo.txt.
        /// </summary>
        
        DataTable Tabla;
        static StreamReader Leer;
        static StreamWriter Escribir;        


        /// <summary>
        /// Creamos la Estructura de Datos que se utilizaran.
        /// </summary>

        public struct Pacientes
        {
            public string Nombre {  get; set; }
            public string Edad { get; set; }
            public string Sexo { get; set; }
            public string Sangre { get; set; }
            public string Diagnostico { get; set; }
            public string Practica { get; set; }
            public string Residencia { get; set; }
            public string Telefono { get; set; }
            public string Observacion { get; set; }
        }
        
        /// <summary>
        /// Funcion que inicia el programa en general.
        /// </summary>

        public Form1()
        {
            InitializeComponent();
            Iniciar();
            Consultar();
        }

        /// <summary>
        /// Funcion de iniciar que crea el archivo.txt si no esta creado e inicializa la tabla de datos.
        /// </summary>

        public void Iniciar()
        {
            if (!File.Exists("Registro.txt"))
            {
                Escribir = new StreamWriter("Registro.txt", true);
                Escribir.Close();
            }

            Tabla = new DataTable();
            Tabla.Columns.Add("Nombre");
            Tabla.Columns.Add("Edad");
            Tabla.Columns.Add("Sexo");
            Tabla.Columns.Add("Sangre");
            Tabla.Columns.Add("Diagnostico");
            Tabla.Columns.Add("Practica");
            Tabla.Columns.Add("Residencia");
            Tabla.Columns.Add("Telefono");
            Tabla.Columns.Add("Observacion");
            ListaPacientes.DataSource = Tabla;
        }

        /// <summary>
        /// Funcion de guardar, que guarda los datos gracias a la estructura y esta la aloja en el archivo.txt.
        /// </summary>

        public void Guardar()
        {
            Escribir = new StreamWriter("Registro.txt", true);
            Pacientes Paciente = new Pacientes();

            Paciente.Nombre = NombreBOX.Text;
            Escribir.WriteLine("Nombre del Paciente: " + Paciente.Nombre);

            Paciente.Edad = EdadBOX.Text;
            Escribir.WriteLine("Edad: " + Paciente.Edad);

            Paciente.Sexo = SexoBOX.Text;
            Escribir.WriteLine("Sexo: " + Paciente.Sexo);

            Paciente.Sangre = SangreBOX.Text;
            Escribir.WriteLine("Tipo de Sangre: " + Paciente.Sangre);

            Paciente.Diagnostico = DiagBOX.Text;
            Escribir.WriteLine("Diagnostico: " + Paciente.Diagnostico);

            Paciente.Practica = PracticaBOX.Text;
            Escribir.WriteLine("Practicas a Realizar: " + Paciente.Practica);

            Paciente.Residencia = ResidenciaBOX.Text;
            Escribir.WriteLine("Residencia: " + Paciente.Residencia);

            Paciente.Telefono = TelefonoBOX.Text;
            Escribir.WriteLine("Telefono: " + Paciente.Telefono);

            Paciente.Observacion = ObservacionBOX.Text;
            Escribir.WriteLine("Observaciones: " + Paciente.Observacion);


            Escribir.WriteLine();
            Escribir.Close();

            DialogResult result = MessageBox.Show(
                "Se a guardado la informacion del Paciente: " + NombreBOX.Text,
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        /// <summary>
        /// Funcion de limpiar las casillas de datos, no la tabla de datos.
        /// </summary>

        public void Limpiar()
        {
            NombreBOX.Text = "";
            EdadBOX.Text = "";
            SexoBOX.Text = "";
            SangreBOX.Text = "";
            DiagBOX.Text = "";
            PracticaBOX.Text = "";
            ResidenciaBOX.Text = "";
            TelefonoBOX.Text = "";
            ObservacionBOX.Text = "";

            DialogResult result = MessageBox.Show(
                "Se han limpiado las casillas",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        /// <summary>
        /// Funcion que lee y presenta los datos del archivo.txt en la tabla de datos.
        /// </summary>

        public void Consultar()
        {
            Leer = new StreamReader("Registro.txt", true);
            string Linea;

            ListaPacientes.DataSource = null;
            ListaPacientes.Rows.Clear();
            Iniciar();

            while (!Leer.EndOfStream)
            {

                    DataRow fila = Tabla.NewRow();

                    Linea = Leer.ReadLine();
                    Linea = Linea.Replace("Nombre del Paciente: ", "");
                    fila["Nombre"] = Linea;
                    Console.WriteLine(Linea);

                    Linea = Leer.ReadLine();
                    Linea = Linea.Replace("Edad: ", "");
                    fila["Edad"] = Linea;
                    Console.WriteLine(Linea);

                    Linea = Leer.ReadLine();
                    Linea = Linea.Replace("Sexo: ", "");
                    fila["Sexo"] = Linea;
                    Console.WriteLine(Linea);

                    Linea = Leer.ReadLine();
                    Linea = Linea.Replace("Tipo de Sangre: ", "");
                    fila["Sangre"] = Linea;
                    Console.WriteLine(Linea);

                    Linea = Leer.ReadLine();
                    Linea = Linea.Replace("Diagnostico: ", "");
                    fila["Diagnostico"] = Linea;
                    Console.WriteLine(Linea);

                    Linea = Leer.ReadLine();
                    Linea = Linea.Replace("Practicas a Realizar: ", "");
                    fila["Practica"] = Linea;
                    Console.WriteLine(Linea);

                    Linea = Leer.ReadLine();
                    Linea = Linea.Replace("Residencia: ", "");
                    fila["Residencia"] = Linea;
                    Console.WriteLine(Linea);

                    Linea = Leer.ReadLine();
                    Linea = Linea.Replace("Telefono: ", "");
                    fila["Telefono"] = Linea;
                    Console.WriteLine(Linea);

                    Linea = Leer.ReadLine();
                    Linea = Linea.Replace("Observaciones: ", "");
                    fila["Observacion"] = Linea;
                    Console.WriteLine(Linea);

                    Linea = Leer.ReadLine();

                    Tabla.Rows.Add(fila);

            }

            Leer.Close();

        }

        /// <summary>
        /// Funcion que edita los datos buscados, ingresa los datos que no se editaran en una lista y los que se modificaran los reemplazan por los nuevos datos
        /// para a continuacion guardar todos estos datos en el archivo.txt sin cambiar alterar el orden o los datos que no se tenian que modificar.
        /// </summary>

        public void Editar()
        {

            string [] Lineas = File.ReadAllLines("Registro.txt");
            
            List<string> nuevoarchivo = new List<string>();

            string ViejoNombre = NombreBOX.Text;

            bool Edad = false, Sexo = false, Sangre = false, Diag = false, Practicas = false, Residencia = false, Telefono = false, Observacion = false, encontrado = false;

            foreach (string linea in Lineas) 
            {

                if (linea.Equals("Nombre del Paciente: " + ViejoNombre))
                {

                    nuevoarchivo.Add("Nombre del Paciente: " + NombreBOX.Text);
                    Edad = true;
                    encontrado = true;
                    continue;

                }

                if (Edad == true)
                {

                    nuevoarchivo.Add("Edad: " + EdadBOX.Text);
                    Edad = false;
                    Sexo = true;
                    continue;

                }

                if (Sexo == true)
                {

                    nuevoarchivo.Add("Sexo: " + SexoBOX.Text);
                    Sexo = false;
                    Sangre = true;
                    continue;

                }

                if (Sangre == true)
                {

                    nuevoarchivo.Add("Tipo de Sangre: " + SangreBOX.Text);
                    Sangre = false;
                    Diag = true;
                    continue;

                }

                if (Diag == true)
                {

                    nuevoarchivo.Add("Diagnostico: " + DiagBOX.Text);
                    Diag = false;
                    Practicas = true;
                    continue;

                }

                if (Practicas == true)
                {

                    nuevoarchivo.Add("Practicas a Realizar: " + PracticaBOX.Text);
                    Practicas = false;
                    Residencia = true;
                    continue;

                }

                if (Residencia == true)
                {

                    nuevoarchivo.Add("Residencia: " + ResidenciaBOX.Text);
                    Residencia = false;
                    Telefono = true;
                    continue;

                }

                if (Telefono == true)
                {

                    nuevoarchivo.Add("Telefono: " + TelefonoBOX.Text);
                    Telefono = false;
                    Observacion = true;
                    continue;
                }

                if (Observacion == true)
                {

                    nuevoarchivo.Add("Observaciones: " + ObservacionBOX.Text);
                    Observacion = false;
                    encontrado = false;
                    continue;

                }

                if(encontrado == false)
                {
                    nuevoarchivo.Add(linea);
                 
                }

            }

            File.WriteAllLines("Registro.txt", nuevoarchivo);

            DialogResult result = MessageBox.Show(
                "Se a Editado los Datos del Paciente: " + ViejoNombre,
                ViejoNombre,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        /// <summary>
        /// Funcion que busca los datos deseados, luego los coloca en las casillas para poder observarlos o modificarlos.
        /// </summary>

        public void Buscar()
        {

            Leer = new StreamReader("Registro.txt", true);
            string Linea;
            

            while (!Leer.EndOfStream)
            {

                Linea = Leer.ReadLine();

                if (Linea.Equals("Nombre del Paciente: " + BuscarBOX.Text))
                {

                    Linea = Linea.Replace("Nombre del Paciente: ", "");
                    NombreBOX.Text = Linea;

                    Linea = Leer.ReadLine();
                    Linea = Linea.Replace("Edad: ", "");
                    EdadBOX.Text = Linea;

                    Linea = Leer.ReadLine();
                    Linea = Linea.Replace("Sexo: ", "");
                    SexoBOX.Text = Linea;

                    Linea = Leer.ReadLine();
                    Linea = Linea.Replace("Tipo de Sangre: ", "");
                    SangreBOX.Text = Linea;

                    Linea = Leer.ReadLine();
                    Linea = Linea.Replace("Diagnostico: ", "");
                    DiagBOX.Text = Linea;

                    Linea = Leer.ReadLine();
                    Linea = Linea.Replace("Practicas a Realizar: ", "");
                    PracticaBOX.Text = Linea;

                    Linea = Leer.ReadLine();
                    Linea = Linea.Replace("Residencia: ", "");
                    ResidenciaBOX.Text = Linea;

                    Linea = Leer.ReadLine();
                    Linea = Linea.Replace("Telefono: ", "");
                    TelefonoBOX.Text = Linea;

                    Linea = Leer.ReadLine();
                    Linea = Linea.Replace("Observaciones: ", "");
                    ObservacionBOX.Text = Linea;

                    DialogResult result = MessageBox.Show(
                        "Se han encontrado los Datos del Paciente: " + NombreBOX.Text,
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    break;

                }
                if (Leer.EndOfStream && !Linea.Equals("Nombre del Paciente: " + BuscarBOX.Text))
                {
                    DialogResult result = MessageBox.Show(
                        "No se a encontrado ningun paciente con el nombre de: " + BuscarBOX.Text,
                        BuscarBOX.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }

            Leer.Close();

        }

        /// <summary>
        /// Funcion de salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void BTNSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Seguro que deseas Salir?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Funcion que evitar ingresar numeros o caracteres especiales en la casilla de nombre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void NombreBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Funcion que evita agregar letras o caracteres especiales en la casilla de edad.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void EdadBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Funcion que evitar ingresar numeros o caracteres especiales en la casilla de Sexo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void SexoBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Funcion que evitar ingresar numeros en la casilla de Sangre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void SangreBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsSymbol(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Funcion que evita agregar letras o caracteres especiales en la casilla de Telefono.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void TelefonoBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Funcion que evitar ingresar numeros o caracteres especiales en la casilla de Buscar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void BuscarBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Funcion que al presionar el Boton Guardar llama a las funciones Guardar, Consultar y Limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void BTNGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Consultar();
            Limpiar();
        }

        /// <summary>
        /// Funcion que al presionar el Boton Limpiar llama a la funcion Limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void BTNLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Funcion que al presionar el Boton Buscar llama a las funciones Buscar y Consultar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
            Consultar();
        }

        /// <summary>
        /// Funcion que al presionar el Boton Editar llama a las funciones Editar, Consultar y Limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BTNEditar_Click(object sender, EventArgs e)
        {
            Editar();
            Consultar();
            Limpiar();
        }
    }
}
