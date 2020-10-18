namespace RegisztracioAlkalmazas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_nev = new System.Windows.Forms.Label();
            this.label_szuldatum = new System.Windows.Forms.Label();
            this.label_nem = new System.Windows.Forms.Label();
            this.label_hobbi = new System.Windows.Forms.Label();
            this.label_ujhobbi = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.radio_F = new System.Windows.Forms.RadioButton();
            this.radio_N = new System.Windows.Forms.RadioButton();
            this.textBox_ujhobbi = new System.Windows.Forms.TextBox();
            this.listBox_kedvenchobbik = new System.Windows.Forms.ListBox();
            this.button_hozzaad = new System.Windows.Forms.Button();
            this.button_mentes = new System.Windows.Forms.Button();
            this.button_betoltes = new System.Windows.Forms.Button();
            this.dateTimePicker_szuldatum = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nev.Location = new System.Drawing.Point(21, 20);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(38, 19);
            this.label_nev.TabIndex = 0;
            this.label_nev.Text = "Név:";
            // 
            // label_szuldatum
            // 
            this.label_szuldatum.AutoSize = true;
            this.label_szuldatum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_szuldatum.Location = new System.Drawing.Point(21, 64);
            this.label_szuldatum.Name = "label_szuldatum";
            this.label_szuldatum.Size = new System.Drawing.Size(105, 19);
            this.label_szuldatum.TabIndex = 1;
            this.label_szuldatum.Text = "Születési dátum:";
            // 
            // label_nem
            // 
            this.label_nem.AutoSize = true;
            this.label_nem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nem.Location = new System.Drawing.Point(21, 104);
            this.label_nem.Name = "label_nem";
            this.label_nem.Size = new System.Drawing.Size(42, 19);
            this.label_nem.TabIndex = 2;
            this.label_nem.Text = "Nem:";
            // 
            // label_hobbi
            // 
            this.label_hobbi.AutoSize = true;
            this.label_hobbi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_hobbi.Location = new System.Drawing.Point(360, 20);
            this.label_hobbi.Name = "label_hobbi";
            this.label_hobbi.Size = new System.Drawing.Size(105, 19);
            this.label_hobbi.TabIndex = 3;
            this.label_hobbi.Text = "Kedvenc hobbi:";
            // 
            // label_ujhobbi
            // 
            this.label_ujhobbi.AutoSize = true;
            this.label_ujhobbi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ujhobbi.Location = new System.Drawing.Point(293, 236);
            this.label_ujhobbi.Name = "label_ujhobbi";
            this.label_ujhobbi.Size = new System.Drawing.Size(65, 19);
            this.label_ujhobbi.TabIndex = 4;
            this.label_ujhobbi.Text = "Új hobbi:";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_nev.Location = new System.Drawing.Point(136, 17);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(218, 26);
            this.textBox_nev.TabIndex = 5;
            // 
            // radio_F
            // 
            this.radio_F.AutoSize = true;
            this.radio_F.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radio_F.Location = new System.Drawing.Point(136, 102);
            this.radio_F.Name = "radio_F";
            this.radio_F.Size = new System.Drawing.Size(55, 23);
            this.radio_F.TabIndex = 7;
            this.radio_F.TabStop = true;
            this.radio_F.Text = "Férfi";
            this.radio_F.UseVisualStyleBackColor = true;
            // 
            // radio_N
            // 
            this.radio_N.AutoSize = true;
            this.radio_N.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radio_N.Location = new System.Drawing.Point(197, 102);
            this.radio_N.Name = "radio_N";
            this.radio_N.Size = new System.Drawing.Size(47, 23);
            this.radio_N.TabIndex = 8;
            this.radio_N.TabStop = true;
            this.radio_N.Text = "Nő";
            this.radio_N.UseVisualStyleBackColor = true;
            // 
            // textBox_ujhobbi
            // 
            this.textBox_ujhobbi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_ujhobbi.Location = new System.Drawing.Point(364, 233);
            this.textBox_ujhobbi.Name = "textBox_ujhobbi";
            this.textBox_ujhobbi.Size = new System.Drawing.Size(120, 26);
            this.textBox_ujhobbi.TabIndex = 9;
            // 
            // listBox_kedvenchobbik
            // 
            this.listBox_kedvenchobbik.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_kedvenchobbik.FormattingEnabled = true;
            this.listBox_kedvenchobbik.ItemHeight = 19;
            this.listBox_kedvenchobbik.Items.AddRange(new object[] {
            "unatkozás",
            "malmozás",
            "zabhegyezés"});
            this.listBox_kedvenchobbik.Location = new System.Drawing.Point(364, 49);
            this.listBox_kedvenchobbik.Name = "listBox_kedvenchobbik";
            this.listBox_kedvenchobbik.Size = new System.Drawing.Size(120, 175);
            this.listBox_kedvenchobbik.TabIndex = 10;
            this.listBox_kedvenchobbik.SelectedValueChanged += new System.EventHandler(this.ListBox_kedvenchobbik_SelectedValueChanged);
            // 
            // button_hozzaad
            // 
            this.button_hozzaad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_hozzaad.Location = new System.Drawing.Point(364, 266);
            this.button_hozzaad.Name = "button_hozzaad";
            this.button_hozzaad.Size = new System.Drawing.Size(120, 28);
            this.button_hozzaad.TabIndex = 11;
            this.button_hozzaad.Text = "Hozzáad";
            this.button_hozzaad.UseVisualStyleBackColor = true;
            this.button_hozzaad.Click += new System.EventHandler(this.Button_hozzaad_Click);
            // 
            // button_mentes
            // 
            this.button_mentes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_mentes.Location = new System.Drawing.Point(308, 315);
            this.button_mentes.Name = "button_mentes";
            this.button_mentes.Size = new System.Drawing.Size(85, 33);
            this.button_mentes.TabIndex = 12;
            this.button_mentes.Text = "Mentés";
            this.button_mentes.UseVisualStyleBackColor = true;
            this.button_mentes.Click += new System.EventHandler(this.Button_mentes_Click);
            // 
            // button_betoltes
            // 
            this.button_betoltes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_betoltes.Location = new System.Drawing.Point(399, 315);
            this.button_betoltes.Name = "button_betoltes";
            this.button_betoltes.Size = new System.Drawing.Size(85, 33);
            this.button_betoltes.TabIndex = 13;
            this.button_betoltes.Text = "Betöltés";
            this.button_betoltes.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_szuldatum
            // 
            this.dateTimePicker_szuldatum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_szuldatum.Location = new System.Drawing.Point(136, 58);
            this.dateTimePicker_szuldatum.Name = "dateTimePicker_szuldatum";
            this.dateTimePicker_szuldatum.Size = new System.Drawing.Size(218, 26);
            this.dateTimePicker_szuldatum.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 363);
            this.Controls.Add(this.dateTimePicker_szuldatum);
            this.Controls.Add(this.button_betoltes);
            this.Controls.Add(this.button_mentes);
            this.Controls.Add(this.button_hozzaad);
            this.Controls.Add(this.listBox_kedvenchobbik);
            this.Controls.Add(this.textBox_ujhobbi);
            this.Controls.Add(this.radio_N);
            this.Controls.Add(this.radio_F);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.label_ujhobbi);
            this.Controls.Add(this.label_hobbi);
            this.Controls.Add(this.label_nem);
            this.Controls.Add(this.label_szuldatum);
            this.Controls.Add(this.label_nev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regisztráció";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.Label label_szuldatum;
        private System.Windows.Forms.Label label_nem;
        private System.Windows.Forms.Label label_hobbi;
        private System.Windows.Forms.Label label_ujhobbi;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.RadioButton radio_F;
        private System.Windows.Forms.RadioButton radio_N;
        private System.Windows.Forms.TextBox textBox_ujhobbi;
        private System.Windows.Forms.ListBox listBox_kedvenchobbik;
        private System.Windows.Forms.Button button_hozzaad;
        private System.Windows.Forms.Button button_mentes;
        private System.Windows.Forms.Button button_betoltes;
        private System.Windows.Forms.DateTimePicker dateTimePicker_szuldatum;
    }
}

