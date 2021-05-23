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
    public partial class SearchEditForm : Form
    {
        public SearchEditForm()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            lblNama.Text = "-";
            lblMatkul.Text = "-";
            dateTimePicker1.Value = DateTime.Now;
            lblDeskripsi.Text = "-";
            EditBtn.Enabled = false;
            DeleteBtn.Enabled = false;
            using (var db = new AssignmentModel())
            {
                var query = from Table in db.Tables where Table.Nama_Tugas == tbSearch.Text select Table;
                foreach (var item in query)
                {
                    lblNama.Text = item.Nama_Tugas;
                    lblMatkul.Text = item.Matkul;
                    dateTimePicker1.Value = (DateTime)item.Deadline;
                    lblDeskripsi.Text = item.Deskripsi;
                    EditBtn.Enabled = true;
                    DeleteBtn.Enabled = true;
                }
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            using (var db = new AssignmentModel())
            {
                db.Tables.RemoveRange(db.Tables.Where(item => item.Nama_Tugas == lblNama.Text));
                db.SaveChanges();
                lblNama.Text = "-";
                lblMatkul.Text = "-";
                dateTimePicker1.Value = DateTime.Now;
                lblDeskripsi.Text = "-";
                EditBtn.Enabled = false;
                DeleteBtn.Enabled = false;
            }
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            InputAssignment inputAssignment = new InputAssignment(lblNama.Text, lblMatkul.Text,
                dateTimePicker1.Value, lblDeskripsi.Text);
            inputAssignment.ShowDialog();
        }
    }
}
