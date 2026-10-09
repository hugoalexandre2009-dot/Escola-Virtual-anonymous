namespace Escola_Virtual_anonymous
{
    partial class Administrador
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
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.pb_Admin = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Turmas = new System.Windows.Forms.TabPage();
            this.Tp_Profs = new System.Windows.Forms.TabPage();
            this.tp_Alunos = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Admin)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(668, 2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(128, 45);
            this.btn_Logout.TabIndex = 11;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Location = new System.Drawing.Point(84, 2);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(90, 16);
            this.lblAdminName.TabIndex = 10;
            this.lblAdminName.Text = "Administrador";
            // 
            // pb_Admin
            // 
            this.pb_Admin.Image = global::Escola_Virtual_anonymous.Properties.Resources.Utilizador;
            this.pb_Admin.Location = new System.Drawing.Point(0, 2);
            this.pb_Admin.Name = "pb_Admin";
            this.pb_Admin.Size = new System.Drawing.Size(77, 72);
            this.pb_Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Admin.TabIndex = 9;
            this.pb_Admin.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_Turmas);
            this.tabControl1.Controls.Add(this.Tp_Profs);
            this.tabControl1.Controls.Add(this.tp_Alunos);
            this.tabControl1.Location = new System.Drawing.Point(0, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 368);
            this.tabControl1.TabIndex = 8;
            // 
            // tp_Turmas
            // 
            this.tp_Turmas.Location = new System.Drawing.Point(4, 25);
            this.tp_Turmas.Name = "tp_Turmas";
            this.tp_Turmas.Size = new System.Drawing.Size(792, 339);
            this.tp_Turmas.TabIndex = 2;
            this.tp_Turmas.Text = "Turmas";
            this.tp_Turmas.UseVisualStyleBackColor = true;
            // 
            // Tp_Profs
            // 
            this.Tp_Profs.Location = new System.Drawing.Point(4, 25);
            this.Tp_Profs.Name = "Tp_Profs";
            this.Tp_Profs.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_Profs.Size = new System.Drawing.Size(792, 339);
            this.Tp_Profs.TabIndex = 0;
            this.Tp_Profs.Text = "Professores";
            this.Tp_Profs.UseVisualStyleBackColor = true;
            // 
            // tp_Alunos
            // 
            this.tp_Alunos.Location = new System.Drawing.Point(4, 25);
            this.tp_Alunos.Name = "tp_Alunos";
            this.tp_Alunos.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Alunos.Size = new System.Drawing.Size(792, 339);
            this.tp_Alunos.TabIndex = 1;
            this.tp_Alunos.Text = "Alunos";
            this.tp_Alunos.UseVisualStyleBackColor = true;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lblAdminName);
            this.Controls.Add(this.pb_Admin);
            this.Controls.Add(this.tabControl1);
            this.Name = "Administrador";
            this.Text = "Adminisrador";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Admin)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.PictureBox pb_Admin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Turmas;
        private System.Windows.Forms.TabPage Tp_Profs;
        private System.Windows.Forms.TabPage tp_Alunos;
    }
}