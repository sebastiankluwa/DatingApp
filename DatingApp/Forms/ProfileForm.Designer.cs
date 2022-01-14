
namespace Local.Forms
{
    partial class ProfileForm
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
            this.detailsWrapperPanel = new System.Windows.Forms.Panel();
            this.detailsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCountry = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblAge = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lblMemberSince = new MaterialSkin.Controls.MaterialLabel();
            this.detailsUserPicture = new System.Windows.Forms.PictureBox();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescription = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLookingFor = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtInterests = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnSaveChanges = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.detailsWrapperPanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsUserPicture)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // detailsWrapperPanel
            // 
            this.detailsWrapperPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.detailsWrapperPanel.Controls.Add(this.detailsPanel);
            this.detailsWrapperPanel.Controls.Add(this.detailsUserPicture);
            this.detailsWrapperPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.detailsWrapperPanel.Location = new System.Drawing.Point(555, 0);
            this.detailsWrapperPanel.Name = "detailsWrapperPanel";
            this.detailsWrapperPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.detailsWrapperPanel.Size = new System.Drawing.Size(245, 450);
            this.detailsWrapperPanel.TabIndex = 0;
            // 
            // detailsPanel
            // 
            this.detailsPanel.Controls.Add(this.materialLabel1);
            this.detailsPanel.Controls.Add(this.lblCountry);
            this.detailsPanel.Controls.Add(this.materialLabel3);
            this.detailsPanel.Controls.Add(this.lblAge);
            this.detailsPanel.Controls.Add(this.materialLabel5);
            this.detailsPanel.Controls.Add(this.lblMemberSince);
            this.detailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.detailsPanel.Location = new System.Drawing.Point(0, 187);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Padding = new System.Windows.Forms.Padding(30, 15, 30, 30);
            this.detailsPanel.Size = new System.Drawing.Size(245, 263);
            this.detailsPanel.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(33, 15);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Location:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Depth = 0;
            this.lblCountry.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCountry.Location = new System.Drawing.Point(33, 39);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.lblCountry.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(55, 19);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Poland";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(33, 73);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(39, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Age:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Depth = 0;
            this.lblAge.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAge.Location = new System.Drawing.Point(33, 97);
            this.lblAge.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.lblAge.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(25, 19);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "18";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(33, 131);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(108, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Member since:";
            // 
            // lblMemberSince
            // 
            this.lblMemberSince.AutoSize = true;
            this.lblMemberSince.Depth = 0;
            this.lblMemberSince.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMemberSince.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMemberSince.Location = new System.Drawing.Point(33, 155);
            this.lblMemberSince.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.lblMemberSince.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMemberSince.Name = "lblMemberSince";
            this.lblMemberSince.Size = new System.Drawing.Size(91, 19);
            this.lblMemberSince.TabIndex = 5;
            this.lblMemberSince.Text = "14 Dec 2021";
            // 
            // detailsUserPicture
            // 
            this.detailsUserPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.detailsUserPicture.Image = global::Local.Properties.Resources.avatar;
            this.detailsUserPicture.Location = new System.Drawing.Point(0, 10);
            this.detailsUserPicture.Name = "detailsUserPicture";
            this.detailsUserPicture.Size = new System.Drawing.Size(245, 177);
            this.detailsUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.detailsUserPicture.TabIndex = 0;
            this.detailsUserPicture.TabStop = false;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.materialLabel7);
            this.flowLayoutPanel1.Controls.Add(this.txtDescription);
            this.flowLayoutPanel1.Controls.Add(this.materialLabel9);
            this.flowLayoutPanel1.Controls.Add(this.txtLookingFor);
            this.flowLayoutPanel1.Controls.Add(this.materialLabel8);
            this.flowLayoutPanel1.Controls.Add(this.txtInterests);
            this.flowLayoutPanel1.Controls.Add(this.materialLabel10);
            this.flowLayoutPanel1.Controls.Add(this.kryptonLabel1);
            this.flowLayoutPanel1.Controls.Add(this.txtCity);
            this.flowLayoutPanel1.Controls.Add(this.kryptonLabel2);
            this.flowLayoutPanel1.Controls.Add(this.txtCountry);
            this.flowLayoutPanel1.Controls.Add(this.btnSaveChanges);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(555, 450);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(23, 20);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(90, 19);
            this.materialLabel7.TabIndex = 1;
            this.materialLabel7.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(23, 42);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(386, 64);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(23, 116);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(93, 19);
            this.materialLabel9.TabIndex = 4;
            this.materialLabel9.Text = "Looking For:";
            // 
            // txtLookingFor
            // 
            this.txtLookingFor.Location = new System.Drawing.Point(23, 138);
            this.txtLookingFor.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtLookingFor.Name = "txtLookingFor";
            this.txtLookingFor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtLookingFor.Size = new System.Drawing.Size(386, 66);
            this.txtLookingFor.TabIndex = 5;
            this.txtLookingFor.Text = "";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(23, 214);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(72, 19);
            this.materialLabel8.TabIndex = 6;
            this.materialLabel8.Text = "Interests:";
            // 
            // txtInterests
            // 
            this.txtInterests.Location = new System.Drawing.Point(23, 236);
            this.txtInterests.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtInterests.Name = "txtInterests";
            this.txtInterests.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtInterests.Size = new System.Drawing.Size(386, 63);
            this.txtInterests.TabIndex = 7;
            this.txtInterests.Text = "";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(23, 309);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(123, 19);
            this.materialLabel10.TabIndex = 8;
            this.materialLabel10.Text = "Location Details:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(23, 331);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(34, 20);
            this.kryptonLabel1.TabIndex = 9;
            this.kryptonLabel1.Values.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(23, 357);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 23);
            this.txtCity.TabIndex = 11;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(23, 386);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(57, 20);
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "Country:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(23, 412);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 23);
            this.txtCountry.TabIndex = 12;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(23, 448);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(3, 10, 3, 25);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.btnSaveChanges.Size = new System.Drawing.Size(158, 25);
            this.btnSaveChanges.TabIndex = 13;
            this.btnSaveChanges.Values.Text = "Save Changes";
            this.btnSaveChanges.Click += new System.EventHandler(this.SaveChanges);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.detailsWrapperPanel);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.detailsWrapperPanel.ResumeLayout(false);
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsUserPicture)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel detailsWrapperPanel;
        private System.Windows.Forms.FlowLayoutPanel detailsPanel;
        private System.Windows.Forms.PictureBox detailsUserPicture;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblCountry;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblAge;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lblMemberSince;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtDescription;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtLookingFor;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtInterests;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSaveChanges;
    }
}