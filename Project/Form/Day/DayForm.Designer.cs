
namespace Project
{
    partial class DayForm
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCompletionSchedule = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panelTimeDeadline = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelTimeClock = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelDescriptionTak = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.paneNameTask = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCompletionSchedule.SuspendLayout();
            this.panelTimeDeadline.SuspendLayout();
            this.panelTimeClock.SuspendLayout();
            this.panelDescriptionTak.SuspendLayout();
            this.paneNameTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(222)))), ((int)(((byte)(212)))));
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panelChildForm);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1740, 630);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panelListTask_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelCompletionSchedule);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panelTimeDeadline);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panelTimeClock);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panelDescriptionTak);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.paneNameTask);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1740, 50);
            this.panel1.TabIndex = 2;
            // 
            // panelCompletionSchedule
            // 
            this.panelCompletionSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
            this.panelCompletionSchedule.Controls.Add(this.label5);
            this.panelCompletionSchedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCompletionSchedule.Location = new System.Drawing.Point(1410, 0);
            this.panelCompletionSchedule.Name = "panelCompletionSchedule";
            this.panelCompletionSchedule.Size = new System.Drawing.Size(320, 50);
            this.panelCompletionSchedule.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tiến độ hoàn thành";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(1400, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 50);
            this.panel10.TabIndex = 18;
            // 
            // panelTimeDeadline
            // 
            this.panelTimeDeadline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
            this.panelTimeDeadline.Controls.Add(this.label4);
            this.panelTimeDeadline.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTimeDeadline.Location = new System.Drawing.Point(1080, 0);
            this.panelTimeDeadline.Name = "panelTimeDeadline";
            this.panelTimeDeadline.Size = new System.Drawing.Size(320, 50);
            this.panelTimeDeadline.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời gian đến hạn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(1070, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 50);
            this.panel8.TabIndex = 16;
            // 
            // panelTimeClock
            // 
            this.panelTimeClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
            this.panelTimeClock.Controls.Add(this.label3);
            this.panelTimeClock.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTimeClock.Location = new System.Drawing.Point(750, 0);
            this.panelTimeClock.Name = "panelTimeClock";
            this.panelTimeClock.Size = new System.Drawing.Size(320, 50);
            this.panelTimeClock.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thời gian báo thức";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(740, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 50);
            this.panel6.TabIndex = 14;
            // 
            // panelDescriptionTak
            // 
            this.panelDescriptionTak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
            this.panelDescriptionTak.Controls.Add(this.label2);
            this.panelDescriptionTak.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDescriptionTak.Location = new System.Drawing.Point(340, 0);
            this.panelDescriptionTak.Name = "panelDescriptionTak";
            this.panelDescriptionTak.Size = new System.Drawing.Size(400, 50);
            this.panelDescriptionTak.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mô tả chi tiết";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(330, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 50);
            this.panel4.TabIndex = 12;
            // 
            // paneNameTask
            // 
            this.paneNameTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(197)))), ((int)(((byte)(186)))));
            this.paneNameTask.Controls.Add(this.label1);
            this.paneNameTask.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneNameTask.Location = new System.Drawing.Point(10, 0);
            this.paneNameTask.Name = "paneNameTask";
            this.paneNameTask.Size = new System.Drawing.Size(320, 50);
            this.paneNameTask.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên công việc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 50);
            this.panel3.TabIndex = 10;
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoScroll = true;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChildForm.Location = new System.Drawing.Point(0, 70);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1740, 560);
            this.panelChildForm.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(222)))), ((int)(((byte)(212)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1740, 10);
            this.panel2.TabIndex = 0;
            // 
            // DayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1760, 650);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DayForm";
            this.Text = "DayForm";
            this.Load += new System.EventHandler(this.DayForm_Load);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelCompletionSchedule.ResumeLayout(false);
            this.panelCompletionSchedule.PerformLayout();
            this.panelTimeDeadline.ResumeLayout(false);
            this.panelTimeDeadline.PerformLayout();
            this.panelTimeClock.ResumeLayout(false);
            this.panelTimeClock.PerformLayout();
            this.panelDescriptionTak.ResumeLayout(false);
            this.panelDescriptionTak.PerformLayout();
            this.paneNameTask.ResumeLayout(false);
            this.paneNameTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCompletionSchedule;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panelTimeDeadline;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panelTimeClock;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelDescriptionTak;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel paneNameTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}