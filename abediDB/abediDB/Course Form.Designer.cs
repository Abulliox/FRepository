namespace abediDB
{
    partial class Course_Form
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
            this.leveltxt = new System.Windows.Forms.TextBox();
            this.cresaulttxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leveltxt
            // 
            this.leveltxt.Location = new System.Drawing.Point(97, 139);
            this.leveltxt.Name = "leveltxt";
            this.leveltxt.Size = new System.Drawing.Size(103, 20);
            this.leveltxt.TabIndex = 0;
            // 
            // cresaulttxt
            // 
            this.cresaulttxt.Location = new System.Drawing.Point(228, 49);
            this.cresaulttxt.Multiline = true;
            this.cresaulttxt.Name = "cresaulttxt";
            this.cresaulttxt.Size = new System.Drawing.Size(190, 177);
            this.cresaulttxt.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Main Form";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "level";
            // 
            // Course_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cresaulttxt);
            this.Controls.Add(this.leveltxt);
            this.Name = "Course_Form";
            this.Text = "Course_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox leveltxt;
        private System.Windows.Forms.TextBox cresaulttxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}