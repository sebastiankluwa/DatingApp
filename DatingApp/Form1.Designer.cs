
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
            this.btnMessages = new FontAwesome.Sharp.IconButton();
            this.btnLists = new FontAwesome.Sharp.IconButton();
            this.btnMatches = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnMessages);
            this.panelMenu.Controls.Add(this.btnLists);
            this.panelMenu.Controls.Add(this.btnMatches);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 703);
            this.panelMenu.TabIndex = 1;
            // 
            // btnMessages
            // 
            this.btnMessages.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMessages.FlatAppearance.BorderSize = 0;
            this.btnMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessages.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMessages.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMessages.IconChar = FontAwesome.Sharp.IconChar.Compass;
            this.btnMessages.IconColor = System.Drawing.Color.White;
            this.btnMessages.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMessages.IconSize = 32;
            this.btnMessages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMessages.Location = new System.Drawing.Point(0, 320);
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
            this.btnLists.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLists.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLists.IconChar = FontAwesome.Sharp.IconChar.Compass;
            this.btnLists.IconColor = System.Drawing.Color.White;
            this.btnLists.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLists.IconSize = 32;
            this.btnLists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLists.Location = new System.Drawing.Point(0, 260);
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
            this.btnMatches.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMatches.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMatches.IconChar = FontAwesome.Sharp.IconChar.Compass;
            this.btnMatches.IconColor = System.Drawing.Color.White;
            this.btnMatches.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMatches.IconSize = 32;
            this.btnMatches.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatches.Location = new System.Drawing.Point(0, 200);
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
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Compass;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 140);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Size = new System.Drawing.Size(220, 60);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 140);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DatingApp.App.Properties.Resources.Tinder_743x420;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(979, 75);
            this.panelTitleBar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 703);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnMessages;
        private FontAwesome.Sharp.IconButton btnLists;
        private FontAwesome.Sharp.IconButton btnMatches;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitleBar;
    }
}

