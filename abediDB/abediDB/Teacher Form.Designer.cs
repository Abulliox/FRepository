namespace abediDB
{
    partial class Teacher_Form
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
            this.pidtxt = new System.Windows.Forms.TextBox();
            this.cidtxt = new System.Windows.Forms.TextBox();
            this.tresaulttxt = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pidtxt
            // 
            this.pidtxt.Location = new System.Drawing.Point(84, 86);
            this.pidtxt.Name = "pidtxt";
            this.pidtxt.Size = new System.Drawing.Size(145, 20);
            this.pidtxt.TabIndex = 0;
            // 
            // cidtxt
            // 
            this.cidtxt.Location = new System.Drawing.Point(84, 132);
            this.cidtxt.Name = "cidtxt";
            this.cidtxt.Size = new System.Drawing.Size(145, 20);
            this.cidtxt.TabIndex = 0;
            // 
            // tresaulttxt
            // 
            this.tresaulttxt.Location = new System.Drawing.Point(269, 58);
            this.tresaulttxt.Multiline = true;
            this.tresaulttxt.Name = "tresaulttxt";
            this.tresaulttxt.Size = new System.Drawing.Size(235, 198);
            this.tresaulttxt.TabIndex = 0;
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(84, 182);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(145, 20);
            this.grade.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Person id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grade";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Main Form";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Person id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Course id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Grade";
            // 
            // Teacher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 366);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tresaulttxt);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.cidtxt);
            this.Controls.Add(this.pidtxt);
            this.Name = "Teacher_Form";
            this.Text = "Teacher_Form";
            this.Load += new System.EventHandler(this.Teacher_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pidtxt;
        private System.Windows.Forms.TextBox cidtxt;
        private System.Windows.Forms.TextBox tresaulttxt;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}