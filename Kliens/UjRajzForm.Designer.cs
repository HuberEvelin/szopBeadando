using System.Runtime.CompilerServices;

namespace BeadandoV3.Kliens
{
    partial class UjRajzForm
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
            this.rajzNeve = new System.Windows.Forms.TextBox();
            this.rajzCime = new System.Windows.Forms.Label();
            this.rajz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mentesButton = new System.Windows.Forms.Button();
            this.visszaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rajzNeve
            // 
            this.rajzNeve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rajzNeve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.rajzNeve.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rajzNeve.Location = new System.Drawing.Point(14, 39);
            this.rajzNeve.Margin = new System.Windows.Forms.Padding(5);
            this.rajzNeve.Name = "rajzNeve";
            this.rajzNeve.ShortcutsEnabled = false;
            this.rajzNeve.Size = new System.Drawing.Size(200, 37);
            this.rajzNeve.TabIndex = 4;
            // 
            // rajzCime
            // 
            this.rajzCime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rajzCime.AutoSize = true;
            this.rajzCime.Font = new System.Drawing.Font("Dubai", 11F);
            this.rajzCime.Location = new System.Drawing.Point(12, 9);
            this.rajzCime.Name = "rajzCime";
            this.rajzCime.Size = new System.Drawing.Size(65, 25);
            this.rajzCime.TabIndex = 6;
            this.rajzCime.Text = "rajz címe";
            // 
            // rajz
            // 
            this.rajz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rajz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.rajz.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rajz.Location = new System.Drawing.Point(17, 119);
            this.rajz.Margin = new System.Windows.Forms.Padding(5);
            this.rajz.Multiline = true;
            this.rajz.Name = "rajz";
            this.rajz.ShortcutsEnabled = false;
            this.rajz.Size = new System.Drawing.Size(456, 250);
            this.rajz.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 11F);
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "rajz";
            // 
            // mentesButton
            // 
            this.mentesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mentesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mentesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mentesButton.FlatAppearance.BorderSize = 5;
            this.mentesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mentesButton.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mentesButton.ForeColor = System.Drawing.Color.White;
            this.mentesButton.Location = new System.Drawing.Point(377, 377);
            this.mentesButton.Name = "mentesButton";
            this.mentesButton.Size = new System.Drawing.Size(95, 30);
            this.mentesButton.TabIndex = 10;
            this.mentesButton.Text = "Mentés";
            this.mentesButton.UseVisualStyleBackColor = false;
            this.mentesButton.Click += new System.EventHandler(this.mentesButton_Click);
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
            this.visszaButton.TabIndex = 11;
            this.visszaButton.Text = "Vissza";
            this.visszaButton.UseVisualStyleBackColor = false;
            this.visszaButton.Click += new System.EventHandler(this.visszaButton_Click);
            // 
            // UjRajzForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.visszaButton);
            this.Controls.Add(this.mentesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rajz);
            this.Controls.Add(this.rajzCime);
            this.Controls.Add(this.rajzNeve);
            this.Name = "UjRajzForm";
            this.Text = "UjRajzForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rajzNeve;
        private System.Windows.Forms.Label rajzCime;
        private System.Windows.Forms.TextBox rajz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mentesButton;
        private System.Windows.Forms.Button visszaButton;
    }
}