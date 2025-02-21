using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MediaNotas
{
    public partial class FrmMediaNotas : MediaNotas.FrmPai
    {
        public FrmMediaNotas()
        {
            InitializeComponent();

            string txtBoxName;
            char c;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && control.Name != "textBoxMedia" && control.Name != "txtBoxPai")
                {
                    ((TextBox)control).MaxLength = 5;
                    txtBoxName = (control.Name);
                    c = txtBoxName[txtBoxName.Length-1];
                    control.Text = $"Digite a nota {c}";

                    control.Click += txtSearch_Click;
                    control.LostFocus += txtSearch_Leave;
                    control.KeyPress += textBox_KeyPress_Regex;   
                }
                
            }
            txtBox10.Text = "Digite a nota 10";
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_KeyPress_Regex(object sender, KeyPressEventArgs e)
        {
            if ( (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d,]") && (e.KeyChar != (char)Keys.Back) ) )
                e.Handled = true;
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
                e.Handled = true;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (( (sender as TextBox).Text).Contains("Digite a nota") ) 
                (sender as TextBox).Text = "";
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "") 
                (sender as TextBox).Text = "Digite a nota";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text.Contains("Digite a nota"))
                    {
                        MessageBox.Show("Digite uma nota válida em todos os campos");
                        break;
                    }
                        
                }
                    
            }
            try
            {
                float media = ((Convert.ToSingle(txtBox1.Text) + Convert.ToSingle(txtBox2.Text) + Convert.ToSingle(txtBox3.Text)
            + Convert.ToSingle(txtBox4.Text) + Convert.ToSingle(txtBox5.Text) + Convert.ToSingle(txtBox6.Text)
            + Convert.ToSingle(txtBox7.Text) + Convert.ToSingle(txtBox8.Text) + Convert.ToSingle(txtBox9.Text))
            + Convert.ToSingle(txtBox10.Text))/10;
                textBoxMedia.Text = media.ToString("0.00");
            }
            catch (Exception ex)
            {
            textBoxMedia.Text = "Erro";
            } 
        }
    }
}
