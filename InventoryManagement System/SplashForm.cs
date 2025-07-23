using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement_System
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter += 5;
            progressBar1.Value = counter;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                Form1 home = new Form1();
                home.Show();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
