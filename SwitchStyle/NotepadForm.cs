using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SwitchStyle
{
    public partial class NotepadForm : Form
    {
        private ImageList small_icons = new ImageList();

        private const string FileFilter = "Rich text file (*.rtf)|*.rtf";
        private DirectoryInfo currentDirectory = new DirectoryInfo(Environment.GetLogicalDrives()[0]);
        private string fileName;
        private bool isFileChanged = false;
        
        private int selectionPointIndex = -1;
        private IList<string> recentFiles;

        public NotepadForm()
        {
            InitializeComponent();

            recentFiles = File.ReadLines("recent.txt").ToList();
            
            recentFilesStripMenuItem.DropDownItems.AddRange(
                recentFiles.Select(fileName => new ToolStripMenuItem() {
                    Text = fileName,
                    Size = new Size(180,22)})
                    .ToArray()
                );

            small_icons.ColorDepth = ColorDepth.Depth32Bit;
            small_icons.Images.Add(Properties.Resources.Directory);

            treeView.ImageList = small_icons;
            listView.SmallImageList = small_icons;
        }

        private void NotepadForm_Load(object sender, EventArgs e)
        {
            textBox_directoryName.Text = currentDirectory.FullName;
            DisplayDirectoryItems();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            isFileChanged = true;
        }

        #region DisplayViewItems
        private void DisplayDirectoryItems()
        {
            if (!Directory.Exists(currentDirectory.FullName))
                return;

            FillTreeView();
            FillListView(currentDirectory);
        }

        private void FillTreeView()
        {
            treeView.Nodes.Clear();
            DirectoryInfo[] directories = currentDirectory.GetDirectories();
            foreach (DirectoryInfo directory in directories)
            {
                treeView.Nodes.Add(CreateTreeNode(directory));
            }
        }

        private void FillListView(DirectoryInfo directoryInfo)
        {
            listView.Items.Clear();
            FileInfo[] files = directoryInfo.GetFiles();
            foreach (FileInfo file in files)
                listView.Items.Add(CreateListViewItem(file));
        }

        private TreeNode CreateTreeNode(DirectoryInfo directoryInfo)
        {
            TreeNode node = new TreeNode(directoryInfo.Name);
            node.Tag = directoryInfo.FullName;
            node.ImageIndex = 0;
            return node;
        }

        private ListViewItem CreateListViewItem(FileInfo file)
        {
            ListViewItem item = new ListViewItem(file.Name);
            item.SubItems.Add(file.Extension);

            Icon icon = Icon.ExtractAssociatedIcon(file.FullName);
            small_icons.Images.Add(icon);
            item.ImageIndex = small_icons.Images.Count - 1;
            item.Tag = file.FullName;

            return item;
        }

        private void textBox_directoryName_TextChanged(object sender, EventArgs e)
        {
            currentDirectory = new DirectoryInfo(textBox_directoryName.Text);
            DisplayDirectoryItems();
        }
        #endregion

        #region OnFormClosing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ConfirmExit())
                e.Cancel = true;
        }

        private bool ConfirmExit()
        {
            if (!isFileChanged)
                return false;

            DialogResult result = MessageBox.Show("File has been changed. Do you want to save changes?",
                "Confirmation",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information);

            switch (result)
            {
                case DialogResult.Yes:
                    return false;
                case DialogResult.No:
                    return false;
                case DialogResult.Cancel:
                    return true;
            }

            return false;
        }
        #endregion

        #region FileMenu
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveFile()
        {
            if (fileName != null)
            {
                richTextBox.SaveFile(fileName);
                isFileChanged = false;
                return;
            }
            OpenSaveDialogFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSaveDialogFile();
        }

        private void OpenSaveDialogFile()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save";
            saveDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveDialog.Filter = FileFilter;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveDialog.FileName;
                richTextBox.SaveFile(fileName);
                isFileChanged = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfirmExit())
                return;

            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Open";
            openDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openDialog.Filter = FileFilter;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openDialog.FileName;
                richTextBox.LoadFile(fileName);
                isFileChanged = false;
                WriteRecentFile();
            }
        }

        private void WriteRecentFile()
        {
            recentFiles.Add(fileName);
            File.WriteAllLines("recent.txt", recentFiles);

            recentFilesStripMenuItem.DropDownItems.Clear();
            recentFilesStripMenuItem.DropDownItems.AddRange(
                recentFiles.Select(fileName => new ToolStripMenuItem()
                {
                    Text = fileName,
                    Size = new Size(180, 22)
                }).ToArray());
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmExit();
            fileName = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region TextEdit
        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (richTextBox.SelectionLength == 0)
                fontDialog.Font = richTextBox.Font;
            else
                fontDialog.Font = richTextBox.SelectionFont;

            if (fontDialog.ShowDialog() != DialogResult.OK)
                return;

            if (richTextBox.SelectionLength == 0)
                richTextBox.Font = fontDialog.Font;
            else
                richTextBox.SelectionFont = fontDialog.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                richTextBox.SelectionColor = colorDialog.Color;
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont,
                richTextBox.SelectionFont.Style ^ FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont,
                richTextBox.SelectionFont.Style ^ FontStyle.Italic);
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont,
                richTextBox.SelectionFont.Style ^ FontStyle.Underline);
        }

        private void strikethroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont,
                richTextBox.SelectionFont.Style ^ FontStyle.Strikeout);
        }
        #endregion

        #region EditMenu
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Redo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm form = new FindForm(richTextBox);
            form.ShowDialog();
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchingText = richTextBox.SelectedText;
            selectionPointIndex += searchingText.Length;
            int selectedIndex = richTextBox.Text.IndexOf(searchingText, selectionPointIndex);
            if (selectedIndex == -1)
            {
                selectionPointIndex = 0;
                selectedIndex = richTextBox.Text.IndexOf(searchingText, selectionPointIndex);
            }

            richTextBox.Select(selectedIndex, searchingText.Length);

        }

        private void richTextBox_SelectionChanged(object sender, EventArgs e)
        {
            selectionPointIndex = richTextBox.SelectionStart;
        }

        private void goToLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToLineForm form = new GoToLineForm(richTextBox);
            form.ShowDialog();
            Show();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplaceForm form = new ReplaceForm(richTextBox);
            form.ShowDialog();
            Show();
        }
        #endregion

        private void listView_Active(object sender, EventArgs e)
        {
            string fileName = (string)listView.SelectedItems[0].Tag;
            if (Path.GetExtension(fileName) != ".rtf")
            {
                MessageBox.Show("Поддерживается только файл формата rtf", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            richTextBox.LoadFile(fileName);
            isFileChanged = false;
        }

        private void treeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            DirectoryInfo clickedDirectory = new DirectoryInfo((string)e.Node.Tag);

            FileInfo[] innerFiles = clickedDirectory.GetFiles();
            FillListView(clickedDirectory);

            if (e.Node.IsExpanded)
                return;

            DirectoryInfo[] innerDirectories = clickedDirectory.GetDirectories();
            if (innerDirectories.Length != 0)
                foreach (DirectoryInfo directory in innerDirectories)
                    e.Node.Nodes.Add(CreateTreeNode(directory));

            e.Node.Expand();
        }
    }
}
