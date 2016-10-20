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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            // Step 1 - Hide the parent form
            this.Hide();
            // Step 2 - Instantiate an object for the form type
            // you are going to next
            GenerateNameForm genrateNameForm = new GenerateNameForm();
            // Step 5 - Show the next form
            genrateNameForm.Show();

        }
    }
}
