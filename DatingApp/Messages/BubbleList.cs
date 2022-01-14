using Local.DTOs.Messages;
using Local.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Local.DTOs;
using Local.Properties;

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

        public BubbleList(MemberDto user, string username, string knownAs, string message, DateTime dateSent, MessageDto? messageDto)
        {
            InitializeComponent();
            Username = username;
            lblUsername.Text = knownAs;
            lblText.Text = message;
            Message = message;
            lblTimeSent.Text = dateSent.ToString("hh:mm tt");

            userPicture.Image = string.IsNullOrEmpty(user.PhotoUrl)
                ? userPicture.Image = Resources.avatar
                : GetImage(user.PhotoUrl);
            
            MessageDto = messageDto;
        }

        private Image GetImage(string photoUrl)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(photoUrl);
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);

            return img;
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
