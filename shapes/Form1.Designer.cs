namespace shapes
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
            this.grpShapes = new System.Windows.Forms.GroupBox();
            this.rdoRectangle = new System.Windows.Forms.RadioButton();
            this.rdoSquare = new System.Windows.Forms.RadioButton();
            this.rdoTriangle = new System.Windows.Forms.RadioButton();
            this.rdoCircle = new System.Windows.Forms.RadioButton();
            this.grpCompute = new System.Windows.Forms.GroupBox();
            this.chkPerimeter = new System.Windows.Forms.CheckBox();
            this.chkArea = new System.Windows.Forms.CheckBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnComputeCircle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnComputeTriangle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnComputeSquare = new System.Windows.Forms.Button();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnComputeRectangle = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblNoSide = new System.Windows.Forms.Label();
            this.grpShapes.SuspendLayout();
            this.grpCompute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpShapes
            // 
            this.grpShapes.Controls.Add(this.rdoRectangle);
            this.grpShapes.Controls.Add(this.rdoSquare);
            this.grpShapes.Controls.Add(this.rdoTriangle);
            this.grpShapes.Controls.Add(this.rdoCircle);
            this.grpShapes.Location = new System.Drawing.Point(12, 12);
            this.grpShapes.Name = "grpShapes";
            this.grpShapes.Size = new System.Drawing.Size(200, 100);
            this.grpShapes.TabIndex = 0;
            this.grpShapes.TabStop = false;
            this.grpShapes.Text = "Shape";
            // 
            // rdoRectangle
            // 
            this.rdoRectangle.AutoSize = true;
            this.rdoRectangle.Location = new System.Drawing.Point(97, 65);
            this.rdoRectangle.Name = "rdoRectangle";
            this.rdoRectangle.Size = new System.Drawing.Size(74, 17);
            this.rdoRectangle.TabIndex = 11;
            this.rdoRectangle.TabStop = true;
            this.rdoRectangle.Text = "Rectangle";
            this.rdoRectangle.UseVisualStyleBackColor = true;
            // 
            // rdoSquare
            // 
            this.rdoSquare.AutoSize = true;
            this.rdoSquare.Location = new System.Drawing.Point(97, 30);
            this.rdoSquare.Name = "rdoSquare";
            this.rdoSquare.Size = new System.Drawing.Size(59, 17);
            this.rdoSquare.TabIndex = 10;
            this.rdoSquare.TabStop = true;
            this.rdoSquare.Text = "Square";
            this.rdoSquare.UseVisualStyleBackColor = true;
            // 
            // rdoTriangle
            // 
            this.rdoTriangle.AutoSize = true;
            this.rdoTriangle.Location = new System.Drawing.Point(6, 65);
            this.rdoTriangle.Name = "rdoTriangle";
            this.rdoTriangle.Size = new System.Drawing.Size(63, 17);
            this.rdoTriangle.TabIndex = 9;
            this.rdoTriangle.TabStop = true;
            this.rdoTriangle.Text = "Triangle";
            this.rdoTriangle.UseVisualStyleBackColor = true;
            // 
            // rdoCircle
            // 
            this.rdoCircle.AutoSize = true;
            this.rdoCircle.Location = new System.Drawing.Point(6, 30);
            this.rdoCircle.Name = "rdoCircle";
            this.rdoCircle.Size = new System.Drawing.Size(51, 17);
            this.rdoCircle.TabIndex = 8;
            this.rdoCircle.TabStop = true;
            this.rdoCircle.Text = "Circle";
            this.rdoCircle.UseVisualStyleBackColor = true;
            // 
            // grpCompute
            // 
            this.grpCompute.Controls.Add(this.chkPerimeter);
            this.grpCompute.Controls.Add(this.chkArea);
            this.grpCompute.Location = new System.Drawing.Point(12, 118);
            this.grpCompute.Name = "grpCompute";
            this.grpCompute.Size = new System.Drawing.Size(200, 100);
            this.grpCompute.TabIndex = 1;
            this.grpCompute.TabStop = false;
            this.grpCompute.Text = "Compute";
            // 
            // chkPerimeter
            // 
            this.chkPerimeter.AutoSize = true;
            this.chkPerimeter.Location = new System.Drawing.Point(47, 63);
            this.chkPerimeter.Name = "chkPerimeter";
            this.chkPerimeter.Size = new System.Drawing.Size(70, 17);
            this.chkPerimeter.TabIndex = 9;
            this.chkPerimeter.Text = "Perimeter";
            this.chkPerimeter.UseVisualStyleBackColor = true;
            // 
            // chkArea
            // 
            this.chkArea.AutoSize = true;
            this.chkArea.Location = new System.Drawing.Point(47, 31);
            this.chkArea.Name = "chkArea";
            this.chkArea.Size = new System.Drawing.Size(48, 17);
            this.chkArea.TabIndex = 8;
            this.chkArea.Text = "Area";
            this.chkArea.UseVisualStyleBackColor = true;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(40, 347);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(36, 373);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(51, 13);
            this.lblPerimeter.TabIndex = 3;
            this.lblPerimeter.Text = "Perimeter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(232, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 121);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(383, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 121);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(534, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(145, 121);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(685, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(145, 121);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnComputeCircle);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtRadius);
            this.groupBox3.Location = new System.Drawing.Point(238, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 196);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Circle";
            // 
            // btnComputeCircle
            // 
            this.btnComputeCircle.Location = new System.Drawing.Point(32, 156);
            this.btnComputeCircle.Name = "btnComputeCircle";
            this.btnComputeCircle.Size = new System.Drawing.Size(75, 23);
            this.btnComputeCircle.TabIndex = 8;
            this.btnComputeCircle.Text = "Compute";
            this.btnComputeCircle.UseVisualStyleBackColor = true;
            this.btnComputeCircle.Click += new System.EventHandler(this.btnComputeCircle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Radius";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(18, 69);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnComputeTriangle);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtHeight);
            this.groupBox4.Controls.Add(this.txtBase);
            this.groupBox4.Location = new System.Drawing.Point(383, 164);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(139, 196);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Triangle";
            // 
            // btnComputeTriangle
            // 
            this.btnComputeTriangle.Location = new System.Drawing.Point(34, 156);
            this.btnComputeTriangle.Name = "btnComputeTriangle";
            this.btnComputeTriangle.Size = new System.Drawing.Size(75, 23);
            this.btnComputeTriangle.TabIndex = 9;
            this.btnComputeTriangle.Text = "Compute";
            this.btnComputeTriangle.UseVisualStyleBackColor = true;
            this.btnComputeTriangle.Click += new System.EventHandler(this.btnComputeTriangle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Base";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Height";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(24, 93);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 10;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(24, 50);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.btnComputeSquare);
            this.groupBox5.Controls.Add(this.txtSide);
            this.groupBox5.Location = new System.Drawing.Point(528, 164);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(145, 196);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Square";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Side";
            // 
            // btnComputeSquare
            // 
            this.btnComputeSquare.Location = new System.Drawing.Point(33, 156);
            this.btnComputeSquare.Name = "btnComputeSquare";
            this.btnComputeSquare.Size = new System.Drawing.Size(75, 23);
            this.btnComputeSquare.TabIndex = 10;
            this.btnComputeSquare.Text = "Compute";
            this.btnComputeSquare.UseVisualStyleBackColor = true;
            this.btnComputeSquare.Click += new System.EventHandler(this.btnComputeSquare_Click);
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(24, 69);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(100, 20);
            this.txtSide.TabIndex = 11;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.btnComputeRectangle);
            this.groupBox6.Controls.Add(this.txtWidth);
            this.groupBox6.Controls.Add(this.txtLength);
            this.groupBox6.Location = new System.Drawing.Point(679, 164);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(145, 196);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Rectangle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Length";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Width";
            // 
            // btnComputeRectangle
            // 
            this.btnComputeRectangle.Location = new System.Drawing.Point(36, 156);
            this.btnComputeRectangle.Name = "btnComputeRectangle";
            this.btnComputeRectangle.Size = new System.Drawing.Size(75, 23);
            this.btnComputeRectangle.TabIndex = 11;
            this.btnComputeRectangle.Text = "Compute";
            this.btnComputeRectangle.UseVisualStyleBackColor = true;
            this.btnComputeRectangle.Click += new System.EventHandler(this.btnComputeRectangle_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(23, 113);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 10;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(23, 69);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(40, 240);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(40, 264);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Color";
            // 
            // lblNoSide
            // 
            this.lblNoSide.AutoSize = true;
            this.lblNoSide.Location = new System.Drawing.Point(40, 293);
            this.lblNoSide.Name = "lblNoSide";
            this.lblNoSide.Size = new System.Drawing.Size(65, 13);
            this.lblNoSide.TabIndex = 10;
            this.lblNoSide.Text = "No. of Sides";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.lblNoSide);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.grpCompute);
            this.Controls.Add(this.grpShapes);
            this.Name = "Form1";
            this.Text = "BasicShapes";
            this.grpShapes.ResumeLayout(false);
            this.grpShapes.PerformLayout();
            this.grpCompute.ResumeLayout(false);
            this.grpCompute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpShapes;
        private System.Windows.Forms.GroupBox grpCompute;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnComputeCircle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnComputeTriangle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnComputeSquare;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnComputeRectangle;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.RadioButton rdoRectangle;
        private System.Windows.Forms.RadioButton rdoSquare;
        private System.Windows.Forms.RadioButton rdoTriangle;
        private System.Windows.Forms.RadioButton rdoCircle;
        private System.Windows.Forms.CheckBox chkPerimeter;
        private System.Windows.Forms.CheckBox chkArea;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblNoSide;
    }
}

