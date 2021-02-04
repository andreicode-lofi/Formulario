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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

    

        private void menuSair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja sair do sistema ? ", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
             if(MessageBox.Show("Deseja sair do sistema ? ", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
             {
                e.Cancel = true;
             }
        }

        private void Tela1_Click(object sender, EventArgs e)
        {
            Frm3 frm = new Frm3();
            frm.MdiParent = this;
            frm.Show();
            

        }

        private void tela2_Click(object sender, EventArgs e)
        {
            Frm4 frm = new Frm4();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void tela3_Click(object sender, EventArgs e)
        {
            Frm5 frm = new Frm5();
            frm.MdiParent = this;
            frm.Show();
          
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void btn_Proxima_Click(object sender, EventArgs e)
        {
            FrmSegundo frmNovaTela = new FrmSegundo();
            frmNovaTela.Nome = txtNome.Text;
            frmNovaTela.SobreNome = txtSobreNome.Text;
            frmNovaTela.Email = txtEmail.Text;

            frmNovaTela.Show();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Limpar cadastro ? ", "Cancelado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void btn_Confimar_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Deseja confirmar Cadastro ? ", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmSegundo frmNovaTela = new FrmSegundo();
                frmNovaTela.Nome = txtNome.Text;
                frmNovaTela.SobreNome = txtSobreNome.Text;
                frmNovaTela.Email = txtEmail.Text;

                frmNovaTela.Show();
            }
            else
            {

            }
        }
    }
}
