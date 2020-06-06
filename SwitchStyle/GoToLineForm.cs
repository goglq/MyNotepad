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
    public partial class GoToLineForm : Form
    {
        private RichTextBox richTextBox;

        public GoToLineForm(RichTextBox richTextBox)
        {
            InitializeComponent();
            this.richTextBox = richTextBox;
            numericUpDown_lineNum.Minimum = 1;
            numericUpDown_lineNum.Maximum = richTextBox.Lines.Length;
        }

        private void button_goToLine_Click(object sender, EventArgs e)
        {
            int lineNum = (int)numericUpDown_lineNum.Value - 1;
            richTextBox.SelectionStart = richTextBox.GetFirstCharIndexFromLine(lineNum);
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
