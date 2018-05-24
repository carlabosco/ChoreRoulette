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

            string answer = tb_Answer.Text;
            string[] answerArray = answer.Split(' ');
            int numberOfPeople = answerArray.Length;



        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string people = tb_Answer.Text;
            string[] peopleArray = people.Split(' ');
            foreach (string name in peopleArray)
            {
                Random rnd = new Random();
                string chore = peopleArray[rnd.Next(peopleArray.Length)];
            }

            foreach (string chore in checkedListBox1.CheckedItems)
            {
                tb_Result.Text += " " + chore;
            }

        }

        private void tb_Question(object sender, EventArgs e)
        {

        }


        private void tb_Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1(object sender, EventArgs e)
        {
           
        }
    }
}
