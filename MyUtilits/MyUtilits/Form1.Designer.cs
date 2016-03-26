namespace MyUtilits
{
    partial class MyUtils
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
            this.ms = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tc = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.lbCount = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnPl = new System.Windows.Forms.Button();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.btRandom = new System.Windows.Forms.Button();
            this.lbRandom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.tbRandom = new System.Windows.Forms.TextBox();
            this.btRandomClear = new System.Windows.Forms.Button();
            this.btRandomCopy = new System.Windows.Forms.Button();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.tp3 = new System.Windows.Forms.TabPage();
            this.rtbNotepad = new System.Windows.Forms.RichTextBox();
            this.tsmiNotepad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tp4 = new System.Windows.Forms.TabPage();
            this.clbPassword = new System.Windows.Forms.CheckedListBox();
            this.nudLengs = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btGenPassword = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.ms.SuspendLayout();
            this.tc.SuspendLayout();
            this.tp1.SuspendLayout();
            this.tp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            this.tp3.SuspendLayout();
            this.tp4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLengs)).BeginInit();
            this.SuspendLayout();
            // 
            // ms
            // 
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiAbout,
            this.tsmiNotepad});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(284, 24);
            this.ms.TabIndex = 0;
            this.ms.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(48, 20);
            this.tsmiFile.Text = "&Файл";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(152, 22);
            this.tsmiExit.Text = "&Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(94, 20);
            this.tsmiAbout.Text = "&О программе";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tp1);
            this.tc.Controls.Add(this.tp2);
            this.tc.Controls.Add(this.tp3);
            this.tc.Controls.Add(this.tp4);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 24);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(284, 237);
            this.tc.TabIndex = 1;
            this.tc.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tc_Selecting);
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.lbCount);
            this.tp1.Controls.Add(this.btnMin);
            this.tp1.Controls.Add(this.btnRes);
            this.tp1.Controls.Add(this.btnPl);
            this.tp1.Location = new System.Drawing.Point(4, 22);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(276, 211);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Счётчик";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(8, 32);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(0, 13);
            this.lbCount.TabIndex = 3;
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(6, 48);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(37, 23);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(49, 6);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 23);
            this.btnRes.TabIndex = 1;
            this.btnRes.Text = "Сброс";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnPl
            // 
            this.btnPl.Location = new System.Drawing.Point(6, 6);
            this.btnPl.Name = "btnPl";
            this.btnPl.Size = new System.Drawing.Size(37, 23);
            this.btnPl.TabIndex = 0;
            this.btnPl.Text = "+";
            this.btnPl.UseVisualStyleBackColor = true;
            this.btnPl.Click += new System.EventHandler(this.btnPl_Click);
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.cbRandom);
            this.tp2.Controls.Add(this.btRandomCopy);
            this.tp2.Controls.Add(this.btRandomClear);
            this.tp2.Controls.Add(this.tbRandom);
            this.tp2.Controls.Add(this.nudMax);
            this.tp2.Controls.Add(this.nudMin);
            this.tp2.Controls.Add(this.label3);
            this.tp2.Controls.Add(this.label2);
            this.tp2.Controls.Add(this.lbRandom);
            this.tp2.Controls.Add(this.btRandom);
            this.tp2.Location = new System.Drawing.Point(4, 22);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(276, 211);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "Генератор";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // btRandom
            // 
            this.btRandom.Location = new System.Drawing.Point(64, 81);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(93, 23);
            this.btRandom.TabIndex = 0;
            this.btRandom.Text = "Сгенерировать";
            this.btRandom.UseVisualStyleBackColor = true;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // lbRandom
            // 
            this.lbRandom.AutoSize = true;
            this.lbRandom.Location = new System.Drawing.Point(12, 67);
            this.lbRandom.Name = "lbRandom";
            this.lbRandom.Size = new System.Drawing.Size(10, 13);
            this.lbRandom.TabIndex = 1;
            this.lbRandom.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "От:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "До:";
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(49, 19);
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(120, 20);
            this.nudMin.TabIndex = 4;
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(49, 40);
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(120, 20);
            this.nudMax.TabIndex = 5;
            // 
            // tbRandom
            // 
            this.tbRandom.Location = new System.Drawing.Point(8, 83);
            this.tbRandom.Multiline = true;
            this.tbRandom.Name = "tbRandom";
            this.tbRandom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRandom.Size = new System.Drawing.Size(50, 120);
            this.tbRandom.TabIndex = 6;
            // 
            // btRandomClear
            // 
            this.btRandomClear.Location = new System.Drawing.Point(64, 110);
            this.btRandomClear.Name = "btRandomClear";
            this.btRandomClear.Size = new System.Drawing.Size(93, 23);
            this.btRandomClear.TabIndex = 7;
            this.btRandomClear.Text = "Отчистить";
            this.btRandomClear.UseVisualStyleBackColor = true;
            this.btRandomClear.Click += new System.EventHandler(this.btRandomClear_Click);
            // 
            // btRandomCopy
            // 
            this.btRandomCopy.Location = new System.Drawing.Point(64, 140);
            this.btRandomCopy.Name = "btRandomCopy";
            this.btRandomCopy.Size = new System.Drawing.Size(93, 23);
            this.btRandomCopy.TabIndex = 8;
            this.btRandomCopy.Text = "Копировать";
            this.btRandomCopy.UseVisualStyleBackColor = true;
            this.btRandomCopy.Click += new System.EventHandler(this.btRandomCopy_Click);
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.Location = new System.Drawing.Point(175, 22);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(95, 17);
            this.cbRandom.TabIndex = 9;
            this.cbRandom.Text = "Без повторов";
            this.cbRandom.UseVisualStyleBackColor = true;
            // 
            // tp3
            // 
            this.tp3.Controls.Add(this.rtbNotepad);
            this.tp3.Location = new System.Drawing.Point(4, 22);
            this.tp3.Name = "tp3";
            this.tp3.Size = new System.Drawing.Size(276, 211);
            this.tp3.TabIndex = 2;
            this.tp3.Text = "Блокнод";
            this.tp3.UseVisualStyleBackColor = true;
            // 
            // rtbNotepad
            // 
            this.rtbNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotepad.Location = new System.Drawing.Point(0, 0);
            this.rtbNotepad.Name = "rtbNotepad";
            this.rtbNotepad.Size = new System.Drawing.Size(276, 211);
            this.rtbNotepad.TabIndex = 0;
            this.rtbNotepad.Text = "";
            // 
            // tsmiNotepad
            // 
            this.tsmiNotepad.BackColor = System.Drawing.Color.Silver;
            this.tsmiNotepad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInsDate,
            this.tsmiInsTime,
            this.toolStripMenuItem1,
            this.tsmiFail});
            this.tsmiNotepad.Name = "tsmiNotepad";
            this.tsmiNotepad.Size = new System.Drawing.Size(66, 20);
            this.tsmiNotepad.Text = "&Блокнод";
            this.tsmiNotepad.Visible = false;
            // 
            // tsmiInsDate
            // 
            this.tsmiInsDate.Name = "tsmiInsDate";
            this.tsmiInsDate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsmiInsDate.Size = new System.Drawing.Size(232, 22);
            this.tsmiInsDate.Text = "Вставить &дату";
            this.tsmiInsDate.Click += new System.EventHandler(this.tsmiInsDate_Click);
            // 
            // tsmiInsTime
            // 
            this.tsmiInsTime.Name = "tsmiInsTime";
            this.tsmiInsTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tsmiInsTime.Size = new System.Drawing.Size(232, 22);
            this.tsmiInsTime.Text = "Вставить &время";
            this.tsmiInsTime.Click += new System.EventHandler(this.tsmiInsTime_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 6);
            // 
            // tsmiFail
            // 
            this.tsmiFail.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFSave,
            this.tsmiFLoad});
            this.tsmiFail.Name = "tsmiFail";
            this.tsmiFail.Size = new System.Drawing.Size(232, 22);
            this.tsmiFail.Text = "&Файл";
            // 
            // tsmiFSave
            // 
            this.tsmiFSave.Name = "tsmiFSave";
            this.tsmiFSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiFSave.Size = new System.Drawing.Size(172, 22);
            this.tsmiFSave.Text = "&Сохранить";
            this.tsmiFSave.Click += new System.EventHandler(this.tsmiFSave_Click);
            // 
            // tsmiFLoad
            // 
            this.tsmiFLoad.Name = "tsmiFLoad";
            this.tsmiFLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiFLoad.Size = new System.Drawing.Size(172, 22);
            this.tsmiFLoad.Text = "&Открыть";
            this.tsmiFLoad.Click += new System.EventHandler(this.tsmiFLoad_Click);
            // 
            // tp4
            // 
            this.tp4.Controls.Add(this.tbPassword);
            this.tp4.Controls.Add(this.btGenPassword);
            this.tp4.Controls.Add(this.label1);
            this.tp4.Controls.Add(this.nudLengs);
            this.tp4.Controls.Add(this.clbPassword);
            this.tp4.Location = new System.Drawing.Point(4, 22);
            this.tp4.Name = "tp4";
            this.tp4.Size = new System.Drawing.Size(276, 211);
            this.tp4.TabIndex = 3;
            this.tp4.Text = "Пароль";
            this.tp4.UseVisualStyleBackColor = true;
            // 
            // clbPassword
            // 
            this.clbPassword.CheckOnClick = true;
            this.clbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.clbPassword.FormattingEnabled = true;
            this.clbPassword.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец. символы %,*,),?,#,$,^?,&,~"});
            this.clbPassword.Location = new System.Drawing.Point(0, 0);
            this.clbPassword.Name = "clbPassword";
            this.clbPassword.Size = new System.Drawing.Size(276, 64);
            this.clbPassword.TabIndex = 0;
            this.clbPassword.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // nudLengs
            // 
            this.nudLengs.Location = new System.Drawing.Point(87, 71);
            this.nudLengs.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudLengs.Name = "nudLengs";
            this.nudLengs.Size = new System.Drawing.Size(120, 20);
            this.nudLengs.TabIndex = 1;
            this.nudLengs.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Длина пароля:";
            // 
            // btGenPassword
            // 
            this.btGenPassword.Location = new System.Drawing.Point(193, 97);
            this.btGenPassword.Name = "btGenPassword";
            this.btGenPassword.Size = new System.Drawing.Size(75, 23);
            this.btGenPassword.TabIndex = 3;
            this.btGenPassword.Text = "Сгенерироват";
            this.btGenPassword.UseVisualStyleBackColor = true;
            this.btGenPassword.Click += new System.EventHandler(this.btGenPassword_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(8, 126);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(260, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // MyUtils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.ms);
            this.MainMenuStrip = this.ms;
            this.Name = "MyUtils";
            this.Text = "Мои утилиты";
            this.Load += new System.EventHandler(this.MyUtils_Load);
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.tc.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp1.PerformLayout();
            this.tp2.ResumeLayout(false);
            this.tp2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            this.tp3.ResumeLayout(false);
            this.tp4.ResumeLayout(false);
            this.tp4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLengs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnPl;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRandom;
        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.TextBox tbRandom;
        private System.Windows.Forms.Button btRandomClear;
        private System.Windows.Forms.Button btRandomCopy;
        private System.Windows.Forms.CheckBox cbRandom;
        private System.Windows.Forms.ToolStripMenuItem tsmiNotepad;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsTime;
        private System.Windows.Forms.TabPage tp3;
        private System.Windows.Forms.RichTextBox rtbNotepad;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFail;
        private System.Windows.Forms.ToolStripMenuItem tsmiFSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiFLoad;
        private System.Windows.Forms.TabPage tp4;
        private System.Windows.Forms.CheckedListBox clbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btGenPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLengs;
    }
}

