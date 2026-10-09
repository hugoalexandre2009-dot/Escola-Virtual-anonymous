namespace Escola_Virtual_anonymous
{
    partial class Professor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Faltas = new System.Windows.Forms.TabPage();
            this.tp_Notas = new System.Windows.Forms.TabPage();
            this.tp_Infs = new System.Windows.Forms.TabPage();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lblProfName = new System.Windows.Forms.Label();
            this.pb_Prof = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Prof)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_Faltas);
            this.tabControl1.Controls.Add(this.tp_Notas);
            this.tabControl1.Controls.Add(this.tp_Infs);
            this.tabControl1.Location = new System.Drawing.Point(0, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 370);
            this.tabControl1.TabIndex = 15;
            // 
            // tp_Faltas
            // 
            this.tp_Faltas.Location = new System.Drawing.Point(4, 25);
            this.tp_Faltas.Name = "tp_Faltas";
            this.tp_Faltas.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Faltas.Size = new System.Drawing.Size(792, 341);
            this.tp_Faltas.TabIndex = 1;
            this.tp_Faltas.Text = "Marcar Faltas";
            this.tp_Faltas.UseVisualStyleBackColor = true;
            // 
            // tp_Notas
            // 
            this.tp_Notas.Location = new System.Drawing.Point(4, 25);
            this.tp_Notas.Name = "tp_Notas";
            this.tp_Notas.Size = new System.Drawing.Size(792, 341);
            this.tp_Notas.TabIndex = 2;
            this.tp_Notas.Text = "Notas";
            this.tp_Notas.UseVisualStyleBackColor = true;
            // 
            // tp_Infs
            // 
            this.tp_Infs.Location = new System.Drawing.Point(4, 25);
            this.tp_Infs.Name = "tp_Infs";
            this.tp_Infs.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Infs.Size = new System.Drawing.Size(792, 341);
            this.tp_Infs.TabIndex = 0;
            this.tp_Infs.Text = "Informaçôes";
            this.tp_Infs.UseVisualStyleBackColor = true;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(664, 1);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(128, 45);
            this.btn_Logout.TabIndex = 14;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.UseVisualStyleBackColor = true;
            // 
            // lblProfName
            // 
            this.lblProfName.AutoSize = true;
            this.lblProfName.Location = new System.Drawing.Point(84, 1);
            this.lblProfName.Name = "lblProfName";
            this.lblProfName.Size = new System.Drawing.Size(65, 16);
            this.lblProfName.TabIndex = 13;
            this.lblProfName.Text = "Professor";
            // 
            // pb_Prof
            // 
            this.pb_Prof.Location = new System.Drawing.Point(0, 1);
            this.pb_Prof.Name = "pb_Prof";
            this.pb_Prof.Size = new System.Drawing.Size(77, 72);
            this.pb_Prof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Prof.TabIndex = 12;
            this.pb_Prof.TabStop = false;
            // 
            // Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lblProfName);
            this.Controls.Add(this.pb_Prof);
            this.Name = "Professor";
            this.Text = "Professor";
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Prof)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Faltas;
        private System.Windows.Forms.TabPage tp_Notas;
        private System.Windows.Forms.TabPage tp_Infs;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lblProfName;
        private System.Windows.Forms.PictureBox pb_Prof;
    }
}