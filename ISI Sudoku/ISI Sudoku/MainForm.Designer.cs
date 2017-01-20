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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SGV = new System.Windows.Forms.DataGridView();
            this.newButton = new System.Windows.Forms.Button();
            this.validerBouton = new System.Windows.Forms.Button();
            this.choixNiveau = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choixNiveau)).BeginInit();
            this.SuspendLayout();
            // 
            // SGV
            // 
            this.SGV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.SGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SGV.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.SGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SGV.Location = new System.Drawing.Point(180, 27);
            this.SGV.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.SGV.Name = "SGV";
            this.SGV.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            this.SGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.SGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SGV.Size = new System.Drawing.Size(588, 588);
            this.SGV.TabIndex = 0;
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(12, 360);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(145, 106);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New grid";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // validerBouton
            // 
            this.validerBouton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validerBouton.Location = new System.Drawing.Point(351, 624);
            this.validerBouton.Name = "validerBouton";
            this.validerBouton.Size = new System.Drawing.Size(245, 62);
            this.validerBouton.TabIndex = 2;
            this.validerBouton.Text = "Submit my sudoku!";
            this.validerBouton.UseVisualStyleBackColor = true;
            this.validerBouton.Click += new System.EventHandler(this.button2_Click);
            // 
            // choixNiveau
            // 
            this.choixNiveau.Location = new System.Drawing.Point(49, 153);
            this.choixNiveau.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.choixNiveau.Name = "choixNiveau";
            this.choixNiveau.Size = new System.Drawing.Size(73, 20);
            this.choixNiveau.TabIndex = 4;
            this.choixNiveau.Tag = "";
            this.choixNiveau.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.choixNiveau.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "   Easiest level is 0!   ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(899, 698);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choixNiveau);
            this.Controls.Add(this.validerBouton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.SGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ISISudoku ";
            ((System.ComponentModel.ISupportInitialize)(this.SGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choixNiveau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SGV;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button validerBouton;
        private System.Windows.Forms.NumericUpDown choixNiveau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

