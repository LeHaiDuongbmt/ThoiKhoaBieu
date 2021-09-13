
namespace Project
{
    partial class MainForm
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
            this.panelForm1 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelButtonMenu = new System.Windows.Forms.Panel();
            this.btnNam = new System.Windows.Forms.Button();
            this.btnThang = new System.Windows.Forms.Button();
            this.btnTuan = new System.Windows.Forms.Button();
            this.btnNgay = new System.Windows.Forms.Button();
            this.panelForm1.SuspendLayout();
            this.panelButtonMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForm1
            // 
            this.panelForm1.Controls.Add(this.panelChildForm);
            this.panelForm1.Controls.Add(this.panelButtonMenu);
            this.panelForm1.Location = new System.Drawing.Point(10, 10);
            this.panelForm1.Name = "panelForm1";
            this.panelForm1.Size = new System.Drawing.Size(1760, 730);
            this.panelForm1.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChildForm.Location = new System.Drawing.Point(0, 80);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1760, 650);
            this.panelChildForm.TabIndex = 1;
            // 
            // panelButtonMenu
            // 
            this.panelButtonMenu.Controls.Add(this.btnNam);
            this.panelButtonMenu.Controls.Add(this.btnThang);
            this.panelButtonMenu.Controls.Add(this.btnTuan);
            this.panelButtonMenu.Controls.Add(this.btnNgay);
            this.panelButtonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonMenu.Location = new System.Drawing.Point(0, 0);
            this.panelButtonMenu.Name = "panelButtonMenu";
            this.panelButtonMenu.Size = new System.Drawing.Size(1760, 70);
            this.panelButtonMenu.TabIndex = 0;
            // 
            // btnNam
            // 
            this.btnNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(188)))), ((int)(((byte)(182)))));
            this.btnNam.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.btnNam.Location = new System.Drawing.Point(750, 0);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(250, 70);
            this.btnNam.TabIndex = 3;
            this.btnNam.Text = "Năm";
            this.btnNam.UseVisualStyleBackColor = false;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // btnThang
            // 
            this.btnThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(188)))), ((int)(((byte)(182)))));
            this.btnThang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.btnThang.Location = new System.Drawing.Point(500, 0);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(250, 70);
            this.btnThang.TabIndex = 2;
            this.btnThang.Text = "Tháng";
            this.btnThang.UseVisualStyleBackColor = false;
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // btnTuan
            // 
            this.btnTuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(188)))), ((int)(((byte)(182)))));
            this.btnTuan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnTuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.btnTuan.Location = new System.Drawing.Point(250, 0);
            this.btnTuan.Name = "btnTuan";
            this.btnTuan.Size = new System.Drawing.Size(250, 70);
            this.btnTuan.TabIndex = 1;
            this.btnTuan.Text = "Tuần";
            this.btnTuan.UseVisualStyleBackColor = false;
            this.btnTuan.Click += new System.EventHandler(this.btnTuan_Click);
            // 
            // btnNgay
            // 
            this.btnNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(188)))), ((int)(((byte)(182)))));
            this.btnNgay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(96)))), ((int)(((byte)(61)))));
            this.btnNgay.Location = new System.Drawing.Point(0, 0);
            this.btnNgay.Name = "btnNgay";
            this.btnNgay.Size = new System.Drawing.Size(250, 70);
            this.btnNgay.TabIndex = 0;
            this.btnNgay.Text = "Ngày";
            this.btnNgay.UseVisualStyleBackColor = false;
            this.btnNgay.Click += new System.EventHandler(this.btnNgay_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(222)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1782, 753);
            this.Controls.Add(this.panelForm1);
            this.MinimumSize = new System.Drawing.Size(1800, 800);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelForm1.ResumeLayout(false);
            this.panelButtonMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm1;
        private System.Windows.Forms.Panel panelButtonMenu;
        private System.Windows.Forms.Button btnNam;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Button btnTuan;
        public System.Windows.Forms.Button btnNgay;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

