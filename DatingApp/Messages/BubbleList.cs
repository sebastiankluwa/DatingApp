using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatingApp.App.Messages
{
    public partial class BubbleList : UserControl
    {
        public BubbleList()
        {
            InitializeComponent();
        }

        public BubbleList(string username, string message, DateTime dateSent)
        {
            InitializeComponent();
            lblUsername.Text = username;
            lblText.Text = message;
            lblTimeSent.Text = dateSent.ToString("hh:mm tt");
        }

        private void bubble_Load(object sender, EventArgs e)
        {

        }
    }
}
