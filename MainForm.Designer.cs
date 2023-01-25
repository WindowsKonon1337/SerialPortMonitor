namespace ASPM
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SerialOutput = new System.Windows.Forms.RichTextBox();
            this.CommandString = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.COMbox = new System.Windows.Forms.ComboBox();
            this.BaudRateBox = new System.Windows.Forms.ComboBox();
            this.ParityBox = new System.Windows.Forms.ComboBox();
            this.DataBitsBox = new System.Windows.Forms.ComboBox();
            this.StopBitsBox = new System.Windows.Forms.ComboBox();
            this.ShowSentCommCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sendColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageWIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOutputWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.StringRadioButton = new System.Windows.Forms.RadioButton();
            this.HexRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.LoopNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.LoopButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoopNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // SerialOutput
            // 
            this.SerialOutput.Font = new System.Drawing.Font("ISOCT_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SerialOutput.Location = new System.Drawing.Point(12, 27);
            this.SerialOutput.Name = "SerialOutput";
            this.SerialOutput.ReadOnly = true;
            this.SerialOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.SerialOutput.Size = new System.Drawing.Size(755, 227);
            this.SerialOutput.TabIndex = 1;
            this.SerialOutput.Text = "";
            // 
            // CommandString
            // 
            this.CommandString.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CommandString.Enabled = false;
            this.CommandString.Location = new System.Drawing.Point(12, 419);
            this.CommandString.Name = "CommandString";
            this.CommandString.Size = new System.Drawing.Size(604, 20);
            this.CommandString.TabIndex = 3;
            this.CommandString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CommandString_KeyPress);
            this.CommandString.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CommandString_KeyUp);
            // 
            // SendBtn
            // 
            this.SendBtn.Enabled = false;
            this.SendBtn.Location = new System.Drawing.Point(642, 416);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(125, 23);
            this.SendBtn.TabIndex = 4;
            this.SendBtn.Text = "send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "BaudRate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Parity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stop bits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Command";
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(641, 286);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(126, 61);
            this.OpenBtn.TabIndex = 15;
            this.OpenBtn.Text = "Open port";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // COMbox
            // 
            this.COMbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMbox.FormattingEnabled = true;
            this.COMbox.Location = new System.Drawing.Point(68, 286);
            this.COMbox.Name = "COMbox";
            this.COMbox.Size = new System.Drawing.Size(143, 21);
            this.COMbox.TabIndex = 19;
            // 
            // BaudRateBox
            // 
            this.BaudRateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRateBox.FormattingEnabled = true;
            this.BaudRateBox.Location = new System.Drawing.Point(68, 326);
            this.BaudRateBox.Name = "BaudRateBox";
            this.BaudRateBox.Size = new System.Drawing.Size(143, 21);
            this.BaudRateBox.TabIndex = 20;
            // 
            // ParityBox
            // 
            this.ParityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParityBox.FormattingEnabled = true;
            this.ParityBox.Location = new System.Drawing.Point(271, 286);
            this.ParityBox.Name = "ParityBox";
            this.ParityBox.Size = new System.Drawing.Size(143, 21);
            this.ParityBox.TabIndex = 21;
            // 
            // DataBitsBox
            // 
            this.DataBitsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBitsBox.FormattingEnabled = true;
            this.DataBitsBox.Location = new System.Drawing.Point(272, 323);
            this.DataBitsBox.Name = "DataBitsBox";
            this.DataBitsBox.Size = new System.Drawing.Size(142, 21);
            this.DataBitsBox.TabIndex = 22;
            // 
            // StopBitsBox
            // 
            this.StopBitsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBitsBox.FormattingEnabled = true;
            this.StopBitsBox.Location = new System.Drawing.Point(474, 286);
            this.StopBitsBox.Name = "StopBitsBox";
            this.StopBitsBox.Size = new System.Drawing.Size(142, 21);
            this.StopBitsBox.TabIndex = 23;
            // 
            // ShowSentCommCheckBox
            // 
            this.ShowSentCommCheckBox.AutoSize = true;
            this.ShowSentCommCheckBox.Checked = true;
            this.ShowSentCommCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowSentCommCheckBox.Location = new System.Drawing.Point(637, 393);
            this.ShowSentCommCheckBox.Name = "ShowSentCommCheckBox";
            this.ShowSentCommCheckBox.Size = new System.Drawing.Size(130, 17);
            this.ShowSentCommCheckBox.TabIndex = 24;
            this.ShowSentCommCheckBox.Text = "Show sent commands\r\n";
            this.ShowSentCommCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sessionToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.outputToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sessionToolStripMenuItem
            // 
            this.sessionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSessionToolStripMenuItem,
            this.saveSessionToolStripMenuItem});
            this.sessionToolStripMenuItem.Name = "sessionToolStripMenuItem";
            this.sessionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sessionToolStripMenuItem.Text = "Session";
            // 
            // loadSessionToolStripMenuItem
            // 
            this.loadSessionToolStripMenuItem.Name = "loadSessionToolStripMenuItem";
            this.loadSessionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadSessionToolStripMenuItem.Text = "Load Session";
            this.loadSessionToolStripMenuItem.Click += new System.EventHandler(this.loadSessionToolStripMenuItem_Click);
            // 
            // saveSessionToolStripMenuItem
            // 
            this.saveSessionToolStripMenuItem.Name = "saveSessionToolStripMenuItem";
            this.saveSessionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveSessionToolStripMenuItem.Text = "Save Session";
            this.saveSessionToolStripMenuItem.Click += new System.EventHandler(this.saveSessionToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.languageWIPToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem,
            this.sendColorToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem4,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1});
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.dToolStripMenuItem.Text = "RecieveColor";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem5.Text = "Red";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem4.Text = "Blue";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem3.Text = "Black";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem2.Text = "Green";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem1.Text = "Yellow";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sendColorToolStripMenuItem
            // 
            this.sendColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.sendColorToolStripMenuItem.Name = "sendColorToolStripMenuItem";
            this.sendColorToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sendColorToolStripMenuItem.Text = "SendColor";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem6.Text = "Red";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem7.Text = "Blue";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem8.Text = "Black";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem9.Text = "Green";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem10.Text = "Yellow";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "Monitor Font";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            this.sizeToolStripMenuItem.Click += new System.EventHandler(this.sizeToolStripMenuItem_Click);
            // 
            // languageWIPToolStripMenuItem
            // 
            this.languageWIPToolStripMenuItem.Name = "languageWIPToolStripMenuItem";
            this.languageWIPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.languageWIPToolStripMenuItem.Text = "Language(WIP)";
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearOutputWindowToolStripMenuItem});
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.outputToolStripMenuItem.Text = "Output";
            // 
            // clearOutputWindowToolStripMenuItem
            // 
            this.clearOutputWindowToolStripMenuItem.Name = "clearOutputWindowToolStripMenuItem";
            this.clearOutputWindowToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.clearOutputWindowToolStripMenuItem.Text = "Clear Output Window";
            this.clearOutputWindowToolStripMenuItem.Click += new System.EventHandler(this.clearOutputWindowToolStripMenuItem_Click);
            // 
            // StringRadioButton
            // 
            this.StringRadioButton.AutoSize = true;
            this.StringRadioButton.Checked = true;
            this.StringRadioButton.Location = new System.Drawing.Point(12, 471);
            this.StringRadioButton.Name = "StringRadioButton";
            this.StringRadioButton.Size = new System.Drawing.Size(52, 17);
            this.StringRadioButton.TabIndex = 27;
            this.StringRadioButton.TabStop = true;
            this.StringRadioButton.Text = "String";
            this.StringRadioButton.UseVisualStyleBackColor = true;
            // 
            // HexRadioButton
            // 
            this.HexRadioButton.AutoSize = true;
            this.HexRadioButton.Location = new System.Drawing.Point(104, 471);
            this.HexRadioButton.Name = "HexRadioButton";
            this.HexRadioButton.Size = new System.Drawing.Size(44, 17);
            this.HexRadioButton.TabIndex = 28;
            this.HexRadioButton.Text = "Hex";
            this.HexRadioButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Loop step:";
            // 
            // LoopNumeric
            // 
            this.LoopNumeric.Location = new System.Drawing.Point(543, 474);
            this.LoopNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.LoopNumeric.Name = "LoopNumeric";
            this.LoopNumeric.Size = new System.Drawing.Size(55, 20);
            this.LoopNumeric.TabIndex = 32;
            this.LoopNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(604, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "ms";
            // 
            // LoopButton
            // 
            this.LoopButton.Location = new System.Drawing.Point(642, 471);
            this.LoopButton.Name = "LoopButton";
            this.LoopButton.Size = new System.Drawing.Size(125, 23);
            this.LoopButton.TabIndex = 34;
            this.LoopButton.Text = "Start loop";
            this.LoopButton.UseVisualStyleBackColor = true;
            this.LoopButton.Click += new System.EventHandler(this.LoopButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 506);
            this.Controls.Add(this.LoopButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LoopNumeric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HexRadioButton);
            this.Controls.Add(this.StringRadioButton);
            this.Controls.Add(this.ShowSentCommCheckBox);
            this.Controls.Add(this.StopBitsBox);
            this.Controls.Add(this.DataBitsBox);
            this.Controls.Add(this.ParityBox);
            this.Controls.Add(this.BaudRateBox);
            this.Controls.Add(this.COMbox);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.CommandString);
            this.Controls.Add(this.SerialOutput);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Serial Port Monitor by WindowsKonon1337";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoopNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RichTextBox SerialOutput;
        private System.Windows.Forms.TextBox CommandString;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.ComboBox COMbox;
        private System.Windows.Forms.ComboBox BaudRateBox;
        private System.Windows.Forms.ComboBox ParityBox;
        private System.Windows.Forms.ComboBox DataBitsBox;
        private System.Windows.Forms.ComboBox StopBitsBox;
        private System.Windows.Forms.CheckBox ShowSentCommCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageWIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sendColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RadioButton StringRadioButton;
        private System.Windows.Forms.RadioButton HexRadioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown LoopNumeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button LoopButton;
        private System.Windows.Forms.ToolStripMenuItem outputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearOutputWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSessionToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
    }
}

