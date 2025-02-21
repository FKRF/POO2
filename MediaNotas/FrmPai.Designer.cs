namespace MediaNotas
{
    partial class FrmPai
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
            this.txtBoxPai = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxPai
            // 
            this.txtBoxPai.Location = new System.Drawing.Point(51, 29);
            this.txtBoxPai.MaxLength = 3;
            this.txtBoxPai.Name = "txtBoxPai";
            this.txtBoxPai.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPai.TabIndex = 0;
            // 
            // FrmPai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxPai);
            this.Name = "FrmPai";
            this.Text = "FrmPai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox txtBoxPai;
    }
}

