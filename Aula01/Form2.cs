using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01
{
    public partial class FrmSegundo : Form
    {
        public FrmSegundo()
        {
            InitializeComponent();
        }

        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }

        private void FrmSegundo_Load(object sender, EventArgs e)
        {
            txtNome.Text = Nome;
            txtSobreNome.Text = SobreNome;
            txtEmail.Text = Email;
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmPrincipal voltarPrincipal = new FrmPrincipal();

            txtNome.Text = Nome;
          

            voltarPrincipal.Show();
            this.Hide();
        }

       
    }
}
