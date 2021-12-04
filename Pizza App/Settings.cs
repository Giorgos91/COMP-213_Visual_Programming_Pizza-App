using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Pizza_App
{
    public partial class Settings : Form
    {
        public List<Toppings> pizzaToppings = new List<Toppings>();
        public List<Size> pizzaSize = new List<Size>();

        const string pizzaSizeFile = "PizzaSizeFile_json";
        const string pizzaToppingsFile = "PizzaToppingsFile_json";

        public Settings()
        {
            InitializeComponent();
            initializeIng();
            initializeSize();
        }
       
        private void initializeSize()
        {
            pizzaSize.Add(new Size("Small", 5.50,2));
            pizzaSize.Add(new Size("Medium", 11.75, 3));
            pizzaSize.Add(new Size("Large", 15.00, 4));
            pizzaSize.Add(new Size("XLarge", 18.50, 5));
        }

        public void initializeIng()
        {
            pizzaToppings.Add(new Toppings("Mushroom",0.70));
            pizzaToppings.Add(new Toppings("Pepper",0.90));
            pizzaToppings.Add(new Toppings("Onion",0.50));
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            toppingsDataGridView.DataSource = new BindingList<Toppings>(pizzaToppings);
            SizeDataGridView.DataSource = new BindingList<Size>(pizzaSize);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (sender== saveButtonSize)
            {
                var jsonSize = JsonConvert.SerializeObject(pizzaSize);
                System.IO.File.WriteAllText(pizzaSizeFile, jsonSize, Encoding.UTF8);
                MessageBox.Show("Successfully saved the Pizza Sizes.", "Success", MessageBoxButtons.OK);
            }
            else
            {
                var jsonToppings= JsonConvert.SerializeObject(pizzaToppings);
                System.IO.File.WriteAllText(pizzaToppingsFile, jsonToppings, Encoding.UTF8);
                MessageBox.Show("Successfully saved the Pizza Sizes.", "Success", MessageBoxButtons.OK);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (sender == resetButtonSize)
            {
                if (System.IO.File.Exists(pizzaSizeFile))
                {
                    var jsonString = System.IO.File.ReadAllText(pizzaSizeFile);
                    pizzaSize = JsonConvert.DeserializeObject<List<Size>>(jsonString);
                }
                else
                {
                    pizzaSize.Clear();
                }
                SizeDataGridView.DataSource = new BindingList<Size>(pizzaSize);
            }
            else
            {
                if (System.IO.File.Exists(pizzaToppingsFile))
                {
                    var jsonString = System.IO.File.ReadAllText(pizzaToppingsFile);
                    pizzaToppings = JsonConvert.DeserializeObject<List<Toppings>>(jsonString);
                }
                else
                {
                    pizzaToppings.Clear();
                }
                toppingsDataGridView.DataSource = new BindingList<Toppings>(pizzaToppings);
            }
        }
    }
}

