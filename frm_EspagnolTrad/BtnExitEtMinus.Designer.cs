
namespace frm_EspagnolTrad
{
    partial class BtnExitEtMinus
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnRéduire = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Yellow;
            this.btnQuitter.ForeColor = System.Drawing.Color.Red;
            this.btnQuitter.Location = new System.Drawing.Point(86, 3);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnRéduire
            // 
            this.btnRéduire.BackColor = System.Drawing.Color.Yellow;
            this.btnRéduire.ForeColor = System.Drawing.Color.Red;
            this.btnRéduire.Location = new System.Drawing.Point(5, 3);
            this.btnRéduire.Name = "btnRéduire";
            this.btnRéduire.Size = new System.Drawing.Size(75, 23);
            this.btnRéduire.TabIndex = 1;
            this.btnRéduire.Text = "Réduire";
            this.btnRéduire.UseVisualStyleBackColor = false;
            this.btnRéduire.Click += new System.EventHandler(this.btnRéduire_Click);
            // 
            // BtnExitEtMinus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.btnRéduire);
            this.Controls.Add(this.btnQuitter);
            this.Name = "BtnExitEtMinus";
            this.Size = new System.Drawing.Size(164, 31);
            this.Load += new System.EventHandler(this.BtnExitEtMinus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnRéduire;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
