namespace COMP123_S2019_FinalTestA.Views
{
    partial class HeroGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeroGenerator));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.identityPage = new System.Windows.Forms.TabPage();
            this.heroNameTextBox = new System.Windows.Forms.TextBox();
            this.generateNameButton = new System.Windows.Forms.Button();
            this.lastNameDataLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameDataLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.heroNameLabel = new System.Windows.Forms.Label();
            this.abilityPage = new System.Windows.Forms.TabPage();
            this.abilityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.physicalAbilitiesLabel = new System.Windows.Forms.Label();
            this.popularityDataLabel = new System.Windows.Forms.Label();
            this.psycheDataLabel = new System.Windows.Forms.Label();
            this.mentalAbilitiesLabel = new System.Windows.Forms.Label();
            this.strengthDataLabel = new System.Windows.Forms.Label();
            this.intutionDataLabel = new System.Windows.Forms.Label();
            this.fightingLabel = new System.Windows.Forms.Label();
            this.reasonDataLabel = new System.Windows.Forms.Label();
            this.enduranceDataLabel = new System.Windows.Forms.Label();
            this.popularityLabel = new System.Windows.Forms.Label();
            this.psycheLabel = new System.Windows.Forms.Label();
            this.agilityLabel = new System.Windows.Forms.Label();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.intutionLabel = new System.Windows.Forms.Label();
            this.enduranceLabel = new System.Windows.Forms.Label();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.fighitingDataLabel = new System.Windows.Forms.Label();
            this.agilityDataLabel = new System.Windows.Forms.Label();
            this.generateAbilitiesButton = new System.Windows.Forms.Button();
            this.powersPage = new System.Windows.Forms.TabPage();
            this.characterSheet = new System.Windows.Forms.TabPage();
            this.heroToolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.heroMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.identityPage.SuspendLayout();
            this.abilityPage.SuspendLayout();
            this.abilityTableLayoutPanel.SuspendLayout();
            this.characterSheet.SuspendLayout();
            this.heroToolStrip.SuspendLayout();
            this.heroMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.identityPage);
            this.MainTabControl.Controls.Add(this.abilityPage);
            this.MainTabControl.Controls.Add(this.powersPage);
            this.MainTabControl.Controls.Add(this.characterSheet);
            this.MainTabControl.Location = new System.Drawing.Point(12, 12);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(758, 460);
            this.MainTabControl.TabIndex = 0;
            // 
            // identityPage
            // 
            this.identityPage.Controls.Add(this.heroNameTextBox);
            this.identityPage.Controls.Add(this.generateNameButton);
            this.identityPage.Controls.Add(this.lastNameDataLabel);
            this.identityPage.Controls.Add(this.lastNameLabel);
            this.identityPage.Controls.Add(this.firstNameDataLabel);
            this.identityPage.Controls.Add(this.firstNameLabel);
            this.identityPage.Controls.Add(this.heroNameLabel);
            this.identityPage.Location = new System.Drawing.Point(4, 33);
            this.identityPage.Name = "identityPage";
            this.identityPage.Size = new System.Drawing.Size(750, 423);
            this.identityPage.TabIndex = 2;
            this.identityPage.Text = "Identity";
            this.identityPage.UseVisualStyleBackColor = true;
            // 
            // heroNameTextBox
            // 
            this.heroNameTextBox.Location = new System.Drawing.Point(208, 50);
            this.heroNameTextBox.Name = "heroNameTextBox";
            this.heroNameTextBox.Size = new System.Drawing.Size(407, 29);
            this.heroNameTextBox.TabIndex = 1;
            // 
            // generateNameButton
            // 
            this.generateNameButton.Location = new System.Drawing.Point(439, 234);
            this.generateNameButton.Name = "generateNameButton";
            this.generateNameButton.Size = new System.Drawing.Size(176, 45);
            this.generateNameButton.TabIndex = 1;
            this.generateNameButton.Text = "Generate Name";
            this.generateNameButton.UseVisualStyleBackColor = true;
            this.generateNameButton.Click += new System.EventHandler(this.generateNameButton_Click);
            // 
            // lastNameDataLabel
            // 
            this.lastNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameDataLabel.Location = new System.Drawing.Point(184, 172);
            this.lastNameDataLabel.Name = "lastNameDataLabel";
            this.lastNameDataLabel.Size = new System.Drawing.Size(431, 35);
            this.lastNameDataLabel.TabIndex = 0;
            this.lastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(24, 172);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(178, 35);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNameDataLabel
            // 
            this.firstNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.firstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameDataLabel.Location = new System.Drawing.Point(184, 127);
            this.firstNameDataLabel.Name = "firstNameDataLabel";
            this.firstNameDataLabel.Size = new System.Drawing.Size(431, 35);
            this.firstNameDataLabel.TabIndex = 0;
            this.firstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(24, 127);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(178, 35);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroNameLabel
            // 
            this.heroNameLabel.Location = new System.Drawing.Point(24, 48);
            this.heroNameLabel.Name = "heroNameLabel";
            this.heroNameLabel.Size = new System.Drawing.Size(178, 35);
            this.heroNameLabel.TabIndex = 0;
            this.heroNameLabel.Text = "Enter Hero Name";
            this.heroNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // abilityPage
            // 
            this.abilityPage.Controls.Add(this.abilityTableLayoutPanel);
            this.abilityPage.Location = new System.Drawing.Point(4, 33);
            this.abilityPage.Name = "abilityPage";
            this.abilityPage.Padding = new System.Windows.Forms.Padding(3);
            this.abilityPage.Size = new System.Drawing.Size(750, 423);
            this.abilityPage.TabIndex = 0;
            this.abilityPage.Text = "Abilities";
            this.abilityPage.UseVisualStyleBackColor = true;
            // 
            // abilityTableLayoutPanel
            // 
            this.abilityTableLayoutPanel.ColumnCount = 4;
            this.abilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.abilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.abilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.abilityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.abilityTableLayoutPanel.Controls.Add(this.physicalAbilitiesLabel, 0, 0);
            this.abilityTableLayoutPanel.Controls.Add(this.popularityDataLabel, 3, 4);
            this.abilityTableLayoutPanel.Controls.Add(this.psycheDataLabel, 3, 3);
            this.abilityTableLayoutPanel.Controls.Add(this.mentalAbilitiesLabel, 2, 0);
            this.abilityTableLayoutPanel.Controls.Add(this.strengthDataLabel, 1, 3);
            this.abilityTableLayoutPanel.Controls.Add(this.intutionDataLabel, 3, 2);
            this.abilityTableLayoutPanel.Controls.Add(this.fightingLabel, 0, 1);
            this.abilityTableLayoutPanel.Controls.Add(this.reasonDataLabel, 3, 1);
            this.abilityTableLayoutPanel.Controls.Add(this.enduranceDataLabel, 1, 4);
            this.abilityTableLayoutPanel.Controls.Add(this.popularityLabel, 2, 4);
            this.abilityTableLayoutPanel.Controls.Add(this.psycheLabel, 2, 3);
            this.abilityTableLayoutPanel.Controls.Add(this.agilityLabel, 0, 2);
            this.abilityTableLayoutPanel.Controls.Add(this.strengthLabel, 0, 3);
            this.abilityTableLayoutPanel.Controls.Add(this.intutionLabel, 2, 2);
            this.abilityTableLayoutPanel.Controls.Add(this.enduranceLabel, 0, 4);
            this.abilityTableLayoutPanel.Controls.Add(this.reasonLabel, 2, 1);
            this.abilityTableLayoutPanel.Controls.Add(this.fighitingDataLabel, 1, 1);
            this.abilityTableLayoutPanel.Controls.Add(this.agilityDataLabel, 1, 2);
            this.abilityTableLayoutPanel.Controls.Add(this.generateAbilitiesButton, 2, 6);
            this.abilityTableLayoutPanel.Location = new System.Drawing.Point(4, 7);
            this.abilityTableLayoutPanel.Name = "abilityTableLayoutPanel";
            this.abilityTableLayoutPanel.RowCount = 7;
            this.abilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.abilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.abilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.abilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.abilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.abilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.abilityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.abilityTableLayoutPanel.Size = new System.Drawing.Size(740, 410);
            this.abilityTableLayoutPanel.TabIndex = 3;
            // 
            // physicalAbilitiesLabel
            // 
            this.physicalAbilitiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abilityTableLayoutPanel.SetColumnSpan(this.physicalAbilitiesLabel, 2);
            this.physicalAbilitiesLabel.Location = new System.Drawing.Point(3, 0);
            this.physicalAbilitiesLabel.Name = "physicalAbilitiesLabel";
            this.physicalAbilitiesLabel.Size = new System.Drawing.Size(364, 58);
            this.physicalAbilitiesLabel.TabIndex = 2;
            this.physicalAbilitiesLabel.Text = "Physical Abilities";
            this.physicalAbilitiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // popularityDataLabel
            // 
            this.popularityDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.popularityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.popularityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.popularityDataLabel.Location = new System.Drawing.Point(558, 232);
            this.popularityDataLabel.Name = "popularityDataLabel";
            this.popularityDataLabel.Size = new System.Drawing.Size(179, 58);
            this.popularityDataLabel.TabIndex = 1;
            this.popularityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // psycheDataLabel
            // 
            this.psycheDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.psycheDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.psycheDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.psycheDataLabel.Location = new System.Drawing.Point(558, 174);
            this.psycheDataLabel.Name = "psycheDataLabel";
            this.psycheDataLabel.Size = new System.Drawing.Size(179, 58);
            this.psycheDataLabel.TabIndex = 1;
            this.psycheDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mentalAbilitiesLabel
            // 
            this.mentalAbilitiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abilityTableLayoutPanel.SetColumnSpan(this.mentalAbilitiesLabel, 2);
            this.mentalAbilitiesLabel.Location = new System.Drawing.Point(373, 0);
            this.mentalAbilitiesLabel.Name = "mentalAbilitiesLabel";
            this.mentalAbilitiesLabel.Size = new System.Drawing.Size(364, 58);
            this.mentalAbilitiesLabel.TabIndex = 2;
            this.mentalAbilitiesLabel.Text = "Mental Abilities";
            this.mentalAbilitiesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // strengthDataLabel
            // 
            this.strengthDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.strengthDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.strengthDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.strengthDataLabel.Location = new System.Drawing.Point(188, 174);
            this.strengthDataLabel.Name = "strengthDataLabel";
            this.strengthDataLabel.Size = new System.Drawing.Size(179, 58);
            this.strengthDataLabel.TabIndex = 1;
            this.strengthDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // intutionDataLabel
            // 
            this.intutionDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.intutionDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.intutionDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intutionDataLabel.Location = new System.Drawing.Point(558, 116);
            this.intutionDataLabel.Name = "intutionDataLabel";
            this.intutionDataLabel.Size = new System.Drawing.Size(179, 58);
            this.intutionDataLabel.TabIndex = 1;
            this.intutionDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fightingLabel
            // 
            this.fightingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fightingLabel.Location = new System.Drawing.Point(3, 58);
            this.fightingLabel.Name = "fightingLabel";
            this.fightingLabel.Size = new System.Drawing.Size(179, 58);
            this.fightingLabel.TabIndex = 2;
            this.fightingLabel.Text = "Fighting";
            this.fightingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reasonDataLabel
            // 
            this.reasonDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reasonDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reasonDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reasonDataLabel.Location = new System.Drawing.Point(558, 58);
            this.reasonDataLabel.Name = "reasonDataLabel";
            this.reasonDataLabel.Size = new System.Drawing.Size(179, 58);
            this.reasonDataLabel.TabIndex = 1;
            this.reasonDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enduranceDataLabel
            // 
            this.enduranceDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enduranceDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.enduranceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enduranceDataLabel.Location = new System.Drawing.Point(188, 232);
            this.enduranceDataLabel.Name = "enduranceDataLabel";
            this.enduranceDataLabel.Size = new System.Drawing.Size(179, 58);
            this.enduranceDataLabel.TabIndex = 1;
            this.enduranceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // popularityLabel
            // 
            this.popularityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.popularityLabel.Location = new System.Drawing.Point(373, 232);
            this.popularityLabel.Name = "popularityLabel";
            this.popularityLabel.Size = new System.Drawing.Size(179, 58);
            this.popularityLabel.TabIndex = 2;
            this.popularityLabel.Text = "Popularity";
            this.popularityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // psycheLabel
            // 
            this.psycheLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.psycheLabel.Location = new System.Drawing.Point(373, 174);
            this.psycheLabel.Name = "psycheLabel";
            this.psycheLabel.Size = new System.Drawing.Size(179, 58);
            this.psycheLabel.TabIndex = 2;
            this.psycheLabel.Text = "Psyche";
            this.psycheLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // agilityLabel
            // 
            this.agilityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.agilityLabel.Location = new System.Drawing.Point(3, 116);
            this.agilityLabel.Name = "agilityLabel";
            this.agilityLabel.Size = new System.Drawing.Size(179, 58);
            this.agilityLabel.TabIndex = 2;
            this.agilityLabel.Text = "Agility";
            this.agilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // strengthLabel
            // 
            this.strengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.strengthLabel.Location = new System.Drawing.Point(3, 174);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(179, 58);
            this.strengthLabel.TabIndex = 2;
            this.strengthLabel.Text = "Strength";
            this.strengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // intutionLabel
            // 
            this.intutionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.intutionLabel.Location = new System.Drawing.Point(373, 116);
            this.intutionLabel.Name = "intutionLabel";
            this.intutionLabel.Size = new System.Drawing.Size(179, 58);
            this.intutionLabel.TabIndex = 2;
            this.intutionLabel.Text = "Intution";
            this.intutionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enduranceLabel
            // 
            this.enduranceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enduranceLabel.Location = new System.Drawing.Point(3, 232);
            this.enduranceLabel.Name = "enduranceLabel";
            this.enduranceLabel.Size = new System.Drawing.Size(179, 58);
            this.enduranceLabel.TabIndex = 2;
            this.enduranceLabel.Text = "Endurance";
            this.enduranceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reasonLabel
            // 
            this.reasonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reasonLabel.Location = new System.Drawing.Point(373, 58);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(179, 58);
            this.reasonLabel.TabIndex = 2;
            this.reasonLabel.Text = "Reason";
            this.reasonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fighitingDataLabel
            // 
            this.fighitingDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fighitingDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fighitingDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fighitingDataLabel.Location = new System.Drawing.Point(188, 58);
            this.fighitingDataLabel.Name = "fighitingDataLabel";
            this.fighitingDataLabel.Size = new System.Drawing.Size(179, 58);
            this.fighitingDataLabel.TabIndex = 1;
            this.fighitingDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // agilityDataLabel
            // 
            this.agilityDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.agilityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.agilityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agilityDataLabel.Location = new System.Drawing.Point(188, 116);
            this.agilityDataLabel.Name = "agilityDataLabel";
            this.agilityDataLabel.Size = new System.Drawing.Size(179, 58);
            this.agilityDataLabel.TabIndex = 1;
            this.agilityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateAbilitiesButton
            // 
            this.generateAbilitiesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abilityTableLayoutPanel.SetColumnSpan(this.generateAbilitiesButton, 2);
            this.generateAbilitiesButton.Location = new System.Drawing.Point(373, 351);
            this.generateAbilitiesButton.Name = "generateAbilitiesButton";
            this.generateAbilitiesButton.Size = new System.Drawing.Size(364, 56);
            this.generateAbilitiesButton.TabIndex = 3;
            this.generateAbilitiesButton.Text = "Generate Abilities";
            this.generateAbilitiesButton.UseVisualStyleBackColor = true;
            this.generateAbilitiesButton.Click += new System.EventHandler(this.generateAbilitiesButton_Click);
            // 
            // powersPage
            // 
            this.powersPage.Location = new System.Drawing.Point(4, 33);
            this.powersPage.Name = "powersPage";
            this.powersPage.Padding = new System.Windows.Forms.Padding(3);
            this.powersPage.Size = new System.Drawing.Size(750, 423);
            this.powersPage.TabIndex = 1;
            this.powersPage.Text = "Powers";
            this.powersPage.UseVisualStyleBackColor = true;
            // 
            // characterSheet
            // 
            this.characterSheet.Controls.Add(this.heroToolStrip);
            this.characterSheet.Controls.Add(this.heroMenuStrip);
            this.characterSheet.Location = new System.Drawing.Point(4, 33);
            this.characterSheet.Name = "characterSheet";
            this.characterSheet.Padding = new System.Windows.Forms.Padding(3);
            this.characterSheet.Size = new System.Drawing.Size(750, 423);
            this.characterSheet.TabIndex = 3;
            this.characterSheet.Text = "Character Sheet";
            this.characterSheet.UseVisualStyleBackColor = true;
            // 
            // heroToolStrip
            // 
            this.heroToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator3,
            this.helpToolStripButton});
            this.heroToolStrip.Location = new System.Drawing.Point(3, 27);
            this.heroToolStrip.Name = "heroToolStrip";
            this.heroToolStrip.Size = new System.Drawing.Size(744, 25);
            this.heroToolStrip.TabIndex = 1;
            this.heroToolStrip.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // heroMenuStrip
            // 
            this.heroMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.heroMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.heroMenuStrip.Name = "heroMenuStrip";
            this.heroMenuStrip.Size = new System.Drawing.Size(744, 24);
            this.heroMenuStrip.TabIndex = 0;
            this.heroMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(113, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(669, 504);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(103, 45);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 504);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(103, 45);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // HeroGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.MainTabControl);
            this.MainMenuStrip = this.heroMenuStrip;
            this.Name = "HeroGenerator";
            this.Text = "Hero Generator";
            this.MainTabControl.ResumeLayout(false);
            this.identityPage.ResumeLayout(false);
            this.identityPage.PerformLayout();
            this.abilityPage.ResumeLayout(false);
            this.abilityTableLayoutPanel.ResumeLayout(false);
            this.characterSheet.ResumeLayout(false);
            this.characterSheet.PerformLayout();
            this.heroToolStrip.ResumeLayout(false);
            this.heroToolStrip.PerformLayout();
            this.heroMenuStrip.ResumeLayout(false);
            this.heroMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage identityPage;
        private System.Windows.Forms.TabPage abilityPage;
        private System.Windows.Forms.TabPage powersPage;
        private System.Windows.Forms.TabPage characterSheet;
        private System.Windows.Forms.MenuStrip heroMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip heroToolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox heroNameTextBox;
        private System.Windows.Forms.Label heroNameLabel;
        private System.Windows.Forms.Button generateNameButton;
        private System.Windows.Forms.Label lastNameDataLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameDataLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label fighitingDataLabel;
        private System.Windows.Forms.Label fightingLabel;
        private System.Windows.Forms.Label psycheDataLabel;
        private System.Windows.Forms.Label strengthDataLabel;
        private System.Windows.Forms.Label popularityDataLabel;
        private System.Windows.Forms.Label intutionDataLabel;
        private System.Windows.Forms.Label enduranceDataLabel;
        private System.Windows.Forms.Label reasonDataLabel;
        private System.Windows.Forms.Label agilityDataLabel;
        private System.Windows.Forms.Label psycheLabel;
        private System.Windows.Forms.Label popularityLabel;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Label intutionLabel;
        private System.Windows.Forms.Label enduranceLabel;
        private System.Windows.Forms.Label reasonLabel;
        private System.Windows.Forms.Label agilityLabel;
        private System.Windows.Forms.TableLayoutPanel abilityTableLayoutPanel;
        private System.Windows.Forms.Label physicalAbilitiesLabel;
        private System.Windows.Forms.Label mentalAbilitiesLabel;
        private System.Windows.Forms.Button generateAbilitiesButton;
    }
}
