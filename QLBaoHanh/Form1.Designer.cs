namespace QLBaoHanh
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1072, 533);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialFloatingActionButton1);
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.ImageKey = "icons8-list-26.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1064, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sản phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.ImageKey = "icons8-maintenance-26.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1064, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bảo hành";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-general-ledger-26.png");
            this.imageList1.Images.SetKeyName(1, "icons8-list-26.png");
            this.imageList1.Images.SetKeyName(2, "icons8-maintenance-26.png");
            this.imageList1.Images.SetKeyName(3, "icons8-people-26.png");
            this.imageList1.Images.SetKeyName(4, "icons8-bill-26.png");
            this.imageList1.Images.SetKeyName(5, "icons8-add-26.png");
            this.imageList1.Images.SetKeyName(6, "icons8-delete-26.png");
            this.imageList1.Images.SetKeyName(7, "icons8-edit-50.png");
            // 
            // tabPage3
            // 
            this.tabPage3.ImageKey = "icons8-people-26.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1064, 498);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Khách hàng";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.ImageKey = "icons8-general-ledger-26.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1064, 498);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Lịch sử giao dịch";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.ImageKey = "icons8-bill-26.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1064, 498);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Hóa đơn";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 31);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1064, 498);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Settings | Log out";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(29, 17);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(502, 254);
            this.materialCard1.TabIndex = 0;
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.Icon = null;
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(506, 58);
            this.materialFloatingActionButton1.Mini = true;
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(40, 40);
            this.materialFloatingActionButton1.TabIndex = 1;
            this.materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 600);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Quản lý bảo hành";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
    }
}

