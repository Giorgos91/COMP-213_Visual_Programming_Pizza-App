using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_App
{
    public partial class MainForm : Form
    {
        Settings settings = new Settings();

        int Count=0, numofIng, different;
        double totalCost = 0.0, BasicCost =0.0;
       
        public MainForm()
        {
            InitializeComponent();
            DisplayToppings();
            DisplaySize();
        }
        /*<sumary>
           The DisplaySize(), filling the flaw layout panel withe the size of the pizzas.
        </sumary>*/
       
        private void DisplaySize()
        {
            sizeFlowLayoutPanel.Controls.Clear();
            foreach (var size in settings.pizzaSize)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Text = size.name;
                radioButton.Tag = size;
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
                sizeFlowLayoutPanel.Controls.Add(radioButton);
            }
        }
        /*<sumary>
          The DisplayToppings(), filling the flaw layout panel withe the toppings of the pizzas.
       </sumary>*/
        private void DisplayToppings()
        {
            ingFlowLayoutPanel.Controls.Clear();          
            foreach (var toppings in settings.pizzaToppings)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = toppings.name;
                checkBox.Tag = toppings;
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                ingFlowLayoutPanel.Controls.Add(checkBox);
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (sender as CheckBox);
            double ExtraIngCost = 0.0;

            
            if (checkBox.Checked == true)
            {
                Count++;
            }
            else if (checkBox.Checked == false)
            {
                Count--;
            }

            
            if (Count > numofIng)
            {
                different = Count - numofIng;
                if (different > 0)
                {
                    ExtraIngCost = different * 0.75;
                }
                totalCost = BasicCost + ExtraIngCost;
            }
            else
            {
                totalCost = BasicCost;
            }

            TotalCostTextBox.Text = $"€ {totalCost.ToString()}";

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = (sender as RadioButton);
            var size = radioButton.Tag as Size;
            numofIng = size.freeIng;
            BasicCost = size.price;
            totalCost = BasicCost;
            TotalCostTextBox.Text = $"€ {totalCost.ToString()}";
            FreeTextBox.Text = size.freeIng.ToString();
            totalCost = BasicCost;
            OrderButton.Visible = true;
            IngredientsGroupBox.Enabled = true;
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.ShowDialog();
            DisplaySize();
            DisplayToppings();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplaySize();
            DisplayToppings();
            Count = 0;
            IngredientsGroupBox.Enabled = false;
            FreeTextBox.Text = "";         
            TotalCostTextBox.Text = "";

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            var time24 = DateTime.Now.TimeOfDay.ToString();
            CurrentTimeMaskedTextBox.Text = time24;

            bool parse;

            parse = TimeSpan.TryParse(TimeMaskedTextBox.Text, out TimeSpan deliveryTime);
            
            if (parse)
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show($"The total for your pizza is {totalCost.ToString("C")}, the delivery time is {TimeMaskedTextBox.Text}.\n Are you sure you want to order?",
                                "ORDER", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("The order is successful", "ORDER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("The order was cancelled", "ORDER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Bad Format", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
