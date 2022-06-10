using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meu_primeiro_projeto_em_C
{
    public partial class Frmpropriedadescheckbox : Form
    {
        public Frmpropriedadescheckbox()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                painelpessoafisica.Visible = true;
            }
            else
            {
                painelpessoafisica.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                panelpessoajuridica.Visible = true;
            }
            else
            {
                panelpessoajuridica.Visible = false;
            }
        }
    }
}
