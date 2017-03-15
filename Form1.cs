using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rjcTestVS2015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String strAnswer = "";
            label1.Text = "--------";
            label1.ForeColor = Color.Maroon;
            label1.BackColor = Color.DarkGray;
            label1.Font = new Font(label1.Font.Name, 12,System.Drawing.FontStyle.Italic |
                System.Drawing.FontStyle.Bold);

            
            
            strAnswer = System.Windows.Forms.MessageBox.Show("Testing", "This is to test installation", MessageBoxButtons.YesNoCancel).ToString();
            switch(strAnswer)
            {
                case "Yes":
                    label1.ForeColor = Color.Blue;
                    break;
                case "No":
                    label1.ForeColor = Color.Red;
                    break;
                case "Cancel":
                    label1.ForeColor = Color.LightCyan;
                    break;
                default:
                    label1.ForeColor = Color.Orange;
                    break;
            }


            label1.Text = "User Response: " + strAnswer;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();


            // this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button2.Enabled = false;
            listBox1.Items.Add(System.DateTime.Today.ToString());
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add(System.DateTime.Now.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = listBox1.Text;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String strSelectedText = listBox1.SelectedItem.ToString();
            treeView1.Nodes.Add(strSelectedText);
            button2.Enabled = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(treeView1.SelectedNode.Text.Length >= 19)
            {
                string strChildNode = treeView1.SelectedNode.Text.Substring(8, 11);
                treeView1.SelectedNode.Nodes.Add(strChildNode);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            this.toolTip1.Show("Test", this , 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !(timer1.Enabled);

            /* testClass = new GeneralClass();

            GeneralClass */

        }
    }
}
