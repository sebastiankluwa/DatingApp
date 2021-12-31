
namespace DatingApp.App.Forms
{
    partial class MessagesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMessageList = new System.Windows.Forms.Panel();
            this.flowMessageList = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoMessages = new System.Windows.Forms.Label();
            this.panelMessageChat = new System.Windows.Forms.Panel();
            this.iconChatMessages = new FontAwesome.Sharp.IconPictureBox();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.panelMessageList.SuspendLayout();
            this.panelMessageChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChatMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMessageList
            // 
            this.panelMessageList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(239)))));
            this.panelMessageList.Controls.Add(this.flowMessageList);
            this.panelMessageList.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMessageList.Location = new System.Drawing.Point(444, 0);
            this.panelMessageList.Margin = new System.Windows.Forms.Padding(0);
            this.panelMessageList.Name = "panelMessageList";
            this.panelMessageList.Size = new System.Drawing.Size(356, 450);
            this.panelMessageList.TabIndex = 0;
            this.panelMessageList.Visible = false;
            // 
            // flowMessageList
            // 
            this.flowMessageList.AutoScroll = true;
            this.flowMessageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMessageList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMessageList.Location = new System.Drawing.Point(0, 0);
            this.flowMessageList.Margin = new System.Windows.Forms.Padding(0);
            this.flowMessageList.Name = "flowMessageList";
            this.flowMessageList.Size = new System.Drawing.Size(356, 450);
            this.flowMessageList.TabIndex = 0;
            this.flowMessageList.WrapContents = false;
            // 
            // lblNoMessages
            // 
            this.lblNoMessages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoMessages.AutoSize = true;
            this.lblNoMessages.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.lblNoMessages.Location = new System.Drawing.Point(153, 262);
            this.lblNoMessages.Name = "lblNoMessages";
            this.lblNoMessages.Size = new System.Drawing.Size(152, 21);
            this.lblNoMessages.TabIndex = 0;
            this.lblNoMessages.Text = "No messages yet...";
            this.lblNoMessages.Visible = false;
            // 
            // panelMessageChat
            // 
            this.panelMessageChat.Controls.Add(this.lblNoMessages);
            this.panelMessageChat.Controls.Add(this.iconChatMessages);
            this.panelMessageChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessageChat.Location = new System.Drawing.Point(0, 0);
            this.panelMessageChat.Name = "panelMessageChat";
            this.panelMessageChat.Size = new System.Drawing.Size(444, 450);
            this.panelMessageChat.TabIndex = 1;
            // 
            // iconChatMessages
            // 
            this.iconChatMessages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconChatMessages.BackColor = System.Drawing.SystemColors.Control;
            this.iconChatMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.iconChatMessages.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.iconChatMessages.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.iconChatMessages.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconChatMessages.IconSize = 85;
            this.iconChatMessages.Location = new System.Drawing.Point(181, 174);
            this.iconChatMessages.Name = "iconChatMessages";
            this.iconChatMessages.Size = new System.Drawing.Size(85, 85);
            this.iconChatMessages.TabIndex = 0;
            this.iconChatMessages.TabStop = false;
            this.iconChatMessages.Visible = false;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMessageChat);
            this.Controls.Add(this.panelMessageList);
            this.Name = "MessagesForm";
            this.Text = "MessagesForm";
            this.panelMessageList.ResumeLayout(false);
            this.panelMessageChat.ResumeLayout(false);
            this.panelMessageChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChatMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMessageList;
        private System.Windows.Forms.Panel panelMessageChat;
        private FontAwesome.Sharp.IconPictureBox iconChatMessages;
        private System.Windows.Forms.Label lblNoMessages;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowMessageList;
    }
}