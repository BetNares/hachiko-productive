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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void AddAsignmentBtn_Click(object sender, EventArgs e)
        {
            InputAssignment AddForm = new InputAssignment();
            AddForm.ShowDialog();
        }

        private void YourAssignmentlbl_Paint(object sender, PaintEventArgs e)
        {
           YourAssignment yourAssignment = new YourAssignment();
           yourAssignment.ShowDialog();
        }
    }
}
