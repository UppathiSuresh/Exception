using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FirstWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public String con = "";
        public void exception(String a,String b)
        {
            try
            {
                //int val = 100;
                //int div = 0;
                if (a!=String.Empty && b != String.Empty ) {
                    String resultVal;
                    resultVal = (a + b);
                 
                    MessageBox.Show("result is : "+resultVal);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show( "argumentException  :  "+e.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception catch here - details  : " + e.ToString());
            }
            finally
            {
                MessageBox.Show("Sucessfully execute ");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                String str = textBox1.Text;
                String str1 = textBox2.Text;
                int i = Convert.ToInt32(textBox3.Text);
                int j = Convert.ToInt32(textBox4.Text);

                exception(str, str1);
            }
            catch 
            {

                MessageBox.Show("enter the valid stirng");
              //  throw;
            }
           
           
        }
    }
}
