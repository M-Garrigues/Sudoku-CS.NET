namespace ISI_Sudoku
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.SGV = new System.Windows.Forms.DataGridView();
            this.newButton = new System.Windows.Forms.Button();
            this.validerBouton = new System.Windows.Forms.Button();
            this.choixNiveau = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choixNiveau)).BeginInit();
            this.SuspendLayout();
            // 
            // SGV
            // 
            this.SGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SGV.ColumnHeadersVisible = false;
            this.SGV.Location = new System.Drawing.Point(12, 22);
            this.SGV.Name = "SGV";
            this.SGV.RowHeadersVisible = false;
            this.SGV.Size = new System.Drawing.Size(537, 487);
            this.SGV.TabIndex = 0;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(582, 160);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(110, 69);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New grid";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // validerBouton
            // 
            this.validerBouton.Location = new System.Drawing.Point(582, 272);
            this.validerBouton.Name = "validerBouton";
            this.validerBouton.Size = new System.Drawing.Size(110, 23);
            this.validerBouton.TabIndex = 2;
            this.validerBouton.Text = "Submit my sudoku!";
            this.validerBouton.UseVisualStyleBackColor = true;
            this.validerBouton.Click += new System.EventHandler(this.button2_Click);
            // 
            // choixNiveau
            // 
            this.choixNiveau.Location = new System.Drawing.Point(611, 134);
            this.choixNiveau.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.choixNiveau.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.choixNiveau.Name = "choixNiveau";
            this.choixNiveau.Size = new System.Drawing.Size(50, 20);
            this.choixNiveau.TabIndex = 4;
            this.choixNiveau.Tag = "";
            this.choixNiveau.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.choixNiveau.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 537);
            this.Controls.Add(this.choixNiveau);
            this.Controls.Add(this.validerBouton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.SGV);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choixNiveau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SGV;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button validerBouton;
        private System.Windows.Forms.NumericUpDown choixNiveau;
    }
}

