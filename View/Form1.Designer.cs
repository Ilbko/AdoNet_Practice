using System.Windows.Forms;

namespace AdoNet_Practice
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 250);
            this.Text = "Form1";

            numeric_weight = new NumericUpDown();
            combo_type = new ComboBox();
            radio_f = new RadioButton();
            radio_m = new RadioButton();
            button_push = new Button();
            label_weight = new Label();
            label_type = new Label();
            label_sex = new Label();
        }
        NumericUpDown numeric_weight;
        ComboBox combo_type;
        RadioButton radio_m;
        RadioButton radio_f;
        Button button_push;
        Label label_weight;
        Label label_type;
        Label label_sex;

        #endregion
    }
}

