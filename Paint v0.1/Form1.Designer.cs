namespace Paint_v0._1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.clearCanvasBtn = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapesPanel = new System.Windows.Forms.Panel();
            this.sqrBtn = new System.Windows.Forms.Button();
            this.rectBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pensPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.penColorBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.penWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.shapeHeight = new System.Windows.Forms.NumericUpDown();
            this.shapeWidth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.canvasColorBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.circleBtn = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.shapesPanel.SuspendLayout();
            this.pensPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(246, 6);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(929, 480);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearCanvasBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1213, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // clearCanvasBtn
            // 
            this.clearCanvasBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clearCanvasBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearCanvasBtn.Image")));
            this.clearCanvasBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearCanvasBtn.Name = "clearCanvasBtn";
            this.clearCanvasBtn.Size = new System.Drawing.Size(38, 22);
            this.clearCanvasBtn.Text = "Clear";
            this.clearCanvasBtn.Click += new System.EventHandler(this.clearCanvasBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1189, 518);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toolsPanel);
            this.tabPage1.Controls.Add(this.mainPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1181, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Draw";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolsPanel
            // 
            this.toolsPanel.BackColor = System.Drawing.Color.Azure;
            this.toolsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolsPanel.Controls.Add(this.panel1);
            this.toolsPanel.Controls.Add(this.shapesPanel);
            this.toolsPanel.Controls.Add(this.pensPanel);
            this.toolsPanel.Controls.Add(this.label1);
            this.toolsPanel.Location = new System.Drawing.Point(6, 6);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(234, 480);
            this.toolsPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.canvasColorBtn);
            this.panel1.Location = new System.Drawing.Point(3, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 161);
            this.panel1.TabIndex = 3;
            // 
            // shapesPanel
            // 
            this.shapesPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.shapesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shapesPanel.Controls.Add(this.circleBtn);
            this.shapesPanel.Controls.Add(this.label7);
            this.shapesPanel.Controls.Add(this.label6);
            this.shapesPanel.Controls.Add(this.shapeWidth);
            this.shapesPanel.Controls.Add(this.shapeHeight);
            this.shapesPanel.Controls.Add(this.sqrBtn);
            this.shapesPanel.Controls.Add(this.rectBtn);
            this.shapesPanel.Controls.Add(this.label3);
            this.shapesPanel.Location = new System.Drawing.Point(3, 168);
            this.shapesPanel.Name = "shapesPanel";
            this.shapesPanel.Size = new System.Drawing.Size(226, 140);
            this.shapesPanel.TabIndex = 2;
            // 
            // sqrBtn
            // 
            this.sqrBtn.Image = global::Paint_v0._1.Properties.Resources._40752;
            this.sqrBtn.Location = new System.Drawing.Point(37, 22);
            this.sqrBtn.Name = "sqrBtn";
            this.sqrBtn.Size = new System.Drawing.Size(28, 30);
            this.sqrBtn.TabIndex = 2;
            this.sqrBtn.UseVisualStyleBackColor = true;
            this.sqrBtn.Click += new System.EventHandler(this.sqrBtn_Click);
            // 
            // rectBtn
            // 
            this.rectBtn.Image = global::Paint_v0._1.Properties.Resources._40742;
            this.rectBtn.Location = new System.Drawing.Point(3, 22);
            this.rectBtn.Name = "rectBtn";
            this.rectBtn.Size = new System.Drawing.Size(28, 30);
            this.rectBtn.TabIndex = 1;
            this.rectBtn.UseVisualStyleBackColor = true;
            this.rectBtn.Click += new System.EventHandler(this.rectBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(72, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Shapes";
            // 
            // pensPanel
            // 
            this.pensPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.pensPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pensPanel.Controls.Add(this.label5);
            this.pensPanel.Controls.Add(this.penWidth);
            this.pensPanel.Controls.Add(this.label4);
            this.pensPanel.Controls.Add(this.penColorBtn);
            this.pensPanel.Controls.Add(this.button2);
            this.pensPanel.Controls.Add(this.button1);
            this.pensPanel.Controls.Add(this.label2);
            this.pensPanel.Location = new System.Drawing.Point(3, 23);
            this.pensPanel.Name = "pensPanel";
            this.pensPanel.Size = new System.Drawing.Size(226, 139);
            this.pensPanel.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Image = global::Paint_v0._1.Properties.Resources._40332;
            this.button2.Location = new System.Drawing.Point(37, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 24);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::Paint_v0._1.Properties.Resources._60417;
            this.button1.Location = new System.Drawing.Point(3, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 24);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(85, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pens";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(89, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tools";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1181, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Colors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // penColorBtn
            // 
            this.penColorBtn.Location = new System.Drawing.Point(61, 109);
            this.penColorBtn.Name = "penColorBtn";
            this.penColorBtn.Size = new System.Drawing.Size(160, 23);
            this.penColorBtn.TabIndex = 3;
            this.penColorBtn.UseVisualStyleBackColor = true;
            this.penColorBtn.Click += new System.EventHandler(this.penColorBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pen color";
            // 
            // penWidth
            // 
            this.penWidth.Location = new System.Drawing.Point(63, 83);
            this.penWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.penWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.penWidth.Name = "penWidth";
            this.penWidth.Size = new System.Drawing.Size(158, 20);
            this.penWidth.TabIndex = 5;
            this.penWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pen width";
            // 
            // shapeHeight
            // 
            this.shapeHeight.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.shapeHeight.Location = new System.Drawing.Point(47, 89);
            this.shapeHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shapeHeight.Name = "shapeHeight";
            this.shapeHeight.Size = new System.Drawing.Size(174, 20);
            this.shapeHeight.TabIndex = 3;
            this.shapeHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // shapeWidth
            // 
            this.shapeWidth.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.shapeWidth.Location = new System.Drawing.Point(47, 115);
            this.shapeWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shapeWidth.Name = "shapeWidth";
            this.shapeWidth.Size = new System.Drawing.Size(174, 20);
            this.shapeWidth.TabIndex = 4;
            this.shapeWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Width";
            // 
            // canvasColorBtn
            // 
            this.canvasColorBtn.BackColor = System.Drawing.Color.White;
            this.canvasColorBtn.Location = new System.Drawing.Point(81, 12);
            this.canvasColorBtn.Name = "canvasColorBtn";
            this.canvasColorBtn.Size = new System.Drawing.Size(140, 23);
            this.canvasColorBtn.TabIndex = 0;
            this.canvasColorBtn.UseVisualStyleBackColor = false;
            this.canvasColorBtn.Click += new System.EventHandler(this.canvasColorBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Canvas color";
            // 
            // circleBtn
            // 
            this.circleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circleBtn.Location = new System.Drawing.Point(71, 22);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(29, 30);
            this.circleBtn.TabIndex = 7;
            this.circleBtn.Text = "O";
            this.circleBtn.UseVisualStyleBackColor = true;
            this.circleBtn.Click += new System.EventHandler(this.circleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 558);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.toolsPanel.ResumeLayout(false);
            this.toolsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.shapesPanel.ResumeLayout(false);
            this.shapesPanel.PerformLayout();
            this.pensPanel.ResumeLayout(false);
            this.pensPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton clearCanvasBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel shapesPanel;
        private System.Windows.Forms.Button sqrBtn;
        private System.Windows.Forms.Button rectBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pensPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button penColorBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown penWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown shapeWidth;
        private System.Windows.Forms.NumericUpDown shapeHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button canvasColorBtn;
        private System.Windows.Forms.Button circleBtn;
    }
}

