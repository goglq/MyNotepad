using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchStyle
{
    public partial class FindForm : Form
    {
        private RichTextBox richTextBox;

        public FindForm(RichTextBox richTextBox)
        {
            InitializeComponent();

            this.richTextBox = richTextBox;
            textBox_find.Text = richTextBox.SelectedText;
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_find_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_find.Text))
                return;
            richTextBox.Select(richTextBox.Find(textBox_find.Text), textBox_find.Text.Length);
            Close();
        }
    }
}
