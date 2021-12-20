using DatingApp.App.Messages;
using DatingApp.App.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatingApp.App.Forms
{
    public partial class MessagesForm : Form
    {
        public MessagesForm()
        {
            InitializeComponent();
            loadContent();
        }

        private void loadContent()
        {
            if (isAnyMessage())
            {
                panelMessageList.Visible = true;
                loadRecentMessagesList();
            }
            else
            {
                lblNoMessages.Visible = true;
                iconChatMessages.Visible = true;
            }
        }

        private void loadRecentMessagesList()
        {
            var bubbleList1 = new BubbleList("Ricardo Lopez", "Hello Tony! How are you? I called you yesterday!", DateTime.Now);
            var bubbleList2 = new BubbleList("Ricardo Lopez", "Hello Tony! How are you? I called you yesterday!", DateTime.Now);
            var bubbleList3 = new BubbleList("Ricardo Lopez", "Hello Tony! How are you? I called you yesterday!", DateTime.Now);
            var bubbleList4 = new BubbleList("Ricardo Lopez", "Hello Tony! How are you? I called you yesterday!", DateTime.Now);
            var bubbleList5 = new BubbleList("Ricardo Lopez", "Hello Tony! How are you? I called you yesterday!", DateTime.Now);
            var bubbleList6 = new BubbleList("Ricardo Lopez", "Hello Tony! How are you? I called you yesterday!", DateTime.Now);
            var bubbleList7 = new BubbleList("Ricardo Lopez", "Hello Tony! How are you? I called you yesterday!", DateTime.Now);
            bubbleList1.Dock = DockStyle.Top;
            bubbleList2.Dock = DockStyle.Top;
            bubbleList3.Dock = DockStyle.Top;
            bubbleList4.Dock = DockStyle.Top;
            bubbleList5.Dock = DockStyle.Top;
            bubbleList6.Dock = DockStyle.Top;
            bubbleList7.Dock = DockStyle.Top;
            panelMessageList.Controls.Add(bubbleList1);
            panelMessageList.Controls.Add(new Divider(Color.LightGray, DockStyle.Top, new Size(0, 1)));
            panelMessageList.Controls.Add(bubbleList2);
            panelMessageList.Controls.Add(new Divider(Color.LightGray, DockStyle.Top, new Size(0, 1)));
            panelMessageList.Controls.Add(bubbleList3);
            panelMessageList.Controls.Add(new Divider(Color.LightGray, DockStyle.Top, new Size(0, 1)));
            panelMessageList.Controls.Add(bubbleList4);
            panelMessageList.Controls.Add(new Divider(Color.LightGray, DockStyle.Top, new Size(0, 1)));
            panelMessageList.Controls.Add(bubbleList5);
            panelMessageList.Controls.Add(new Divider(Color.LightGray, DockStyle.Top, new Size(0, 1)));
            panelMessageList.Controls.Add(bubbleList6);
            panelMessageList.Controls.Add(new Divider(Color.LightGray, DockStyle.Top, new Size(0, 1)));
            panelMessageList.Controls.Add(bubbleList7);

        }

        private bool isAnyMessage()
        {
            return true;
        }
    }
}
