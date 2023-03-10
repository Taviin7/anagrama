using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anagrama
{
    public partial class frmEsgotado : Form
    {
       
        public frmEsgotado()
        {
            InitializeComponent();
        }


        string[] titleChars = new string[3] {".",".","."};
        int Count = 0;

        private void TimerTitle_Tick_1(object sender, EventArgs e)
        {
            string title = lblTitulo.Text;
            Count++;

            if (Count < 3)
            {
                title += titleChars[Count];
            }
            if (Count >= 10)
            {
                Count = 0;
                title = "Você perdeu";
            }
            lblTitulo.Text = title;
        }

        private void Btn_Reiniciar_Click(object sender, EventArgs e)
        {
            frm_menu frm_Menu = new frm_menu();
            frm_Menu.Show();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
