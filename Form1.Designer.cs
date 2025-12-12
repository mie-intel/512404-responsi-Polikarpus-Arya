namespace ResponsiJunpro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtNama = new TextBox();
            txtProyek = new TextBox();
            txtStatus = new TextBox();
            txtFitur = new TextBox();
            txtBug = new TextBox();
            insert = new Button();
            update = new Button();
            delete = new Button();
            dtgv = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            to_update = new TextBox();
            to_delete = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 23);
            label1.Name = "label1";
            label1.Size = new Size(362, 52);
            label1.TabIndex = 0;
            label1.Text = "Uhuy Ini Dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(46, 92);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 1;
            label2.Text = "Data Developer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(46, 222);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 2;
            label3.Text = "Data Kinerja";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(88, 113);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 3;
            label4.Text = "Nama";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(88, 134);
            label5.Name = "label5";
            label5.Size = new Size(92, 21);
            label5.TabIndex = 4;
            label5.Text = "Pilih Proyek";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(88, 183);
            label6.Name = "label6";
            label6.Size = new Size(110, 21);
            label6.TabIndex = 5;
            label6.Text = "Status Kontrak";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(88, 243);
            label7.Name = "label7";
            label7.Size = new Size(94, 21);
            label7.TabIndex = 6;
            label7.Text = "Fitur Selesai";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(89, 264);
            label8.Name = "label8";
            label8.Size = new Size(91, 21);
            label8.TabIndex = 7;
            label8.Text = "Jumlah Bug";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(214, 111);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(136, 23);
            txtNama.TabIndex = 8;
            // 
            // txtProyek
            // 
            txtProyek.Location = new Point(214, 136);
            txtProyek.Name = "txtProyek";
            txtProyek.Size = new Size(136, 23);
            txtProyek.TabIndex = 9;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(214, 185);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(136, 23);
            txtStatus.TabIndex = 10;
            // 
            // txtFitur
            // 
            txtFitur.Location = new Point(214, 241);
            txtFitur.Name = "txtFitur";
            txtFitur.Size = new Size(136, 23);
            txtFitur.TabIndex = 11;
            // 
            // txtBug
            // 
            txtBug.Location = new Point(214, 264);
            txtBug.Name = "txtBug";
            txtBug.Size = new Size(136, 23);
            txtBug.TabIndex = 12;
            // 
            // insert
            // 
            insert.Location = new Point(283, 306);
            insert.Name = "insert";
            insert.Size = new Size(75, 23);
            insert.TabIndex = 13;
            insert.Text = "insert";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // update
            // 
            update.Location = new Point(283, 340);
            update.Name = "update";
            update.Size = new Size(75, 23);
            update.TabIndex = 14;
            update.Text = "update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.Location = new Point(283, 382);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 15;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // dtgv
            // 
            dtgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv.Location = new Point(379, 113);
            dtgv.Name = "dtgv";
            dtgv.Size = new Size(409, 325);
            dtgv.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(379, 92);
            label9.Name = "label9";
            label9.Size = new Size(140, 21);
            label9.TabIndex = 17;
            label9.Text = "Data Performa Tim";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(214, 211);
            label10.Name = "label10";
            label10.Size = new Size(144, 21);
            label10.TabIndex = 18;
            label10.Text = "freelance / full time";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(214, 161);
            label11.Name = "label11";
            label11.Size = new Size(111, 21);
            label11.TabIndex = 19;
            label11.Text = "1 / 2 / 3 / 4 / 5";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(46, 342);
            label12.Name = "label12";
            label12.Size = new Size(148, 21);
            label12.TabIndex = 20;
            label12.Text = "id dev untuk update";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(46, 382);
            label13.Name = "label13";
            label13.Size = new Size(142, 21);
            label13.TabIndex = 21;
            label13.Text = "id dev untuk delete";
            // 
            // to_update
            // 
            to_update.Location = new Point(214, 341);
            to_update.Name = "to_update";
            to_update.Size = new Size(63, 23);
            to_update.TabIndex = 22;
            // 
            // to_delete
            // 
            to_delete.Location = new Point(214, 380);
            to_delete.Name = "to_delete";
            to_delete.Size = new Size(63, 23);
            to_delete.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(to_delete);
            Controls.Add(to_update);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dtgv);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(insert);
            Controls.Add(txtBug);
            Controls.Add(txtFitur);
            Controls.Add(txtStatus);
            Controls.Add(txtProyek);
            Controls.Add(txtNama);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtNama;
        private TextBox txtProyek;
        private TextBox txtStatus;
        private TextBox txtFitur;
        private TextBox txtBug;
        private Button insert;
        private Button update;
        private Button delete;
        private DataGridView dtgv;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox to_update;
        private TextBox to_delete;
    }
}
