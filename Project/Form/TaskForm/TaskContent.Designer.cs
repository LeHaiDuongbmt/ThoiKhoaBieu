
namespace Project
{
    partial class TaskContent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContentTask = new System.Windows.Forms.Panel();
            this.panelButtonTaskControl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelButtonTaskControl.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1740, 10);
            this.panel1.TabIndex = 0;
            // 
            // panelContentTask
            // 
            this.panelContentTask.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelContentTask.Location = new System.Drawing.Point(0, 10);
            this.panelContentTask.Name = "panelContentTask";
            this.panelContentTask.Size = new System.Drawing.Size(1660, 110);
            this.panelContentTask.TabIndex = 1;
            // 
            // panelButtonTaskControl
            // 
            this.panelButtonTaskControl.AutoSize = true;
            this.panelButtonTaskControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(18)))));
            this.panelButtonTaskControl.Controls.Add(this.panel2);
            this.panelButtonTaskControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtonTaskControl.Location = new System.Drawing.Point(1660, 10);
            this.panelButtonTaskControl.Name = "panelButtonTaskControl";
            this.panelButtonTaskControl.Size = new System.Drawing.Size(0, 110);
            this.panelButtonTaskControl.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 10);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.CausesValidation = false;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1730, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 110);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(18)))));
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(1660, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(70, 110);
            this.panel5.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 110);
            this.panel3.TabIndex = 0;
            // 
            // TaskContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(222)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1740, 120);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelButtonTaskControl);
            this.Controls.Add(this.panelContentTask);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskContent";
            this.Text = "Task";
            this.Load += new System.EventHandler(this.TaskContent_Load);
            this.panelButtonTaskControl.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContentTask;
        private System.Windows.Forms.Panel panelButtonTaskControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
    }
}