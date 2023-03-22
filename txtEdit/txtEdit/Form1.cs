using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace txtEdit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\ucenik\Documents\Raul Dominik Holik\txtEdit\" + txtPutanja + " .txt";

            try
            {

                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(txtBx.Text);
                    fs.Write(info, 0, info.Length);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }



        private void btnOtvori_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\ucenik\Documents\Raul Dominik Holik\txtEdit\" + txtPutanja + " .txt";

            try
            {

                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(txtBx.Text);
                    fs.Write(info, 0, info.Length);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPutanja_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOtv_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\ucenik\Documents\Raul Dominik Holik\txtEdit\" + txtPutanja + " .txt";

            try
            {

                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(txtBx.Text);
                    fs.Write(info, 0, info.Length);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
