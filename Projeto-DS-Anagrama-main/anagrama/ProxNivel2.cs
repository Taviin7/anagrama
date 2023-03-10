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
    public partial class frm_ProxNivel2 : Form
    {
        public frm_ProxNivel2()
        {
            InitializeComponent();
        }

        private void Btn_Avancar_Click(object sender, EventArgs e)
        {
            frm_fasedificil frm_Fasedificil = new frm_fasedificil();
            frm_Fasedificil.Show();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            frm_menu frm_Menu = new frm_menu();
            frm_Menu.Show();
        }
    }
}
