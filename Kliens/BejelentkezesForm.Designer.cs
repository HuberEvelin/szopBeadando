namespace BeadandoV3.Kliens
{
    partial class BejelentkezesForm
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
            this.BejelentkezesButton = new System.Windows.Forms.Button();
            this.RegisztracioButton = new System.Windows.Forms.Button();
            this.felhasznalonev = new System.Windows.Forms.TextBox();
            this.jelszoTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BejelentkezesButton
            // 
            this.BejelentkezesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BejelentkezesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BejelentkezesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BejelentkezesButton.FlatAppearance.BorderSize = 5;
            this.BejelentkezesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BejelentkezesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BejelentkezesButton.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BejelentkezesButton.Location = new System.Drawing.Point(150, 200);
            this.BejelentkezesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BejelentkezesButton.Name = "BejelentkezesButton";
            this.BejelentkezesButton.Size = new System.Drawing.Size(200, 50);
            this.BejelentkezesButton.TabIndex = 0;
            this.BejelentkezesButton.Text = "Bejelentkezés";
            this.BejelentkezesButton.UseVisualStyleBackColor = false;
            this.BejelentkezesButton.Click += new System.EventHandler(this.BejelentkezesButton_Click);
            // 
            // RegisztracioButton
            // 
            this.RegisztracioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisztracioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RegisztracioButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RegisztracioButton.FlatAppearance.BorderSize = 5;
            this.RegisztracioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RegisztracioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegisztracioButton.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisztracioButton.Location = new System.Drawing.Point(150, 400);
            this.RegisztracioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RegisztracioButton.Name = "RegisztracioButton";
            this.RegisztracioButton.Size = new System.Drawing.Size(200, 50);
            this.RegisztracioButton.TabIndex = 1;
            this.RegisztracioButton.Text = "Regisztráció";
            this.RegisztracioButton.UseVisualStyleBackColor = false;
            this.RegisztracioButton.Click += new System.EventHandler(this.RegisztracioButton_Click);
            // 
            // felhasznalonev
            // 
            this.felhasznalonev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.felhasznalonev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.felhasznalonev.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.felhasznalonev.Location = new System.Drawing.Point(150, 37);
            this.felhasznalonev.Margin = new System.Windows.Forms.Padding(5);
            this.felhasznalonev.Name = "felhasznalonev";
            this.felhasznalonev.ShortcutsEnabled = false;
            this.felhasznalonev.Size = new System.Drawing.Size(200, 37);
            this.felhasznalonev.TabIndex = 2;
            // 
            // jelszoTextbox
            // 
            this.jelszoTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jelszoTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.jelszoTextbox.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jelszoTextbox.Location = new System.Drawing.Point(150, 105);
            this.jelszoTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.jelszoTextbox.Name = "jelszoTextbox";
            this.jelszoTextbox.Size = new System.Drawing.Size(200, 37);
            this.jelszoTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 11F);
            this.label1.Location = new System.Drawing.Point(200, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "felhasználónév";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 11F);
            this.label2.Location = new System.Drawing.Point(232, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "jelszó";
            // 
            // BejelentkezesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jelszoTextbox);
            this.Controls.Add(this.felhasznalonev);
            this.Controls.Add(this.RegisztracioButton);
            this.Controls.Add(this.BejelentkezesButton);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BejelentkezesForm";
            this.Text = "Bejelentkezes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BejelentkezesButton;
        private System.Windows.Forms.Button RegisztracioButton;
        private System.Windows.Forms.TextBox felhasznalonev;
        private System.Windows.Forms.TextBox jelszoTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}