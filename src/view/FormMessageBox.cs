using LyricsFinder.src.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyricsFinderC.src.view
{
    public partial class FormMessageBox : Form
    {
        public FormMessageBox()
        {
            InitializeComponent();
        }

        public FormMessageBox(String title, String message)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            this.Text = title;
            MessageLabel.Text = message;
        }

        public static DialogResult Show(string title, string message)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(title, message))
                result = msgForm.ShowDialog();
            return result;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
