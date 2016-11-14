using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vavatech.WPF.WinFormsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World!";
        }


        private string firstname = "Marcin";


        //  label1.BackgroundColor  = person.Address.City

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = firstname;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            firstname = label1.Text;
        }
    }
}
