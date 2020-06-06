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
    public partial class ReplaceForm : Form
    {
        private RichTextBox richTextBox;

        public ReplaceForm(RichTextBox richTextBox)
        {
            InitializeComponent();

            this.richTextBox = richTextBox;
        }

        private void button_replace_Click(object sender, EventArgs e)
        {
            if (!richTextBox.Text.Contains(textBox_target.Text))
            {
                MessageBox.Show("Target text does not exist.", "Replacement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            richTextBox.Text = richTextBox.Text.Replace(textBox_target.Text, textBox_replace.Text);
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
