using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Sem_Task_2
{
    public partial class fadingForm : Form
    {
        private string appearingText = "Кот уже ушёл!";

        public fadingForm()
        {
            InitializeComponent();
        }

        private void fadingForm_Load(object sender, EventArgs e)
        {
            fadingLabel.Text = "Чеширский кот";
            fadingTimer.Start();
        }

        private void fadingTimer_Tick(object sender, EventArgs e)
        {
            if (fadingLabel.Text != "")
            {
                fadingLabel.Text = 
                    fadingLabel.Text.Substring(0, fadingLabel.Text.Length - 1);
                return;
            }
            if (Opacity > 0)
            {
                Opacity -= 0.1;
                return;
            }
            appearingTimer.Start();
            fadingTimer.Stop();
        }

        private void appearingTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
            {
                Opacity += 0.1;
                return;
            }
            if (fadingLabel.Text != appearingText)
            {
                fadingLabel.Text = 
                    appearingText.Substring(0, fadingLabel.Text.Length + 1);
                return;
            }
            appearingTimer.Stop();
        }
    }
}
