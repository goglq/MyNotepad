namespace SwitchStyle
{
    partial class GoToLineForm
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
            this.numericUpDown_lineNum = new System.Windows.Forms.NumericUpDown();
            this.button_goToLine = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lineNum)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_lineNum
            // 
            this.numericUpDown_lineNum.Location = new System.Drawing.Point(24, 36);
            this.numericUpDown_lineNum.Name = "numericUpDown_lineNum";
            this.numericUpDown_lineNum.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_lineNum.TabIndex = 0;
            // 
            // button_goToLine
            // 
            this.button_goToLine.Location = new System.Drawing.Point(168, 24);
            this.button_goToLine.Name = "button_goToLine";
            this.button_goToLine.Size = new System.Drawing.Size(96, 36);
            this.button_goToLine.TabIndex = 1;
            this.button_goToLine.Text = "Go To";
            this.button_goToLine.UseVisualStyleBackColor = true;
            this.button_goToLine.Click += new System.EventHandler(this.button_goToLine_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(168, 72);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(96, 36);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Line number";
            // 
            // GoToLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 123);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_goToLine);
            this.Controls.Add(this.numericUpDown_lineNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GoToLineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Go To Line";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lineNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_lineNum;
        private System.Windows.Forms.Button button_goToLine;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label1;
    }
}