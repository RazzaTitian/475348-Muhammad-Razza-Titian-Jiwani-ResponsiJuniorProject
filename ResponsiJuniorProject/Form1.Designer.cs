namespace ResponsiJuniorProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            logoBox = new System.Windows.Forms.PictureBox();
            lblLogo = new System.Windows.Forms.Label();
            btnInsert = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            lblKaryawan = new System.Windows.Forms.Label();
            lblDept = new System.Windows.Forms.Label();
            tbKaryawan = new System.Windows.Forms.TextBox();
            tableDGV = new System.Windows.Forms.DataGridView();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            cbDept = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableDGV).BeginInit();
            SuspendLayout();
            // 
            // logoBox
            // 
            logoBox.BackgroundImage = (System.Drawing.Image)resources.GetObject("logoBox.BackgroundImage");
            logoBox.Location = new System.Drawing.Point(12, 12);
            logoBox.Name = "logoBox";
            logoBox.Size = new System.Drawing.Size(247, 256);
            logoBox.TabIndex = 0;
            logoBox.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLogo.Location = new System.Drawing.Point(32, 271);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new System.Drawing.Size(212, 25);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "SUS AMOGUS Database";
            // 
            // btnInsert
            // 
            btnInsert.Location = new System.Drawing.Point(506, 96);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new System.Drawing.Size(129, 116);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(641, 96);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(129, 116);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Update";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(776, 96);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(129, 116);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblKaryawan
            // 
            lblKaryawan.AutoSize = true;
            lblKaryawan.Location = new System.Drawing.Point(285, 136);
            lblKaryawan.Name = "lblKaryawan";
            lblKaryawan.Size = new System.Drawing.Size(93, 15);
            lblKaryawan.TabIndex = 5;
            lblKaryawan.Text = "Nama Karyawan";
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Location = new System.Drawing.Point(289, 165);
            lblDept.Name = "lblDept";
            lblDept.Size = new System.Drawing.Size(89, 15);
            lblDept.TabIndex = 6;
            lblDept.Text = "Dept. Karyawan";
            // 
            // tbKaryawan
            // 
            tbKaryawan.Location = new System.Drawing.Point(384, 133);
            tbKaryawan.Name = "tbKaryawan";
            tbKaryawan.Size = new System.Drawing.Size(100, 23);
            tbKaryawan.TabIndex = 7;
            // 
            // tableDGV
            // 
            tableDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableDGV.Location = new System.Drawing.Point(289, 248);
            tableDGV.Name = "tableDGV";
            tableDGV.RowTemplate.Height = 25;
            tableDGV.Size = new System.Drawing.Size(616, 186);
            tableDGV.TabIndex = 9;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            richTextBox1.Location = new System.Drawing.Point(974, 96);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(171, 338);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "ID Departemen:\nHR : HR\nENG : Engineer\nDEV : Developer\nPM : Product M\nFIN : Finance";
            // 
            // cbDept
            // 
            cbDept.DisplayMember = "1";
            cbDept.FormattingEnabled = true;
            cbDept.Location = new System.Drawing.Point(384, 162);
            cbDept.Name = "cbDept";
            cbDept.Size = new System.Drawing.Size(100, 23);
            cbDept.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1199, 522);
            Controls.Add(cbDept);
            Controls.Add(richTextBox1);
            Controls.Add(tableDGV);
            Controls.Add(tbKaryawan);
            Controls.Add(lblDept);
            Controls.Add(lblKaryawan);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(lblLogo);
            Controls.Add(logoBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblKaryawan;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox tbKaryawan;
        private System.Windows.Forms.DataGridView tableDGV;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cbDept;
    }
}
