namespace Test_2
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.negative_button = new System.Windows.Forms.Button();
            this.Sharp_button = new System.Windows.Forms.Button();
            this.button_filter_test = new System.Windows.Forms.Button();
            this.Apply_britness = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Contrast_bar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Brightness_bar = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Apply_Filter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(234, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 511);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Apply_Filter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.negative_button);
            this.groupBox1.Controls.Add(this.Sharp_button);
            this.groupBox1.Controls.Add(this.button_filter_test);
            this.groupBox1.Controls.Add(this.Apply_britness);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Contrast_bar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Brightness_bar);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 533);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструменты";
            // 
            // negative_button
            // 
            this.negative_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.negative_button.Location = new System.Drawing.Point(11, 335);
            this.negative_button.Name = "negative_button";
            this.negative_button.Size = new System.Drawing.Size(196, 29);
            this.negative_button.TabIndex = 12;
            this.negative_button.Text = "Негатив";
            this.negative_button.UseVisualStyleBackColor = true;
            this.negative_button.Click += new System.EventHandler(this.negative_button_Click);
            // 
            // Sharp_button
            // 
            this.Sharp_button.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sharp_button.Location = new System.Drawing.Point(13, 248);
            this.Sharp_button.Name = "Sharp_button";
            this.Sharp_button.Size = new System.Drawing.Size(196, 29);
            this.Sharp_button.TabIndex = 11;
            this.Sharp_button.Text = "Резкость";
            this.Sharp_button.UseVisualStyleBackColor = true;
            this.Sharp_button.Click += new System.EventHandler(this.Sharp_button_Click);
            // 
            // button_filter_test
            // 
            this.button_filter_test.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_filter_test.Location = new System.Drawing.Point(13, 214);
            this.button_filter_test.Name = "button_filter_test";
            this.button_filter_test.Size = new System.Drawing.Size(70, 29);
            this.button_filter_test.TabIndex = 10;
            this.button_filter_test.Text = "Размыть";
            this.button_filter_test.UseVisualStyleBackColor = true;
            this.button_filter_test.Click += new System.EventHandler(this.button_filter_test_Click);
            // 
            // Apply_britness
            // 
            this.Apply_britness.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Apply_britness.Location = new System.Drawing.Point(11, 140);
            this.Apply_britness.Name = "Apply_britness";
            this.Apply_britness.Size = new System.Drawing.Size(79, 30);
            this.Apply_britness.TabIndex = 7;
            this.Apply_britness.Text = "Применить";
            this.Apply_britness.UseVisualStyleBackColor = true;
            this.Apply_britness.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Контрастность";
            // 
            // Contrast_bar
            // 
            this.Contrast_bar.Location = new System.Drawing.Point(6, 102);
            this.Contrast_bar.Maximum = 8;
            this.Contrast_bar.Minimum = -8;
            this.Contrast_bar.Name = "Contrast_bar";
            this.Contrast_bar.Size = new System.Drawing.Size(201, 45);
            this.Contrast_bar.TabIndex = 3;
            this.Contrast_bar.Scroll += new System.EventHandler(this.Contrast_bar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Яркость";
            // 
            // Brightness_bar
            // 
            this.Brightness_bar.Location = new System.Drawing.Point(6, 51);
            this.Brightness_bar.Maximum = 8;
            this.Brightness_bar.Minimum = -8;
            this.Brightness_bar.Name = "Brightness_bar";
            this.Brightness_bar.Size = new System.Drawing.Size(201, 45);
            this.Brightness_bar.TabIndex = 1;
            this.Brightness_bar.Scroll += new System.EventHandler(this.Brightness_bar_Scroll);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(168, 215);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 28);
            this.numericUpDown1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(89, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Степень: ";
            // 
            // Apply_Filter
            // 
            this.Apply_Filter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Apply_Filter.Location = new System.Drawing.Point(13, 282);
            this.Apply_Filter.Name = "Apply_Filter";
            this.Apply_Filter.Size = new System.Drawing.Size(196, 29);
            this.Apply_Filter.TabIndex = 17;
            this.Apply_Filter.Text = "Применить";
            this.Apply_Filter.UseVisualStyleBackColor = true;
            this.Apply_Filter.Click += new System.EventHandler(this.Apply_Filter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Фильтры";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar Contrast_bar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar Brightness_bar;
        private System.Windows.Forms.Button Apply_britness;
        private System.Windows.Forms.Button button_filter_test;
        private System.Windows.Forms.Button Sharp_button;
        private System.Windows.Forms.Button negative_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button Apply_Filter;
        private System.Windows.Forms.Label label3;
    }
}

