using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoreRoulette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string answer = tbAnswer.Text;
            string[] answerArray = answer.Split(' ');
            int numberOfPeople = answerArray.Length;

            answerArray.

            foreach (string name in answerArray)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void tbAnswer_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string[] choresChecked = new string[] { };
            checkedListBox1.Items.AddRange(choresChecked);
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
