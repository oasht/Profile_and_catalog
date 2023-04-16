using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace User_profile__catalog
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            bt_show.Enabled = false;
            
        }
        Regex regex = new Regex("[0-9!@#$%^&*+/=(){}\\][_-]*");
        public List<string> City(string str)
        {
            List<string> Russia = new List<string> { "Москва", "Санкт-Петербург", "Красноярск", "Новосибирск"};
            List<string> England = new List<string> { "Лондон", "Кембридж", "Ливерпуль", "Манчестер","Лидс"};
            List<string> Germany = new List<string> { "Берлин", "Гамбург","Кёльн", "Мюнхен", "Дрезден" };
            List<string> USA = new List<string> { "Нью-Йорк", "Вашингтон", "Майами", "Лос Анжелес", "Питтсбург" };

            if (str == "Россия")
            {
                return Russia;
            }
            else if (str == "Англия")
            {
                return England;
            }
            else if (str == "Германия")
            {
                return Germany;
            }
            else if (str == "США")
            {
                return USA;
            }
            else return null;
        }
        private void cb_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_city.Items.Clear();
            cb_city.Text = null;
            cb_city.Items.AddRange(City(cb_country.SelectedItem.ToString()).ToArray());
            string str_country=cb_country.SelectedItem.ToString();
        }

        private void rb_female_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb=(RadioButton)sender;
            if (rb.Checked) { }
        }

        private void bt_show_Click(object sender, EventArgs e)
        {
            string str = "Анкета:\n---------------\n";
            str += $"{lb_ln.Text}: \t{tb_ln.Text}\n";
            str += $"{lb_fn.Text}: \t\t{tb_fn.Text}\n";
            str += $"{lb_pn.Text}: \t{tb_pn.Text}\n";
            str += $"{lb_cn.Text}: \t\t{cb_country.Text}\n";
            str += $"{lb_ct.Text}: \t\t{cb_city.Text}\n";
            str += $"{lb_tel.Text}: \t{mtb_phone.Text}\n";
            str += $"{lb_gen.Text}: \t\t{(rb_male.Checked ? rb_male.Text : rb_female.Text)}\n";
            MessageBox.Show(str);
        }

        

        private void Profile_MouseEnter(object sender, EventArgs e)
        {
            if (tb_ln.Text != string.Empty && tb_fn.Text != string.Empty && cb_country.Items.Contains(cb_country.Text) &&
             cb_city.Items.Contains(cb_city.Text) && mtb_phone.MaskCompleted
             && mtb_phone.MaskFull && (rb_male.Checked || rb_female.Checked))
            {
                bt_show.Enabled = true;
            }
            else
            {
                bt_show.Enabled = false;
            }
        }

        private void bt_escape_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_ln_TextChanged(object sender, EventArgs e)
        {
          
            string str = regex.Replace(tb_ln.Text, "");
            tb_ln.Text = str;
           
            
        }

        private void tb_fn_TextChanged(object sender, EventArgs e)
        {
            string str = regex.Replace(tb_fn.Text, "");
            tb_fn.Text = str;
        }

        private void tb_pn_TextChanged(object sender, EventArgs e)
        {
            string str = regex.Replace(tb_pn.Text, "");
            tb_pn.Text = str;
        }
    }
}
