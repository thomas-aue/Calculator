namespace Calculator3
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
            this.ButtonDecimal = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.ButtonDel = new System.Windows.Forms.Button();
            this.ButtonPercent = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonSubtract = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonDecimal
            // 
            this.ButtonDecimal.Location = new System.Drawing.Point(224, 374);
            this.ButtonDecimal.Name = "ButtonDecimal";
            this.ButtonDecimal.Size = new System.Drawing.Size(100, 50);
            this.ButtonDecimal.TabIndex = 44;
            this.ButtonDecimal.Text = ".";
            this.ButtonDecimal.UseVisualStyleBackColor = true;
            this.ButtonDecimal.Click += new System.EventHandler(this.ButtonDecimal_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(12, 150);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(100, 50);
            this.ButtonClear.TabIndex = 43;
            this.ButtonClear.Text = "CLEAR";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.Menu;
            this.display.Cursor = System.Windows.Forms.Cursors.Default;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(12, 12);
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(418, 62);
            this.display.TabIndex = 42;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonDel
            // 
            this.ButtonDel.Location = new System.Drawing.Point(118, 150);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(100, 50);
            this.ButtonDel.TabIndex = 41;
            this.ButtonDel.Text = "DEL";
            this.ButtonDel.UseVisualStyleBackColor = true;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // ButtonPercent
            // 
            this.ButtonPercent.Location = new System.Drawing.Point(224, 150);
            this.ButtonPercent.Name = "ButtonPercent";
            this.ButtonPercent.Size = new System.Drawing.Size(100, 50);
            this.ButtonPercent.TabIndex = 40;
            this.ButtonPercent.Text = "%";
            this.ButtonPercent.UseVisualStyleBackColor = true;
            this.ButtonPercent.Click += new System.EventHandler(this.ButtonPercent_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Location = new System.Drawing.Point(330, 150);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(100, 50);
            this.ButtonDivide.TabIndex = 39;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.Location = new System.Drawing.Point(330, 206);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(100, 50);
            this.ButtonMultiply.TabIndex = 38;
            this.ButtonMultiply.Text = "*";
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // ButtonSubtract
            // 
            this.ButtonSubtract.Location = new System.Drawing.Point(330, 262);
            this.ButtonSubtract.Name = "ButtonSubtract";
            this.ButtonSubtract.Size = new System.Drawing.Size(100, 50);
            this.ButtonSubtract.TabIndex = 37;
            this.ButtonSubtract.Text = "-";
            this.ButtonSubtract.UseVisualStyleBackColor = true;
            this.ButtonSubtract.Click += new System.EventHandler(this.ButtonSubtract_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(330, 318);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(100, 50);
            this.ButtonAdd.TabIndex = 36;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.Location = new System.Drawing.Point(330, 374);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(100, 50);
            this.ButtonEquals.TabIndex = 35;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = true;
            this.ButtonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(224, 206);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(100, 50);
            this.Button9.TabIndex = 34;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(118, 206);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(100, 50);
            this.Button8.TabIndex = 33;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(12, 206);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(100, 50);
            this.Button7.TabIndex = 32;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(224, 262);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(100, 50);
            this.Button6.TabIndex = 31;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(118, 262);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(100, 50);
            this.Button5.TabIndex = 30;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(12, 262);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(100, 50);
            this.Button4.TabIndex = 29;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(118, 318);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(100, 50);
            this.Button2.TabIndex = 28;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 318);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(100, 50);
            this.Button1.TabIndex = 27;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button0
            // 
            this.Button0.Location = new System.Drawing.Point(118, 374);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(100, 50);
            this.Button0.TabIndex = 26;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(224, 318);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(100, 50);
            this.Button3.TabIndex = 25;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 436);
            this.Controls.Add(this.ButtonDecimal);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.display);
            this.Controls.Add(this.ButtonDel);
            this.Controls.Add(this.ButtonPercent);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.ButtonMultiply);
            this.Controls.Add(this.ButtonSubtract);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonEquals);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.Button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Calculator v3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ButtonDecimal;
        internal System.Windows.Forms.Button ButtonClear;
        internal System.Windows.Forms.TextBox display;
        internal System.Windows.Forms.Button ButtonDel;
        internal System.Windows.Forms.Button ButtonPercent;
        internal System.Windows.Forms.Button ButtonDivide;
        internal System.Windows.Forms.Button ButtonMultiply;
        internal System.Windows.Forms.Button ButtonSubtract;
        internal System.Windows.Forms.Button ButtonAdd;
        internal System.Windows.Forms.Button ButtonEquals;
        internal System.Windows.Forms.Button Button9;
        internal System.Windows.Forms.Button Button8;
        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button0;
        internal System.Windows.Forms.Button Button3;
    }
}

