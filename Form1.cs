using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb_words_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_result.Text = lb_words.SelectedItem.ToString();
        }

        private void ch_bold_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_bold.Checked == true)
            {
               
                txt_result.Font = new Font(txt_result.Font, txt_result.Font.Style | FontStyle.Bold);
            }
            else
            { 
                txt_result.Font = new Font(txt_result.Font, FontStyle.Regular);
            }
        }

        private void cb_italicize_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_italicize.Checked)
            {
                txt_result.Font = new Font(txt_result.Font, txt_result.Font.Style | FontStyle.Italic);
            }
            else
            {
                txt_result.Font = new Font(txt_result.Font, FontStyle.Regular);
            }
        }

        private void cb_underline_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_underline.Checked)
            {
                txt_result.Font = new Font(txt_result.Font, txt_result.Font.Style | FontStyle.Underline);
            }
            else
            {
                txt_result.Font = new Font(txt_result.Font, FontStyle.Regular);
            }
        }

        private void rb_blue_CheckedChanged(object sender, EventArgs e)
        {
            txt_result.ForeColor = Color.Blue;
        }

        private void rb_red_CheckedChanged(object sender, EventArgs e)
        {
            txt_result.ForeColor = Color.Red;
        }

        private void rb_green_CheckedChanged(object sender, EventArgs e)
        {
            txt_result.ForeColor = Color.Green;
        }
    }
}
