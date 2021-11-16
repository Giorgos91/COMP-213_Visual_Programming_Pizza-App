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
        private const double SmallSizePrice = 5.50;
        private const double MediumSizePrice = 11.75;
        private const double LargeSizePrice = 15.00;
        private const int SmallFreeIng = 2;
        private const int MediumFreeIng = 3;
        private const int LargeFreeIng = 4;
        private const double IngredientsPrice = 0.75;

        
        int Count, numofIng, different;
        double totalCost = 0.0, BasicCost =0.0;
       
        public MainForm()
        {
            InitializeComponent();

            //Display(); 
        }

       /* private void Display()
        {
            RadioButton radioButton =new RadioButton();

            while ()


        }*/

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (SmallRadioButton.Checked)
            {

                BasicCost = SmallSizePrice;
                numofIng = SmallFreeIng;
                TotalCostTextBox.Text = SmallSizePrice.ToString("C");
                FreeTextBox.Text = SmallFreeIng.ToString();
                
            }
            else if (MediumRadioButton.Checked)
            {
                BasicCost = MediumSizePrice;
                numofIng = MediumFreeIng;
                TotalCostTextBox.Text = MediumSizePrice.ToString("C");
                FreeTextBox.Text = MediumFreeIng.ToString();
                
            }
            else if (LargeRadioButton.Checked)
            {
                BasicCost = LargeSizePrice;
                numofIng = LargeFreeIng;
                TotalCostTextBox.Text = LargeSizePrice.ToString("C");
                FreeTextBox.Text = LargeFreeIng.ToString();
            }
            totalCost = BasicCost;
            OrderButton.Visible = true;
            IngredientsGroupBox.Enabled = true;
        }

        private void PepperoniCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            double ExtraIngCost = 0.0;
            if (PepperoniCheckBox.Checked == true)
            {
                Count++;
            }
            else if (PepperoniCheckBox.Checked == false)
            {
                Count--;
            }
            if (Count > numofIng)
            {
                different = Count - numofIng;
                if (different > 0)
                {
                    ExtraIngCost = different * IngredientsPrice;
                }
                totalCost = BasicCost + ExtraIngCost;
            }
            else
            {
                totalCost = BasicCost;
            }
           
            TotalCostTextBox.Text = totalCost.ToString("C");
        }

        private void OnionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            double  ExtraIngCost = 0.0;
            if (OnionCheckBox.Checked == true)
            {
                Count++;
            }
            else if (OnionCheckBox.Checked == false)
            {
                Count--;
            }
            if (Count > numofIng)
            {
                different = Count - numofIng;
                if (different > 0)
                {
                    ExtraIngCost = different * IngredientsPrice;
                }
                totalCost = BasicCost + ExtraIngCost;
            }
            else
            {
                totalCost = BasicCost;
            }
            TotalCostTextBox.Text = totalCost.ToString("C");
        }

        private void MushroomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            double ExtraIngCost = 0.0;
            if (MushroomCheckBox.Checked == true)
            {
                Count++;
            }
            else if (MushroomCheckBox.Checked == false)
            {
                Count--;
            }
            if (Count > numofIng)
            {
                different = Count - numofIng;
                if (different > 0)
                {
                    ExtraIngCost = different * IngredientsPrice;
                }
                totalCost = BasicCost + ExtraIngCost;
            }
            else
            {
                totalCost = BasicCost;
            }
            TotalCostTextBox.Text = totalCost.ToString("C");
        }

        private void OlivesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            double  ExtraIngCost = 0.0;
            if (OlivesCheckBox.Checked == true)
            {
                Count++;
            }
            else if (OlivesCheckBox.Checked == false)
            {
                Count--;
            }
            if (Count > numofIng)
            {
                different = Count - numofIng;
                if (different > 0)
                {
                    ExtraIngCost = different * IngredientsPrice;
                }
                totalCost = BasicCost+ExtraIngCost;
            }
            else
            {
                totalCost = BasicCost;
            }
            TotalCostTextBox.Text = totalCost.ToString("C");
        }

        private void PineappleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            double  ExtraIngCost = 0.0;
            if (PineappleCheckBox.Checked == true)
            {
                Count++;
            }
            else if (PineappleCheckBox.Checked == false)
            {
                Count--;
            }
            if (Count > numofIng)
            {
                different = Count - numofIng;
                if (different > 0)
                {
                    ExtraIngCost = different * IngredientsPrice;
                }
                totalCost = BasicCost+ExtraIngCost;
            }
            else
            {
                totalCost = BasicCost;
            }
            TotalCostTextBox.Text = totalCost.ToString("C");
        }

        private void CheeseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            double  ExtraIngCost = 0.0;
            if (CheeseCheckBox.Checked == true)
            {
                Count++;
            }
            else if (CheeseCheckBox.Checked == false)
            {
                Count--;
            }
            if (Count > numofIng)
            {
                different = Count - numofIng;
                if (different > 0)
                {
                    ExtraIngCost = different * IngredientsPrice;
                }
                totalCost += ExtraIngCost;
            }
            else
            {
                totalCost = BasicCost;
            }
            TotalCostTextBox.Text = totalCost.ToString("C");
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            LargeRadioButton.Checked = false;
            SmallRadioButton.Checked = false;
            MediumRadioButton.Checked = false;

            CheeseCheckBox.Checked = false;
            PepperoniCheckBox.Checked = false;
            OnionCheckBox.Checked = false;
            MushroomCheckBox.Checked = false;
            OlivesCheckBox.Checked = false;
            PineappleCheckBox.Checked = false;
            OrderButton.Visible = false;
            
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
