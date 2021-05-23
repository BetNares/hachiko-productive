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
    public partial class YourAssignment : Form
    {
        public YourAssignment()
        {
            InitializeComponent();
        }

        private void YourAssignment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }

        private void AddAsignmentBtn_Click(object sender, EventArgs e)
        {
            InputAssignment AddForm = new InputAssignment();
            AddForm.ShowDialog();
        }

        private void EditAssignmentBtn_Click(object sender, EventArgs e)
        {
            SearchEditForm searchEditForm = new SearchEditForm();
            searchEditForm.ShowDialog();
        }
    }
}
