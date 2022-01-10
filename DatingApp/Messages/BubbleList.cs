using Local.DTOs.Messages;
using Local.Forms;
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
        Color _defaultBackColor;

        public Color DefaultBackColor {
            get 
            { 
                return _defaultBackColor; 
            }
            set 
            {
                _defaultBackColor = value;
                this.BackColor = value;
            }
        }

        public string Username { get; set; }
        public string KnownAs{ get; set; }

        public string Message { get; set; }
        public MessageDto MessageDto { get; set; }

        public BubbleList()
        {
            InitializeComponent();
        }

        public BubbleList(string username, string knownAs, string message, DateTime dateSent, MessageDto? messageDto)
        {
            InitializeComponent();
            Username = username;
            lblUsername.Text = knownAs;
            lblText.Text = message;
            Message = message;
            lblTimeSent.Text = dateSent.ToString("hh:mm tt");
            MessageDto = messageDto;
        }

        private void BubbleListMouseLeave(object sender, EventArgs e)
        {
            this.BackColor = this.DefaultBackColor;
        }

        private void BubbleListMouseEnter(object sender, EventArgs e)
        {

        }

        private void BubbleListMouseHover(object sender, EventArgs e)
        {
            this.BackColor = ControlPaint.Light(this.DefaultBackColor);

        }

        private void BubbleList_Load(object sender, EventArgs e)
        {

        }
    }
}
