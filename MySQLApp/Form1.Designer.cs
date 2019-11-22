namespace MySQLApp
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
            this.rendezoListBox = new System.Windows.Forms.ListBox();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.tbSzarmazas = new System.Windows.Forms.TextBox();
            this.dtSzulDatum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRendezoDelete = new System.Windows.Forms.Button();
            this.filmekListBox = new System.Windows.Forms.ListBox();
            this.tbCim = new System.Windows.Forms.TextBox();
            this.dtFilm = new System.Windows.Forms.DateTimePicker();
            this.tbHossz = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rendezoListBox
            // 
            this.rendezoListBox.FormattingEnabled = true;
            this.rendezoListBox.Location = new System.Drawing.Point(3, 1);
            this.rendezoListBox.Name = "rendezoListBox";
            this.rendezoListBox.Size = new System.Drawing.Size(173, 303);
            this.rendezoListBox.TabIndex = 0;
            this.rendezoListBox.SelectedIndexChanged += new System.EventHandler(this.rendezoListBox_SelectedIndexChanged);
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(262, 11);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(109, 20);
            this.tbNev.TabIndex = 1;
            // 
            // tbSzarmazas
            // 
            this.tbSzarmazas.Location = new System.Drawing.Point(262, 63);
            this.tbSzarmazas.Name = "tbSzarmazas";
            this.tbSzarmazas.Size = new System.Drawing.Size(109, 20);
            this.tbSzarmazas.TabIndex = 3;
            // 
            // dtSzulDatum
            // 
            this.dtSzulDatum.Location = new System.Drawing.Point(262, 37);
            this.dtSzulDatum.Name = "dtSzulDatum";
            this.dtSzulDatum.Size = new System.Drawing.Size(109, 20);
            this.dtSzulDatum.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Szül dátum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Származás";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(262, 89);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(109, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Rendezo felvétele";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRendezoDelete
            // 
            this.btnRendezoDelete.Location = new System.Drawing.Point(3, 310);
            this.btnRendezoDelete.Name = "btnRendezoDelete";
            this.btnRendezoDelete.Size = new System.Drawing.Size(173, 43);
            this.btnRendezoDelete.TabIndex = 9;
            this.btnRendezoDelete.Text = "Rendezo kirugasa";
            this.btnRendezoDelete.UseVisualStyleBackColor = true;
            this.btnRendezoDelete.Click += new System.EventHandler(this.btnRendezoDelete_Click);
            // 
            // filmekListBox
            // 
            this.filmekListBox.FormattingEnabled = true;
            this.filmekListBox.Location = new System.Drawing.Point(377, 1);
            this.filmekListBox.Name = "filmekListBox";
            this.filmekListBox.Size = new System.Drawing.Size(411, 303);
            this.filmekListBox.TabIndex = 10;
            // 
            // tbCim
            // 
            this.tbCim.Location = new System.Drawing.Point(377, 310);
            this.tbCim.Name = "tbCim";
            this.tbCim.Size = new System.Drawing.Size(270, 20);
            this.tbCim.TabIndex = 11;
            // 
            // dtFilm
            // 
            this.dtFilm.Location = new System.Drawing.Point(377, 336);
            this.dtFilm.Name = "dtFilm";
            this.dtFilm.Size = new System.Drawing.Size(270, 20);
            this.dtFilm.TabIndex = 12;
            // 
            // tbHossz
            // 
            this.tbHossz.Location = new System.Drawing.Point(377, 362);
            this.tbHossz.Name = "tbHossz";
            this.tbHossz.Size = new System.Drawing.Size(270, 20);
            this.tbHossz.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Film felvétele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cím:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kiadás:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Hossz:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(196, 136);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(166, 72);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Adatfrissítés";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbHossz);
            this.Controls.Add(this.dtFilm);
            this.Controls.Add(this.tbCim);
            this.Controls.Add(this.filmekListBox);
            this.Controls.Add(this.btnRendezoDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtSzulDatum);
            this.Controls.Add(this.tbSzarmazas);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.rendezoListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox rendezoListBox;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.TextBox tbSzarmazas;
        private System.Windows.Forms.DateTimePicker dtSzulDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnRendezoDelete;
        private System.Windows.Forms.ListBox filmekListBox;
        private System.Windows.Forms.TextBox tbCim;
        private System.Windows.Forms.DateTimePicker dtFilm;
        private System.Windows.Forms.TextBox tbHossz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
    }
}

