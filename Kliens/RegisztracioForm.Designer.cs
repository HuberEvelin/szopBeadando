namespace BeadandoV3.Kliens
{
    partial class RegisztracioForm
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
            this.regisztracioButton = new System.Windows.Forms.Button();
            this.felhasznalonev = new System.Windows.Forms.TextBox();
            this.jelszo = new System.Windows.Forms.TextBox();
            this.bejelentkezesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regisztracioButton
            // 
            this.regisztracioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.regisztracioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.regisztracioButton.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regisztracioButton.ForeColor = System.Drawing.Color.White;
            this.regisztracioButton.Location = new System.Drawing.Point(150, 177);
            this.regisztracioButton.Name = "regisztracioButton";
            this.regisztracioButton.Size = new System.Drawing.Size(200, 50);
            this.regisztracioButton.TabIndex = 0;
            this.regisztracioButton.Text = "Regisztráció";
            this.regisztracioButton.UseVisualStyleBackColor = false;
            this.regisztracioButton.Click += new System.EventHandler(this.regisztracioButton_Click);
            // 
            // felhasznalonev
            // 
            this.felhasznalonev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.felhasznalonev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.felhasznalonev.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.felhasznalonev.Location = new System.Drawing.Point(150, 50);
            this.felhasznalonev.Name = "felhasznalonev";
            this.felhasznalonev.Size = new System.Drawing.Size(200, 37);
            this.felhasznalonev.TabIndex = 1;
            // 
            // jelszo
            // 
            this.jelszo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.jelszo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.jelszo.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jelszo.Location = new System.Drawing.Point(150, 113);
            this.jelszo.Name = "jelszo";
            this.jelszo.Size = new System.Drawing.Size(200, 37);
            this.jelszo.TabIndex = 2;
            // 
            // bejelentkezesButton
            // 
            this.bejelentkezesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bejelentkezesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bejelentkezesButton.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bejelentkezesButton.ForeColor = System.Drawing.Color.White;
            this.bejelentkezesButton.Location = new System.Drawing.Point(150, 399);
            this.bejelentkezesButton.Name = "bejelentkezesButton";
            this.bejelentkezesButton.Size = new System.Drawing.Size(200, 50);
            this.bejelentkezesButton.TabIndex = 3;
            this.bejelentkezesButton.Text = "Bejelentkezés";
            this.bejelentkezesButton.UseVisualStyleBackColor = false;
            this.bejelentkezesButton.Click += new System.EventHandler(this.bejelentkezesButton_Click);
            // 
            // RegisztracioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.bejelentkezesButton);
            this.Controls.Add(this.jelszo);
            this.Controls.Add(this.felhasznalonev);
            this.Controls.Add(this.regisztracioButton);
            this.Name = "RegisztracioForm";
            this.Text = "RegisztracioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regisztracioButton;
        private System.Windows.Forms.TextBox felhasznalonev;
        private System.Windows.Forms.TextBox jelszo;
        private System.Windows.Forms.Button bejelentkezesButton;
    }
}