using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Guessing_Game
{
    

    public partial class Form1 : Form
    {
        Random random = new Random();

        int number = 0;
        int guess = 0;



        public Form1()
        {
            InitializeComponent();

            LoadQuestions();
        }

        private void CheckNumber(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtEnterNumber.Text);

            guess += 1;
            lblGuess.Text = $"Количество попыток: {guess}";

            if (i == number)
            {
                MessageBox.Show("Круто! Ты угадал число. Попробуй еще");
                LoadQuestions();
                txtEnterNumber.Text = "";
                guess = 0;
                lblGuess.Text = $"Количество попыток: {guess}";
            }
            else if (i > number)
            {
                MessageBox.Show("Слишком большое!");
                
            }
            else if (i < number)
            {
                MessageBox.Show("Слишком маленькое!");
                
            }

        }

        private void LoadQuestions()
        {
            number = random.Next(0, 100);

            lbmQuetion.Text = " Я загадал число между 0 и 100 ";
        }


    }
}
