
namespace DatingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.logoutButton = new FontAwesome.Sharp.IconButton();
            this.btnProfile = new FontAwesome.Sharp.IconButton();
            this.btnMessages = new FontAwesome.Sharp.IconButton();
            this.btnLists = new FontAwesome.Sharp.IconButton();
            this.btnMatches = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelWindowControlBar = new System.Windows.Forms.Panel();
            this.panelWindowControlWrap = new System.Windows.Forms.Panel();
            this.btnWindowMinimize = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnWindowMaximize = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnWindowExit = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelWindowControlBar.SuspendLayout();
            this.panelWindowControlWrap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1167, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 18);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(70)))));
            this.panelMenu.Controls.Add(this.logoutButton);
            this.panelMenu.Controls.Add(this.btnProfile);
            this.panelMenu.Controls.Add(this.btnMessages);
            this.panelMenu.Controls.Add(this.btnLists);
            this.panelMenu.Controls.Add(this.btnMatches);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 611);
            this.panelMenu.TabIndex = 1;
            // 
            // logoutButton
            // 
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logoutButton.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.logoutButton.IconColor = System.Drawing.Color.White;
            this.logoutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutButton.IconSize = 32;
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(0, 551);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.logoutButton.Size = new System.Drawing.Size(220, 60);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProfile.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnProfile.IconColor = System.Drawing.Color.White;
            this.btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProfile.IconSize = 32;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 304);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProfile.Size = new System.Drawing.Size(220, 60);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnMessages
            // 
            this.btnMessages.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMessages.FlatAppearance.BorderSize = 0;
            this.btnMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessages.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMessages.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMessages.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.btnMessages.IconColor = System.Drawing.Color.White;
            this.btnMessages.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMessages.IconSize = 32;
            this.btnMessages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMessages.Location = new System.Drawing.Point(0, 244);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMessages.Size = new System.Drawing.Size(220, 60);
            this.btnMessages.TabIndex = 3;
            this.btnMessages.Text = "Messages";
            this.btnMessages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMessages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMessages.UseVisualStyleBackColor = true;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // btnLists
            // 
            this.btnLists.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLists.FlatAppearance.BorderSize = 0;
            this.btnLists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLists.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLists.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLists.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnLists.IconColor = System.Drawing.Color.White;
            this.btnLists.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLists.IconSize = 32;
            this.btnLists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLists.Location = new System.Drawing.Point(0, 184);
            this.btnLists.Name = "btnLists";
            this.btnLists.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLists.Size = new System.Drawing.Size(220, 60);
            this.btnLists.TabIndex = 2;
            this.btnLists.Text = "Lists";
            this.btnLists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLists.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLists.UseVisualStyleBackColor = true;
            this.btnLists.Click += new System.EventHandler(this.btnLists_Click);
            // 
            // btnMatches
            // 
            this.btnMatches.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMatches.FlatAppearance.BorderSize = 0;
            this.btnMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatches.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMatches.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMatches.IconChar = FontAwesome.Sharp.IconChar.Compass;
            this.btnMatches.IconColor = System.Drawing.Color.White;
            this.btnMatches.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMatches.IconSize = 32;
            this.btnMatches.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatches.Location = new System.Drawing.Point(0, 124);
            this.btnMatches.Name = "btnMatches";
            this.btnMatches.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMatches.Size = new System.Drawing.Size(220, 60);
            this.btnMatches.TabIndex = 1;
            this.btnMatches.Text = "Matches";
            this.btnMatches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatches.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMatches.UseVisualStyleBackColor = true;
            this.btnMatches.Click += new System.EventHandler(this.btnMatches_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 124);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(70)))));
            this.panel5.Controls.Add(this.userPicture);
            this.panel5.Controls.Add(this.lblUserName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 124);
            this.panel5.TabIndex = 2;
            // 
            // userPicture
            // 
            this.userPicture.Image = global::Local.Properties.Resources.user;
            this.userPicture.Location = new System.Drawing.Point(85, 23);
            this.userPicture.Margin = new System.Windows.Forms.Padding(2);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(52, 45);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            this.userPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserName.Location = new System.Drawing.Point(39, 75);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(150, 21);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitleBar.Controls.Add(this.panelWindowControlBar);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(964, 75);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panelWindowControlBar
            // 
            this.panelWindowControlBar.Controls.Add(this.panelWindowControlWrap);
            this.panelWindowControlBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelWindowControlBar.Location = new System.Drawing.Point(860, 0);
            this.panelWindowControlBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelWindowControlBar.Name = "panelWindowControlBar";
            this.panelWindowControlBar.Size = new System.Drawing.Size(104, 75);
            this.panelWindowControlBar.TabIndex = 4;
            // 
            // panelWindowControlWrap
            // 
            this.panelWindowControlWrap.Controls.Add(this.btnWindowMinimize);
            this.panelWindowControlWrap.Controls.Add(this.panel6);
            this.panelWindowControlWrap.Controls.Add(this.btnWindowMaximize);
            this.panelWindowControlWrap.Controls.Add(this.panel4);
            this.panelWindowControlWrap.Controls.Add(this.btnWindowExit);
            this.panelWindowControlWrap.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindowControlWrap.Location = new System.Drawing.Point(0, 0);
            this.panelWindowControlWrap.Margin = new System.Windows.Forms.Padding(2);
            this.panelWindowControlWrap.Name = "panelWindowControlWrap";
            this.panelWindowControlWrap.Padding = new System.Windows.Forms.Padding(0, 6, 10, 0);
            this.panelWindowControlWrap.Size = new System.Drawing.Size(104, 26);
            this.panelWindowControlWrap.TabIndex = 0;
            // 
            // btnWindowMinimize
            // 
            this.btnWindowMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnWindowMinimize.FlatAppearance.BorderSize = 0;
            this.btnWindowMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnWindowMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnWindowMinimize.IconColor = System.Drawing.Color.DimGray;
            this.btnWindowMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWindowMinimize.IconSize = 32;
            this.btnWindowMinimize.Location = new System.Drawing.Point(20, 6);
            this.btnWindowMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnWindowMinimize.Name = "btnWindowMinimize";
            this.btnWindowMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnWindowMinimize.TabIndex = 3;
            this.btnWindowMinimize.UseVisualStyleBackColor = true;
            this.btnWindowMinimize.Click += new System.EventHandler(this.btnWindowMinimize_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(40, 6);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(7, 20);
            this.panel6.TabIndex = 7;
            // 
            // btnWindowMaximize
            // 
            this.btnWindowMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnWindowMaximize.FlatAppearance.BorderSize = 0;
            this.btnWindowMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnWindowMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnWindowMaximize.IconColor = System.Drawing.Color.DimGray;
            this.btnWindowMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWindowMaximize.IconSize = 32;
            this.btnWindowMaximize.Location = new System.Drawing.Point(47, 6);
            this.btnWindowMaximize.Margin = new System.Windows.Forms.Padding(2);
            this.btnWindowMaximize.Name = "btnWindowMaximize";
            this.btnWindowMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnWindowMaximize.TabIndex = 3;
            this.btnWindowMaximize.UseVisualStyleBackColor = true;
            this.btnWindowMaximize.Click += new System.EventHandler(this.btnWindowMaximize_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(67, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 20);
            this.panel4.TabIndex = 6;
            // 
            // btnWindowExit
            // 
            this.btnWindowExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnWindowExit.FlatAppearance.BorderSize = 0;
            this.btnWindowExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnWindowExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnWindowExit.IconColor = System.Drawing.Color.DimGray;
            this.btnWindowExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWindowExit.IconSize = 32;
            this.btnWindowExit.Location = new System.Drawing.Point(74, 6);
            this.btnWindowExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnWindowExit.Name = "btnWindowExit";
            this.btnWindowExit.Size = new System.Drawing.Size(20, 20);
            this.btnWindowExit.TabIndex = 3;
            this.btnWindowExit.UseVisualStyleBackColor = true;
            this.btnWindowExit.Click += new System.EventHandler(this.btnWindowExit_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitleChildForm.Location = new System.Drawing.Point(62, 29);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(40, 15);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 29;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(25, 23);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(34, 29);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(2);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(964, 5);
            this.panelShadow.TabIndex = 3;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(964, 531);
            this.panelDesktop.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelWindowControlBar.ResumeLayout(false);
            this.panelWindowControlWrap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnMessages;
        private FontAwesome.Sharp.IconButton btnLists;
        private FontAwesome.Sharp.IconButton btnMatches;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnWindowExit;
        private FontAwesome.Sharp.IconButton btnWindowMinimize;
        private FontAwesome.Sharp.IconButton btnWindowMaximize;
        private System.Windows.Forms.Panel panelWindowControlBar;
        private System.Windows.Forms.Panel panelWindowControlWrap;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblUserName;
        private FontAwesome.Sharp.IconButton btnProfile;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton logoutButton;
    }
}

