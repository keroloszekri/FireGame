using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace project2
{
    public partial class Form2 : Form
    {
        
        public Keys charMoveRight;
        public Keys charMoveleft;
        public Keys charfire;
        Form1 nf;
        public Form2( Form1 f1)
        {
            nf = f1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try {
                comboBox1.DataSource = Enum.GetValues(typeof(Keys));
                comboBox2.DataSource = Enum.GetValues(typeof(Keys));
                comboBox3.DataSource = Enum.GetValues(typeof(Keys));
                comboBox1.SelectedIndex = Properties.Settings.Default.rin;
                comboBox2.SelectedIndex = Properties.Settings.Default.lin;
                comboBox3.SelectedIndex = Properties.Settings.Default.fin;
                Enum.TryParse<Keys>(comboBox1.SelectedValue.ToString(), out charMoveRight);
                Enum.TryParse<Keys>(comboBox2.SelectedValue.ToString(), out charMoveleft);
                Enum.TryParse<Keys>(comboBox3.SelectedValue.ToString(), out charfire);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                Close();
                nf.Form2IsOpen = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Properties.Settings.Default.Reset();
                charMoveRight = (Keys)comboBox1.SelectedItem;
                Properties.Settings.Default.rin = comboBox1.SelectedIndex;
                charMoveleft = (Keys)comboBox2.SelectedItem;
                Properties.Settings.Default.lin = comboBox2.SelectedIndex; ;
                charfire = (Keys)comboBox3.SelectedItem;
                Properties.Settings.Default.fin = comboBox3.SelectedIndex;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
                MessageBox.Show("Setting Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show( " RIGHT : "+charMoveRight.ToString());
                MessageBox.Show( " LEFT : " + charMoveleft.ToString());
                MessageBox.Show( " FIRE : " + charfire.ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            nf.Form2IsOpen = false;
        }
    }
}
