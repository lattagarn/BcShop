namespace BcShop
{
    partial class FormMain
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.รายงานคลงสนคาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.รายงานการขายToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Font = new System.Drawing.Font("Quark", 18F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripDropDownButton2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 59);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(818, 39);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.รายงานคลงสนคาToolStripMenuItem,
            this.รายงานการขายToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(121, 36);
            this.toolStripDropDownButton1.Text = "จัดการสินค้า";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // รายงานคลงสนคาToolStripMenuItem
            // 
            this.รายงานคลงสนคาToolStripMenuItem.Name = "รายงานคลงสนคาToolStripMenuItem";
            this.รายงานคลงสนคาToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
            this.รายงานคลงสนคาToolStripMenuItem.Text = "หมวดหมู่สินค้า";
            this.รายงานคลงสนคาToolStripMenuItem.Click += new System.EventHandler(this.รายงานคลงสนคาToolStripMenuItem_Click);
            // 
            // รายงานการขายToolStripMenuItem
            // 
            this.รายงานการขายToolStripMenuItem.Name = "รายงานการขายToolStripMenuItem";
            this.รายงานการขายToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
            this.รายงานการขายToolStripMenuItem.Text = "คลังสินค้า";
            this.รายงานการขายToolStripMenuItem.Click += new System.EventHandler(this.รายงานการขายToolStripMenuItem_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(87, 36);
            this.toolStripLabel2.Text = "ขายสินค้า";
            this.toolStripLabel2.Click += new System.EventHandler(this.ToolStripLabel2_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(130, 36);
            this.toolStripLabel3.Text = "จัดการพนักงาน";
            this.toolStripLabel3.Click += new System.EventHandler(this.ToolStripLabel3_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(87, 36);
            this.toolStripDropDownButton2.Text = "รายงาน";
            this.toolStripDropDownButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 36);
            this.toolStripMenuItem1.Text = "รายงานคลังสินค้า";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 36);
            this.toolStripMenuItem2.Text = "รายงานการขาย";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(146, 36);
            this.toolStripLabel1.Text = "ออกจากโปรแกรม";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("RSU", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(818, 59);
            this.label1.TabIndex = 16;
            this.label1.Text = "ร้าน Bc Shop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 469);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Text = "BcShop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem รายงานคลงสนคาToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายงานการขายToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}