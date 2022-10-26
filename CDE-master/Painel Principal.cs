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
    public partial class PAINEL_PRINCIPAL : Form
    {
        Thread t1;
        public PAINEL_PRINCIPAL()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            // COMEÇO DO CODIGO PARA ABRIR A TELA DE REGISTRO
            this.Close();
            t1 = new Thread(abrirJanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirJanela(object obj)
        {
            Application.Run(new NovaJanela());
        }
    }
}
