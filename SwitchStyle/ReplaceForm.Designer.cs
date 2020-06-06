namespace SwitchStyle
{
    partial class ReplaceForm
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
            this.textBox_target = new System.Windows.Forms.TextBox();
            this.textBox_replace = new System.Windows.Forms.TextBox();
            this.button_replace = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_target
            // 
            this.textBox_target.Location = new System.Drawing.Point(24, 36);
            this.textBox_target.Name = "textBox_target";
            this.textBox_target.Size = new System.Drawing.Size(144, 22);
            this.textBox_target.TabIndex = 0;
            // 
            // textBox_replace
            // 
            this.textBox_replace.Location = new System.Drawing.Point(24, 84);
            this.textBox_replace.Name = "textBox_replace";
            this.textBox_replace.Size = new System.Drawing.Size(144, 22);
            this.textBox_replace.TabIndex = 1;
            // 
            // button_replace
            // 
            this.button_replace.Location = new System.Drawing.Point(180, 36);
            this.button_replace.Name = "button_replace";
            this.button_replace.Size = new System.Drawing.Size(84, 36);
            this.button_replace.TabIndex = 2;
            this.button_replace.Text = "Replace";
            this.button_replace.UseVisualStyleBackColor = true;
            this.button_replace.Click += new System.EventHandler(this.button_replace_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(180, 84);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(84, 36);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Target";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Replace";
            // 
            // ReplaceForm
            // 
            this.AcceptButton = this.button_replace;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(277, 140);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_replace);
            this.Controls.Add(this.textBox_replace);
            this.Controls.Add(this.textBox_target);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReplaceForm";
            this.Text = "Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_target;
        private System.Windows.Forms.TextBox textBox_replace;
        private System.Windows.Forms.Button button_replace;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}