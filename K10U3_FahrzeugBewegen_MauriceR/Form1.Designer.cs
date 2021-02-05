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
            // 
            // buttonFahren
            // 
            this.buttonFahren.Location = new System.Drawing.Point(170, 149);
            this.buttonFahren.Name = "buttonFahren";
            this.buttonFahren.Size = new System.Drawing.Size(75, 23);
            this.buttonFahren.TabIndex = 1;
            this.buttonFahren.Text = "Fahren";
            this.buttonFahren.UseVisualStyleBackColor = true;
            // 
            // buttonLangsamer
            // 
            this.buttonLangsamer.Location = new System.Drawing.Point(251, 149);
            this.buttonLangsamer.Name = "buttonLangsamer";
            this.buttonLangsamer.Size = new System.Drawing.Size(75, 23);
            this.buttonLangsamer.TabIndex = 2;
            this.buttonLangsamer.Text = "Langsamer";
            this.buttonLangsamer.UseVisualStyleBackColor = true;
            // 
            // buttonSchneller
            // 
            this.buttonSchneller.Location = new System.Drawing.Point(332, 149);
            this.buttonSchneller.Name = "buttonSchneller";
            this.buttonSchneller.Size = new System.Drawing.Size(75, 23);
            this.buttonSchneller.TabIndex = 3;
            this.buttonSchneller.Text = "Schneller";
            this.buttonSchneller.UseVisualStyleBackColor = true;
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Location = new System.Drawing.Point(510, 149);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(75, 23);
            this.buttonBeenden.TabIndex = 4;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 51);
            this.panel1.TabIndex = 5;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonFahren;
        private System.Windows.Forms.Button buttonLangsamer;
        private System.Windows.Forms.Button buttonSchneller;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Panel panel1;
    }
}

