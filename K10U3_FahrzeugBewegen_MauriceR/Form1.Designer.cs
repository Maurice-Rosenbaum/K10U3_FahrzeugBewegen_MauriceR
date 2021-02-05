namespace K10U3_FahrzeugBewegen_MauriceR
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonFahren = new System.Windows.Forms.Button();
            this.buttonLangsamer = new System.Windows.Forms.Button();
            this.buttonSchneller = new System.Windows.Forms.Button();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pkw1 = new K10U3_FahrzeugBewegen_MauriceR.PKW();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 149);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonFahren
            // 
            this.buttonFahren.Location = new System.Drawing.Point(170, 149);
            this.buttonFahren.Name = "buttonFahren";
            this.buttonFahren.Size = new System.Drawing.Size(75, 23);
            this.buttonFahren.TabIndex = 1;
            this.buttonFahren.Text = "Fahren";
            this.buttonFahren.UseVisualStyleBackColor = true;
            this.buttonFahren.Click += new System.EventHandler(this.buttonFahren_Click);
            // 
            // buttonLangsamer
            // 
            this.buttonLangsamer.Location = new System.Drawing.Point(251, 149);
            this.buttonLangsamer.Name = "buttonLangsamer";
            this.buttonLangsamer.Size = new System.Drawing.Size(75, 23);
            this.buttonLangsamer.TabIndex = 2;
            this.buttonLangsamer.Text = "Langsamer";
            this.buttonLangsamer.UseVisualStyleBackColor = true;
            this.buttonLangsamer.Click += new System.EventHandler(this.buttonLangsamer_Click);
            // 
            // buttonSchneller
            // 
            this.buttonSchneller.Location = new System.Drawing.Point(332, 149);
            this.buttonSchneller.Name = "buttonSchneller";
            this.buttonSchneller.Size = new System.Drawing.Size(75, 23);
            this.buttonSchneller.TabIndex = 3;
            this.buttonSchneller.Text = "Schneller";
            this.buttonSchneller.UseVisualStyleBackColor = true;
            this.buttonSchneller.Click += new System.EventHandler(this.buttonSchneller_Click);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(510, 149);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden.TabIndex = 4;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.pkw1);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 51);
            this.panel1.TabIndex = 5;
            // 
            // pkw1
            // 
            this.pkw1.BackColor = System.Drawing.Color.Red;
            this.pkw1.ForeColor = System.Drawing.Color.Black;
            this.pkw1.Location = new System.Drawing.Point(3, 25);
            this.pkw1.Name = "pkw1";
            this.pkw1.Size = new System.Drawing.Size(75, 23);
            this.pkw1.TabIndex = 6;
            this.pkw1.Text = "PKW";
            this.pkw1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 191);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonBeenden);
            this.Controls.Add(this.buttonSchneller);
            this.Controls.Add(this.buttonLangsamer);
            this.Controls.Add(this.buttonFahren);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Geschwindigkeit: 50";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonFahren;
        private System.Windows.Forms.Button buttonLangsamer;
        private System.Windows.Forms.Button buttonSchneller;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Panel panel1;
        private PKW pkw1;
    }
}

