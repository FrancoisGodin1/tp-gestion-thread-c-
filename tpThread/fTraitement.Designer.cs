namespace tpThread
{
    partial class fTraitement
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAsynchrome = new System.Windows.Forms.Button();
            this.pbTraitement = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Synchome";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAsynchrome
            // 
            this.btnAsynchrome.Location = new System.Drawing.Point(140, 85);
            this.btnAsynchrome.Name = "btnAsynchrome";
            this.btnAsynchrome.Size = new System.Drawing.Size(75, 23);
            this.btnAsynchrome.TabIndex = 1;
            this.btnAsynchrome.Text = "Asynchrome";
            this.btnAsynchrome.UseVisualStyleBackColor = true;
            // 
            // pbTraitement
            // 
            this.pbTraitement.Cursor = System.Windows.Forms.Cursors.No;
            this.pbTraitement.Location = new System.Drawing.Point(64, 203);
            this.pbTraitement.Name = "pbTraitement";
            this.pbTraitement.Size = new System.Drawing.Size(151, 23);
            this.pbTraitement.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbTraitement.TabIndex = 2;
            // 
            // fTraitement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pbTraitement);
            this.Controls.Add(this.btnAsynchrome);
            this.Controls.Add(this.button1);
            this.Name = "fTraitement";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAsynchrome;
        private System.Windows.Forms.ProgressBar pbTraitement;
    }
}

