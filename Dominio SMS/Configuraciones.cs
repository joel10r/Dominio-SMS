using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio_SMS.Properties;

namespace Dominio_SMS
{
    public partial class Configuraciones : Form
    {
        public Configuraciones()
        {
            InitializeComponent();
        }

        private void Configuraciones_Load(object sender, EventArgs e)
        {
            txtDominioActual.Text = Settings.Default.Dominio; 
        }

        private void btnModificarDominio_Click(object sender, EventArgs e)
        {
            if (txtDominio.Text != string.Empty)
            {
                Settings.Default.Dominio = txtDominio.Text.Trim().ToLower();
                Settings.Default.Save();
                txtDominio.Text = string.Empty;
                txtDominioActual.Text = Settings.Default.Dominio;
            }
            else
            {
                MessageBox.Show("Nuevo Dominio es un campo requerido",
                            "Modicar Dominio",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          
          
        }
    }
}
