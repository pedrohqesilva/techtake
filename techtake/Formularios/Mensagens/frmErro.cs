using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace techtake
{
    public partial class frmErro : Form
    {
        public frmErro()
        {
            InitializeComponent();
            Mensagem.Text = Program.Msg;
        }
        
        #region Mudar a cor do botão OK
        private void btnOK_MouseEnter(object sender, EventArgs e)
        { btnOK.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoOK2.png"); }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        { btnOK.BackgroundImage = new Bitmap(@"..\..\Imagens\Botoes\BotaoOK1.png"); }
        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
