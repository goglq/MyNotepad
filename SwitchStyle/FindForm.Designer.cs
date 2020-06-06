namespace SwitchStyle
{
    partial class FindForm
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
            this.button_find = new System.Windows.Forms.Button();
            this.textBox_find = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_find
            // 
            this.button_find.Location = new System.Drawing.Point(288, 24);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(96, 36);
            this.button_find.TabIndex = 1;
            this.button_find.Text = "Find";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.Button_find_Click);
            // 
            // textBox_find
            // 
            this.textBox_find.Location = new System.Drawing.Point(24, 36);
            this.textBox_find.Name = "textBox_find";
            this.textBox_find.Size = new System.Drawing.Size(252, 22);
            this.textBox_find.TabIndex = 0;
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(288, 72);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(96, 36);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Find text";
            // 
            // FindForm
            // 
            this.AcceptButton = this.button_find;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(406, 116);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.textBox_find);
            this.Controls.Add(this.button_find);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.TextBox textBox_find;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label1;
    }
}