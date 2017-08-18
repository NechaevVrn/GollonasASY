namespace _123456789
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tikslujb = new System.Windows.Forms.Timer(this.components);
            this.FSDstatus = new System.Windows.Forms.Label();
            this.FSDInstance = new System.Windows.Forms.Label();
            this.FGDInstance = new System.Windows.Forms.Label();
            this.FGDstatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataProject = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.логированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DataDATA = new System.Windows.Forms.Label();
            this.бекапToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tikslujb
            // 
            this.tikslujb.Enabled = true;
            this.tikslujb.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FSDstatus
            // 
            this.FSDstatus.AutoSize = true;
            this.FSDstatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FSDstatus.Location = new System.Drawing.Point(189, 30);
            this.FSDstatus.Name = "FSDstatus";
            this.FSDstatus.Size = new System.Drawing.Size(56, 15);
            this.FSDstatus.TabIndex = 0;
            this.FSDstatus.Text = "Загрузка";
            this.FSDstatus.DoubleClick += new System.EventHandler(this.FSDstatus_DoubleClick_1);
            // 
            // FSDInstance
            // 
            this.FSDInstance.AutoSize = true;
            this.FSDInstance.Location = new System.Drawing.Point(17, 30);
            this.FSDInstance.Name = "FSDInstance";
            this.FSDInstance.Size = new System.Drawing.Size(147, 13);
            this.FSDInstance.TabIndex = 1;
            this.FSDInstance.Text = "FirebirdServerDefaultInstance";
            // 
            // FGDInstance
            // 
            this.FGDInstance.AutoSize = true;
            this.FGDInstance.Location = new System.Drawing.Point(17, 57);
            this.FGDInstance.Name = "FGDInstance";
            this.FGDInstance.Size = new System.Drawing.Size(159, 13);
            this.FGDInstance.TabIndex = 3;
            this.FGDInstance.Text = "FirebirdGuardianDefaultInstance";
            // 
            // FGDstatus
            // 
            this.FGDstatus.AutoSize = true;
            this.FGDstatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FGDstatus.Location = new System.Drawing.Point(189, 57);
            this.FGDstatus.Name = "FGDstatus";
            this.FGDstatus.Size = new System.Drawing.Size(56, 15);
            this.FGDstatus.TabIndex = 4;
            this.FGDstatus.Text = "Загрузка";
            this.FGDstatus.DoubleClick += new System.EventHandler(this.FGDstatus_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FSDInstance);
            this.groupBox1.Controls.Add(this.FGDstatus);
            this.groupBox1.Controls.Add(this.FGDInstance);
            this.groupBox1.Controls.Add(this.FSDstatus);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 99);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Службы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataDATA);
            this.groupBox2.Controls.Add(this.DataProject);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 148);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Базы Данных";
            // 
            // DataProject
            // 
            this.DataProject.AutoSize = true;
            this.DataProject.Location = new System.Drawing.Point(191, 109);
            this.DataProject.Name = "DataProject";
            this.DataProject.Size = new System.Drawing.Size(54, 13);
            this.DataProject.TabIndex = 3;
            this.DataProject.Text = "Загрузка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Restor DATA.FDB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Restor PROJECTS.FDB";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.логированиеToolStripMenuItem,
            this.бекапToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // логированиеToolStripMenuItem
            // 
            this.логированиеToolStripMenuItem.Name = "логированиеToolStripMenuItem";
            this.логированиеToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.логированиеToolStripMenuItem.Text = "Логирование";
            this.логированиеToolStripMenuItem.Click += new System.EventHandler(this.логированиеToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // DataDATA
            // 
            this.DataDATA.AutoSize = true;
            this.DataDATA.Location = new System.Drawing.Point(191, 87);
            this.DataDATA.Name = "DataDATA";
            this.DataDATA.Size = new System.Drawing.Size(54, 13);
            this.DataDATA.TabIndex = 4;
            this.DataDATA.Text = "Загрузка";
            this.DataDATA.Click += new System.EventHandler(this.label3_Click);
            // 
            // бекапToolStripMenuItem
            // 
            this.бекапToolStripMenuItem.Name = "бекапToolStripMenuItem";
            this.бекапToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.бекапToolStripMenuItem.Text = "Бекап";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 146);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Порты";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(367, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Буфризация ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 541);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tikslujb;
        private System.Windows.Forms.Label FSDstatus;
        private System.Windows.Forms.Label FSDInstance;
        private System.Windows.Forms.Label FGDInstance;
        private System.Windows.Forms.Label FGDstatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem логированиеToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label DataProject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label DataDATA;
        private System.Windows.Forms.ToolStripMenuItem бекапToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;

    }
}

