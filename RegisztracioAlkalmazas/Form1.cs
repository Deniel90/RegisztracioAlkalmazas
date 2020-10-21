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
                textBox_ujhobbi.Clear();
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

                Ember ember = new Ember(textBox_nev.Text, dateTimePicker_szuldatum.Value.Date, nem, hobbik, listBox_kedvenchobbik.SelectedIndex.ToString());

                //mentés
                DialogResult visszajelzes = saveFileDialog1.ShowDialog();
                if (visszajelzes != DialogResult.OK)
                {
                    MessageBox.Show("Az űrlapadatok nem lettek elmentve");
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

        private void Button_betoltes_Click(object sender, EventArgs e)
        {
            DialogResult visszajelzes = openFileDialog1.ShowDialog();
            if (visszajelzes != DialogResult.OK)
            {
                MessageBox.Show("Nincs fájl kiválasztva!");
                return;
            }
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            listBox_kedvenchobbik.Items.Clear();
            string[] betoltott;
            while (!sr.EndOfStream)
            {
                betoltott = sr.ReadLine().Split(';');

                //név
                textBox_nev.Text = betoltott[0];

                //születési dátum
                dateTimePicker_szuldatum.Value = Convert.ToDateTime(betoltott[1]);

                //nem
                if (betoltott[2] == "férfi")
                {
                    radio_F.Checked = true;
                }
                else
                {
                    radio_N.Checked = true;
                }

                //hobbik
                string[] betoltotthobbik = betoltott[4].Split('-');
                foreach (string elem in betoltotthobbik)
                {
                    listBox_kedvenchobbik.Items.Add(elem);
                }

                //kedvenc hobbi
                listBox_kedvenchobbik.SelectedIndex = int.Parse(betoltott[3]) - 1;
            }
        }
    }
}