namespace EditorText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьДляПросмотраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакДокументWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditorTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьЭффектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьЭффектывыделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.сохранитьДокументКакRtfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьДокументRtfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьДокументWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.Location = new System.Drawing.Point(1, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(875, 425);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem8});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.открытьДляПросмотраToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.открытьДокументWordToolStripMenuItem,
            this.сохранитьКакДокументWordToolStripMenuItem,
            this.открытьДокументRtfToolStripMenuItem,
            this.сохранитьДокументКакRtfToolStripMenuItem,
            this.EditorTextToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // открытьДляПросмотраToolStripMenuItem
            // 
            this.открытьДляПросмотраToolStripMenuItem.Name = "открытьДляПросмотраToolStripMenuItem";
            this.открытьДляПросмотраToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.открытьДляПросмотраToolStripMenuItem.Text = "Открыть для просмотра";
            this.открытьДляПросмотраToolStripMenuItem.Click += new System.EventHandler(this.открытьДляПросмотраToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакДокументWordToolStripMenuItem
            // 
            this.сохранитьКакДокументWordToolStripMenuItem.Name = "сохранитьКакДокументWordToolStripMenuItem";
            this.сохранитьКакДокументWordToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.сохранитьКакДокументWordToolStripMenuItem.Text = "Сохранить как документ word";
            this.сохранитьКакДокументWordToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакДокументWordToolStripMenuItem_Click);
            // 
            // EditorTextToolStripMenuItem
            // 
            this.EditorTextToolStripMenuItem.Name = "EditorTextToolStripMenuItem";
            this.EditorTextToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.EditorTextToolStripMenuItem.Text = "Сохранить как документ Editor Text";
            this.EditorTextToolStripMenuItem.Click += new System.EventHandler(this.EditorTextToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьЭффектыToolStripMenuItem,
            this.очиститьЭффектывыделениеToolStripMenuItem});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // очиститьЭффектыToolStripMenuItem
            // 
            this.очиститьЭффектыToolStripMenuItem.Name = "очиститьЭффектыToolStripMenuItem";
            this.очиститьЭффектыToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.очиститьЭффектыToolStripMenuItem.Text = "Очистить эффекты";
            this.очиститьЭффектыToolStripMenuItem.Click += new System.EventHandler(this.очиститьЭффектыToolStripMenuItem_Click);
            // 
            // очиститьЭффектывыделениеToolStripMenuItem
            // 
            this.очиститьЭффектывыделениеToolStripMenuItem.Name = "очиститьЭффектывыделениеToolStripMenuItem";
            this.очиститьЭффектывыделениеToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.очиститьЭффектывыделениеToolStripMenuItem.Text = "Очистить эффекты (выделение)";
            this.очиститьЭффектывыделениеToolStripMenuItem.Click += new System.EventHandler(this.очиститьЭффектывыделениеToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem6.Image")));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem7.Image")));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem8.Image")));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(430, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Microsoft Sans Serif"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Microsoft Sans Serif",
            "Arial",
            "Impact",
            "academy engraved let",
            "algerian",
            "amaze",
            "arial black",
            "balthazar",
            "bankgothic lt bt",
            "bart",
            "bimini",
            "book antiqua",
            "bookman old style",
            "braggadocio",
            "britannic bold",
            "brush script mt",
            "calibri",
            "cambria",
            "candara",
            "century gothic",
            "century schoolbook",
            "chasm",
            "chicago",
            "colonna mt",
            "comic sans ms",
            "commercialscript bt",
            "consolas",
            "constantia",
            "coolsville",
            "corbel",
            "courier",
            "courier new",
            "cursive",
            "dayton",
            "desdemona",
            "estrangelo edessa",
            "fantasy",
            "flat brush"});
            this.comboBox1.Location = new System.Drawing.Point(527, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Microsoft Sans Serif";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Размер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Шрифт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цвет";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Green",
            "Blue"});
            this.comboBox2.Location = new System.Drawing.Point(692, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.Text = "Black";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // сохранитьДокументКакRtfToolStripMenuItem
            // 
            this.сохранитьДокументКакRtfToolStripMenuItem.Name = "сохранитьДокументКакRtfToolStripMenuItem";
            this.сохранитьДокументКакRtfToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.сохранитьДокументКакRtfToolStripMenuItem.Text = "Сохранить документ как rtf";
            this.сохранитьДокументКакRtfToolStripMenuItem.Click += new System.EventHandler(this.сохранитьДокументКакRtfToolStripMenuItem_Click);
            // 
            // открытьДокументRtfToolStripMenuItem
            // 
            this.открытьДокументRtfToolStripMenuItem.Name = "открытьДокументRtfToolStripMenuItem";
            this.открытьДокументRtfToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.открытьДокументRtfToolStripMenuItem.Text = "Открыть документ rtf";
            this.открытьДокументRtfToolStripMenuItem.Click += new System.EventHandler(this.открытьДокументRtfToolStripMenuItem_Click);
            // 
            // открытьДокументWordToolStripMenuItem
            // 
            this.открытьДокументWordToolStripMenuItem.Name = "открытьДокументWordToolStripMenuItem";
            this.открытьДокументWordToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.открытьДокументWordToolStripMenuItem.Text = "Открыть документ word";
            this.открытьДокументWordToolStripMenuItem.Click += new System.EventHandler(this.открытьДокументWordToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "EditorText";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьЭффектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьЭффектывыделениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьДляПросмотраToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакДокументWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditorTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьДокументКакRtfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьДокументRtfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьДокументWordToolStripMenuItem;
    }
}

