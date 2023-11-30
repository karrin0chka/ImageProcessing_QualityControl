namespace ОИ_Практика1
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uQIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uQIBlocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.усреднениеСАльфасдвигомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрГауссаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гистограммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripDropDownButton();
            this.методСобеляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискОкружностейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripDropDownButton();
            this.прямоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрНизкихЧастотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.фильтрВысокихЧастотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обратноеПреобразованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel3,
            this.toolStripLabel2,
            this.toolStripLabel5,
            this.toolStripLabel4,
            this.toolStripLabel6,
            this.toolStripLabel7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1254, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 24);
            this.toolStripLabel1.Text = "Open1";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(53, 24);
            this.toolStripLabel3.Text = "Open2";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSEToolStripMenuItem,
            this.uQIToolStripMenuItem,
            this.uQIBlocksToolStripMenuItem});
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(139, 24);
            this.toolStripLabel2.Text = "Оценка качества";
            // 
            // mSEToolStripMenuItem
            // 
            this.mSEToolStripMenuItem.Name = "mSEToolStripMenuItem";
            this.mSEToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.mSEToolStripMenuItem.Text = "MSE";
            this.mSEToolStripMenuItem.Click += new System.EventHandler(this.mSEToolStripMenuItem_Click);
            // 
            // uQIToolStripMenuItem
            // 
            this.uQIToolStripMenuItem.Name = "uQIToolStripMenuItem";
            this.uQIToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.uQIToolStripMenuItem.Text = "UQI";
            this.uQIToolStripMenuItem.Click += new System.EventHandler(this.uQIToolStripMenuItem_Click);
            // 
            // uQIBlocksToolStripMenuItem
            // 
            this.uQIBlocksToolStripMenuItem.Name = "uQIBlocksToolStripMenuItem";
            this.uQIBlocksToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.uQIBlocksToolStripMenuItem.Text = "UQI blocks";
            this.uQIBlocksToolStripMenuItem.Click += new System.EventHandler(this.uQIBlocksToolStripMenuItem_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(105, 24);
            this.toolStripLabel5.Text = "GaussianNoise";
            this.toolStripLabel5.Click += new System.EventHandler(this.toolStripLabel5_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.усреднениеСАльфасдвигомToolStripMenuItem,
            this.фильтрГауссаToolStripMenuItem,
            this.гистограммаToolStripMenuItem});
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(85, 24);
            this.toolStripLabel4.Text = "Фильтры";
            // 
            // усреднениеСАльфасдвигомToolStripMenuItem
            // 
            this.усреднениеСАльфасдвигомToolStripMenuItem.Name = "усреднениеСАльфасдвигомToolStripMenuItem";
            this.усреднениеСАльфасдвигомToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.усреднениеСАльфасдвигомToolStripMenuItem.Text = "Усреднение с альфа-сдвигом";
            this.усреднениеСАльфасдвигомToolStripMenuItem.Click += new System.EventHandler(this.усреднениеСАльфасдвигомToolStripMenuItem_Click);
            // 
            // фильтрГауссаToolStripMenuItem
            // 
            this.фильтрГауссаToolStripMenuItem.Name = "фильтрГауссаToolStripMenuItem";
            this.фильтрГауссаToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.фильтрГауссаToolStripMenuItem.Text = "Фильтр Гаусса";
            this.фильтрГауссаToolStripMenuItem.Click += new System.EventHandler(this.фильтрГауссаToolStripMenuItem_Click);
            // 
            // гистограммаToolStripMenuItem
            // 
            this.гистограммаToolStripMenuItem.Name = "гистограммаToolStripMenuItem";
            this.гистограммаToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.гистограммаToolStripMenuItem.Text = "Гистограмма";
            this.гистограммаToolStripMenuItem.Click += new System.EventHandler(this.гистограммаToolStripMenuItem_Click);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.методСобеляToolStripMenuItem,
            this.поискОкружностейToolStripMenuItem});
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(155, 24);
            this.toolStripLabel6.Text = "Выделение границ";
            // 
            // методСобеляToolStripMenuItem
            // 
            this.методСобеляToolStripMenuItem.Name = "методСобеляToolStripMenuItem";
            this.методСобеляToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.методСобеляToolStripMenuItem.Text = "Метод Собеля";
            this.методСобеляToolStripMenuItem.Click += new System.EventHandler(this.методСобеляToolStripMenuItem_Click);
            // 
            // поискОкружностейToolStripMenuItem
            // 
            this.поискОкружностейToolStripMenuItem.Name = "поискОкружностейToolStripMenuItem";
            this.поискОкружностейToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.поискОкружностейToolStripMenuItem.Text = "Поиск окружностей";
            this.поискОкружностейToolStripMenuItem.Click += new System.EventHandler(this.поискОкружностейToolStripMenuItem_Click);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прямоеToolStripMenuItem,
            this.фильтрНизкихЧастотToolStripMenuItem,
            this.фильтрВысокихЧастотToolStripMenuItem,
            this.обратноеПреобразованиеToolStripMenuItem});
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(66, 24);
            this.toolStripLabel7.Text = "Фурье";
            // 
            // прямоеToolStripMenuItem
            // 
            this.прямоеToolStripMenuItem.Name = "прямоеToolStripMenuItem";
            this.прямоеToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.прямоеToolStripMenuItem.Text = "Прямое преобразование";
            this.прямоеToolStripMenuItem.Click += new System.EventHandler(this.прямоеToolStripMenuItem_Click_1);
            // 
            // фильтрНизкихЧастотToolStripMenuItem
            // 
            this.фильтрНизкихЧастотToolStripMenuItem.Name = "фильтрНизкихЧастотToolStripMenuItem";
            this.фильтрНизкихЧастотToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.фильтрНизкихЧастотToolStripMenuItem.Text = "Фильтр низких частот";
            this.фильтрНизкихЧастотToolStripMenuItem.Click += new System.EventHandler(this.фильтрНизкихЧастотToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 481);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(636, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(601, 481);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 3;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // фильтрВысокихЧастотToolStripMenuItem
            // 
            this.фильтрВысокихЧастотToolStripMenuItem.Name = "фильтрВысокихЧастотToolStripMenuItem";
            this.фильтрВысокихЧастотToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.фильтрВысокихЧастотToolStripMenuItem.Text = "Фильтр высоких частот";
            this.фильтрВысокихЧастотToolStripMenuItem.Click += new System.EventHandler(this.фильтрВысокихЧастотToolStripMenuItem_Click);
            // 
            // обратноеПреобразованиеToolStripMenuItem
            // 
            this.обратноеПреобразованиеToolStripMenuItem.Name = "обратноеПреобразованиеToolStripMenuItem";
            this.обратноеПреобразованиеToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.обратноеПреобразованиеToolStripMenuItem.Text = "Обратное преобразование";
            this.обратноеПреобразованиеToolStripMenuItem.Click += new System.EventHandler(this.обратноеПреобразованиеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem mSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uQIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uQIBlocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel4;
        private System.Windows.Forms.ToolStripMenuItem усреднениеСАльфасдвигомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрГауссаToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel6;
        private System.Windows.Forms.ToolStripMenuItem методСобеляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискОкружностейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гистограммаToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel7;
        private System.Windows.Forms.ToolStripMenuItem прямоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрНизкихЧастотToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фильтрВысокихЧастотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обратноеПреобразованиеToolStripMenuItem;
    }
}

