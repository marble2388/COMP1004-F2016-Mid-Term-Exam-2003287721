﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_Exam_2003287721
{
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
            Character character = Program.character;
            FirstNameBox.Text = character.FirstName;
            LastNameBox.Text = character.LastName;
            StrengthTextBox.Text = character.Strength;
            DexterityTextBox.Text = character.Dexterity;
            ConstitutionTextBox.Text = character.Constitution;
            IntelligenceTextBox.Text = character.Intelligence;
            WisdomTextBox.Text = character.Wisdom;
            CharismaTextBox.Text = character.Charisma;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
