namespace BeadandoV3.Kliens
{
    partial class PostaladaForm
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
            this.kijelentkezes = new System.Windows.Forms.Button();
            this.ujUzenet = new System.Windows.Forms.Button();
            this.ujRajz = new System.Windows.Forms.Button();
            this.uzenetekPanel = new System.Windows.Forms.DataGridView();
            this.frissitesButton = new System.Windows.Forms.Button();
            this.torlesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uzenetekPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // kijelentkezes
            // 
            this.kijelentkezes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kijelentkezes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kijelentkezes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.kijelentkezes.FlatAppearance.BorderSize = 5;
            this.kijelentkezes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kijelentkezes.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kijelentkezes.ForeColor = System.Drawing.Color.White;
            this.kijelentkezes.Location = new System.Drawing.Point(377, 419);
            this.kijelentkezes.Name = "kijelentkezes";
            this.kijelentkezes.Size = new System.Drawing.Size(95, 30);
            this.kijelentkezes.TabIndex = 0;
            this.kijelentkezes.Text = "Kijelentkezés";
            this.kijelentkezes.UseVisualStyleBackColor = false;
            this.kijelentkezes.Click += new System.EventHandler(this.kijelentkezes_Click);
            // 
            // ujUzenet
            // 
            this.ujUzenet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ujUzenet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ujUzenet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ujUzenet.FlatAppearance.BorderSize = 5;
            this.ujUzenet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ujUzenet.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ujUzenet.ForeColor = System.Drawing.Color.White;
            this.ujUzenet.Location = new System.Drawing.Point(377, 12);
            this.ujUzenet.Name = "ujUzenet";
            this.ujUzenet.Size = new System.Drawing.Size(95, 30);
            this.ujUzenet.TabIndex = 1;
            this.ujUzenet.Text = "Új üzenet";
            this.ujUzenet.UseVisualStyleBackColor = false;
            this.ujUzenet.Click += new System.EventHandler(this.ujUzenet_Click);
            // 
            // ujRajz
            // 
            this.ujRajz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ujRajz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ujRajz.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ujRajz.FlatAppearance.BorderSize = 5;
            this.ujRajz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ujRajz.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ujRajz.ForeColor = System.Drawing.Color.White;
            this.ujRajz.Location = new System.Drawing.Point(377, 48);
            this.ujRajz.Name = "ujRajz";
            this.ujRajz.Size = new System.Drawing.Size(95, 30);
            this.ujRajz.TabIndex = 2;
            this.ujRajz.Text = "Új Rajz";
            this.ujRajz.UseVisualStyleBackColor = false;
            this.ujRajz.Click += new System.EventHandler(this.ujRajz_Click);
            // 
            // uzenetekPanel
            // 
            this.uzenetekPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uzenetekPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uzenetekPanel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uzenetekPanel.Location = new System.Drawing.Point(12, 12);
            this.uzenetekPanel.Name = "uzenetekPanel";
            this.uzenetekPanel.Size = new System.Drawing.Size(345, 437);
            this.uzenetekPanel.TabIndex = 3;
            // 
            // frissitesButton
            // 
            this.frissitesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frissitesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.frissitesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.frissitesButton.FlatAppearance.BorderSize = 5;
            this.frissitesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.frissitesButton.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frissitesButton.ForeColor = System.Drawing.Color.White;
            this.frissitesButton.Location = new System.Drawing.Point(377, 84);
            this.frissitesButton.Name = "frissitesButton";
            this.frissitesButton.Size = new System.Drawing.Size(95, 30);
            this.frissitesButton.TabIndex = 4;
            this.frissitesButton.Text = "Frissítés";
            this.frissitesButton.UseVisualStyleBackColor = false;
            this.frissitesButton.Click += new System.EventHandler(this.frissitesButton_Click);
            // 
            // torlesButton
            // 
            this.torlesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.torlesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.torlesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.torlesButton.FlatAppearance.BorderSize = 5;
            this.torlesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.torlesButton.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torlesButton.ForeColor = System.Drawing.Color.White;
            this.torlesButton.Location = new System.Drawing.Point(377, 120);
            this.torlesButton.Name = "torlesButton";
            this.torlesButton.Size = new System.Drawing.Size(95, 30);
            this.torlesButton.TabIndex = 5;
            this.torlesButton.Text = "Törlés";
            this.torlesButton.UseVisualStyleBackColor = false;
            this.torlesButton.Click += new System.EventHandler(this.torlesButton_Click);
            // 
            // PostaladaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.torlesButton);
            this.Controls.Add(this.frissitesButton);
            this.Controls.Add(this.uzenetekPanel);
            this.Controls.Add(this.ujRajz);
            this.Controls.Add(this.ujUzenet);
            this.Controls.Add(this.kijelentkezes);
            this.Name = "PostaladaForm";
            this.Text = "Postalada";
            ((System.ComponentModel.ISupportInitialize)(this.uzenetekPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kijelentkezes;
        private System.Windows.Forms.Button ujUzenet;
        private System.Windows.Forms.Button ujRajz;
        private System.Windows.Forms.DataGridView uzenetekPanel;
        private System.Windows.Forms.Button frissitesButton;
        private System.Windows.Forms.Button torlesButton;
    }
}