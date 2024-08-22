
namespace Task_2_Web_Application
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
            this.pictureBoximage = new System.Windows.Forms.PictureBox();
            this.buttonBlueTagtask1 = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttonpythagoreamsolver = new System.Windows.Forms.Button();
            this.buttonquadraticequationsolver = new System.Windows.Forms.Button();
            this.buttonareaofcircle = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoximage
            // 
            this.pictureBoximage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoximage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoximage.Image")));
            this.pictureBoximage.Location = new System.Drawing.Point(269, 12);
            this.pictureBoximage.Name = "pictureBoximage";
            this.pictureBoximage.Size = new System.Drawing.Size(270, 80);
            this.pictureBoximage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoximage.TabIndex = 0;
            this.pictureBoximage.TabStop = false;
            // 
            // buttonBlueTagtask1
            // 
            this.buttonBlueTagtask1.BackColor = System.Drawing.Color.Yellow;
            this.buttonBlueTagtask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlueTagtask1.Location = new System.Drawing.Point(12, 107);
            this.buttonBlueTagtask1.Name = "buttonBlueTagtask1";
            this.buttonBlueTagtask1.Size = new System.Drawing.Size(145, 75);
            this.buttonBlueTagtask1.TabIndex = 1;
            this.buttonBlueTagtask1.Text = "BlueTag Task 1";
            this.buttonBlueTagtask1.UseVisualStyleBackColor = false;
            this.buttonBlueTagtask1.Click += new System.EventHandler(this.buttonBlueTagtask1_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclear.ForeColor = System.Drawing.Color.White;
            this.buttonclear.Location = new System.Drawing.Point(609, 476);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(169, 75);
            this.buttonclear.TabIndex = 2;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = false;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // buttonpythagoreamsolver
            // 
            this.buttonpythagoreamsolver.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonpythagoreamsolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpythagoreamsolver.ForeColor = System.Drawing.Color.Snow;
            this.buttonpythagoreamsolver.Location = new System.Drawing.Point(10, 397);
            this.buttonpythagoreamsolver.Name = "buttonpythagoreamsolver";
            this.buttonpythagoreamsolver.Size = new System.Drawing.Size(147, 75);
            this.buttonpythagoreamsolver.TabIndex = 3;
            this.buttonpythagoreamsolver.Text = "Pythagoran Theory Solver";
            this.buttonpythagoreamsolver.UseVisualStyleBackColor = false;
            this.buttonpythagoreamsolver.Click += new System.EventHandler(this.buttonpythagoreamsolver_Click);
            // 
            // buttonquadraticequationsolver
            // 
            this.buttonquadraticequationsolver.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonquadraticequationsolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonquadraticequationsolver.ForeColor = System.Drawing.Color.Black;
            this.buttonquadraticequationsolver.Location = new System.Drawing.Point(10, 305);
            this.buttonquadraticequationsolver.Name = "buttonquadraticequationsolver";
            this.buttonquadraticequationsolver.Size = new System.Drawing.Size(147, 75);
            this.buttonquadraticequationsolver.TabIndex = 4;
            this.buttonquadraticequationsolver.Text = "Quadratic Equation Solver\r\n";
            this.buttonquadraticequationsolver.UseVisualStyleBackColor = false;
            this.buttonquadraticequationsolver.Click += new System.EventHandler(this.buttonquadraticequationsolver_Click);
            // 
            // buttonareaofcircle
            // 
            this.buttonareaofcircle.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonareaofcircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonareaofcircle.ForeColor = System.Drawing.Color.White;
            this.buttonareaofcircle.Location = new System.Drawing.Point(10, 208);
            this.buttonareaofcircle.Name = "buttonareaofcircle";
            this.buttonareaofcircle.Size = new System.Drawing.Size(147, 75);
            this.buttonareaofcircle.TabIndex = 5;
            this.buttonareaofcircle.Text = "Area of Circle";
            this.buttonareaofcircle.UseVisualStyleBackColor = false;
            this.buttonareaofcircle.Click += new System.EventHandler(this.buttonareaofcircle_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Image = ((System.Drawing.Image)(resources.GetObject("buttondelete.Image")));
            this.buttondelete.Location = new System.Drawing.Point(743, 12);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(45, 47);
            this.buttondelete.TabIndex = 6;
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 107);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(581, 365);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(812, 562);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonareaofcircle);
            this.Controls.Add(this.buttonquadraticequationsolver);
            this.Controls.Add(this.buttonpythagoreamsolver);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonBlueTagtask1);
            this.Controls.Add(this.pictureBoximage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Task 2 Solver";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoximage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoximage;
        private System.Windows.Forms.Button buttonBlueTagtask1;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttonpythagoreamsolver;
        private System.Windows.Forms.Button buttonquadraticequationsolver;
        private System.Windows.Forms.Button buttonareaofcircle;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.TextBox textBox1;
    }
}

