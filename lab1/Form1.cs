using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IChairFactory chairFactory;
            switch (comboBox1.SelectedItem)
            {
                case "Wooden":
                    chairFactory = new WoodenChairFactory();
                    break;
                case "Metal":
                    chairFactory = new MetalChairFactory();
                    break;
                case "Plastic":
                    chairFactory = new PlasticChairFactory();
                    break;
                default:
                    MessageBox.Show("Please select a material for the chair.");
                    return;
            }

            IChair chair = chairFactory.CreateChair();
            chair.Sit();
        }
    }
}
