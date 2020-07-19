using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio_SMS.Properties;   

namespace Dominio_SMS
{
    public partial class Form1 : Form
    {
        private string dominio;
        public Form1()
        {
            InitializeComponent();
        }

        private  void btnBuscarArchivo_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog rutaArchivo = new OpenFileDialog()
            {
                Filter = "Archivo de Text|*.txt",
                ValidateNames = true,
                Multiselect = false
            })


                if (rutaArchivo.ShowDialog() == DialogResult.OK)
                {
                    RefrescarDominio();

                    string linea = "";
                    using (StreamReader leer = new StreamReader(rutaArchivo.FileName))
                    {
                        while (leer.Peek() != -1)
                        {
                            linea = leer.ReadLine();
                            if (!String.IsNullOrEmpty(linea))
                            {
                                int fila = dataGridView1.Rows.Add();
                                dataGridView1.Rows[fila].Cells[0].Value = ($"{linea}{dominio}{Environment.NewLine}");
                            }
                        }
                    }
                }
         }

        private void configuracionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuraciones conf = new Configuraciones();
            conf.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             dominio = RefrescarDominio();
        }

        #region RefrescarDominio
        private string RefrescarDominio()
           => dominio = (string)Settings.Default["Dominio"];

        #endregion

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
          
         Clipboard.SetText(dataGridView1.Rows[dataGridView1.CurrentRow.Index]
             .Cells[0].Value.ToString());

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void ocultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
