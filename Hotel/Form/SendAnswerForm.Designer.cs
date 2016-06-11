namespace Hotel
{
    partial class SendAnswerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendAnswerForm));
            this.recallTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recallTextBox
            // 
            this.recallTextBox.Location = new System.Drawing.Point(10, 39);
            this.recallTextBox.Multiline = true;
            this.recallTextBox.Name = "recallTextBox";
            this.recallTextBox.ReadOnly = true;
            this.recallTextBox.Size = new System.Drawing.Size(661, 199);
            this.recallTextBox.TabIndex = 1;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(10, 244);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(661, 153);
            this.answerTextBox.TabIndex = 0;
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendButton.Image = global::Hotel.Properties.Resources.answer;
            this.sendButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendButton.Location = new System.Drawing.Point(543, 403);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(128, 57);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Ответить";
            this.sendButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sendButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // SendAnswerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(683, 459);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.recallTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendAnswerForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Ответ на отзыв";
            this.Load += new System.EventHandler(this.SendAnswerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox recallTextBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button sendButton;
    }
}