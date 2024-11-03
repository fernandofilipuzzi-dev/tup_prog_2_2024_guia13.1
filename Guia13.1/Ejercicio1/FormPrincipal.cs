using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        Agencia agencia = new Agencia();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("agencia.dat", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf= new BinaryFormatter();
                agencia = bf.Deserialize(fs) as Agencia;
            }
            catch { }
            finally 
            {
                if (fs != null) fs.Close();
            }

            if (agencia == null)
            {
                agencia = new Agencia();

                agencia.AgregarVehiculo("ABC123", 45312756);
                agencia.AgregarVehiculo("ABC345", 35122536);
                agencia.AgregarVehiculo("AAA111", 33666336);

                //no tengo nada que mostrar en la pantalla del estado anterior.
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("agencia.dat", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, agencia);
            }
            catch { }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket nuevo = null;
                if (rbDenuncia.Checked)
                {
                    string patente = tbPatente.Text;
                    Vehiculo asegurado = agencia[patente];

                    //para setearle  el dni, podría ser que necesite acceso al cliente

                    if (asegurado != null)
                    {
                        nuevo = new Denuncia(asegurado);

                        tbPatente.Clear();
                    }
                    else
                    {
                        MessageBox.Show("El vehículo no pertenece a la agencia.");
                    }
                }
                else if (rbNuevoCliente.Checked)
                {
                    string dni = tbDNI.Text;
                    int tipo=cbTipoVehiculo.SelectedIndex+1;

                    nuevo = new Cliente(dni);
                    ((Cliente)nuevo).TipoVehiculo = tipo;

                    tbDNI.Clear();
                }
                else 
                {
                    MessageBox.Show("Elija el tipo de ticket!");
                }

                if (nuevo != null)
                {
                    agencia.AgregarTicket(nuevo);
                    lbxTurnos.Items.Add(nuevo);
                }

                rbDenuncia.Checked = false;
                rbNuevoCliente.Checked = false;
            }
            catch (DniNoValidoException ex)
            {
                MessageBox.Show(ex.Message, "DNI No válido");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAtenderDenuncias_Click(object sender, EventArgs e)
        {
            Ticket ticket = agencia.AtenderTicket(0);
            if (ticket != null)
            {
                lbxTurnos.Items.Remove(ticket);
            }
        }

        private void btnAtenderClientes_Click(object sender, EventArgs e)
        {
            Ticket ticket = agencia.AtenderTicket(1);
            if (ticket != null)
            {
                lbxTurnos.Items.Remove(ticket);
            }
        }

        private void btnExportarTickets_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Exportando los archivos";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;

                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

                    sw = new StreamWriter(fs);
                    
                    string linea = "TIPO:DENUNCIA;NroTicket;Fecha;Patente";
                    sw.WriteLine(linea);
                    linea = "TIPO:CLIENTE;NroTicket;Fecha;DNI";
                    sw.WriteLine(linea);    

                    foreach (Ticket ticket in agencia.ListaAtendidos) 
                    {
                        linea = ticket.ToString();
                        sw.WriteLine(linea);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en la exportación" );
                }
                finally 
                {
                    if (sw != null) sw.Close();
                    if(fs!=null) fs.Close();
                }
            }
        }

        private void btnImportarVehiculos_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Importando listado de vehículos asegurados";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);

                    sr = new StreamReader(fs);

                    while(sr.EndOfStream==false)
                    {
                        string linea = sr.ReadLine();
                        string[] campos = linea.Split(';');

                        string nroPantente = campos[0];
                        int dniDueño=Convert.ToInt32(campos[1]);
                                                
                        agencia.AgregarVehiculo(nroPantente, dniDueño);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en la importación");
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
            }
        }
    }
}
