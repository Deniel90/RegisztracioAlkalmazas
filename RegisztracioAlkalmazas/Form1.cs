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

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_hozzaad_Click(object sender, EventArgs e)
        {
            string ujhobbi = textBox_ujhobbi.Text.Trim();
            if (ujhobbi != "" && !listBox_kedvenchobbik.Items.Contains(ujhobbi))
            {
                listBox_kedvenchobbik.Items.Add(ujhobbi);
            }
        }

        private void ListBox_kedvenchobbik_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox_ujhobbi.Text = listBox_kedvenchobbik.SelectedItem.ToString();
        }

        private void Button_mentes_Click(object sender, EventArgs e)
        {
            int kitoltve = 3;

            //név
            if (textBox_nev.Text.Trim() == "")
            {
                MessageBox.Show("A név kitöltése kötelező!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_nev.Focus();
                kitoltve--;
            }

            //dátum
            if (dateTimePicker_szuldatum.Value.Date > ma.Date)
            {
                MessageBox.Show("A dátum csak korábbi dátum lehet!", "Hibás dátum!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker_szuldatum.Focus();
                kitoltve--;
            }

            //nem
            if (true)
            {

            }

            //validálás
            if (kitoltve != 3)
            {

            }
        }
    }
}
/*
 Mentés gomb
 A gombra kattintva mentse el a form tartalmát egy szövegfájlba úgy, hogy az
visszatölthető legyen. A fájlt egy saveFileDialog-al lehessen kiválasztani.
 Mentés előtt ellenőrizze, hogy minden mező ki legyen töltve:
o A név szövegdoboz tartalmazzon szóköztől különböző karaktert
o A születési dátum egy érvényes dátumot tartalmazzon, ami ne mutathasson az
aktuális dátumnál későbbi időpontra

o Legyen kiválasztva nem
o A kedvenc hobbi legyen kiválasztva a hobbi listából. (SelectedIndex
tulajdonság ne legyen -1)
 Mentésnél figyeljen, hogy a hobbi lista teljes tartalmát mentse el.
c.) Betöltés gomb
 A gombra kattintva nyíljon meg 1 openFileDialog, amivel ki lehessen választani 1
szöveges állományt
 A kiválasztott fájl tartalma alapján töltse újra a formot.
 A lista visszatöltésekor az alábbi dolgokra figyeljen:
o Újratöltés előtt ürítse a listát
o Először töltse fel a teljes listát a fájlból beolvasott hobbikkal
o A betöltés után válassza ki a kedvenc hobbi a fájlból beolvasott érték alapján.
     
     */
