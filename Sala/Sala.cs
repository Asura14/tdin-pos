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
        private static Label label1;
        public SortedDictionary<string, double> menuList;
        public SortedDictionary<int, string> mesasList;
        public int[] quantityList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        static void Main()
        {
            Application.Run(new Sala());
        }

        public Sala()
        {
            //Inicializar Menu
            menuList = new SortedDictionary<string, double>();
            mesasList = new SortedDictionary<int, string>();
            populateComboMenus();

            InitializeComponent();
            comboBoxMenu.DataSource = new BindingSource(menuList, null);
            comboBoxMenu.DisplayMember = "Key";
            comboBoxMenu.ValueMember = "Value";
            comboBoxMesa.DataSource = new BindingSource(mesasList, null);
            comboBoxMesa.DisplayMember = "Value";
            comboBoxMesa.ValueMember = "Key";
            foreach (int type in quantityList)
            {
                comboBoxQuantidade.Items.Add(type);
            }
        }

        private void buttonPedir_Click(object sender, EventArgs e)
        {

        }

        public void populateComboMenus()
        {
            menuList.Add("Bacalhau com natas - 7.50€", 7.50);
            menuList.Add("Francesinha - 9.50€", 9.50);
            menuList.Add("Cocktail Mexicano - 3.50€", 3.50);
            menuList.Add("Caipirinha - 3.00€", 3.00);
            mesasList.Add(1, "Mesa 1");
            mesasList.Add(2, "Mesa 2");
            mesasList.Add(3, "Mesa 3");
            mesasList.Add(4, "Mesa 4");

        }
    }
}
