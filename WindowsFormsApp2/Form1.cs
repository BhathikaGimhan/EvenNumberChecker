using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmittonButton_Click(object sender, EventArgs e)
        {
            try
            {
                //int i = Convert.ToInt32(this.Input.Text);
                ListView.Items.Clear();
                int tryInt;
                var returnVal=int.TryParse(this.Input.Text, out tryInt);
                if (returnVal)
                {
                    int j = 1;
                    int i = Convert.ToInt32(this.Input.Text);
                    int val = 0;
                    while (j <= i)
                    {
                        if(j % 2 == 0)
                        {
                            ListView.Items.Add(j.ToString());
                            val++;
                        }
                        
                        j++;
                    }
                    Number.Text = val.ToString();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
