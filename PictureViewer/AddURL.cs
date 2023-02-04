using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class AddURL : Form
    {
        public string AdresUrl { get; set; }
        
        public AddURL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUrlAdres.Text==string.Empty)
            {
                MessageBox.Show("Podaj adress URL:","Błąd",MessageBoxButtons.OK);
                return;
            }
            AdresUrl=tbUrlAdres.Text;

            Close();
        }
    }
}
