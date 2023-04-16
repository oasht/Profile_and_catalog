using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace User_profile__catalog
{
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Editor Editor = new Editor();
            Editor.Text = "Добавить";
            if (Editor.ShowDialog() == DialogResult.OK)
            {
                Good tmp = new Good() { Name = Editor.T_name, Country = Editor.T_counry, Price = Editor.T_price };
                listBox1.Items.Add(tmp);
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            Editor Editor = new Editor();
            Editor.Text = "Редактирование";
            if (listBox1.SelectedItem != null)
            {
                Good tmp2 = new Good();
                tmp2 = (Good)listBox1.SelectedItem;

                Editor.T_name = tmp2.Name;
                Editor.T_counry = tmp2.Country;
                Editor.T_price = tmp2.Price;
                if (Editor.ShowDialog() == DialogResult.OK)
                {
                    if (listBox1.SelectedIndex != -1) listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    Good tmp1 = new Good() { Name = Editor.T_name, Country = Editor.T_counry, Price = Editor.T_price };
                    listBox1.Items.Add(tmp1);
                }

            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex != -1) listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Good>));
                SaveFileDialog save = new SaveFileDialog();
                try
                {
                    List<Good> tmp2 = new List<Good>();
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        tmp2.Add((Good)listBox1.Items[i]);
                    }
                    save.Filter = "Text Files(*.xml)|*.xml||";
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        Stream fs = File.Create(save.FileName);
                        xs.Serialize(fs, tmp2);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Список пуст");
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Good>));
            List<Good> p_new = null;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Files(*.xml)|*.xml||";//All Files(*.*)|*.*| 
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (Stream fs = File.OpenRead(open.FileName))
                {
                    p_new = (List<Good>)xs.Deserialize(fs);
                }
                listBox1.Items.AddRange(p_new.ToArray());
            }
        }
    }
}
