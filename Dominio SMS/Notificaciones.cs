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
    public partial class Notificaciones : Form
    {
        public Notificaciones()
        {
            InitializeComponent();
        }

        private void chkNotificacion_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.Notificacion = chkNotificacion.Checked;
            Settings.Default.Save();
        }

        private void Notificaciones_Load(object sender, EventArgs e)
        {
            chkNotificacion.Checked = (bool) Settings.Default["Notificacion"];
        }
    }
}
