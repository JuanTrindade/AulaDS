using System;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_ProjetoDS;
using DTO_ProjetoDS;

namespace aplicacao
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                LoginDTO obj = new LoginDTO();
                LoginBLL obj1 = new LoginBLL();
                FuncionarioDTO pessoa = new FuncionarioDTO();

                obj.usuario = textBox1.Text;
                obj.senha = textBox2.Text;

                pessoa = LoginBLL.validar(obj);

                if (pessoa.Nome != "" && pessoa.ativo != "true")
                {
                    this.Hide();
                    Form2 frm2 = new Form2(pessoa);
                    frm2.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    throw new Exception("Usuario ou senha invalidos");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
