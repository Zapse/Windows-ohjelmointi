using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info
{
    public partial class Form1 : Form
    {
        // alustetaan
        public string iceCream;
        RadioButton selectedrb;
        public Form1()
        {
            InitializeComponent();
            IntializeListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text + ": "+ iceCream + Environment.NewLine
                + " belongs to age group of : " + selectedrb.Text + Environment.NewLine
                + " he/she would like to live in : " + listBox1.SelectedItem.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //käytetään iceCream atribuuttia.
            if (checkBox1.Checked) iceCream = "likes ice cream";
            else iceCream = "doesn't like ice cream";
        }
       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // eventissä käyty lisäämässä jäljellä olevilla buttoneille checkedchanges ja viittaus radioButton1.
            RadioButton rb = sender as RadioButton;
            if (rb.Checked == true) selectedrb = rb;
        }

        private void IntializeListBox()
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.BeginUpdate();
            listBox1.Items.Add("Finland");
            listBox1.Items.Add("Sweden");
            listBox1.Items.Add("Norway");
            listBox1.Items.Add("Denmark");
            listBox1.EndUpdate();

            listBox1.SetSelected(1, true);

        }

        
    }
}
