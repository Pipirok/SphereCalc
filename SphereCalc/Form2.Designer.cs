namespace SphereCalc
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelPerimeter = new System.Windows.Forms.Label();
            this.labelUI_perimeter = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelUI_area = new System.Windows.Forms.Label();
            this.buttonMoveToRectangle = new System.Windows.Forms.Button();
            this.buttonMoveToSphere = new System.Windows.Forms.Button();
            this.textBoxSide1 = new System.Windows.Forms.TextBox();
            this.textBoxSide2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxSide3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPerimeter
            // 
            this.labelPerimeter.AutoSize = true;
            this.labelPerimeter.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerimeter.Location = new System.Drawing.Point(598, 178);
            this.labelPerimeter.Name = "labelPerimeter";
            this.labelPerimeter.Size = new System.Drawing.Size(0, 39);
            this.labelPerimeter.TabIndex = 23;
            // 
            // labelUI_perimeter
            // 
            this.labelUI_perimeter.AutoSize = true;
            this.labelUI_perimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUI_perimeter.Location = new System.Drawing.Point(539, 178);
            this.labelUI_perimeter.Name = "labelUI_perimeter";
            this.labelUI_perimeter.Size = new System.Drawing.Size(43, 32);
            this.labelUI_perimeter.TabIndex = 22;
            this.labelUI_perimeter.Text = "P:";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(598, 116);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(0, 39);
            this.labelArea.TabIndex = 21;
            // 
            // labelUI_area
            // 
            this.labelUI_area.AutoSize = true;
            this.labelUI_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUI_area.Location = new System.Drawing.Point(539, 116);
            this.labelUI_area.Name = "labelUI_area";
            this.labelUI_area.Size = new System.Drawing.Size(43, 32);
            this.labelUI_area.TabIndex = 20;
            this.labelUI_area.Text = "S:";
            // 
            // buttonMoveToRectangle
            // 
            this.buttonMoveToRectangle.Location = new System.Drawing.Point(638, 368);
            this.buttonMoveToRectangle.Name = "buttonMoveToRectangle";
            this.buttonMoveToRectangle.Size = new System.Drawing.Size(110, 46);
            this.buttonMoveToRectangle.TabIndex = 19;
            this.buttonMoveToRectangle.Text = "Rectangle >>";
            this.buttonMoveToRectangle.UseVisualStyleBackColor = true;
            this.buttonMoveToRectangle.Click += new System.EventHandler(this.buttonMoveToRectangle_Click);
            // 
            // buttonMoveToSphere
            // 
            this.buttonMoveToSphere.Location = new System.Drawing.Point(463, 368);
            this.buttonMoveToSphere.Name = "buttonMoveToSphere";
            this.buttonMoveToSphere.Size = new System.Drawing.Size(110, 46);
            this.buttonMoveToSphere.TabIndex = 18;
            this.buttonMoveToSphere.Text = "<< Sphere";
            this.buttonMoveToSphere.UseVisualStyleBackColor = true;
            this.buttonMoveToSphere.Click += new System.EventHandler(this.buttonMoveToSphere_Click);
            // 
            // textBoxSide1
            // 
            this.textBoxSide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSide1.Location = new System.Drawing.Point(387, 185);
            this.textBoxSide1.Name = "textBoxSide1";
            this.textBoxSide1.Size = new System.Drawing.Size(100, 30);
            this.textBoxSide1.TabIndex = 17;
            this.textBoxSide1.Text = "0";
            this.textBoxSide1.TextChanged += new System.EventHandler(this.textBoxSide1_TextChanged);
            // 
            // textBoxSide2
            // 
            this.textBoxSide2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSide2.Location = new System.Drawing.Point(196, 330);
            this.textBoxSide2.Name = "textBoxSide2";
            this.textBoxSide2.Size = new System.Drawing.Size(100, 30);
            this.textBoxSide2.TabIndex = 16;
            this.textBoxSide2.Text = "0";
            this.textBoxSide2.TextChanged += new System.EventHandler(this.textBoxSide2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(59, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 268);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxSide3
            // 
            this.textBoxSide3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSide3.Location = new System.Drawing.Point(12, 185);
            this.textBoxSide3.Name = "textBoxSide3";
            this.textBoxSide3.Size = new System.Drawing.Size(100, 30);
            this.textBoxSide3.TabIndex = 24;
            this.textBoxSide3.Text = "0";
            this.textBoxSide3.TextChanged += new System.EventHandler(this.textBoxSide3_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSide3);
            this.Controls.Add(this.labelPerimeter);
            this.Controls.Add(this.labelUI_perimeter);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelUI_area);
            this.Controls.Add(this.buttonMoveToRectangle);
            this.Controls.Add(this.buttonMoveToSphere);
            this.Controls.Add(this.textBoxSide1);
            this.Controls.Add(this.textBoxSide2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPerimeter;
        private System.Windows.Forms.Label labelUI_perimeter;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelUI_area;
        private System.Windows.Forms.Button buttonMoveToRectangle;
        private System.Windows.Forms.Button buttonMoveToSphere;
        private System.Windows.Forms.TextBox textBoxSide1;
        private System.Windows.Forms.TextBox textBoxSide2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSide3;
    }
}