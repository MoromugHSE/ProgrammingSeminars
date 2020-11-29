using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Sem_Task_3
{
    public partial class PellSequence : Form
    {
        private int pPrevious = 1;
        private int pCurrent = 0;
        public PellSequence()
        {
            InitializeComponent();
        }

        private void PellSequence_Load(object sender, EventArgs e)
        {
            displayBox.Text = "Нажмите кнопку, чтобы получить следующий член последовательности";
            Width = displayBox.Width + 10;
            displayBox.Location = new Point(0, displayBox.Location.Y);
        }

        private void nextNumberButton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int pNext = checked(pPrevious + 2 * pCurrent);
                displayBox.Text = $"Член ряда Пелла: {pNext}";
                pPrevious = pCurrent;
                pCurrent = pNext;
            }
            catch (OverflowException)
            {
                displayBox.Text = "Переполнение! Ряд начнем с начала!";
                pPrevious = 1;
                pCurrent = 0;
            }
            displayBox.Location = new Point((Width - displayBox.Width) / 2, displayBox.Location.Y);
        }
    }
}
