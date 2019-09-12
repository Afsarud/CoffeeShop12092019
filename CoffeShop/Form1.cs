using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object ComboBox1 { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Text = "Customer Name: "+ CusNameTextBox.Text + "," +
                " "+ "Contact Number: " + contactTextBox.Text+ "," +
                " " + "Address: " + addressTextBox.Text+ ", " +
                " " +"Order Amount:" + orderComboBox.SelectedItem + " ," +
                " " +"Quantity Value: " + quantityTextBox.Text+ " ," +
                " " + "Total Price: "+Convert.ToInt32( orderComboBox.SelectedItem)* Convert.ToInt32(quantityTextBox.Text);
        }
    }
}
