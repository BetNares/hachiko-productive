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

        private void label3_Click(object sender, EventArgs e)
        {
            YourAssignment yourAssignment = new YourAssignment();
            yourAssignment.ShowDialog();
        }

        private void EditAssignmentBtn_Click(object sender, EventArgs e)
        {
            SearchEditForm searchEditForm = new SearchEditForm();
            searchEditForm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.ShowDialog();
        }
    }
}
