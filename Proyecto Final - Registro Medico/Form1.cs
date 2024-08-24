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
        DataTable Tabla;
        static StreamReader Leer;
        static StreamWriter Escribir;        

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
        
        public Form1()
        {
            InitializeComponent();
            Iniciar();
            Consultar();
        }

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

        }

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
        }

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

        public void NombreBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void EdadBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void SexoBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void SangreBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsSymbol(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void TelefonoBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void BuscarBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void BTNGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Consultar();
            Limpiar();
        }

        public void BTNLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
            Consultar();
        }

        private void BTNEditar_Click(object sender, EventArgs e)
        {
            Editar();
            Consultar();
            Limpiar();
        }
    }
}
