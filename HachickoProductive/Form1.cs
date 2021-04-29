using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HachickoProductive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            LoadingProgress.Value = start;
            PercentageLabel.Text = start + "%";
            if (LoadingProgress.Value == 100)
            {
                LoadingProgress.Value = 0;
                timer1.Stop();
                Home hom = new Home();
                hom.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
