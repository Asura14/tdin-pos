using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal
{
    public partial class Terminal : Form
    {
        public Terminal()
        {
            InitializeComponent();
        }

        [STAThread]
        static void Main()
        {
            Application.Run(new Terminal());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form cozinha = new CozinhaBar(0);
            this.Hide();
            cozinha.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form bar = new CozinhaBar(1);
            this.Hide();
            bar.ShowDialog();
            this.Close();
        }
    }
}
