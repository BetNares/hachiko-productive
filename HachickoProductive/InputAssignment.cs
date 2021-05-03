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
    public partial class InputAssignment : Form
    {
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            TambahData();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        Table Assignment;
        public InputAssignment()
        {
            InitializeComponent();
        }

        private void TambahData()
        {
            if (NamaTb.Text != "" && MatKulTb.Text != "")
            {
                using (var db = new AssignmentModel())
                {
                    Assignment = new Table
                    {
                        Nama_Tugas = NamaTb.Text,
                        Matkul = MatKulTb.Text,
                        Deskripsi = DeskripsiTb.Text,
                        Deadline = dateTimePicker1.Value,
                    };
                    db.Tables.Add(Assignment);
                    db.SaveChanges();
                    MessageBox.Show("Assignment added");
                    Close();
                }
            }



        }
    }
}
