﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Loop through people array,
//Assign n chores to one person
//Remove assigned chores from chores array
//Repeat until all chores assigned

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
            int p = 0;
            string person = peopleArray[p];
            //string rndChore;
            string[] selectedChores = checkedListBox1.CheckedItems.OfType<string>().ToArray();
            int choresPerPerson = selectedChores.Length / peopleArray.Length;
            int remainder = selectedChores.Length % peopleArray.Length;
            //Random rnd = new Random();



            for (int i = 0; i < selectedChores.Length; i++)
            {
                tb_Result.Text += peopleArray[p] + ": " + selectedChores[i] + " \t";
                p++;

                //If current p index gets to the end of the array, return to the beginning of the array:
                if (p >= peopleArray.Length)
                {
                    p = 0;
                }
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
