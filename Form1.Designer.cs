namespace CreditCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.oldmanCheckBox3 = new System.Windows.Forms.CheckBox();
            this.youngParentCheckBox2 = new System.Windows.Forms.CheckBox();
            this.studentCheckBox1 = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.interRateLabel2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите сумму кредита в рублях";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(378, 39);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oldmanCheckBox3);
            this.groupBox1.Controls.Add(this.youngParentCheckBox2);
            this.groupBox1.Controls.Add(this.studentCheckBox1);
            this.groupBox1.Location = new System.Drawing.Point(507, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Я льготник";
            // 
            // oldmanCheckBox3
            // 
            this.oldmanCheckBox3.AutoSize = true;
            this.oldmanCheckBox3.Location = new System.Drawing.Point(32, 138);
            this.oldmanCheckBox3.Name = "oldmanCheckBox3";
            this.oldmanCheckBox3.Size = new System.Drawing.Size(170, 36);
            this.oldmanCheckBox3.TabIndex = 2;
            this.oldmanCheckBox3.Text = "Пенсионер";
            this.oldmanCheckBox3.UseVisualStyleBackColor = true;
            this.oldmanCheckBox3.CheckedChanged += new System.EventHandler(this.oldmanCheckBox3_CheckedChanged);
            // 
            // youngParentCheckBox2
            // 
            this.youngParentCheckBox2.AutoSize = true;
            this.youngParentCheckBox2.Location = new System.Drawing.Point(32, 96);
            this.youngParentCheckBox2.Name = "youngParentCheckBox2";
            this.youngParentCheckBox2.Size = new System.Drawing.Size(260, 36);
            this.youngParentCheckBox2.TabIndex = 1;
            this.youngParentCheckBox2.Text = "Молодой родитель";
            this.youngParentCheckBox2.UseVisualStyleBackColor = true;
            this.youngParentCheckBox2.CheckedChanged += new System.EventHandler(this.youngParentCheckBox2_CheckedChanged);
            // 
            // studentCheckBox1
            // 
            this.studentCheckBox1.AutoSize = true;
            this.studentCheckBox1.Location = new System.Drawing.Point(32, 54);
            this.studentCheckBox1.Name = "studentCheckBox1";
            this.studentCheckBox1.Size = new System.Drawing.Size(262, 36);
            this.studentCheckBox1.TabIndex = 0;
            this.studentCheckBox1.Text = "Являюсь студентом";
            this.studentCheckBox1.UseVisualStyleBackColor = true;
            this.studentCheckBox1.CheckedChanged += new System.EventHandler(this.studentCheckBox1_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(23, 294);
            this.trackBar1.Maximum = 60;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1062, 90);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // interRateLabel2
            // 
            this.interRateLabel2.AutoSize = true;
            this.interRateLabel2.Location = new System.Drawing.Point(89, 400);
            this.interRateLabel2.Name = "interRateLabel2";
            this.interRateLabel2.Size = new System.Drawing.Size(91, 32);
            this.interRateLabel2.TabIndex = 4;
            this.interRateLabel2.Text = "от 14%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.interRateLabel2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Кредитный калькулятор";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private CheckBox oldmanCheckBox3;
        private CheckBox youngParentCheckBox2;
        private CheckBox studentCheckBox1;
        private TrackBar trackBar1;
        private Label interRateLabel2;
        private Button button1;
    }
}