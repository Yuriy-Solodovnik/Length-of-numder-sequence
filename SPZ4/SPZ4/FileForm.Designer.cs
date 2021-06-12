namespace SPZ4
{
    partial class FileForm
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
            this.FileContent = new System.Windows.Forms.TextBox();
            this.labelTowrite = new System.Windows.Forms.Label();
            this.buttonCreateFile = new System.Windows.Forms.Button();
            this.ReadFromFile = new System.Windows.Forms.Button();
            this.labelToRead = new System.Windows.Forms.Label();
            this.FromFile = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.Button();
            this.CountOfIntegers = new System.Windows.Forms.TextBox();
            this.CreateFile = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.Generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileContent
            // 
            this.FileContent.Location = new System.Drawing.Point(16, 38);
            this.FileContent.Name = "FileContent";
            this.FileContent.Size = new System.Drawing.Size(298, 20);
            this.FileContent.TabIndex = 0;
            // 
            // labelTowrite
            // 
            this.labelTowrite.AutoSize = true;
            this.labelTowrite.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTowrite.Location = new System.Drawing.Point(68, 13);
            this.labelTowrite.Name = "labelTowrite";
            this.labelTowrite.Size = new System.Drawing.Size(193, 20);
            this.labelTowrite.TabIndex = 1;
            this.labelTowrite.Text = "Введите содержимое файла";
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateFile.Location = new System.Drawing.Point(16, 77);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Size = new System.Drawing.Size(98, 37);
            this.buttonCreateFile.TabIndex = 2;
            this.buttonCreateFile.Text = "Записать";
            this.buttonCreateFile.UseVisualStyleBackColor = true;
            this.buttonCreateFile.Click += new System.EventHandler(this.buttonCreateFile_Click);
            // 
            // ReadFromFile
            // 
            this.ReadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadFromFile.Location = new System.Drawing.Point(640, 77);
            this.ReadFromFile.Name = "ReadFromFile";
            this.ReadFromFile.Size = new System.Drawing.Size(117, 37);
            this.ReadFromFile.TabIndex = 5;
            this.ReadFromFile.Text = "Прочитать файл";
            this.ReadFromFile.UseVisualStyleBackColor = true;
            this.ReadFromFile.Click += new System.EventHandler(this.ReadFromFile_Click);
            // 
            // labelToRead
            // 
            this.labelToRead.AutoSize = true;
            this.labelToRead.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToRead.Location = new System.Drawing.Point(487, 15);
            this.labelToRead.Name = "labelToRead";
            this.labelToRead.Size = new System.Drawing.Size(213, 20);
            this.labelToRead.TabIndex = 4;
            this.labelToRead.Text = "Прочитать содержимое файла";
            // 
            // FromFile
            // 
            this.FromFile.Location = new System.Drawing.Point(414, 38);
            this.FromFile.Name = "FromFile";
            this.FromFile.ReadOnly = true;
            this.FromFile.Size = new System.Drawing.Size(343, 20);
            this.FromFile.TabIndex = 3;
            // 
            // Count
            // 
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.Location = new System.Drawing.Point(17, 181);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(118, 35);
            this.Count.TabIndex = 6;
            this.Count.Text = "Рассчитать";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // CountOfIntegers
            // 
            this.CountOfIntegers.Location = new System.Drawing.Point(141, 189);
            this.CountOfIntegers.Name = "CountOfIntegers";
            this.CountOfIntegers.ReadOnly = true;
            this.CountOfIntegers.Size = new System.Drawing.Size(173, 20);
            this.CountOfIntegers.TabIndex = 7;
            // 
            // CreateFile
            // 
            this.CreateFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateFile.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateFile.Location = new System.Drawing.Point(0, 383);
            this.CreateFile.Name = "CreateFile";
            this.CreateFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CreateFile.Size = new System.Drawing.Size(780, 46);
            this.CreateFile.TabIndex = 8;
            this.CreateFile.Text = "Создать файл";
            this.CreateFile.UseVisualStyleBackColor = true;
            this.CreateFile.Click += new System.EventHandler(this.CreateFile_Click);
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(17, 222);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(297, 24);
            this.comboBox.TabIndex = 9;
            this.comboBox.Text = "Что посчитать?";
            // 
            // Generate
            // 
            this.Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generate.Location = new System.Drawing.Point(120, 77);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(86, 37);
            this.Generate.TabIndex = 10;
            this.Generate.Text = "Генерация";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 429);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.CreateFile);
            this.Controls.Add(this.CountOfIntegers);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.ReadFromFile);
            this.Controls.Add(this.labelToRead);
            this.Controls.Add(this.FromFile);
            this.Controls.Add(this.buttonCreateFile);
            this.Controls.Add(this.labelTowrite);
            this.Controls.Add(this.FileContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "FileForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "FileOperations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileContent;
        private System.Windows.Forms.Label labelTowrite;
        private System.Windows.Forms.Button buttonCreateFile;
        private System.Windows.Forms.Button ReadFromFile;
        private System.Windows.Forms.Label labelToRead;
        private System.Windows.Forms.TextBox FromFile;
        private System.Windows.Forms.Button Count;
        private System.Windows.Forms.TextBox CountOfIntegers;
        private System.Windows.Forms.Button CreateFile;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button Generate;
    }
}

