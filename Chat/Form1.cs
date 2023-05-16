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
    // форма используется для ввода имени пользователя
    public partial class Form_username : Form
    {
        public Form_username()
        {
            Program.form_user = this; // теперь form_user будет ссылкой на форму Form_username
            InitializeComponent();
            KeyPreview = true;
        }

        // при нажатии на кнопку "ввод"
        private void button_username_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form_ChatBot();
            form2.Show();
            
            if (this.textBox_username.Text != "")
            {
                // передача второй форме имени пользователя
                form2.Txt = this.textBox_username.Text;
            }
            // если не введено имя, устанавливается имя по умолчанию
            else form2.Txt = "NoName";
        }

        // ввод имени при нажатии на enter
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_username.PerformClick();
            }
        }
    }
}
