namespace Kolekcije
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
            this.TxtBoxIme = new System.Windows.Forms.TextBox();
            this.TxtBoxPrz = new System.Windows.Forms.TextBox();
            this.TxtBoxGodRod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbBoxRod = new System.Windows.Forms.ComboBox();
            this.BtnUnos = new System.Windows.Forms.Button();
            this.BtnObrada = new System.Windows.Forms.Button();
            this.BtnIspis = new System.Windows.Forms.Button();
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.BtnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBoxIme
            // 
            this.TxtBoxIme.Location = new System.Drawing.Point(13, 45);
            this.TxtBoxIme.Name = "TxtBoxIme";
            this.TxtBoxIme.Size = new System.Drawing.Size(120, 20);
            this.TxtBoxIme.TabIndex = 0;
            // 
            // TxtBoxPrz
            // 
            this.TxtBoxPrz.Location = new System.Drawing.Point(12, 94);
            this.TxtBoxPrz.Name = "TxtBoxPrz";
            this.TxtBoxPrz.Size = new System.Drawing.Size(121, 20);
            this.TxtBoxPrz.TabIndex = 1;
            // 
            // TxtBoxGodRod
            // 
            this.TxtBoxGodRod.Location = new System.Drawing.Point(12, 147);
            this.TxtBoxGodRod.Name = "TxtBoxGodRod";
            this.TxtBoxGodRod.Size = new System.Drawing.Size(121, 20);
            this.TxtBoxGodRod.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Godina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rod";
            // 
            // CmbBoxRod
            // 
            this.CmbBoxRod.FormattingEnabled = true;
            this.CmbBoxRod.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.CmbBoxRod.Location = new System.Drawing.Point(12, 197);
            this.CmbBoxRod.Name = "CmbBoxRod";
            this.CmbBoxRod.Size = new System.Drawing.Size(121, 21);
            this.CmbBoxRod.TabIndex = 8;
            // 
            // BtnUnos
            // 
            this.BtnUnos.Location = new System.Drawing.Point(13, 258);
            this.BtnUnos.Name = "BtnUnos";
            this.BtnUnos.Size = new System.Drawing.Size(75, 23);
            this.BtnUnos.TabIndex = 9;
            this.BtnUnos.Text = "Unesi";
            this.BtnUnos.UseVisualStyleBackColor = true;
            this.BtnUnos.Click += new System.EventHandler(this.BtnUnos_Click);
            // 
            // BtnObrada
            // 
            this.BtnObrada.Location = new System.Drawing.Point(105, 258);
            this.BtnObrada.Name = "BtnObrada";
            this.BtnObrada.Size = new System.Drawing.Size(75, 23);
            this.BtnObrada.TabIndex = 10;
            this.BtnObrada.Text = "Obradi";
            this.BtnObrada.UseVisualStyleBackColor = true;
            this.BtnObrada.Click += new System.EventHandler(this.BtnObrada_Click);
            // 
            // BtnIspis
            // 
            this.BtnIspis.Location = new System.Drawing.Point(12, 307);
            this.BtnIspis.Name = "BtnIspis";
            this.BtnIspis.Size = new System.Drawing.Size(75, 23);
            this.BtnIspis.TabIndex = 11;
            this.BtnIspis.Text = "Ispiši";
            this.BtnIspis.UseVisualStyleBackColor = true;
            this.BtnIspis.Click += new System.EventHandler(this.BtnIspis_Click);
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(331, 45);
            this.TxtBox.Multiline = true;
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.ReadOnly = true;
            this.TxtBox.Size = new System.Drawing.Size(375, 173);
            this.TxtBox.TabIndex = 12;
            this.TxtBox.TabStop = false;
            // 
            // BtnSpremi
            // 
            this.BtnSpremi.Location = new System.Drawing.Point(105, 306);
            this.BtnSpremi.Name = "BtnSpremi";
            this.BtnSpremi.Size = new System.Drawing.Size(75, 23);
            this.BtnSpremi.TabIndex = 13;
            this.BtnSpremi.Text = "Spremi";
            this.BtnSpremi.UseVisualStyleBackColor = true;
            this.BtnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSpremi);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.BtnIspis);
            this.Controls.Add(this.BtnObrada);
            this.Controls.Add(this.BtnUnos);
            this.Controls.Add(this.CmbBoxRod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxGodRod);
            this.Controls.Add(this.TxtBoxPrz);
            this.Controls.Add(this.TxtBoxIme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxIme;
        private System.Windows.Forms.TextBox TxtBoxPrz;
        private System.Windows.Forms.TextBox TxtBoxGodRod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbBoxRod;
        private System.Windows.Forms.Button BtnUnos;
        private System.Windows.Forms.Button BtnObrada;
        private System.Windows.Forms.Button BtnIspis;
        private System.Windows.Forms.TextBox TxtBox;
        private System.Windows.Forms.Button BtnSpremi;
    }
}

