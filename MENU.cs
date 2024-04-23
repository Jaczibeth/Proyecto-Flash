using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLASH
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new NIVEL1());
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.Menu.Controls.Count > 0)
                this.Menu.Controls.RemoveAt(0);
            Form fh = formhija as Form;AbrirFormHija(new NIVEL1());
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.Menu.Controls.Count > 0)
                this.Menu.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Menu.Controls.Add(fh);
            this.Menu.Tag = fh;
            fh.Show();
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Menu.Controls.Add(fh);
            this.Menu.Tag = fh;
            fh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
