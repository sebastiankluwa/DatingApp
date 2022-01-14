
namespace DatingApp.App.Forms
{
    partial class PhotosForm
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
            this.filtersPanel = new System.Windows.Forms.Panel();
            this.filtersFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblGender = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.sliderPanel = new System.Windows.Forms.Panel();
            this.btnMainPhoto = new FontAwesome.Sharp.IconButton();
            this.btnDeletePhoto = new FontAwesome.Sharp.IconButton();
            this.btnChangeBack = new FontAwesome.Sharp.IconButton();
            this.btnChangeNext = new FontAwesome.Sharp.IconButton();
            this.btnBrowseFile = new FontAwesome.Sharp.IconButton();
            this.filtersPanel.SuspendLayout();
            this.filtersFlowPanel.SuspendLayout();
            this.sliderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtersPanel
            // 
            this.filtersPanel.Controls.Add(this.filtersFlowPanel);
            this.filtersPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.filtersPanel.Location = new System.Drawing.Point(641, 0);
            this.filtersPanel.Name = "filtersPanel";
            this.filtersPanel.Size = new System.Drawing.Size(159, 450);
            this.filtersPanel.TabIndex = 0;
            // 
            // filtersFlowPanel
            // 
            this.filtersFlowPanel.Controls.Add(this.lblGender);
            this.filtersFlowPanel.Controls.Add(this.btnBrowseFile);
            this.filtersFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtersFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.filtersFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.filtersFlowPanel.Name = "filtersFlowPanel";
            this.filtersFlowPanel.Size = new System.Drawing.Size(159, 450);
            this.filtersFlowPanel.TabIndex = 0;
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(3, 3);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(130, 20);
            this.lblGender.TabIndex = 5;
            this.lblGender.Values.Text = "Choose file to upload:";
            // 
            // sliderPanel
            // 
            this.sliderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sliderPanel.Controls.Add(this.btnMainPhoto);
            this.sliderPanel.Controls.Add(this.btnDeletePhoto);
            this.sliderPanel.Controls.Add(this.btnChangeBack);
            this.sliderPanel.Controls.Add(this.btnChangeNext);
            this.sliderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sliderPanel.Location = new System.Drawing.Point(0, 0);
            this.sliderPanel.Name = "sliderPanel";
            this.sliderPanel.Size = new System.Drawing.Size(641, 450);
            this.sliderPanel.TabIndex = 1;
            // 
            // btnMainPhoto
            // 
            this.btnMainPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMainPhoto.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnMainPhoto.FlatAppearance.BorderSize = 0;
            this.btnMainPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainPhoto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMainPhoto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMainPhoto.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            this.btnMainPhoto.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnMainPhoto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMainPhoto.IconSize = 32;
            this.btnMainPhoto.Location = new System.Drawing.Point(320, 394);
            this.btnMainPhoto.Name = "btnMainPhoto";
            this.btnMainPhoto.Size = new System.Drawing.Size(66, 56);
            this.btnMainPhoto.TabIndex = 3;
            this.btnMainPhoto.Text = "MAIN";
            this.btnMainPhoto.UseVisualStyleBackColor = false;
            this.btnMainPhoto.Click += new System.EventHandler(this.SetMainPhoto);
            // 
            // btnDeletePhoto
            // 
            this.btnDeletePhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeletePhoto.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeletePhoto.FlatAppearance.BorderSize = 0;
            this.btnDeletePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePhoto.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeletePhoto.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeletePhoto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDeletePhoto.IconSize = 32;
            this.btnDeletePhoto.Location = new System.Drawing.Point(254, 394);
            this.btnDeletePhoto.Name = "btnDeletePhoto";
            this.btnDeletePhoto.Size = new System.Drawing.Size(66, 56);
            this.btnDeletePhoto.TabIndex = 2;
            this.btnDeletePhoto.UseVisualStyleBackColor = false;
            this.btnDeletePhoto.Click += new System.EventHandler(this.DeletePhoto);
            // 
            // btnChangeBack
            // 
            this.btnChangeBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeBack.FlatAppearance.BorderSize = 0;
            this.btnChangeBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeBack.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.btnChangeBack.IconColor = System.Drawing.Color.DimGray;
            this.btnChangeBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangeBack.Location = new System.Drawing.Point(-14, 193);
            this.btnChangeBack.Name = "btnChangeBack";
            this.btnChangeBack.Size = new System.Drawing.Size(57, 50);
            this.btnChangeBack.TabIndex = 1;
            this.btnChangeBack.UseVisualStyleBackColor = true;
            this.btnChangeBack.Click += new System.EventHandler(this.SliderSlideBack);
            // 
            // btnChangeNext
            // 
            this.btnChangeNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeNext.FlatAppearance.BorderSize = 0;
            this.btnChangeNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeNext.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            this.btnChangeNext.IconColor = System.Drawing.Color.DimGray;
            this.btnChangeNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangeNext.Location = new System.Drawing.Point(604, 193);
            this.btnChangeNext.Name = "btnChangeNext";
            this.btnChangeNext.Size = new System.Drawing.Size(57, 50);
            this.btnChangeNext.TabIndex = 0;
            this.btnChangeNext.UseVisualStyleBackColor = true;
            this.btnChangeNext.Click += new System.EventHandler(this.SliderSlideNext);
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnBrowseFile.IconColor = System.Drawing.Color.Black;
            this.btnBrowseFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBrowseFile.IconSize = 32;
            this.btnBrowseFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseFile.Location = new System.Drawing.Point(3, 29);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(153, 43);
            this.btnBrowseFile.TabIndex = 6;
            this.btnBrowseFile.Text = "Browse File";
            this.btnBrowseFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // PhotosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sliderPanel);
            this.Controls.Add(this.filtersPanel);
            this.Name = "PhotosForm";
            this.Text = "PhotosForm";
            this.filtersPanel.ResumeLayout(false);
            this.filtersFlowPanel.ResumeLayout(false);
            this.filtersFlowPanel.PerformLayout();
            this.sliderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filtersPanel;
        private System.Windows.Forms.FlowLayoutPanel filtersFlowPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblGender;
        private System.Windows.Forms.Panel sliderPanel;
        private FontAwesome.Sharp.IconButton btnChangeBack;
        private FontAwesome.Sharp.IconButton btnChangeNext;
        private FontAwesome.Sharp.IconButton btnMainPhoto;
        private FontAwesome.Sharp.IconButton btnDeletePhoto;
        private FontAwesome.Sharp.IconButton btnBrowseFile;
    }
}