using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using konumTest.ServiceReference1;

namespace konumTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Service1Client Cl = new Service1Client();
            string[] dizi = Cl.onaylanmayantakipciler("O");
            for(int i = 0;i < dizi.Length; i++)
            {
                MessageBox.Show(dizi[i].ToString());
            }
        }
    }
}
