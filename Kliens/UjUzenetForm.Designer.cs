using System.Runtime.CompilerServices;

namespace BeadandoV3.Kliens
{
    partial class UjUzenetForm
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
            this.cimzett = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.visszaButton = new System.Windows.Forms.Button();
            this.kuldesButton = new System.Windows.Forms.Button();
            this.legorduloMenu = new System.Windows.Forms.ComboBox();
            this.kepTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cimzett
            // 
            this.cimzett.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cimzett.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.cimzett.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cimzett.Location = new System.Drawing.Point(17, 43);
            this.cimzett.Margin = new System.Windows.Forms.Padding(5);
            this.cimzett.Name = "cimzett";
            this.cimzett.ShortcutsEnabled = false;
            this.cimzett.Size = new System.Drawing.Size(200, 37);
            this.cimzett.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 11F);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "címzett";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 11F);
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "üzenet";
            // 
            // visszaButton
            // 
            this.visszaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.visszaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.visszaButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.visszaButton.FlatAppearance.BorderSize = 5;
            this.visszaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.visszaButton.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visszaButton.ForeColor = System.Drawing.Color.White;
            this.visszaButton.Location = new System.Drawing.Point(12, 419);
            this.visszaButton.Name = "visszaButton";
            this.visszaButton.Size = new System.Drawing.Size(95, 30);
            this.visszaButton.TabIndex = 8;
            this.visszaButton.Text = "Vissza";
            this.visszaButton.UseVisualStyleBackColor = false;
            this.visszaButton.Click += new System.EventHandler(this.visszaButton_Click);
            // 
            // kuldesButton
            // 
            this.kuldesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kuldesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kuldesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.kuldesButton.FlatAppearance.BorderSize = 5;
            this.kuldesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kuldesButton.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kuldesButton.ForeColor = System.Drawing.Color.White;
            this.kuldesButton.Location = new System.Drawing.Point(17, 221);
            this.kuldesButton.Name = "kuldesButton";
            this.kuldesButton.Size = new System.Drawing.Size(95, 30);
            this.kuldesButton.TabIndex = 9;
            this.kuldesButton.Text = "Küldés";
            this.kuldesButton.UseVisualStyleBackColor = false;
            this.kuldesButton.Click += new System.EventHandler(this.kuldesButton_Click);
            // 
            // legorduloMenu
            // 
            this.legorduloMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.legorduloMenu.ForeColor = System.Drawing.Color.Violet;
            this.legorduloMenu.Location = new System.Drawing.Point(17, 145);
            this.legorduloMenu.Name = "legorduloMenu";
            this.legorduloMenu.Size = new System.Drawing.Size(200, 21);
            this.legorduloMenu.TabIndex = 10;
            // 
            // kepTextbox
            // 
            this.kepTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kepTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.kepTextbox.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kepTextbox.Location = new System.Drawing.Point(171, 214);
            this.kepTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.kepTextbox.Name = "kepTextbox";
            this.kepTextbox.ShortcutsEnabled = false;
            this.kepTextbox.Size = new System.Drawing.Size(200, 37);
            this.kepTextbox.TabIndex = 11;
            // 
            // UjUzenetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.kepTextbox);
            this.Controls.Add(this.legorduloMenu);
            this.Controls.Add(this.kuldesButton);
            this.Controls.Add(this.visszaButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cimzett);
            this.Name = "UjUzenetForm";
            this.Text = "UjUzenetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cimzett;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        
        private System.Windows.Forms.Button visszaButton;
        private System.Windows.Forms.Button kuldesButton;
        private System.Windows.Forms.ComboBox legorduloMenu;
        private System.Windows.Forms.TextBox kepTextbox;
    }
}