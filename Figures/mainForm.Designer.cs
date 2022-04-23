
namespace Figures
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.RbPolygon = new System.Windows.Forms.RadioButton();
            this.RbTriangle = new System.Windows.Forms.RadioButton();
            this.RbCircle = new System.Windows.Forms.RadioButton();
            this.RbSquare = new System.Windows.Forms.RadioButton();
            this.RbReactangle = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.инструкцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RbPolygon
            // 
            this.RbPolygon.AutoSize = true;
            this.RbPolygon.Location = new System.Drawing.Point(9, 34);
            this.RbPolygon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbPolygon.Name = "RbPolygon";
            this.RbPolygon.Size = new System.Drawing.Size(103, 17);
            this.RbPolygon.TabIndex = 0;
            this.RbPolygon.TabStop = true;
            this.RbPolygon.Text = "Многоугольник";
            this.RbPolygon.UseVisualStyleBackColor = true;
            // 
            // RbTriangle
            // 
            this.RbTriangle.AutoSize = true;
            this.RbTriangle.Location = new System.Drawing.Point(133, 34);
            this.RbTriangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbTriangle.Name = "RbTriangle";
            this.RbTriangle.Size = new System.Drawing.Size(90, 17);
            this.RbTriangle.TabIndex = 1;
            this.RbTriangle.TabStop = true;
            this.RbTriangle.Text = "Треугольник";
            this.RbTriangle.UseVisualStyleBackColor = true;
            // 
            // RbCircle
            // 
            this.RbCircle.AutoSize = true;
            this.RbCircle.Location = new System.Drawing.Point(250, 34);
            this.RbCircle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbCircle.Name = "RbCircle";
            this.RbCircle.Size = new System.Drawing.Size(48, 17);
            this.RbCircle.TabIndex = 2;
            this.RbCircle.TabStop = true;
            this.RbCircle.Text = "Круг";
            this.RbCircle.UseVisualStyleBackColor = true;
            // 
            // RbSquare
            // 
            this.RbSquare.AutoSize = true;
            this.RbSquare.Location = new System.Drawing.Point(331, 34);
            this.RbSquare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbSquare.Name = "RbSquare";
            this.RbSquare.Size = new System.Drawing.Size(67, 17);
            this.RbSquare.TabIndex = 3;
            this.RbSquare.TabStop = true;
            this.RbSquare.Text = "Квадрат";
            this.RbSquare.UseVisualStyleBackColor = true;
            // 
            // RbReactangle
            // 
            this.RbReactangle.AutoSize = true;
            this.RbReactangle.Location = new System.Drawing.Point(427, 34);
            this.RbReactangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RbReactangle.Name = "RbReactangle";
            this.RbReactangle.Size = new System.Drawing.Size(105, 17);
            this.RbReactangle.TabIndex = 4;
            this.RbReactangle.TabStop = true;
            this.RbReactangle.Text = "Прямоугольник";
            this.RbReactangle.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инструкцияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // инструкцияToolStripMenuItem
            // 
            this.инструкцияToolStripMenuItem.Name = "инструкцияToolStripMenuItem";
            this.инструкцияToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.инструкцияToolStripMenuItem.Text = "Инструкция";
            this.инструкцияToolStripMenuItem.Click += new System.EventHandler(this.инструкцияToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(761, 439);
            this.Controls.Add(this.RbReactangle);
            this.Controls.Add(this.RbSquare);
            this.Controls.Add(this.RbCircle);
            this.Controls.Add(this.RbTriangle);
            this.Controls.Add(this.RbPolygon);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Геометрические фигуры";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RbPolygon;
        private System.Windows.Forms.RadioButton RbTriangle;
        private System.Windows.Forms.RadioButton RbCircle;
        private System.Windows.Forms.RadioButton RbSquare;
        private System.Windows.Forms.RadioButton RbReactangle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem инструкцияToolStripMenuItem;
    }
}

