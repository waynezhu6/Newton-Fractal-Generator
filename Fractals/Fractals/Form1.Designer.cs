namespace Fractals
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
            this.pBox = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtIteration = new System.Windows.Forms.TextBox();
            this.lblIterations = new System.Windows.Forms.Label();
            this.lblEquation = new System.Windows.Forms.Label();
            this.txtEquation = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lblViewport = new System.Windows.Forms.Label();
            this.txtViewport = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox.Location = new System.Drawing.Point(13, 13);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(1000, 1000);
            this.pBox.TabIndex = 0;
            this.pBox.TabStop = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(1022, 128);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(238, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Render";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtIteration
            // 
            this.txtIteration.Location = new System.Drawing.Point(1089, 13);
            this.txtIteration.Name = "txtIteration";
            this.txtIteration.Size = new System.Drawing.Size(171, 20);
            this.txtIteration.TabIndex = 2;
            // 
            // lblIterations
            // 
            this.lblIterations.AutoSize = true;
            this.lblIterations.Location = new System.Drawing.Point(1019, 16);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(50, 13);
            this.lblIterations.TabIndex = 3;
            this.lblIterations.Text = "Iterations";
            // 
            // lblEquation
            // 
            this.lblEquation.AutoSize = true;
            this.lblEquation.Location = new System.Drawing.Point(1019, 42);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(49, 13);
            this.lblEquation.TabIndex = 5;
            this.lblEquation.Text = "Equation";
            // 
            // txtEquation
            // 
            this.txtEquation.Location = new System.Drawing.Point(1089, 39);
            this.txtEquation.Name = "txtEquation";
            this.txtEquation.Size = new System.Drawing.Size(171, 20);
            this.txtEquation.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(1022, 94);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Color By Root";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1118, 94);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Color By Iterations";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lblViewport
            // 
            this.lblViewport.AutoSize = true;
            this.lblViewport.Location = new System.Drawing.Point(1019, 68);
            this.lblViewport.Name = "lblViewport";
            this.lblViewport.Size = new System.Drawing.Size(48, 13);
            this.lblViewport.TabIndex = 10;
            this.lblViewport.Text = "Viewport";
            // 
            // txtViewport
            // 
            this.txtViewport.Location = new System.Drawing.Point(1089, 65);
            this.txtViewport.Name = "txtViewport";
            this.txtViewport.Size = new System.Drawing.Size(171, 20);
            this.txtViewport.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 1026);
            this.Controls.Add(this.lblViewport);
            this.Controls.Add(this.txtViewport);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblEquation);
            this.Controls.Add(this.txtEquation);
            this.Controls.Add(this.lblIterations);
            this.Controls.Add(this.txtIteration);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.pBox);
            this.Name = "Form1";
            this.Text = "Fractals";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtIteration;
        private System.Windows.Forms.Label lblIterations;
        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.TextBox txtEquation;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label lblViewport;
        private System.Windows.Forms.TextBox txtViewport;
    }
}

