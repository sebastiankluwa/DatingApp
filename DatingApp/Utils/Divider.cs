using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatingApp.App.Utils
{
    public partial class Divider : UserControl
    {
        public Divider(Color color, Size size)
        {
            InitializeComponent();
            Size = size;
            BackColor = color;
        }

        private void Divider_Load(object sender, EventArgs e)
        {

        }
    }
}
