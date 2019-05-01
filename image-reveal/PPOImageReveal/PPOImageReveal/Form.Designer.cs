namespace PPOImageReveal
{
    partial class Form
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button16 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.l_score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(150, 191);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(80, 80);
            this.button16.TabIndex = 0;
            this.button16.Text = "16";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(236, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 80);
            this.button4.TabIndex = 49;
            this.button4.Text = "16";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // l_score
            // 
            this.l_score.AutoSize = true;
            this.l_score.Location = new System.Drawing.Point(12, 500);
            this.l_score.Name = "l_score";
            this.l_score.Size = new System.Drawing.Size(41, 13);
            this.l_score.TabIndex = 50;
            this.l_score.Text = "Score: ";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 522);
            this.Controls.Add(this.l_score);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button16);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label l_score;
    }
}

