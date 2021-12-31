
namespace DatingApp.App.Messages
{
    partial class BubbleList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTimeSent = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userPicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 73);
            this.panel1.TabIndex = 1;
            // 
            // userPicture
            // 
            this.userPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPicture.Image = global::Local.Properties.Resources.avatar;
            this.userPicture.Location = new System.Drawing.Point(0, 0);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(64, 50);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 0;
            this.userPicture.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTimeSent);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(84, 20);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.panel2.Size = new System.Drawing.Size(196, 28);
            this.panel2.TabIndex = 2;
            // 
            // lblTimeSent
            // 
            this.lblTimeSent.AutoSize = true;
            this.lblTimeSent.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTimeSent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeSent.ForeColor = System.Drawing.Color.Gray;
            this.lblTimeSent.Location = new System.Drawing.Point(130, 2);
            this.lblTimeSent.Name = "lblTimeSent";
            this.lblTimeSent.Size = new System.Drawing.Size(66, 17);
            this.lblTimeSent.TabIndex = 3;
            this.lblTimeSent.Text = "11:23 am";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(98)))), ((int)(((byte)(134)))));
            this.lblUsername.Location = new System.Drawing.Point(0, 2);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(113, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Ricardo Lopez";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblText);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(84, 48);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel3.Size = new System.Drawing.Size(196, 45);
            this.panel3.TabIndex = 3;
            // 
            // lblText
            // 
            this.lblText.AutoEllipsis = true;
            this.lblText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.ForeColor = System.Drawing.Color.Gray;
            this.lblText.Location = new System.Drawing.Point(0, 19);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(196, 23);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Hello Tony! How are you? I called you yesterday!";
            // 
            // BubbleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BubbleList";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(300, 113);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox userPicture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblTimeSent;
        private System.Windows.Forms.Label lblUsername;
    }
}
