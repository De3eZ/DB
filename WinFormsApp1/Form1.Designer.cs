namespace WinFormsApp1
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            запросыToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            заказыПоМастерамToolStripMenuItem = new ToolStripMenuItem();
            моделиПоСезонамToolStripMenuItem = new ToolStripMenuItem();
            тканьПоНазваниюИлиПоЦветуToolStripMenuItem = new ToolStripMenuItem();
            назначитьМастераНаЗаказПоСтажуToolStripMenuItem = new ToolStripMenuItem();
            menuStrip3 = new MenuStrip();
            отчётыToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            клиентыToolStripMenuItem = new ToolStripMenuItem();
            мастераToolStripMenuItem = new ToolStripMenuItem();
            тканиToolStripMenuItem = new ToolStripMenuItem();
            моделиToolStripMenuItem = new ToolStripMenuItem();
            размерыToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            menuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(217, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(158, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { запросыToolStripMenuItem });
            menuStrip2.Location = new Point(125, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(92, 28);
            menuStrip2.TabIndex = 5;
            menuStrip2.Text = "menuStrip2";
            // 
            // запросыToolStripMenuItem
            // 
            запросыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, заказыПоМастерамToolStripMenuItem, моделиПоСезонамToolStripMenuItem, тканьПоНазваниюИлиПоЦветуToolStripMenuItem, назначитьМастераНаЗаказПоСтажуToolStripMenuItem });
            запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            запросыToolStripMenuItem.Size = new Size(84, 24);
            запросыToolStripMenuItem.Text = "Запросы";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(354, 26);
            toolStripMenuItem3.Text = "Состояние заказов";
            // 
            // заказыПоМастерамToolStripMenuItem
            // 
            заказыПоМастерамToolStripMenuItem.Name = "заказыПоМастерамToolStripMenuItem";
            заказыПоМастерамToolStripMenuItem.Size = new Size(354, 26);
            заказыПоМастерамToolStripMenuItem.Text = "Заказы по мастерам";
            // 
            // моделиПоСезонамToolStripMenuItem
            // 
            моделиПоСезонамToolStripMenuItem.Name = "моделиПоСезонамToolStripMenuItem";
            моделиПоСезонамToolStripMenuItem.Size = new Size(354, 26);
            моделиПоСезонамToolStripMenuItem.Text = "Модели по сезонам";
            // 
            // тканьПоНазваниюИлиПоЦветуToolStripMenuItem
            // 
            тканьПоНазваниюИлиПоЦветуToolStripMenuItem.Name = "тканьПоНазваниюИлиПоЦветуToolStripMenuItem";
            тканьПоНазваниюИлиПоЦветуToolStripMenuItem.Size = new Size(354, 26);
            тканьПоНазваниюИлиПоЦветуToolStripMenuItem.Text = "Ткань по названию или по цвету";
            // 
            // назначитьМастераНаЗаказПоСтажуToolStripMenuItem
            // 
            назначитьМастераНаЗаказПоСтажуToolStripMenuItem.Name = "назначитьМастераНаЗаказПоСтажуToolStripMenuItem";
            назначитьМастераНаЗаказПоСтажуToolStripMenuItem.Size = new Size(354, 26);
            назначитьМастераНаЗаказПоСтажуToolStripMenuItem.Text = "Назначить мастера на заказ по стажу";
            // 
            // menuStrip3
            // 
            menuStrip3.Dock = DockStyle.None;
            menuStrip3.ImageScalingSize = new Size(20, 20);
            menuStrip3.Items.AddRange(new ToolStripItem[] { отчётыToolStripMenuItem });
            menuStrip3.Location = new Point(0, 0);
            menuStrip3.Name = "menuStrip3";
            menuStrip3.Size = new Size(125, 28);
            menuStrip3.TabIndex = 6;
            menuStrip3.Text = "menuStrip3";
            // 
            // отчётыToolStripMenuItem
            // 
            отчётыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, клиентыToolStripMenuItem, мастераToolStripMenuItem, тканиToolStripMenuItem, моделиToolStripMenuItem, размерыToolStripMenuItem });
            отчётыToolStripMenuItem.Size = new Size(117, 24);
            отчётыToolStripMenuItem.Text = "Справочники";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(224, 26);
            toolStripMenuItem2.Text = "Заказы";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // клиентыToolStripMenuItem
            // 
            клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            клиентыToolStripMenuItem.Size = new Size(224, 26);
            клиентыToolStripMenuItem.Text = "Клиенты";
            клиентыToolStripMenuItem.Click += клиентыToolStripMenuItem_Click;
            // 
            // мастераToolStripMenuItem
            // 
            мастераToolStripMenuItem.Name = "мастераToolStripMenuItem";
            мастераToolStripMenuItem.Size = new Size(224, 26);
            мастераToolStripMenuItem.Text = "Мастера";
            // 
            // тканиToolStripMenuItem
            // 
            тканиToolStripMenuItem.Name = "тканиToolStripMenuItem";
            тканиToolStripMenuItem.Size = new Size(224, 26);
            тканиToolStripMenuItem.Text = "Ткани";
            // 
            // моделиToolStripMenuItem
            // 
            моделиToolStripMenuItem.Name = "моделиToolStripMenuItem";
            моделиToolStripMenuItem.Size = new Size(224, 26);
            моделиToolStripMenuItem.Text = "Модели";
            // 
            // размерыToolStripMenuItem
            // 
            размерыToolStripMenuItem.Name = "размерыToolStripMenuItem";
            размерыToolStripMenuItem.Size = new Size(224, 26);
            размерыToolStripMenuItem.Text = "Размеры";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Ателье";
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            menuStrip3.ResumeLayout(false);
            menuStrip3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem запросыToolStripMenuItem;
        private MenuStrip menuStrip3;
        private ToolStripMenuItem отчётыToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem заказыПоМастерамToolStripMenuItem;
        private ToolStripMenuItem моделиПоСезонамToolStripMenuItem;
        private ToolStripMenuItem тканьПоНазваниюИлиПоЦветуToolStripMenuItem;
        private ToolStripMenuItem назначитьМастераНаЗаказПоСтажуToolStripMenuItem;
        private ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem мастераToolStripMenuItem;
        private ToolStripMenuItem тканиToolStripMenuItem;
        private ToolStripMenuItem моделиToolStripMenuItem;
        private ToolStripMenuItem размерыToolStripMenuItem;
    }
}