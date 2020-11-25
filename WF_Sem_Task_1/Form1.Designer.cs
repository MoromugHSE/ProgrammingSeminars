namespace WF_Sem_Task_1
{
    partial class FindTheButton
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstButton = new System.Windows.Forms.Button();
            this.secondButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(282, 63);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(97, 53);
            this.firstButton.TabIndex = 0;
            this.firstButton.Text = "Нажми!";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.firstButton_MouseClick);
            // 
            // secondButton
            // 
            this.secondButton.Location = new System.Drawing.Point(282, 259);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(97, 53);
            this.secondButton.TabIndex = 1;
            this.secondButton.Text = "Нажми!";
            this.secondButton.UseVisualStyleBackColor = true;
            this.secondButton.Visible = false;
            this.secondButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.secondButton_MouseClick);
            // 
            // FindTheButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.secondButton);
            this.Controls.Add(this.firstButton);
            this.Name = "FindTheButton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Где кнопка?";
            this.Load += new System.EventHandler(this.FindTheButton_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button secondButton;
    }
}

