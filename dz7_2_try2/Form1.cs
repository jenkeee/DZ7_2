using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace dz7_2_try2
{
    public partial class Form1 : Form
    {
        // я нарисовал форму и придумал как будет выглядеть игра, начал описывать методы для текстбокса и понял что хочу начать с переменных писать код

        bool isGame = false; // переменная игра // по умолчанию пусть будет выключена 
        int CompNum; // число которое загадал комп
        int UserNum; // число пользователя
        int steps; // попытка угадать число
        int lowNUM = 0;
        int upNUM = 100;

        // нам потребуеться нарисовать форму на другом слое у нас же isGame false

        private void topmenubtnPause_Click(object sender, EventArgs e) // событие кнопки пауза
        {
             game_wrapper.Visible = false;
            pause_wrapper.Visible = true;
            menu_wrapper.Visible = false; //  Main_menu_layout.Visible = false; полностью уберет и кнопку и форму
        }

        private void Main_menu_forms_Click(object sender, EventArgs e) // 
        {
           // Application.Exit();
            
        }

        private void Main_menu_layout_Click(object sender, EventArgs e) // вызываем главное меню
        {
            game_wrapper.Visible = false;
            pause_wrapper.Visible = false;
            menu_wrapper.Visible = true;
        }

        private void Exit() // опишем метод для выхода
        {
            if (MessageBox.Show("Вы уверены что хотите выйти?", "ur weak", // выводим месадж бокс с подтверждением на выход
            MessageBoxButtons.YesNo) == DialogResult.Yes) // если да
            {
                this.Close();         // закрываем app 
            }
            else MessageBox.Show("Передумал выходить");   //если нет, будет месаджбокс, он тут не очень нужен
        }


        public void topmenubtn_Exit_Click(object sender, EventArgs e) // кнопка выхода топ меню
        {
            Thread.Sleep(3000);
            Application.Exit();
            // Exit();
        }


        /// ////////////////////////////// решил описать слой пауза, потом сделаю ненужное главное меню слоями или не сделаю ////////////////////////

        private void btnExit_Click(object sender, EventArgs e) // у нас уже есть метод выхода
        {
            Exit();
        }

        private void btnContinue_Click(object sender, EventArgs e) // событие кнопки продолжить на меню пауза
        {
            game_wrapper.Visible = !isGame;
            pause_wrapper.Visible = isGame;
            menu_wrapper.Visible = isGame;
        }

        private void NewGame() {
            Random rnd = new Random();
            CompNum = rnd.Next(1, 100);
            steps = 1;
            label1.Text = "Введите число от 1 до 100";
            textBox1.Enabled = true;
            btnTakeAnswer.Enabled = true; //проверим enter
            //// убераю слой
            game_wrapper.Visible = true;
            pause_wrapper.Visible = isGame;
            menu_wrapper.Visible = isGame;
            //label2.Text = "0";
            taked.Text = "";
            shlam2 = null;
            textBox1.Text = "";
            lowNUM = 0;
            upNUM = 100;

        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exit();            
        }
        // ///////////////////////////////////////мы получили число от компа CompNum теперь можно сравнивать число пользователя с компом 
        string shlam2; // обязательно объявляем  до метода , иначе просто перезапишет. // работает но не валидно
        private void checkTHIS()
        {
            string shlam = textBox1.Text;
            string ltransformLabel2 = "Человек предоставил для сравнения число :"; // 
            taked.Text = "";
           
            if (int.TryParse(textBox1.Text, out int userAnswer)) // на ходу объявили переменную и дали ей значение текстбокса если оно есть
            {
                if (userAnswer == CompNum)
                {
                    label3.Text = $"Поздравляю! Это правильный ответ.\nВам потребовалось {steps} попыток.";
                    textBox1.Enabled = false; // мы выиграли отключаем на ввод
                    btnTakeAnswer.Enabled = false;
                }
                //else if (userAnswer < CompNum) lowNUM = userAnswer;
                //else if (userAnswer > CompNum) upNUM = userAnswer;
                else if (userAnswer < CompNum)
                {
                    steps++;
                    label3.Text = $"Попытка {steps}. Не верный ответ.\nЗагаданное число больше.";
                    label2.Text = userAnswer.ToString();
                    shlam2 = taked.Text;
                    shlam2 = $"{shlam2}\n{shlam}";
                    taked.Text = shlam2;
                    if (userAnswer > lowNUM && userAnswer < CompNum)
                    { lowNUM = userAnswer; }
                }
                else if (userAnswer > CompNum)
                {
                    steps++;
                    label3.Text = $"Попытка {steps}. Не верный ответ.\nЗагаданное число меньше.";
                    label2.Text = ltransformLabel2 + " " + userAnswer.ToString();
                    //shlam2 = shlam2 + shlam;
                    //shlam2 = taked.Text;
                    shlam2 = $"{shlam2}\n{shlam}";
                    taked.Text = shlam2;
                    if (userAnswer < upNUM && userAnswer > CompNum)
                    { upNUM = userAnswer; }
                }               
            }
            else
            {
                label3.Text = $"попытка не засчитана\nВведите число от 1 до 100 \n<<{shlam}>> не число";
                //label2.Text = label2.Text + " " + userAnswer.ToString();
            }            
            textBox1.Text = "";
        }



        public Form1()  // это точка входа 
        {
            InitializeComponent();
            textBox1.Enabled = false; // мы выиграли отключаем на ввод
            btnTakeAnswer.Enabled = false;
            game_wrapper.Visible = false;
            pause_wrapper.Visible = false;
            menu_wrapper.Visible = true;
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e) // описываем подписанное событие для текс бокса кей даун
        { 
            if(e.KeyCode == Keys.Enter) // если клавиша ентер
            {
                checkTHIS(); // вызываем метод чекансвер
            }
        }

        private void btnTakeAnswer_Click(object sender, EventArgs e)
        {
            checkTHIS();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void takeHelp_Click(object sender, EventArgs e)
        {
           MessageBox.Show($"Ваше число в диапазоне от {lowNUM} до {upNUM}");
        }


        //2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное
        //число попыток.Компьютер говорит, больше или меньше загаданное число введенного.

    }
}
