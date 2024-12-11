namespace PaletteGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.GenerationTab = new System.Windows.Forms.TabPage();
            this.TriadPaletteView3 = new System.Windows.Forms.Panel();
            this.TriadLightOnDark = new System.Windows.Forms.Label();
            this.TriadMidOnDark = new System.Windows.Forms.Label();
            this.TriadPaletteView2 = new System.Windows.Forms.Panel();
            this.TriadLightOnMid = new System.Windows.Forms.Label();
            this.TriadDarkOnMid = new System.Windows.Forms.Label();
            this.TriadPaletteView1 = new System.Windows.Forms.Panel();
            this.TriadDarkOnLight = new System.Windows.Forms.Label();
            this.TriadMidOnLight = new System.Windows.Forms.Label();
            this.TriadPaletteButton3 = new System.Windows.Forms.Button();
            this.TriadPaletteButton2 = new System.Windows.Forms.Button();
            this.TriadPaletteButton = new System.Windows.Forms.Button();
            this.TriadPaletteButton1 = new System.Windows.Forms.Button();
            this.TriadPalettePanelLight = new System.Windows.Forms.Panel();
            this.TriadPalettePanelMid = new System.Windows.Forms.Panel();
            this.TriadPalettePanelDark = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.generateButton = new System.Windows.Forms.Button();
            this.directionInput = new System.Windows.Forms.ComboBox();
            this.directionLabel = new System.Windows.Forms.Label();
            this.numShadesInput = new System.Windows.Forms.NumericUpDown();
            this.numShadesLabel = new System.Windows.Forms.Label();
            this.hexDisplayLabel = new System.Windows.Forms.Label();
            this.colorPreviewPanel = new System.Windows.Forms.Panel();
            this.hexInput = new System.Windows.Forms.TextBox();
            this.hexLabel = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.MainTabControl.SuspendLayout();
            this.GenerationTab.SuspendLayout();
            this.TriadPaletteView3.SuspendLayout();
            this.TriadPaletteView2.SuspendLayout();
            this.TriadPaletteView1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numShadesInput)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.GenerationTab);
            this.MainTabControl.Controls.Add(this.tabPage2);
            this.MainTabControl.ItemSize = new System.Drawing.Size(128, 32);
            this.MainTabControl.Location = new System.Drawing.Point(16, 56);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1088, 544);
            this.MainTabControl.TabIndex = 0;
            // 
            // GenerationTab
            // 
            this.GenerationTab.AutoScroll = true;
            this.GenerationTab.Controls.Add(this.TriadPaletteView3);
            this.GenerationTab.Controls.Add(this.TriadPaletteView2);
            this.GenerationTab.Controls.Add(this.TriadPaletteView1);
            this.GenerationTab.Controls.Add(this.TriadPaletteButton3);
            this.GenerationTab.Controls.Add(this.TriadPaletteButton2);
            this.GenerationTab.Controls.Add(this.TriadPaletteButton);
            this.GenerationTab.Controls.Add(this.TriadPaletteButton1);
            this.GenerationTab.Controls.Add(this.TriadPalettePanelLight);
            this.GenerationTab.Controls.Add(this.TriadPalettePanelMid);
            this.GenerationTab.Controls.Add(this.TriadPalettePanelDark);
            this.GenerationTab.Controls.Add(this.label1);
            this.GenerationTab.Location = new System.Drawing.Point(4, 36);
            this.GenerationTab.Name = "GenerationTab";
            this.GenerationTab.Padding = new System.Windows.Forms.Padding(3);
            this.GenerationTab.Size = new System.Drawing.Size(1080, 504);
            this.GenerationTab.TabIndex = 0;
            this.GenerationTab.Text = "Генерация";
            this.GenerationTab.UseVisualStyleBackColor = true;
            // 
            // TriadPaletteView3
            // 
            this.TriadPaletteView3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TriadPaletteView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TriadPaletteView3.Controls.Add(this.TriadLightOnDark);
            this.TriadPaletteView3.Controls.Add(this.TriadMidOnDark);
            this.TriadPaletteView3.Location = new System.Drawing.Point(472, 206);
            this.TriadPaletteView3.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.TriadPaletteView3.Name = "TriadPaletteView3";
            this.TriadPaletteView3.Size = new System.Drawing.Size(384, 64);
            this.TriadPaletteView3.TabIndex = 3;
            // 
            // TriadLightOnDark
            // 
            this.TriadLightOnDark.BackColor = System.Drawing.Color.Transparent;
            this.TriadLightOnDark.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.TriadLightOnDark.Location = new System.Drawing.Point(0, 0);
            this.TriadLightOnDark.Margin = new System.Windows.Forms.Padding(0);
            this.TriadLightOnDark.Name = "TriadLightOnDark";
            this.TriadLightOnDark.Size = new System.Drawing.Size(192, 64);
            this.TriadLightOnDark.TabIndex = 4;
            this.TriadLightOnDark.Text = "Цвет 1";
            this.TriadLightOnDark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TriadMidOnDark
            // 
            this.TriadMidOnDark.BackColor = System.Drawing.Color.Transparent;
            this.TriadMidOnDark.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.TriadMidOnDark.Location = new System.Drawing.Point(192, 0);
            this.TriadMidOnDark.Margin = new System.Windows.Forms.Padding(0);
            this.TriadMidOnDark.Name = "TriadMidOnDark";
            this.TriadMidOnDark.Size = new System.Drawing.Size(192, 64);
            this.TriadMidOnDark.TabIndex = 4;
            this.TriadMidOnDark.Text = "Цвет 2";
            this.TriadMidOnDark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TriadPaletteView2
            // 
            this.TriadPaletteView2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TriadPaletteView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TriadPaletteView2.Controls.Add(this.TriadLightOnMid);
            this.TriadPaletteView2.Controls.Add(this.TriadDarkOnMid);
            this.TriadPaletteView2.Location = new System.Drawing.Point(472, 134);
            this.TriadPaletteView2.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.TriadPaletteView2.Name = "TriadPaletteView2";
            this.TriadPaletteView2.Size = new System.Drawing.Size(384, 64);
            this.TriadPaletteView2.TabIndex = 3;
            // 
            // TriadLightOnMid
            // 
            this.TriadLightOnMid.BackColor = System.Drawing.Color.Transparent;
            this.TriadLightOnMid.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.TriadLightOnMid.Location = new System.Drawing.Point(0, 0);
            this.TriadLightOnMid.Margin = new System.Windows.Forms.Padding(0);
            this.TriadLightOnMid.Name = "TriadLightOnMid";
            this.TriadLightOnMid.Size = new System.Drawing.Size(192, 64);
            this.TriadLightOnMid.TabIndex = 4;
            this.TriadLightOnMid.Text = "Цвет 1";
            this.TriadLightOnMid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TriadDarkOnMid
            // 
            this.TriadDarkOnMid.BackColor = System.Drawing.Color.Transparent;
            this.TriadDarkOnMid.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.TriadDarkOnMid.Location = new System.Drawing.Point(192, 0);
            this.TriadDarkOnMid.Margin = new System.Windows.Forms.Padding(0);
            this.TriadDarkOnMid.Name = "TriadDarkOnMid";
            this.TriadDarkOnMid.Size = new System.Drawing.Size(192, 64);
            this.TriadDarkOnMid.TabIndex = 4;
            this.TriadDarkOnMid.Text = "Цвет 3";
            this.TriadDarkOnMid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TriadPaletteView1
            // 
            this.TriadPaletteView1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TriadPaletteView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TriadPaletteView1.Controls.Add(this.TriadDarkOnLight);
            this.TriadPaletteView1.Controls.Add(this.TriadMidOnLight);
            this.TriadPaletteView1.Location = new System.Drawing.Point(472, 62);
            this.TriadPaletteView1.Margin = new System.Windows.Forms.Padding(32, 8, 0, 0);
            this.TriadPaletteView1.Name = "TriadPaletteView1";
            this.TriadPaletteView1.Size = new System.Drawing.Size(384, 64);
            this.TriadPaletteView1.TabIndex = 3;
            // 
            // TriadDarkOnLight
            // 
            this.TriadDarkOnLight.BackColor = System.Drawing.Color.Transparent;
            this.TriadDarkOnLight.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.TriadDarkOnLight.Location = new System.Drawing.Point(192, 0);
            this.TriadDarkOnLight.Margin = new System.Windows.Forms.Padding(0);
            this.TriadDarkOnLight.Name = "TriadDarkOnLight";
            this.TriadDarkOnLight.Size = new System.Drawing.Size(192, 64);
            this.TriadDarkOnLight.TabIndex = 4;
            this.TriadDarkOnLight.Text = "Цвет 3";
            this.TriadDarkOnLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TriadMidOnLight
            // 
            this.TriadMidOnLight.BackColor = System.Drawing.Color.Transparent;
            this.TriadMidOnLight.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.TriadMidOnLight.Location = new System.Drawing.Point(0, 0);
            this.TriadMidOnLight.Margin = new System.Windows.Forms.Padding(0);
            this.TriadMidOnLight.Name = "TriadMidOnLight";
            this.TriadMidOnLight.Size = new System.Drawing.Size(192, 64);
            this.TriadMidOnLight.TabIndex = 4;
            this.TriadMidOnLight.Text = "Цвет 2";
            this.TriadMidOnLight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TriadPaletteButton3
            // 
            this.TriadPaletteButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TriadPaletteButton3.Location = new System.Drawing.Point(312, 118);
            this.TriadPaletteButton3.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.TriadPaletteButton3.Name = "TriadPaletteButton3";
            this.TriadPaletteButton3.Size = new System.Drawing.Size(128, 32);
            this.TriadPaletteButton3.TabIndex = 2;
            this.TriadPaletteButton3.Text = "Копировать";
            this.TriadPaletteButton3.UseVisualStyleBackColor = true;
            // 
            // TriadPaletteButton2
            // 
            this.TriadPaletteButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TriadPaletteButton2.Location = new System.Drawing.Point(176, 118);
            this.TriadPaletteButton2.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.TriadPaletteButton2.Name = "TriadPaletteButton2";
            this.TriadPaletteButton2.Size = new System.Drawing.Size(128, 32);
            this.TriadPaletteButton2.TabIndex = 2;
            this.TriadPaletteButton2.Text = "Копировать";
            this.TriadPaletteButton2.UseVisualStyleBackColor = true;
            // 
            // TriadPaletteButton
            // 
            this.TriadPaletteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TriadPaletteButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.TriadPaletteButton.Location = new System.Drawing.Point(160, 182);
            this.TriadPaletteButton.Margin = new System.Windows.Forms.Padding(0);
            this.TriadPaletteButton.Name = "TriadPaletteButton";
            this.TriadPaletteButton.Size = new System.Drawing.Size(160, 48);
            this.TriadPaletteButton.TabIndex = 2;
            this.TriadPaletteButton.Text = "Сгенерировать";
            this.TriadPaletteButton.UseVisualStyleBackColor = true;
            this.TriadPaletteButton.Click += new System.EventHandler(this.TriadPaletteButton_Click);
            // 
            // TriadPaletteButton1
            // 
            this.TriadPaletteButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TriadPaletteButton1.Location = new System.Drawing.Point(40, 118);
            this.TriadPaletteButton1.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.TriadPaletteButton1.Name = "TriadPaletteButton1";
            this.TriadPaletteButton1.Size = new System.Drawing.Size(128, 32);
            this.TriadPaletteButton1.TabIndex = 2;
            this.TriadPaletteButton1.Text = "Копировать";
            this.TriadPaletteButton1.UseVisualStyleBackColor = true;
            // 
            // TriadPalettePanelLight
            // 
            this.TriadPalettePanelLight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TriadPalettePanelLight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TriadPalettePanelLight.Location = new System.Drawing.Point(312, 62);
            this.TriadPalettePanelLight.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.TriadPalettePanelLight.Name = "TriadPalettePanelLight";
            this.TriadPalettePanelLight.Size = new System.Drawing.Size(128, 48);
            this.TriadPalettePanelLight.TabIndex = 1;
            // 
            // TriadPalettePanelMid
            // 
            this.TriadPalettePanelMid.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TriadPalettePanelMid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TriadPalettePanelMid.Location = new System.Drawing.Point(176, 62);
            this.TriadPalettePanelMid.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.TriadPalettePanelMid.Name = "TriadPalettePanelMid";
            this.TriadPalettePanelMid.Size = new System.Drawing.Size(128, 48);
            this.TriadPalettePanelMid.TabIndex = 1;
            // 
            // TriadPalettePanelDark
            // 
            this.TriadPalettePanelDark.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TriadPalettePanelDark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TriadPalettePanelDark.Location = new System.Drawing.Point(40, 62);
            this.TriadPalettePanelDark.Margin = new System.Windows.Forms.Padding(0);
            this.TriadPalettePanelDark.Name = "TriadPalettePanelDark";
            this.TriadPalettePanelDark.Size = new System.Drawing.Size(128, 48);
            this.TriadPalettePanelDark.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(32, 16, 16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Триадная контрастная палитра";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelContainer);
            this.tabPage2.Controls.Add(this.generateButton);
            this.tabPage2.Controls.Add(this.directionInput);
            this.tabPage2.Controls.Add(this.directionLabel);
            this.tabPage2.Controls.Add(this.numShadesInput);
            this.tabPage2.Controls.Add(this.numShadesLabel);
            this.tabPage2.Controls.Add(this.hexDisplayLabel);
            this.tabPage2.Controls.Add(this.colorPreviewPanel);
            this.tabPage2.Controls.Add(this.hexInput);
            this.tabPage2.Controls.Add(this.hexLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1080, 504);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Генератор оттенков";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContainer.Location = new System.Drawing.Point(3, 111);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1074, 390);
            this.panelContainer.TabIndex = 9;
            // 
            // generateButton
            // 
            this.generateButton.AutoSize = true;
            this.generateButton.Location = new System.Drawing.Point(10, 71);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(159, 34);
            this.generateButton.TabIndex = 8;
            this.generateButton.Text = "Сгенерировать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // directionInput
            // 
            this.directionInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.directionInput.FormattingEnabled = true;
            this.directionInput.Items.AddRange(new object[] {
            "Светлее",
            "Темнее"});
            this.directionInput.Location = new System.Drawing.Point(900, 73);
            this.directionInput.Name = "directionInput";
            this.directionInput.Size = new System.Drawing.Size(121, 32);
            this.directionInput.TabIndex = 7;
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Location = new System.Drawing.Point(896, 32);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(137, 24);
            this.directionLabel.TabIndex = 6;
            this.directionLabel.Text = "Направление:";
            // 
            // numShadesInput
            // 
            this.numShadesInput.Location = new System.Drawing.Point(666, 71);
            this.numShadesInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numShadesInput.Name = "numShadesInput";
            this.numShadesInput.Size = new System.Drawing.Size(120, 32);
            this.numShadesInput.TabIndex = 5;
            this.numShadesInput.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numShadesLabel
            // 
            this.numShadesLabel.AutoSize = true;
            this.numShadesLabel.Location = new System.Drawing.Point(662, 32);
            this.numShadesLabel.Name = "numShadesLabel";
            this.numShadesLabel.Size = new System.Drawing.Size(214, 24);
            this.numShadesLabel.TabIndex = 4;
            this.numShadesLabel.Text = "Количество оттенков:";
            // 
            // hexDisplayLabel
            // 
            this.hexDisplayLabel.AutoSize = true;
            this.hexDisplayLabel.Location = new System.Drawing.Point(409, 32);
            this.hexDisplayLabel.Name = "hexDisplayLabel";
            this.hexDisplayLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.hexDisplayLabel.Size = new System.Drawing.Size(98, 24);
            this.hexDisplayLabel.TabIndex = 3;
            this.hexDisplayLabel.Text = "#0000FF";
            // 
            // colorPreviewPanel
            // 
            this.colorPreviewPanel.BackColor = System.Drawing.Color.Blue;
            this.colorPreviewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPreviewPanel.Location = new System.Drawing.Point(340, 20);
            this.colorPreviewPanel.Name = "colorPreviewPanel";
            this.colorPreviewPanel.Size = new System.Drawing.Size(50, 50);
            this.colorPreviewPanel.TabIndex = 2;
            // 
            // hexInput
            // 
            this.hexInput.Location = new System.Drawing.Point(224, 29);
            this.hexInput.Name = "hexInput";
            this.hexInput.Size = new System.Drawing.Size(100, 32);
            this.hexInput.TabIndex = 1;
            this.hexInput.Text = "#0000FF";
            this.hexInput.TextChanged += new System.EventHandler(this.hexInput_TextChanged);
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Location = new System.Drawing.Point(6, 35);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(212, 24);
            this.hexLabel.TabIndex = 0;
            this.hexLabel.Text = "HEX цвет (#RRGGBB):";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeaderPanel.Controls.Add(this.MinimizeButton);
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Location = new System.Drawing.Point(16, 16);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1088, 32);
            this.HeaderPanel.TabIndex = 1;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(1024, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(32, 32);
            this.MinimizeButton.TabIndex = 0;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(1056, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 32);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "x";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1120, 616);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.MainTabControl);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainTabControl.ResumeLayout(false);
            this.GenerationTab.ResumeLayout(false);
            this.GenerationTab.PerformLayout();
            this.TriadPaletteView3.ResumeLayout(false);
            this.TriadPaletteView2.ResumeLayout(false);
            this.TriadPaletteView1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numShadesInput)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage GenerationTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TriadPalettePanelLight;
        private System.Windows.Forms.Panel TriadPalettePanelMid;
        private System.Windows.Forms.Panel TriadPalettePanelDark;
        private System.Windows.Forms.Button TriadPaletteButton3;
        private System.Windows.Forms.Button TriadPaletteButton2;
        private System.Windows.Forms.Button TriadPaletteButton1;
        private System.Windows.Forms.Button TriadPaletteButton;
        private System.Windows.Forms.Panel TriadPaletteView1;
        private System.Windows.Forms.Panel TriadPaletteView3;
        private System.Windows.Forms.Panel TriadPaletteView2;
        private System.Windows.Forms.Label TriadLightOnDark;
        private System.Windows.Forms.Label TriadMidOnDark;
        private System.Windows.Forms.Label TriadLightOnMid;
        private System.Windows.Forms.Label TriadDarkOnMid;
        private System.Windows.Forms.Label TriadDarkOnLight;
        private System.Windows.Forms.Label TriadMidOnLight;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.TextBox hexInput;
        private System.Windows.Forms.Label hexDisplayLabel;
        private System.Windows.Forms.Panel colorPreviewPanel;
        private System.Windows.Forms.Label numShadesLabel;
        private System.Windows.Forms.NumericUpDown numShadesInput;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.ComboBox directionInput;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.FlowLayoutPanel panelContainer;
    }
}

