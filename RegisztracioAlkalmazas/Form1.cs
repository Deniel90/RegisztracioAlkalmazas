using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_hozzaad_Click(object sender, EventArgs e)
        {
            string ujhobbi = textBox_ujhobbi.Text;
            if (!listBox_kedvenchobbik.Items.Contains(ujhobbi))
            {
                listBox_kedvenchobbik.Items.Add(ujhobbi);
            }
        }

        private void ListBox_kedvenchobbik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
