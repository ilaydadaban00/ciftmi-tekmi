using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekmi_ciftmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYAzdir_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSayi.Text);
            if(sayi%2 == 0 )
            {
                MessageBox.Show("sayınız çifttir");
            }else if(sayi%2 == 1 )
            {
                MessageBox.Show("sayınız tektir");

            }
            else
            {
                MessageBox.Show("sayınız sıffırdır");
            }
        }
    }
}
