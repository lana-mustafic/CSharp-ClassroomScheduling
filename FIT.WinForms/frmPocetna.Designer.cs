﻿namespace FIT.WinForms
{
    partial class frmPocetna
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
            lblKonekcijaInfo = new Label();
            btnIzvjestaj = new Button();
            btnIspit = new Button();
            SuspendLayout();
            // 
            // lblKonekcijaInfo
            // 
            lblKonekcijaInfo.AutoSize = true;
            lblKonekcijaInfo.Font = new Font("Segoe UI", 15F);
            lblKonekcijaInfo.Location = new Point(114, 96);
            lblKonekcijaInfo.Name = "lblKonekcijaInfo";
            lblKonekcijaInfo.Size = new Size(0, 35);
            lblKonekcijaInfo.TabIndex = 0;
            // 
            // btnIzvjestaj
            // 
            btnIzvjestaj.Location = new Point(152, 142);
            btnIzvjestaj.Margin = new Padding(3, 4, 3, 4);
            btnIzvjestaj.Name = "btnIzvjestaj";
            btnIzvjestaj.Size = new Size(207, 31);
            btnIzvjestaj.TabIndex = 1;
            btnIzvjestaj.Text = "Izvještaj";
            btnIzvjestaj.UseVisualStyleBackColor = true;
            btnIzvjestaj.Click += btnIzvjestaj_Click;
            // 
            // btnIspit
            // 
            btnIspit.Location = new Point(152, 180);
            btnIspit.Margin = new Padding(3, 4, 3, 4);
            btnIspit.Name = "btnIspit";
            btnIspit.Size = new Size(207, 31);
            btnIspit.TabIndex = 1;
            btnIspit.Text = "Ispit";
            btnIspit.UseVisualStyleBackColor = true;
            btnIspit.Click += btnIzvjestaj_Click;
            // 
            // frmPocetna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 245);
            Controls.Add(btnIspit);
            Controls.Add(btnIzvjestaj);
            Controls.Add(lblKonekcijaInfo);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPocetna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Template 2023/24";
            Load += frmPocetna_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKonekcijaInfo;
        private Button btnIzvjestaj;
        private Button btnIspit;
    }
}