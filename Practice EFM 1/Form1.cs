using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_EFM_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adherentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuverForm(new Gestion_Adherents());
        }
        void OuverForm(Form form)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
