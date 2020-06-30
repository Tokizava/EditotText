using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorText
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var color_top = comboBox1.Text;
            var color_main = comboBox2.Text;

            //InitializeComponent();
            var main = new Form1();
            switch (color_top)
            {
                case "LightSteel":

                    break;
                case "Inactive":

                    break;
                case "Black":

                    break;
                case "White":

                    break;
            }

            switch (color_main)
            {
                case "LightSteel":
                    this.BackColor = Color.LightSteelBlue;
                    main.richTextBox1.BackColor = Color.LightSteelBlue;
                    break;
                case "Inactive":
                    this.BackColor = Color.FromArgb(177, 197, 223);
                    main.richTextBox1.BackColor = Color.FromArgb(177, 197, 223);
                    break;
                case "Black":
                    this.BackColor = Color.Black;
                    //main.BackColor = Color.Black;
                    //main.richTextBox1.BackColor = Color.Black;
                    main.richTextBox1.BackColor = Color.Black;
                    break;
                case "White":
                    this.BackColor = Color.White;
                    //main.BackColor = Color.White;
                    main.richTextBox1.BackColor = Color.White;
                    break;
            }
        }
    }
}
