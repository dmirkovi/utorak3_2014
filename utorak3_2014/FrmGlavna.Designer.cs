﻿namespace utorak3_2014
{
    partial class FrmGlavna
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
            this.lblPolumjer = new System.Windows.Forms.Label();
            this.lblPovrsina = new System.Windows.Forms.Label();
            this.lblOpseg = new System.Windows.Forms.Label();
            this.txtPolumjer = new System.Windows.Forms.TextBox();
            this.txtPovrsina = new System.Windows.Forms.TextBox();
            this.txtOpseg = new System.Windows.Forms.TextBox();
            this.chkSpremi = new System.Windows.Forms.CheckBox();
            this.lstRezultati = new System.Windows.Forms.ListBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPolumjer
            // 
            this.lblPolumjer.AutoSize = true;
            this.lblPolumjer.Location = new System.Drawing.Point(21, 21);
            this.lblPolumjer.Name = "lblPolumjer";
            this.lblPolumjer.Size = new System.Drawing.Size(53, 13);
            this.lblPolumjer.TabIndex = 0;
            this.lblPolumjer.Text = "Polumjer: ";
            // 
            // lblPovrsina
            // 
            this.lblPovrsina.AutoSize = true;
            this.lblPovrsina.Location = new System.Drawing.Point(23, 58);
            this.lblPovrsina.Name = "lblPovrsina";
            this.lblPovrsina.Size = new System.Drawing.Size(51, 13);
            this.lblPovrsina.TabIndex = 1;
            this.lblPovrsina.Text = "Površina:";
            // 
            // lblOpseg
            // 
            this.lblOpseg.AutoSize = true;
            this.lblOpseg.Location = new System.Drawing.Point(31, 93);
            this.lblOpseg.Name = "lblOpseg";
            this.lblOpseg.Size = new System.Drawing.Size(41, 13);
            this.lblOpseg.TabIndex = 2;
            this.lblOpseg.Text = "Opseg:";
            // 
            // txtPolumjer
            // 
            this.txtPolumjer.Location = new System.Drawing.Point(80, 18);
            this.txtPolumjer.Name = "txtPolumjer";
            this.txtPolumjer.Size = new System.Drawing.Size(100, 20);
            this.txtPolumjer.TabIndex = 3;
            this.txtPolumjer.Text = "0,00";
            this.txtPolumjer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPovrsina
            // 
            this.txtPovrsina.Location = new System.Drawing.Point(80, 53);
            this.txtPovrsina.Name = "txtPovrsina";
            this.txtPovrsina.ReadOnly = true;
            this.txtPovrsina.Size = new System.Drawing.Size(100, 20);
            this.txtPovrsina.TabIndex = 4;
            this.txtPovrsina.Text = "0,00";
            this.txtPovrsina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOpseg
            // 
            this.txtOpseg.Location = new System.Drawing.Point(78, 90);
            this.txtOpseg.Name = "txtOpseg";
            this.txtOpseg.ReadOnly = true;
            this.txtOpseg.Size = new System.Drawing.Size(100, 20);
            this.txtOpseg.TabIndex = 5;
            this.txtOpseg.Text = "0,00";
            this.txtOpseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkSpremi
            // 
            this.chkSpremi.AutoSize = true;
            this.chkSpremi.Location = new System.Drawing.Point(78, 130);
            this.chkSpremi.Name = "chkSpremi";
            this.chkSpremi.Size = new System.Drawing.Size(88, 17);
            this.chkSpremi.TabIndex = 6;
            this.chkSpremi.Text = "Spremi u listu";
            this.chkSpremi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSpremi.UseVisualStyleBackColor = true;
            // 
            // lstRezultati
            // 
            this.lstRezultati.FormattingEnabled = true;
            this.lstRezultati.Location = new System.Drawing.Point(206, 18);
            this.lstRezultati.Name = "lstRezultati";
            this.lstRezultati.Size = new System.Drawing.Size(166, 186);
            this.lstRezultati.TabIndex = 7;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(65, 153);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(115, 22);
            this.btnIzracunaj.TabIndex = 8;
            this.btnIzracunaj.Text = "Izračunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(65, 181);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(115, 22);
            this.btnObrisi.TabIndex = 9;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.lstRezultati);
            this.Controls.Add(this.chkSpremi);
            this.Controls.Add(this.txtOpseg);
            this.Controls.Add(this.txtPovrsina);
            this.Controls.Add(this.txtPolumjer);
            this.Controls.Add(this.lblOpseg);
            this.Controls.Add(this.lblPovrsina);
            this.Controls.Add(this.lblPolumjer);
            this.Name = "FrmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavna forma aplikacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPolumjer;
        private System.Windows.Forms.Label lblPovrsina;
        private System.Windows.Forms.Label lblOpseg;
        private System.Windows.Forms.TextBox txtPolumjer;
        private System.Windows.Forms.TextBox txtPovrsina;
        private System.Windows.Forms.TextBox txtOpseg;
        private System.Windows.Forms.CheckBox chkSpremi;
        private System.Windows.Forms.ListBox lstRezultati;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Button btnObrisi;
    }
}

