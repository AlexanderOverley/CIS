namespace Lab3
{
    partial class Form1Lab3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.calculate = new System.Windows.Forms.Button();
            this.radiussphlbl = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.diameterlbl = new System.Windows.Forms.Label();
            this.salbl = new System.Windows.Forms.Label();
            this.vollbl = new System.Windows.Forms.Label();
            this.diameterOutput = new System.Windows.Forms.TextBox();
            this.saOutput = new System.Windows.Forms.TextBox();
            this.volOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab3.Properties.Resources.Sphere_and_Ball;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Lab3.Properties.Resources.Sphere_and_Ball;
            this.pictureBox2.Location = new System.Drawing.Point(297, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 203);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(390, 120);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(115, 52);
            this.calculate.TabIndex = 2;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // radiussphlbl
            // 
            this.radiussphlbl.AutoSize = true;
            this.radiussphlbl.Location = new System.Drawing.Point(247, 88);
            this.radiussphlbl.Name = "radiussphlbl";
            this.radiussphlbl.Size = new System.Drawing.Size(137, 20);
            this.radiussphlbl.TabIndex = 3;
            this.radiussphlbl.Text = "Radius of Sphere:";
            // 
            // inputBox
            // 
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBox.Location = new System.Drawing.Point(390, 88);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(115, 26);
            this.inputBox.TabIndex = 4;
            // 
            // diameterlbl
            // 
            this.diameterlbl.AutoSize = true;
            this.diameterlbl.Location = new System.Drawing.Point(39, 264);
            this.diameterlbl.Name = "diameterlbl";
            this.diameterlbl.Size = new System.Drawing.Size(78, 20);
            this.diameterlbl.TabIndex = 5;
            this.diameterlbl.Text = "Diameter:";
            // 
            // salbl
            // 
            this.salbl.AutoSize = true;
            this.salbl.Location = new System.Drawing.Point(10, 299);
            this.salbl.Name = "salbl";
            this.salbl.Size = new System.Drawing.Size(107, 20);
            this.salbl.TabIndex = 6;
            this.salbl.Text = "Surface Area:";
            // 
            // vollbl
            // 
            this.vollbl.AutoSize = true;
            this.vollbl.Location = new System.Drawing.Point(50, 336);
            this.vollbl.Name = "vollbl";
            this.vollbl.Size = new System.Drawing.Size(67, 20);
            this.vollbl.TabIndex = 7;
            this.vollbl.Text = "Volume:";
            // 
            // diameterOutput
            // 
            this.diameterOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diameterOutput.Location = new System.Drawing.Point(123, 264);
            this.diameterOutput.Name = "diameterOutput";
            this.diameterOutput.Size = new System.Drawing.Size(100, 26);
            this.diameterOutput.TabIndex = 8;
            // 
            // saOutput
            // 
            this.saOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saOutput.Location = new System.Drawing.Point(123, 299);
            this.saOutput.Name = "saOutput";
            this.saOutput.Size = new System.Drawing.Size(100, 26);
            this.saOutput.TabIndex = 9;
            // 
            // volOutput
            // 
            this.volOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volOutput.Location = new System.Drawing.Point(123, 336);
            this.volOutput.Name = "volOutput";
            this.volOutput.Size = new System.Drawing.Size(100, 26);
            this.volOutput.TabIndex = 10;
            // 
            // Form1Lab3
            // 
            this.AcceptButton = this.calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.volOutput);
            this.Controls.Add(this.saOutput);
            this.Controls.Add(this.diameterOutput);
            this.Controls.Add(this.vollbl);
            this.Controls.Add(this.salbl);
            this.Controls.Add(this.diameterlbl);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.radiussphlbl);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1Lab3";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label radiussphlbl;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label diameterlbl;
        private System.Windows.Forms.Label salbl;
        private System.Windows.Forms.Label vollbl;
        private System.Windows.Forms.TextBox diameterOutput;
        private System.Windows.Forms.TextBox saOutput;
        private System.Windows.Forms.TextBox volOutput;
    }
}

