using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_profile__catalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            Profile Profile = new Profile();
            Profile.ShowDialog();
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            Catalog Catalog = new Catalog();
            Catalog.ShowDialog();
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
