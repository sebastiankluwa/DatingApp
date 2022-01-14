
namespace DatingApp.App.Forms
{
    partial class MatchesForm
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
            this.lblAgeFrom = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtAgeFrom = new System.Windows.Forms.NumericUpDown();
            this.lblAgeTo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtAgeTo = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.lblGender = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnGender = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnApplyFilters = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.sliderPanel = new System.Windows.Forms.Panel();
            this.lblKnownAs = new System.Windows.Forms.Label();
            this.btnMessage = new FontAwesome.Sharp.IconButton();
            this.btnLike = new FontAwesome.Sharp.IconButton();
            this.btnChangeBack = new FontAwesome.Sharp.IconButton();
            this.btnChangeNext = new FontAwesome.Sharp.IconButton();
            this.filtersPanel.SuspendLayout();
            this.filtersFlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGender)).BeginInit();
            this.sliderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtersPanel
            // 
            this.filtersPanel.Controls.Add(this.filtersFlowPanel);
            this.filtersPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.filtersPanel.Location = new System.Drawing.Point(693, 0);
            this.filtersPanel.Name = "filtersPanel";
            this.filtersPanel.Size = new System.Drawing.Size(107, 450);
            this.filtersPanel.TabIndex = 0;
            // 
            // filtersFlowPanel
            // 
            this.filtersFlowPanel.Controls.Add(this.lblAgeFrom);
            this.filtersFlowPanel.Controls.Add(this.txtAgeFrom);
            this.filtersFlowPanel.Controls.Add(this.lblAgeTo);
            this.filtersFlowPanel.Controls.Add(this.txtAgeTo);
            this.filtersFlowPanel.Controls.Add(this.lblGender);
            this.filtersFlowPanel.Controls.Add(this.btnGender);
            this.filtersFlowPanel.Controls.Add(this.btnApplyFilters);
            this.filtersFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtersFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.filtersFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.filtersFlowPanel.Name = "filtersFlowPanel";
            this.filtersFlowPanel.Size = new System.Drawing.Size(107, 450);
            this.filtersFlowPanel.TabIndex = 0;
            // 
            // lblAgeFrom
            // 
            this.lblAgeFrom.Location = new System.Drawing.Point(3, 3);
            this.lblAgeFrom.Name = "lblAgeFrom";
            this.lblAgeFrom.Size = new System.Drawing.Size(64, 20);
            this.lblAgeFrom.TabIndex = 0;
            this.lblAgeFrom.Values.Text = "Age from:";
            // 
            // txtAgeFrom
            // 
            this.txtAgeFrom.Location = new System.Drawing.Point(3, 29);
            this.txtAgeFrom.Name = "txtAgeFrom";
            this.txtAgeFrom.Size = new System.Drawing.Size(43, 23);
            this.txtAgeFrom.TabIndex = 8;
            this.txtAgeFrom.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // lblAgeTo
            // 
            this.lblAgeTo.Location = new System.Drawing.Point(3, 58);
            this.lblAgeTo.Name = "lblAgeTo";
            this.lblAgeTo.Size = new System.Drawing.Size(50, 20);
            this.lblAgeTo.TabIndex = 2;
            this.lblAgeTo.Values.Text = "Age to:";
            // 
            // txtAgeTo
            // 
            this.txtAgeTo.Location = new System.Drawing.Point(3, 84);
            this.txtAgeTo.Name = "txtAgeTo";
            this.txtAgeTo.Size = new System.Drawing.Size(43, 22);
            this.txtAgeTo.TabIndex = 7;
            this.txtAgeTo.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(3, 112);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(43, 20);
            this.lblGender.TabIndex = 5;
            this.lblGender.Values.Text = "Show:";
            // 
            // btnGender
            // 
            this.btnGender.DropDownWidth = 90;
            this.btnGender.Items.AddRange(new object[] {
            "female",
            "male"});
            this.btnGender.Location = new System.Drawing.Point(3, 138);
            this.btnGender.Name = "btnGender";
            this.btnGender.Size = new System.Drawing.Size(90, 21);
            this.btnGender.TabIndex = 9;
            this.btnGender.Text = "female";
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.Location = new System.Drawing.Point(3, 165);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(90, 25);
            this.btnApplyFilters.TabIndex = 6;
            this.btnApplyFilters.Values.Text = "Apply Filters";
            this.btnApplyFilters.Click += new System.EventHandler(this.ApplyFilters);
            // 
            // sliderPanel
            // 
            this.sliderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sliderPanel.Controls.Add(this.lblKnownAs);
            this.sliderPanel.Controls.Add(this.btnMessage);
            this.sliderPanel.Controls.Add(this.btnLike);
            this.sliderPanel.Controls.Add(this.btnChangeBack);
            this.sliderPanel.Controls.Add(this.btnChangeNext);
            this.sliderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sliderPanel.Location = new System.Drawing.Point(0, 0);
            this.sliderPanel.Name = "sliderPanel";
            this.sliderPanel.Size = new System.Drawing.Size(693, 450);
            this.sliderPanel.TabIndex = 1;
            // 
            // lblKnownAs
            // 
            this.lblKnownAs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKnownAs.AutoSize = true;
            this.lblKnownAs.BackColor = System.Drawing.Color.Gainsboro;
            this.lblKnownAs.Font = new System.Drawing.Font("Rubik", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKnownAs.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblKnownAs.Location = new System.Drawing.Point(310, 362);
            this.lblKnownAs.Name = "lblKnownAs";
            this.lblKnownAs.Size = new System.Drawing.Size(0, 25);
            this.lblKnownAs.TabIndex = 6;
            // 
            // btnMessage
            // 
            this.btnMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMessage.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnMessage.FlatAppearance.BorderSize = 0;
            this.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessage.IconChar = FontAwesome.Sharp.IconChar.Comment;
            this.btnMessage.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnMessage.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMessage.IconSize = 32;
            this.btnMessage.Location = new System.Drawing.Point(346, 394);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(66, 56);
            this.btnMessage.TabIndex = 3;
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.EnterChat);
            // 
            // btnLike
            // 
            this.btnLike.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLike.BackColor = System.Drawing.Color.YellowGreen;
            this.btnLike.FlatAppearance.BorderSize = 0;
            this.btnLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLike.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnLike.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnLike.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLike.IconSize = 32;
            this.btnLike.Location = new System.Drawing.Point(280, 394);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(66, 56);
            this.btnLike.TabIndex = 2;
            this.btnLike.UseVisualStyleBackColor = false;
            this.btnLike.Click += new System.EventHandler(this.AddLike);
            // 
            // btnChangeBack
            // 
            this.btnChangeBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeBack.FlatAppearance.BorderSize = 0;
            this.btnChangeBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeBack.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.btnChangeBack.IconColor = System.Drawing.Color.DimGray;
            this.btnChangeBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangeBack.Location = new System.Drawing.Point(12, 193);
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
            this.btnChangeNext.Location = new System.Drawing.Point(630, 193);
            this.btnChangeNext.Name = "btnChangeNext";
            this.btnChangeNext.Size = new System.Drawing.Size(57, 50);
            this.btnChangeNext.TabIndex = 0;
            this.btnChangeNext.UseVisualStyleBackColor = true;
            this.btnChangeNext.Click += new System.EventHandler(this.SliderSlideNext);
            // 
            // MatchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sliderPanel);
            this.Controls.Add(this.filtersPanel);
            this.Name = "MatchesForm";
            this.Text = "MatchesForm";
            this.filtersPanel.ResumeLayout(false);
            this.filtersFlowPanel.ResumeLayout(false);
            this.filtersFlowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGender)).EndInit();
            this.sliderPanel.ResumeLayout(false);
            this.sliderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filtersPanel;
        private System.Windows.Forms.FlowLayoutPanel filtersFlowPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAgeFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAgeTo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblGender;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnApplyFilters;
        private System.Windows.Forms.Panel sliderPanel;
        private FontAwesome.Sharp.IconButton btnChangeBack;
        private FontAwesome.Sharp.IconButton btnChangeNext;
        private FontAwesome.Sharp.IconButton btnMessage;
        private FontAwesome.Sharp.IconButton btnLike;
        private System.Windows.Forms.NumericUpDown txtAgeFrom;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown txtAgeTo;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox btnGender;
        private System.Windows.Forms.Label lblKnownAs;
    }
}