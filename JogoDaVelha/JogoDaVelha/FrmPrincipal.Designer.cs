﻿namespace JogoDaVelha
{
    partial class FrmPrincipal
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
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.btReiniciar = new System.Windows.Forms.Button();
            this.LBoxLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(96, 46);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 66);
            this.bt1.TabIndex = 0;
            this.bt1.UseVisualStyleBackColor = true;
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(213, 46);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 66);
            this.bt2.TabIndex = 1;
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(330, 46);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 66);
            this.bt3.TabIndex = 2;
            this.bt3.UseVisualStyleBackColor = true;
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(330, 139);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(75, 66);
            this.bt6.TabIndex = 5;
            this.bt6.UseVisualStyleBackColor = true;
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(213, 139);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(75, 66);
            this.bt5.TabIndex = 4;
            this.bt5.UseVisualStyleBackColor = true;
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(96, 139);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(75, 66);
            this.bt4.TabIndex = 3;
            this.bt4.UseVisualStyleBackColor = true;
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(330, 232);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(75, 66);
            this.bt9.TabIndex = 8;
            this.bt9.UseVisualStyleBackColor = true;
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(213, 232);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(75, 66);
            this.bt8.TabIndex = 7;
            this.bt8.UseVisualStyleBackColor = true;
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(96, 232);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(75, 66);
            this.bt7.TabIndex = 6;
            this.bt7.UseVisualStyleBackColor = true;
            // 
            // btReiniciar
            // 
            this.btReiniciar.Location = new System.Drawing.Point(530, 12);
            this.btReiniciar.Name = "btReiniciar";
            this.btReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btReiniciar.TabIndex = 9;
            this.btReiniciar.Text = "Reiniciar";
            this.btReiniciar.UseVisualStyleBackColor = true;
            this.btReiniciar.Click += new System.EventHandler(this.btReiniciar_Click);
            // 
            // LBoxLog
            // 
            this.LBoxLog.FormattingEnabled = true;
            this.LBoxLog.Location = new System.Drawing.Point(530, 46);
            this.LBoxLog.Name = "LBoxLog";
            this.LBoxLog.Size = new System.Drawing.Size(224, 251);
            this.LBoxLog.TabIndex = 10;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBoxLog);
            this.Controls.Add(this.btReiniciar);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Name = "FrmPrincipal";
            this.Text = "Jogo da Velha";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button btReiniciar;
        private System.Windows.Forms.ListBox LBoxLog;
    }
}

