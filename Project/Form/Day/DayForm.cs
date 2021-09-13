using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class DayForm : Form
    {
        public DayForm()
        {
            InitializeComponent();
        }

        public void LoadListTask(Form TaskForm)
        {
            TaskForm.TopLevel = false;
            TaskForm.FormBorderStyle = FormBorderStyle.None;
            TaskForm.Dock = DockStyle.Top;
            panelChildForm.Controls.Add(TaskForm);
            panelChildForm.Tag = TaskForm;
            TaskForm.BringToFront();
            TaskForm.Show();
        }

        private void panelListTask_Paint(object sender, PaintEventArgs e)
        {
           


        }

        private void DayForm_Load(object sender, EventArgs e)
        {
            //TaskLaybel x = new TaskLaybel();
            //x.labelNameTask.Text = "Học tiếng anh";
            //x.labelDescriptionTak.Text = "+ Elsa\n+ Duo\n+ PMP";
            //x.textBoxNameTask.Text = x.labelNameTask.Text;

            //LoadListTask(x);

            //TaskLaybel y = new TaskLaybel();
            //y.labelNameTask.Text = "Lâp trình web";
            //LoadListTask(y);

            TaskContent a = new TaskContent();
            TaskContent b = new TaskContent();
            TaskContent c = new TaskContent();
            TaskContent d = new TaskContent();
            TaskContent e1 = new TaskContent();
            TaskContent t = new TaskContent();
            LoadListTask(e1);
            LoadListTask(t);
            LoadListTask(a);
            LoadListTask(b);
            LoadListTask(c);
            LoadListTask(d);
        }
    }
}
