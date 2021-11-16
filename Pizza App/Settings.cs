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
    public partial class Settings : Form
    {
        public  List<Toppings> pizzaToppings = new List<Toppings>();
        public List<Size> pizzaSize = new List<Size>();

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
            pizzaToppings.Add(new Toppings("Mushroom", 0.75));
            pizzaToppings.Add(new Toppings("Pepper", 1.25));
            pizzaToppings.Add(new Toppings("Onion", 1));
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            IngreedientsDataGridView.DataSource = new BindingList<Toppings>(pizzaToppings);
            SizeDataGridView.DataSource = new BindingList<Size>(pizzaSize);

        }
    }
}

