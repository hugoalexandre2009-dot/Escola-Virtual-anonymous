namespace Escola_Virtual_anonymous
{
    partial class Aluno
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
            this.tab_student = new System.Windows.Forms.TabControl();
            this.tp_information = new System.Windows.Forms.TabPage();
            this.tp_notes = new System.Windows.Forms.TabPage();
            this.tp_card = new System.Windows.Forms.TabPage();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_StudentName = new System.Windows.Forms.Label();
            this.pb_Student = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lbl_class = new System.Windows.Forms.Label();
            this.tab_student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_student
            // 
            this.tab_student.Controls.Add(this.tp_information);
            this.tab_student.Controls.Add(this.tp_notes);
            this.tab_student.Controls.Add(this.tp_card);
            this.tab_student.Controls.Add(this.tabPage4);
            this.tab_student.Controls.Add(this.tabPage5);
            this.tab_student.Location = new System.Drawing.Point(2, 80);
            this.tab_student.Name = "tab_student";
            this.tab_student.SelectedIndex = 0;
            this.tab_student.Size = new System.Drawing.Size(796, 370);
            this.tab_student.TabIndex = 18;
            // 
            // tp_information
            // 
            this.tp_information.Location = new System.Drawing.Point(4, 25);
            this.tp_information.Name = "tp_information";
            this.tp_information.Padding = new System.Windows.Forms.Padding(3);
            this.tp_information.Size = new System.Drawing.Size(788, 341);
            this.tp_information.TabIndex = 0;
            this.tp_information.Text = "Informações";
            this.tp_information.UseVisualStyleBackColor = true;
            // 
            // tp_notes
            // 
            this.tp_notes.Location = new System.Drawing.Point(4, 25);
            this.tp_notes.Name = "tp_notes";
            this.tp_notes.Padding = new System.Windows.Forms.Padding(3);
            this.tp_notes.Size = new System.Drawing.Size(788, 341);
            this.tp_notes.TabIndex = 1;
            this.tp_notes.Text = "Notas";
            this.tp_notes.UseVisualStyleBackColor = true;
            // 
            // tp_card
            // 
            this.tp_card.Location = new System.Drawing.Point(4, 25);
            this.tp_card.Name = "tp_card";
            this.tp_card.Padding = new System.Windows.Forms.Padding(3);
            this.tp_card.Size = new System.Drawing.Size(788, 341);
            this.tp_card.TabIndex = 2;
            this.tp_card.Text = "Cartão";
            this.tp_card.UseVisualStyleBackColor = true;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(670, 1);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(128, 45);
            this.btn_Logout.TabIndex = 17;
            this.btn_Logout.Text = "Sair";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_StudentName
            // 
            this.lbl_StudentName.AutoSize = true;
            this.lbl_StudentName.Location = new System.Drawing.Point(86, 1);
            this.lbl_StudentName.Name = "lbl_StudentName";
            this.lbl_StudentName.Size = new System.Drawing.Size(41, 16);
            this.lbl_StudentName.TabIndex = 16;
            this.lbl_StudentName.Text = "Aluno";
            // 
            // pb_Student
            // 
            this.pb_Student.Image = global::Escola_Virtual_anonymous.Properties.Resources.icons8_student_100;
            this.pb_Student.Location = new System.Drawing.Point(2, 1);
            this.pb_Student.Name = "pb_Student";
            this.pb_Student.Size = new System.Drawing.Size(77, 72);
            this.pb_Student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Student.TabIndex = 15;
            this.pb_Student.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(788, 341);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(788, 341);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Location = new System.Drawing.Point(85, 30);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(46, 16);
            this.lbl_class.TabIndex = 19;
            this.lbl_class.Text = "Turma";
            // 
            // Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_class);
            this.Controls.Add(this.tab_student);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_StudentName);
            this.Controls.Add(this.pb_Student);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Aluno";
            this.Text = "Aluno";
            this.tab_student.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_student;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_StudentName;
        private System.Windows.Forms.PictureBox pb_Student;
        private System.Windows.Forms.TabPage tp_information;
        private System.Windows.Forms.TabPage tp_notes;
        private System.Windows.Forms.TabPage tp_card;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lbl_class;
    }
}