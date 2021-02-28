using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNet_Practice.Control;

namespace AdoNet_Practice
{
    public partial class Form1 : Form
    {
        MyLogic myLogic = new MyLogic();

        public Form1()
        {
            InitializeComponent();

            numeric_weight.Location = new Point(20, 20);

            combo_type.Location = new Point(20, 100);

            radio_f.Location = new Point(20, 200);
            radio_f.Text = "Ж";
            radio_f.Size = new Size(30, radio_f.Size.Height);
            radio_m.Location = new Point(80, 200);
            radio_m.Text = "М";

            button_push.Location = new Point(this.ClientSize.Width - button_push.Size.Width, this.ClientSize.Height - button_push.Size.Height);

            button_push.Click += Button_push_Click;
            

            this.Controls.AddRange(new System.Windows.Forms.Control[] { numeric_weight, combo_type, radio_f, radio_m, button_push });
        }

        public void Button_push_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
