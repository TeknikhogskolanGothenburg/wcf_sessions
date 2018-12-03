using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {
        SessionService.SessionServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new SessionService.SessionServiceClient();
        }

        private void btnGetCount_Click(object sender, EventArgs e)
        {
            lblCount.Text = "Service count: " + client.GetCount().ToString();
        }
    }
}
