/// разработчик: Самаев Антон ИВТ-21

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Chat
{
    // форма для общения с чатботом
    public partial class Form_ChatBot : Form
    {
        ChatBotCS user;

        public Form_ChatBot()
        {
            InitializeComponent();

            user = new ChatBotCS();

            // справка
            ToolStripMenuItem aboutItem = new ToolStripMenuItem("Справка");


            // назначив обработчики для события Click, мы можем обработать нажатия на пункты меню
            //https://metanit.com/sharp/windowsforms/5.2.php
            aboutItem.Click += aboutItem_Click;
            Menu.Items.Add(aboutItem);

            // обработчик при закрытии форма
            FormClosing += new FormClosingEventHandler(Form2_Closing);

            KeyPreview = true;
        }

        // нажатие на справку
        void aboutItem_Click(object sender, EventArgs e)
        {
            textBox_out.Text += "Справка " + Environment.NewLine +
                "Возможности ЧатБота:" + Environment.NewLine +
                "1. Отвечает на приветствие(любое слово, которое начинается на 'прив')" + Environment.NewLine +
                "2. Показывает время(врем)" + Environment.NewLine +
                "3. Показывает дату(дат)" + Environment.NewLine +
                "4. Умеет складывать/умножать/вычитать/делить числа(прибавь число к числу/умножь/разность/раздели)" + Environment.NewLine;
        }

        // используется для передачи данных между формами
        public string Txt
        {
            get { return user.username_get(); }
            set { user.username_set(value); }
        }

        // отправка сообщений по кнопке
        private void button_send_Click(object sender, EventArgs e)
        {
            if (textBox_In.Text != "")
            {
                // сообщение пользователя  
                textBox_out.Text += textBox_In.Text + "(" + user.username_get() + ", " + DateTime.Now.ToString("T") + ")\n" + Environment.NewLine;
                // ответ чатбота
                textBox_out.Text += user.answer(textBox_In.Text) + Environment.NewLine + Environment.NewLine;
            }
            // очистка поля ввода
            textBox_In.Text = "";
        }

        // обработчик события при закрытии формы
        private void Form2_Closing(object sender, FormClosingEventArgs e)
        {
            string path = @"MyFile";
            // Символ @ перед строкой означает то, что escape-последовательности не обрабатываются.
            // http://microsin.net/programming/pc/csharp-before-string.html
            //Чтобы указать, что строковый литерал следует интерпретировать буквально.
            //Символ @ в этом случае определяет буквальный строковый литерал.
            //Простые escape-последовательности (например, "\\" для обратной косой черты),
            //шестнадцатеричные escape-последовательности (например, "\x0041" для прописной буквы A)
            //и escape-последовательности Юникода (например, "\u0041" для прописной буквы A) интерпретируются буквально.

            //string Text = textBox_out.Text;
            // сохранение истории
            //File.AppendAllText(path, Text);

            user.SaveToHist(textBox_out.Text);

            user.SaveToFile(path, user.get_hist());

            // закрытие первой невидимой формы(чтобы закрывалась и вся программа)
            Program.form_user.Close();
        }

        // обработчик события при загрузки формы
        private void Form2_Load(object sender, EventArgs e)
        {
            // название файла
            string path = @"MyFile";
            // проверка на существование файла
            if (File.Exists(path))
            {   

                // todo: store data inside bot
                // если файл сущесвует, то вывести из него данные в окно вывода
                //textBox_out.Text = File.ReadAllText(path);
                user.SaveToHist(File.ReadAllText(path));
                textBox_out.Text = user.get_hist();
                File.Delete(path);
            }
        }

        // горячая клавиша для отправки сообщения(enter)
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_send.PerformClick();
                // чтобы при нажатии на enter курсор в поле ввода оставался на первой строчке
                e.SuppressKeyPress = true;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_In.Text = "";
        }
    }
}
