using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_68_part_2_partial
{
    public partial class Form1 : Form           // Разделённый класс. Эта часть отвечает за функциональную часть
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки
        {
            MessageBox.Show("Forma");
        }
    }
}
