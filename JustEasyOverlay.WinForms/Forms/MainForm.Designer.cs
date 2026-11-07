namespace JustEasyOverlay.WinForms.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ShowOverlayButton = new Button();
            HideOverlayButton = new Button();
            SendOverlayBehindButton = new Button();
            pictureBox1 = new PictureBox();
            DescriptionRichTextBox = new RichTextBox();
            GitHubLinkLabel = new LinkLabel();
            CloudTipsLinkLabel = new LinkLabel();
            VKLinkLabel = new LinkLabel();
            LinksFlowLayoutPanel = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            LinksFlowLayoutPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ShowOverlayButton
            // 
            ShowOverlayButton.FlatAppearance.BorderColor = Color.DarkSlateGray;
            ShowOverlayButton.FlatAppearance.MouseDownBackColor = Color.Red;
            ShowOverlayButton.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            ShowOverlayButton.FlatStyle = FlatStyle.Flat;
            ShowOverlayButton.Location = new Point(12, 146);
            ShowOverlayButton.Name = "ShowOverlayButton";
            ShowOverlayButton.Size = new Size(128, 32);
            ShowOverlayButton.TabIndex = 0;
            ShowOverlayButton.Text = "Show Overlay";
            ShowOverlayButton.UseVisualStyleBackColor = true;
            ShowOverlayButton.Click += OnShowOverlayButtonClicked;
            // 
            // HideOverlayButton
            // 
            HideOverlayButton.FlatAppearance.BorderColor = Color.DarkSlateGray;
            HideOverlayButton.FlatAppearance.MouseDownBackColor = Color.Red;
            HideOverlayButton.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            HideOverlayButton.FlatStyle = FlatStyle.Flat;
            HideOverlayButton.Location = new Point(280, 146);
            HideOverlayButton.Name = "HideOverlayButton";
            HideOverlayButton.Size = new Size(128, 32);
            HideOverlayButton.TabIndex = 1;
            HideOverlayButton.Text = "Hide Overlay";
            HideOverlayButton.UseVisualStyleBackColor = true;
            HideOverlayButton.Click += OnHideOverlayButtonClicked;
            // 
            // SendOverlayBehindButton
            // 
            SendOverlayBehindButton.FlatAppearance.BorderColor = Color.DarkSlateGray;
            SendOverlayBehindButton.FlatAppearance.MouseDownBackColor = Color.Red;
            SendOverlayBehindButton.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            SendOverlayBehindButton.FlatStyle = FlatStyle.Flat;
            SendOverlayBehindButton.Location = new Point(146, 146);
            SendOverlayBehindButton.Name = "SendOverlayBehindButton";
            SendOverlayBehindButton.Size = new Size(128, 32);
            SendOverlayBehindButton.TabIndex = 2;
            SendOverlayBehindButton.Text = "Send Behind";
            SendOverlayBehindButton.UseVisualStyleBackColor = true;
            SendOverlayBehindButton.Click += OnSendOverlayBehindButtonClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.YO;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.BackColor = Color.SteelBlue;
            DescriptionRichTextBox.BorderStyle = BorderStyle.None;
            DescriptionRichTextBox.Location = new Point(146, 12);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.ReadOnly = true;
            DescriptionRichTextBox.Size = new Size(262, 128);
            DescriptionRichTextBox.TabIndex = 4;
            DescriptionRichTextBox.Text = resources.GetString("DescriptionRichTextBox.Text");
            // 
            // GitHubLinkLabel
            // 
            GitHubLinkLabel.ActiveLinkColor = Color.Indigo;
            GitHubLinkLabel.Anchor = AnchorStyles.None;
            GitHubLinkLabel.AutoSize = true;
            GitHubLinkLabel.DisabledLinkColor = Color.LightSlateGray;
            GitHubLinkLabel.LinkArea = new LinkArea(0, 25);
            GitHubLinkLabel.LinkColor = Color.LightBlue;
            GitHubLinkLabel.Location = new Point(28, 0);
            GitHubLinkLabel.Name = "GitHubLinkLabel";
            GitHubLinkLabel.Size = new Size(43, 21);
            GitHubLinkLabel.TabIndex = 5;
            GitHubLinkLabel.TabStop = true;
            GitHubLinkLabel.Tag = "https://github.com/Enedwait";
            GitHubLinkLabel.Text = "GitHub";
            GitHubLinkLabel.UseCompatibleTextRendering = true;
            GitHubLinkLabel.LinkClicked += OnGitHubLinkClicked;
            // 
            // CloudTipsLinkLabel
            // 
            CloudTipsLinkLabel.ActiveLinkColor = Color.Indigo;
            CloudTipsLinkLabel.Anchor = AnchorStyles.None;
            CloudTipsLinkLabel.AutoSize = true;
            CloudTipsLinkLabel.DisabledLinkColor = Color.LightSlateGray;
            CloudTipsLinkLabel.LinkArea = new LinkArea(0, 25);
            CloudTipsLinkLabel.LinkColor = Color.LightBlue;
            CloudTipsLinkLabel.Location = new Point(102, 0);
            CloudTipsLinkLabel.Name = "CloudTipsLinkLabel";
            CloudTipsLinkLabel.Size = new Size(59, 21);
            CloudTipsLinkLabel.TabIndex = 7;
            CloudTipsLinkLabel.TabStop = true;
            CloudTipsLinkLabel.Tag = "https://pay.cloudtips.ru/p/7dd05dc6";
            CloudTipsLinkLabel.Text = "CloudTips";
            CloudTipsLinkLabel.UseCompatibleTextRendering = true;
            CloudTipsLinkLabel.LinkClicked += OnCloudTipsLinkClicked;
            // 
            // VKLinkLabel
            // 
            VKLinkLabel.ActiveLinkColor = Color.Indigo;
            VKLinkLabel.Anchor = AnchorStyles.None;
            VKLinkLabel.AutoSize = true;
            VKLinkLabel.DisabledLinkColor = Color.LightSlateGray;
            VKLinkLabel.LinkArea = new LinkArea(0, 25);
            VKLinkLabel.LinkColor = Color.LightBlue;
            VKLinkLabel.Location = new Point(77, 0);
            VKLinkLabel.Name = "VKLinkLabel";
            VKLinkLabel.Size = new Size(19, 21);
            VKLinkLabel.TabIndex = 8;
            VKLinkLabel.TabStop = true;
            VKLinkLabel.Tag = "https://vk.ru/yovoleg";
            VKLinkLabel.Text = "VK";
            VKLinkLabel.UseCompatibleTextRendering = true;
            VKLinkLabel.LinkClicked += OnVKLinkClicked;
            // 
            // LinksFlowLayoutPanel
            // 
            LinksFlowLayoutPanel.Anchor = AnchorStyles.None;
            LinksFlowLayoutPanel.AutoSize = true;
            LinksFlowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LinksFlowLayoutPanel.Controls.Add(GitHubLinkLabel);
            LinksFlowLayoutPanel.Controls.Add(VKLinkLabel);
            LinksFlowLayoutPanel.Controls.Add(CloudTipsLinkLabel);
            LinksFlowLayoutPanel.Location = new Point(116, 8);
            LinksFlowLayoutPanel.Name = "LinksFlowLayoutPanel";
            LinksFlowLayoutPanel.Padding = new Padding(25, 0, 25, 0);
            LinksFlowLayoutPanel.Size = new Size(189, 21);
            LinksFlowLayoutPanel.TabIndex = 9;
            LinksFlowLayoutPanel.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(LinksFlowLayoutPanel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 181);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(422, 37);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(422, 218);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(DescriptionRichTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(SendOverlayBehindButton);
            Controls.Add(HideOverlayButton);
            Controls.Add(ShowOverlayButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JustEasyOverlay";
            FormClosed += OnFormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            LinksFlowLayoutPanel.ResumeLayout(false);
            LinksFlowLayoutPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ShowOverlayButton;
        private Button HideOverlayButton;
        private Button SendOverlayBehindButton;
        private PictureBox pictureBox1;
        private RichTextBox DescriptionRichTextBox;
        private LinkLabel GitHubLinkLabel;
        private LinkLabel CloudTipsLinkLabel;
        private LinkLabel VKLinkLabel;
        private FlowLayoutPanel LinksFlowLayoutPanel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
