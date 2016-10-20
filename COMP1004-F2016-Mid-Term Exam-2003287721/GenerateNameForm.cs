using System;
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
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
            GenerateName();
        }
        static Random rnd = new Random();
        public void GenerateName()
        {
            int F = rnd.Next(FirstNameListBox.Items.Count);
            int L = rnd.Next(LastNameListBox.Items.Count);
            FirstNameBox.Text = FirstNameListBox.Items[F].ToString();
            LastNameBox.Text = FirstNameListBox.Items[L].ToString();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateName();
            Character character = Program.character;
            character.FirstName = FirstNameBox.Text;
            character.LastName = LastNameBox.Text;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // Step 1 - Hide the parent form
            this.Hide();
            // Step 2 - Instantiate an object for the form type
            // you are going to next
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            // Step 5 - Show the next form
            abilityGeneratorForm.Show();
        }
    }
}
