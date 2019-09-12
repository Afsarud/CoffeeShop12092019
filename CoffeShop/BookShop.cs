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
    public partial class BookShop : Form
    {
        public BookShop()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            resultRichTextBox.Text = "Customer Name: "+textBox1.Text + ", " +
                " " + "Contact Number: "+textBox2.Text + ", " +
                " " +"Your Address"+textBox3.Text+ "Order Amount: "+ orderComboBox.SelectedItem + ", " +
                " " + "Quantity Number: "+textBox4.Text+", " +
                " "+"Total Price"+Convert.ToInt32(orderComboBox.Text)* Convert.ToInt32(textBox4.Text);
        }
    }
}
