using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet_Practice
{
    public partial class Form1 : Form
    {
        MyLogic myLogic = new MyLogic();

        public Form1()
        {
            InitializeComponent();

            numeric_weight.Location = new Point(20, 40);
            numeric_weight.Maximum = 150;
            numeric_weight.Minimum = 20;
            numeric_weight.Value = 50;
            label_weight.Location = new Point(20, 20);
            label_weight.Text = "Вес";

            combo_type.Location = new Point(20, 100);
            combo_type.Items.AddRange(new string[] {"Сидячий", "Активный"});
            combo_type.SelectedIndex = 1;
            label_type.Location = new Point(20, 80);
            label_type.Text = "Тип жизни";

            radio_f.Location = new Point(20, 160);
            radio_f.Text = "Ж";
            radio_f.Size = new Size(30, radio_f.Size.Height);
            radio_f.Checked = true;
            radio_m.Location = new Point(80, 160);
            radio_m.Text = "М";
            label_sex.Location = new Point(50, 140);
            label_sex.Text = "Пол";

            button_push.Location = new Point(this.ClientSize.Width - button_push.Size.Width, this.ClientSize.Height - button_push.Size.Height);
            button_push.Text = "Внести";

            button_push.Click += Button_push_Click;
            
            this.Controls.AddRange(new System.Windows.Forms.Control[] {numeric_weight, combo_type, radio_f, radio_m, button_push, label_weight, label_type, label_sex});
        }

        public void Button_push_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.weight = (int)numeric_weight.Value;
            person.type = combo_type.SelectedItem.ToString();
            if (radio_m.Checked == true)
                person.sex = true;           
            else
                person.sex = false;

            if (myLogic.Button_Save(person))
                MessageBox.Show("Запись произошла успешно!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Ошибка записи!", "Статус", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
