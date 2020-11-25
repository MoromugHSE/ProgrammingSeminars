namespace WF_Sem_Task_2
{
    partial class fadingForm
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
            this.components = new System.ComponentModel.Container();
            this.fadingLabel = new System.Windows.Forms.Label();
            this.fadingTimer = new System.Windows.Forms.Timer(this.components);
            this.appearingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // fadingLabel
            // 
            this.fadingLabel.AutoSize = true;
            this.fadingLabel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fadingLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.fadingLabel.Location = new System.Drawing.Point(149, 118);
            this.fadingLabel.Name = "fadingLabel";
            this.fadingLabel.Size = new System.Drawing.Size(172, 72);
            this.fadingLabel.TabIndex = 0;
            this.fadingLabel.Text = "label1";
            this.fadingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fadingTimer
            // 
            this.fadingTimer.Tick += new System.EventHandler(this.fadingTimer_Tick);
            // 
            // appearingTimer
            // 
            this.appearingTimer.Tick += new System.EventHandler(this.appearingTimer_Tick);
            // 
            // fadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fadingLabel);
            this.Name = "fadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Растаявшая надпись";
            this.Load += new System.EventHandler(this.fadingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fadingLabel;
        private System.Windows.Forms.Timer fadingTimer;
        private System.Windows.Forms.Timer appearingTimer;
    }
}

