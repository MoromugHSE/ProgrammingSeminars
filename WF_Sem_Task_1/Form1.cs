using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Sem_Task_1
{
    public partial class FindTheButton : Form
    {
        public FindTheButton()
        {
            InitializeComponent();
        }

        private void firstButton_MouseClick(object sender, MouseEventArgs e)
        {
            firstButton.Hide();
            secondButton.Show();
        }

        private void secondButton_MouseClick(object sender, MouseEventArgs e)
        {
            secondButton.Hide();
            firstButton.Show();
        }

        private void FindTheButton_Load(object sender, EventArgs e)
        {
            secondButton.Hide();
        }
    }
}
