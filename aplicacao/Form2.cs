using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_ProjetoDS;


namespace aplicacao
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            TimeSpan tarde = new TimeSpan(12, 0, 0);
            TimeSpan noite = new TimeSpan(18, 0, 0);
            TimeSpan HoraAtual = DateTime.Now.TimeOfDay;

            if (HoraAtual < tarde)
            {
                label1.Text = "Acorda, vai trabalhar amigo";
            }
            else if (HoraAtual < noite)
            {
                label1.Text = "Batendo uma essa hora amigão?";
            }
            else
            {
                label1.Text = "Vai dormir fdp";
            }
            

        }

        public Form2(FuncionarioDTO obj) 
        {
            InitializeComponent();
            TimeSpan tarde = new TimeSpan(12, 0, 0);
            TimeSpan noite = new TimeSpan(18, 0, 0);
            TimeSpan HoraAtual = DateTime.Now.TimeOfDay;

            if (HoraAtual < tarde)
            {
                label1.Text = "Boa manhã, bora trabalhar";
            }
            else if (HoraAtual < noite)
            {
                label1.Text = "Tenha uma boa tarde?";
            }
            else
            {
                label1.Text = "Tenha uma boa noite";
            }
            label2.Text = obj.Nome;
            if (obj.cargo == "Funcionario")
            {
                this.PaginaInicial.TabPages.Remove(tabPage4);
                this.PaginaInicial.TabPages.Remove(tabPage5);
                this.PaginaInicial.TabPages.Remove(tabPage6);
                this.PaginaInicial.TabPages.Remove(tabPage7);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label1.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try 
            {
                FuncionarioDTO obj = new FuncionarioDTO();
                obj.UserName = textBox1.Text;
                obj.Nome = textBox1.Text;
                obj.RG = maskedTextBox1.Text;
                obj.CPF = maskedTextBox2.Text ;
                obj.DataNascimento = maskedTextBox3.Text;
                obj.TelFixo = maskedTextBox4.Text;
                obj.TelCelular = maskedTextBox5.Text;
                obj.cargo = comboBox2.Text;
                obj.endereco = textBox2.Text;
                obj.numero = maskedTextBox7.Text;
                obj.bairro = textBox3.Text;
                obj.cidade = textBox4.Text;
                obj.UF = comboBox1.Text;
                obj.CEP = maskedTextBox6.Text;

                if(radioButton4.Checked == true)
                {
                    obj.sexo = radioButton4.Text;
                }
                if(radioButton1.Checked == true)
                {
                    obj.sexo = radioButton1.Text;
                }

                if (radioButton2.Checked == true)
                {
                    obj.ativo = radioButton2.Text;
                }
                if (radioButton3.Checked == true)
                {
                    obj.ativo = radioButton3.Text;
                }
            }
            catch 
            {
 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
