
namespace HachickoProductive
{
    partial class InputAssignment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputAssignment));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NamaTb = new System.Windows.Forms.TextBox();
            this.MatKulTb = new System.Windows.Forms.TextBox();
            this.DeskripsiTb = new System.Windows.Forms.TextBox();
            this.ActionBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Tugas :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deadline :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mata Kuliah :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Deskripsi :";
            // 
            // NamaTb
            // 
            this.NamaTb.BackColor = System.Drawing.Color.NavajoWhite;
            this.NamaTb.Location = new System.Drawing.Point(268, 55);
            this.NamaTb.Name = "NamaTb";
            this.NamaTb.Size = new System.Drawing.Size(313, 26);
            this.NamaTb.TabIndex = 4;
            // 
            // MatKulTb
            // 
            this.MatKulTb.BackColor = System.Drawing.Color.NavajoWhite;
            this.MatKulTb.Location = new System.Drawing.Point(268, 112);
            this.MatKulTb.Name = "MatKulTb";
            this.MatKulTb.Size = new System.Drawing.Size(313, 26);
            this.MatKulTb.TabIndex = 5;
            // 
            // DeskripsiTb
            // 
            this.DeskripsiTb.BackColor = System.Drawing.Color.NavajoWhite;
            this.DeskripsiTb.Location = new System.Drawing.Point(269, 231);
            this.DeskripsiTb.Multiline = true;
            this.DeskripsiTb.Name = "DeskripsiTb";
            this.DeskripsiTb.Size = new System.Drawing.Size(313, 136);
            this.DeskripsiTb.TabIndex = 7;
            // 
            // ActionBtn
            // 
            this.ActionBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.ActionBtn.Location = new System.Drawing.Point(396, 494);
            this.ActionBtn.Name = "ActionBtn";
            this.ActionBtn.Size = new System.Drawing.Size(147, 34);
            this.ActionBtn.TabIndex = 8;
            this.ActionBtn.Text = "Add";
            this.ActionBtn.UseVisualStyleBackColor = false;
            this.ActionBtn.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.CancelBtn.Location = new System.Drawing.Point(549, 494);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(106, 34);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 432);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.NavajoWhite;
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "ddd, dd MMMM yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(268, 165);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(313, 26);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2021, 5, 22, 17, 35, 0, 0);
            // 
            // InputAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(680, 562);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ActionBtn);
            this.Controls.Add(this.DeskripsiTb);
            this.Controls.Add(this.MatKulTb);
            this.Controls.Add(this.NamaTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputAssignment";
            this.Text = "InputAssignment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NamaTb;
        private System.Windows.Forms.TextBox MatKulTb;
        private System.Windows.Forms.TextBox DeskripsiTb;
        private System.Windows.Forms.Button ActionBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}