namespace MySQLApp
{
    partial class Form2
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
            this.btnApply = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbFilmRendezo = new System.Windows.Forms.ComboBox();
            this.cbFilm = new System.Windows.Forms.ComboBox();
            this.cbRendezo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(107, 415);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Alkalmaz";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(188, 415);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(26, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbFilmRendezo
            // 
            this.cbFilmRendezo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmRendezo.FormattingEnabled = true;
            this.cbFilmRendezo.Location = new System.Drawing.Point(12, 12);
            this.cbFilmRendezo.Name = "cbFilmRendezo";
            this.cbFilmRendezo.Size = new System.Drawing.Size(251, 21);
            this.cbFilmRendezo.TabIndex = 3;
            this.cbFilmRendezo.SelectedIndexChanged += new System.EventHandler(this.cbFilmRendezo_SelectedIndexChanged);
            // 
            // cbFilm
            // 
            this.cbFilm.FormattingEnabled = true;
            this.cbFilm.Location = new System.Drawing.Point(12, 39);
            this.cbFilm.Name = "cbFilm";
            this.cbFilm.Size = new System.Drawing.Size(251, 21);
            this.cbFilm.TabIndex = 4;
            // 
            // cbRendezo
            // 
            this.cbRendezo.FormattingEnabled = true;
            this.cbRendezo.Location = new System.Drawing.Point(12, 39);
            this.cbRendezo.Name = "cbRendezo";
            this.cbRendezo.Size = new System.Drawing.Size(251, 21);
            this.cbRendezo.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 450);
            this.Controls.Add(this.cbRendezo);
            this.Controls.Add(this.cbFilm);
            this.Controls.Add(this.cbFilmRendezo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnApply);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbFilmRendezo;
        private System.Windows.Forms.ComboBox cbFilm;
        private System.Windows.Forms.ComboBox cbRendezo;
    }
}