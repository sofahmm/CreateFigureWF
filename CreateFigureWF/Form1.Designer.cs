
namespace CreateFigureWF
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
            this.btn_Point = new System.Windows.Forms.Button();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.btn_Triangle = new System.Windows.Forms.Button();
            this.btn_Line = new System.Windows.Forms.Button();
            this.btn_Rectangle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Point
            // 
            this.btn_Point.Location = new System.Drawing.Point(167, 14);
            this.btn_Point.Name = "btn_Point";
            this.btn_Point.Size = new System.Drawing.Size(140, 69);
            this.btn_Point.TabIndex = 0;
            this.btn_Point.Text = "Point";
            this.btn_Point.UseVisualStyleBackColor = true;
            this.btn_Point.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Circle
            // 
            this.btn_Circle.Location = new System.Drawing.Point(335, 14);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(132, 69);
            this.btn_Circle.TabIndex = 1;
            this.btn_Circle.Text = "Circle";
            this.btn_Circle.UseVisualStyleBackColor = true;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // btn_Triangle
            // 
            this.btn_Triangle.Location = new System.Drawing.Point(12, 14);
            this.btn_Triangle.Name = "btn_Triangle";
            this.btn_Triangle.Size = new System.Drawing.Size(122, 69);
            this.btn_Triangle.TabIndex = 2;
            this.btn_Triangle.Text = "Triangle";
            this.btn_Triangle.UseVisualStyleBackColor = true;
            this.btn_Triangle.Click += new System.EventHandler(this.btn_Triangle_Click);
            // 
            // btn_Line
            // 
            this.btn_Line.Location = new System.Drawing.Point(493, 14);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(122, 69);
            this.btn_Line.TabIndex = 3;
            this.btn_Line.Text = "Line";
            this.btn_Line.UseVisualStyleBackColor = true;
            this.btn_Line.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.Location = new System.Drawing.Point(652, 14);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.Size = new System.Drawing.Size(122, 69);
            this.btn_Rectangle.TabIndex = 4;
            this.btn_Rectangle.Text = "Rectangle";
            this.btn_Rectangle.UseVisualStyleBackColor = true;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btn_Triangle);
            this.panel1.Controls.Add(this.btn_Rectangle);
            this.panel1.Controls.Add(this.btn_Point);
            this.panel1.Controls.Add(this.btn_Line);
            this.panel1.Controls.Add(this.btn_Circle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 108);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 342);
            this.panel2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Point;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Button btn_Triangle;
        private System.Windows.Forms.Button btn_Line;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

