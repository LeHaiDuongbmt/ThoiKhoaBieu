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
    public partial class TaskContent : Form
    {
        public TaskContent()
        {
            InitializeComponent();
        }
        private void TaskContent_Load(object sender, EventArgs e)
        {
            openChildForm(new TaskLaybel());
        }

        Form activeForm = null;
        Button activeButton = null;

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContentTask.Controls.Add(childForm);
            panelContentTask.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void activeButtonColor(Button btn)
        {
            if (activeButton != null)
            {
                activeButton.BackColor = ColorTranslator.FromHtml("#A3BCB6");
                activeButton.ForeColor = ColorTranslator.FromHtml("#39603D");
            }

            activeButton = btn;
            btn.BackColor = ColorTranslator.FromHtml("#39603D");
            btn.ForeColor = ColorTranslator.FromHtml("#FFFFFF");

        }

       
    }
}
