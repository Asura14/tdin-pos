using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sala
{
    public partial class Sala : Form
    {
        private IPedidos listaPedidos;
        private EventIntermediate inter;
        private Panel painelSalas;
        private Label label1;
        SortedDictionary<string, double> menuList;

        public Sala()
        {
            //Inicializar Menu
            menuList = new SortedDictionary<string, double>();
            menuList.Add("Bacalhau com natas - 7.50€", 7.50);
            menuList.Add("Francesinha - 9.50€", 9.50);
            menuList.Add("Cocktail Mexicano - 3.50€", 3.50);
            menuList.Add("Caipirinha - 3.00€", 3.00);
            InitializeComponent();
            comboBoxMenu.DataSource = new BindingSource(menuList, null);
            comboBoxMenu.DisplayMember = "Key";
            comboBoxMenu.ValueMember = "Value";
            
        }

        private void buttonPedir_Click(object sender, EventArgs e)
        {

        }

        static void Main()
        {
            Application.Run(new Sala());
        }
    }
}
