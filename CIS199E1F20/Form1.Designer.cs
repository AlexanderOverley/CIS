namespace CIS199E1F20
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
            this.aqilbl = new System.Windows.Forms.Label();
            this.pollvllbl = new System.Windows.Forms.Label();
            this.findPolLvl = new System.Windows.Forms.Button();
            this.outBox = new System.Windows.Forms.TextBox();
            this.inBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aqilbl
            // 
            this.aqilbl.AutoSize = true;
            this.aqilbl.Location = new System.Drawing.Point(109, 110);
            this.aqilbl.Name = "aqilbl";
            this.aqilbl.Size = new System.Drawing.Size(197, 20);
            this.aqilbl.TabIndex = 0;
            this.aqilbl.Text = "Enter the Air Quality Index:";
            // 
            // pollvllbl
            // 
            this.pollvllbl.AutoSize = true;
            this.pollvllbl.Location = new System.Drawing.Point(109, 153);
            this.pollvllbl.Name = "pollvllbl";
            this.pollvllbl.Size = new System.Drawing.Size(114, 20);
            this.pollvllbl.TabIndex = 1;
            this.pollvllbl.Text = "Pollution Level:";
            // 
            // findPolLvl
            // 
            this.findPolLvl.Location = new System.Drawing.Point(113, 202);
            this.findPolLvl.Name = "findPolLvl";
            this.findPolLvl.Size = new System.Drawing.Size(462, 46);
            this.findPolLvl.TabIndex = 2;
            this.findPolLvl.Text = "Determine Pollution Level";
            this.findPolLvl.UseVisualStyleBackColor = true;
            this.findPolLvl.Click += new System.EventHandler(this.findPolLvl_Click);
            // 
            // outBox
            // 
            this.outBox.Location = new System.Drawing.Point(309, 146);
            this.outBox.Name = "outBox";
            this.outBox.Size = new System.Drawing.Size(266, 26);
            this.outBox.TabIndex = 3;
            // 
            // inBox
            // 
            this.inBox.Location = new System.Drawing.Point(309, 110);
            this.inBox.Name = "inBox";
            this.inBox.Size = new System.Drawing.Size(266, 26);
            this.inBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inBox);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.findPolLvl);
            this.Controls.Add(this.pollvllbl);
            this.Controls.Add(this.aqilbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aqilbl;
        private System.Windows.Forms.Label pollvllbl;
        private System.Windows.Forms.Button findPolLvl;
        private System.Windows.Forms.TextBox outBox;
        private System.Windows.Forms.TextBox inBox;
    }
}

