using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        private DateTime ma = DateTime.Now;
        private string nem = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_hozzaad_Click(object sender, EventArgs e)
        {
            string ujhobbi = textBox_ujhobbi.Text.Trim();
            if (!String.IsNullOrEmpty(ujhobbi) && !listBox_kedvenchobbik.Items.Contains(ujhobbi))
            {
                listBox_kedvenchobbik.Items.Add(ujhobbi);
            }
        }

        private void ListBox_kedvenchobbik_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox_kedvenchobbik.SelectedItem != null)
            {
                textBox_ujhobbi.Text = listBox_kedvenchobbik.SelectedItem.ToString();
            }
        }

        private void Button_mentes_Click(object sender, EventArgs e)
        {
            int kitoltve = 4;
            string hibauzenet = "";

            //név
            if (String.IsNullOrEmpty(textBox_nev.Text.Trim()))
            {
                hibauzenet += "A név kitöltése kötelező!\n";
                textBox_nev.Focus();
                kitoltve--;
            }

            //dátum
            if (dateTimePicker_szuldatum.Value.Date > ma.Date)
            {
                hibauzenet += "A dátum csak korábbi dátum lehet!\n";
                dateTimePicker_szuldatum.Focus();
                kitoltve--;
            }

            //nem
            if (radio_F.Checked)
            {
                nem = "férfi";
            }
            else if (radio_N.Checked)
            {
                nem = "nő";
            }
            else
            {
                hibauzenet += "A nem kiválasztása kötelező!\n";
                kitoltve--;
            }

            //kedvenc hobbi
            if (listBox_kedvenchobbik.SelectedIndex < 0)
            {
                hibauzenet += "Ki kell jelölni egy kedvenc hobbit!";
                kitoltve--;
            }
            
            //validálás
            if (kitoltve == 4)
            {
                string[] hobbik = new string[listBox_kedvenchobbik.Items.Count];
                
                for (int i = 0; i < hobbik.Length; i++)
                {
                    hobbik[i] = listBox_kedvenchobbik.Items[i].ToString();
                }

                Ember ember = new Ember(textBox_nev.Text, dateTimePicker_szuldatum.Value.Date, nem, hobbik, listBox_kedvenchobbik.SelectedItem.ToString());

                DialogResult visszajelzes = saveFileDialog1.ShowDialog();
                if (visszajelzes != DialogResult.OK)
                {
                    return;
                }
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine("{0};{1};{2};{3};{4}", ember.Nev, ember.Szuldatum, ember.Nem, ember.KedvencHobbi, String.Join("-", ember.Hobbik));
                sw.Close();

                MessageBox.Show("A fájl elmentve");
            }
            else
            {
                MessageBox.Show(hibauzenet, "Hiányzó adatok!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
/*
 Mentés gomb
c.) Betöltés gomb
 A gombra kattintva nyíljon meg 1 openFileDialog, amivel ki lehessen választani 1
szöveges állományt
 A kiválasztott fájl tartalma alapján töltse újra a formot.
 A lista visszatöltésekor az alábbi dolgokra figyeljen:
o Újratöltés előtt ürítse a listát
o Először töltse fel a teljes listát a fájlból beolvasott hobbikkal
o A betöltés után válassza ki a kedvenc hobbi a fájlból beolvasott érték alapján.
     
     */
