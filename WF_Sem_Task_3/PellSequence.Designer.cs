namespace WF_Sem_Task_3
{
    partial class PellSequence
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
            this.displayBox = new System.Windows.Forms.Label();
            this.nextNumberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayBox
            // 
            this.displayBox.AutoSize = true;
            this.displayBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayBox.Location = new System.Drawing.Point(329, 135);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(90, 37);
            this.displayBox.TabIndex = 0;
            this.displayBox.Text = "label1";
            this.displayBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextNumberButton
            // 
            this.nextNumberButton.Location = new System.Drawing.Point(294, 281);
            this.nextNumberButton.Name = "nextNumberButton";
            this.nextNumberButton.Size = new System.Drawing.Size(175, 26);
            this.nextNumberButton.TabIndex = 1;
            this.nextNumberButton.Text = "Следующий член ряда";
            this.nextNumberButton.UseVisualStyleBackColor = true;
            this.nextNumberButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nextNumberButton_MouseClick);
            // 
            // PellSequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextNumberButton);
            this.Controls.Add(this.displayBox);
            this.Name = "PellSequence";
            this.Text = "Ряд Пелла почленно";
            this.Load += new System.EventHandler(this.PellSequence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayBox;
        private System.Windows.Forms.Button nextNumberButton;
    }
}

