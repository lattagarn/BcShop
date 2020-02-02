namespace BcShop
{
    partial class FormSale
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quark", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(48, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 32);
            this.label6.TabIndex = 41;
            this.label6.Text = "เลขที่ใบเสร็จ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quark", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(336, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 42;
            this.label1.Text = "รายการรวม";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quark", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(720, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 36);
            this.label2.TabIndex = 43;
            this.label2.Text = "ราคารวม";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(49, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(918, 258);
            this.dataGridView1.TabIndex = 46;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "รายการที่";
            this.Column1.Name = "Column1";
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "รหัสสินค้า";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ชื่อสินค้า";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "จำนวน";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ราคา";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ราคารวม";
            this.Column6.Name = "Column6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quark", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(43, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 32);
            this.label3.TabIndex = 47;
            this.label3.Text = "รหัสสินค้า";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Quark", 18F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(138, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 40);
            this.textBox1.TabIndex = 48;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox6_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Quark", 18F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(457, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 40);
            this.textBox2.TabIndex = 49;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quark", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(371, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 32);
            this.label4.TabIndex = 50;
            this.label4.Text = "จำนวน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quark", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(196, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 32);
            this.label5.TabIndex = 51;
            this.label5.Text = "...";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Quark", 20F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(847, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 36);
            this.label8.TabIndex = 53;
            this.label8.Text = "0";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackgroundImage = global::BcShop.Properties.Resources.save;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Quark", 18F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(1013, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 64);
            this.button3.TabIndex = 54;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackgroundImage = global::BcShop.Properties.Resources.close;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Quark", 18F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(1013, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 64);
            this.button4.TabIndex = 56;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Quark", 14F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(758, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 25);
            this.label10.TabIndex = 58;
            this.label10.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Quark", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(466, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 25);
            this.label7.TabIndex = 52;
            this.label7.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Quark", 18F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(545, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 32);
            this.label9.TabIndex = 59;
            this.label9.Text = "รายการ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Quark", 20F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(749, 444);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 36);
            this.label12.TabIndex = 61;
            this.label12.Text = "รับเงิน";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Quark", 18F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(818, 441);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 40);
            this.textBox3.TabIndex = 62;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label13.Font = new System.Drawing.Font("Quark", 20F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(818, 495);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 36);
            this.label13.TabIndex = 64;
            this.label13.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Quark", 20F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(734, 495);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 36);
            this.label14.TabIndex = 63;
            this.label14.Text = "ถอนเงิน";
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 645);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "FormSale";
            this.Text = "ขายสินค้า";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}