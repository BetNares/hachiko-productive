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
        private void ActionBtn_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Insert)
                TambahData();
            else if (mode == Mode.Edit)
                EditData();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        Table Assignment;
        public enum Mode { Insert, Edit }
        Mode mode;
        public InputAssignment()
        {
            InitializeComponent();
            mode = Mode.Insert;
            ActionBtn.Text = "Add";
        }

        private void TambahData()
        {
            if (NamaTb.Text != "" && MatKulTb.Text != "")
            {
                using (var db = new AssignmentModel())
                {
                    var Assignment = new Table()
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
        public InputAssignment(string nama, string matkul, DateTime deadline, string deskripsi)
        {
            InitializeComponent();
            mode = Mode.Edit;
            Assignment = new Table
            {
                Nama_Tugas = nama,
                Matkul = matkul,
                Deadline = deadline,
                Deskripsi = deskripsi
            };
            NamaTb.Text = nama;
            MatKulTb.Text = matkul;
            dateTimePicker1.Value = deadline;
            DeskripsiTb.Text = deskripsi;
            ActionBtn.Text = "Update";
        }
        private void EditData()
        {
            using (var db = new AssignmentModel())
            {
                var result = db.Tables.SingleOrDefault(k => k.Nama_Tugas == Assignment.Nama_Tugas);
                if (result != null)
                {
                    result.Nama_Tugas = NamaTb.Text;
                    result.Matkul = MatKulTb.Text;
                    result.Deadline = dateTimePicker1.Value;
                    result.Deskripsi = DeskripsiTb.Text;
                    db.SaveChanges();
                    MessageBox.Show("Assignment updated");
                    Close();
                }
            }
        }
    }
}