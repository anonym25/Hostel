namespace Hotel
{
    partial class ViewRecallForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRecallForm));
            this.recallTextBox = new System.Windows.Forms.TextBox();
            this.topicTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // recallTextBox
            // 
            this.recallTextBox.Location = new System.Drawing.Point(3, 77);
            this.recallTextBox.Multiline = true;
            this.recallTextBox.Name = "recallTextBox";
            this.recallTextBox.ReadOnly = true;
            this.recallTextBox.Size = new System.Drawing.Size(707, 199);
            this.recallTextBox.TabIndex = 4;
            // 
            // topicTextBox
            // 
            this.topicTextBox.Location = new System.Drawing.Point(3, 12);
            this.topicTextBox.Multiline = true;
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.ReadOnly = true;
            this.topicTextBox.Size = new System.Drawing.Size(707, 59);
            this.topicTextBox.TabIndex = 3;
            // 
            // ViewRecallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 284);
            this.Controls.Add(this.topicTextBox);
            this.Controls.Add(this.recallTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewRecallForm";
            this.Text = "Просмотр отзыва";
            this.Load += new System.EventHandler(this.ViewRecallForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox recallTextBox;
        private System.Windows.Forms.TextBox topicTextBox;
    }
}