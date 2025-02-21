namespace MediaNotas
{
    partial class FrmMediaNotas
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
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.txtBox5 = new System.Windows.Forms.TextBox();
            this.txtBox6 = new System.Windows.Forms.TextBox();
            this.txtBox7 = new System.Windows.Forms.TextBox();
            this.txtBox8 = new System.Windows.Forms.TextBox();
            this.txtBox9 = new System.Windows.Forms.TextBox();
            this.txtBox10 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxMedia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxPai
            // 
            this.txtBoxPai.Location = new System.Drawing.Point(622, 26);
            this.txtBoxPai.Visible = false;
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(29, 26);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(100, 20);
            this.txtBox1.TabIndex = 0;
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(29, 66);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(100, 20);
            this.txtBox2.TabIndex = 1;
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(29, 106);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(100, 20);
            this.txtBox3.TabIndex = 3;
            // 
            // txtBox4
            // 
            this.txtBox4.Location = new System.Drawing.Point(29, 146);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(100, 20);
            this.txtBox4.TabIndex = 4;
            // 
            // txtBox5
            // 
            this.txtBox5.Location = new System.Drawing.Point(29, 186);
            this.txtBox5.Name = "txtBox5";
            this.txtBox5.Size = new System.Drawing.Size(100, 20);
            this.txtBox5.TabIndex = 5;
            // 
            // txtBox6
            // 
            this.txtBox6.Location = new System.Drawing.Point(29, 226);
            this.txtBox6.Name = "txtBox6";
            this.txtBox6.Size = new System.Drawing.Size(100, 20);
            this.txtBox6.TabIndex = 6;
            // 
            // txtBox7
            // 
            this.txtBox7.Location = new System.Drawing.Point(29, 266);
            this.txtBox7.Name = "txtBox7";
            this.txtBox7.Size = new System.Drawing.Size(100, 20);
            this.txtBox7.TabIndex = 7;
            // 
            // txtBox8
            // 
            this.txtBox8.Location = new System.Drawing.Point(29, 306);
            this.txtBox8.Name = "txtBox8";
            this.txtBox8.Size = new System.Drawing.Size(100, 20);
            this.txtBox8.TabIndex = 8;
            // 
            // txtBox9
            // 
            this.txtBox9.Location = new System.Drawing.Point(29, 346);
            this.txtBox9.Name = "txtBox9";
            this.txtBox9.Size = new System.Drawing.Size(100, 20);
            this.txtBox9.TabIndex = 9;
            // 
            // txtBox10
            // 
            this.txtBox10.Location = new System.Drawing.Point(29, 386);
            this.txtBox10.Name = "txtBox10";
            this.txtBox10.Size = new System.Drawing.Size(100, 20);
            this.txtBox10.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 20);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calcular média";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMedia
            // 
            this.textBoxMedia.Location = new System.Drawing.Point(303, 66);
            this.textBoxMedia.Name = "textBoxMedia";
            this.textBoxMedia.Size = new System.Drawing.Size(100, 20);
            this.textBoxMedia.TabIndex = 12;
            // 
            // FrmMediaNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMedia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox10);
            this.Controls.Add(this.txtBox9);
            this.Controls.Add(this.txtBox8);
            this.Controls.Add(this.txtBox7);
            this.Controls.Add(this.txtBox6);
            this.Controls.Add(this.txtBox5);
            this.Controls.Add(this.txtBox4);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Name = "FrmMediaNotas";
            this.Text = "Média das notas";
            this.Controls.SetChildIndex(this.txtBoxPai, 0);
            this.Controls.SetChildIndex(this.txtBox1, 0);
            this.Controls.SetChildIndex(this.txtBox2, 0);
            this.Controls.SetChildIndex(this.txtBox3, 0);
            this.Controls.SetChildIndex(this.txtBox4, 0);
            this.Controls.SetChildIndex(this.txtBox5, 0);
            this.Controls.SetChildIndex(this.txtBox6, 0);
            this.Controls.SetChildIndex(this.txtBox7, 0);
            this.Controls.SetChildIndex(this.txtBox8, 0);
            this.Controls.SetChildIndex(this.txtBox9, 0);
            this.Controls.SetChildIndex(this.txtBox10, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.textBoxMedia, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.TextBox txtBox4;
        private System.Windows.Forms.TextBox txtBox5;
        private System.Windows.Forms.TextBox txtBox6;
        private System.Windows.Forms.TextBox txtBox7;
        private System.Windows.Forms.TextBox txtBox8;
        private System.Windows.Forms.TextBox txtBox9;
        private System.Windows.Forms.TextBox txtBox10;
        protected System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMedia;
    }
}
