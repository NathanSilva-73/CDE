using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace telaLogin
{
    public partial class Form1 : Form
    {
        Thread nt;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "administrador" && textBox2.Text == "22k22") 
            {
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Usuário inválido, você é administrador?");
            }
        }

        private void novoForm()
        {
            Application.Run(new PAINEL_PRINCIPAL());
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
