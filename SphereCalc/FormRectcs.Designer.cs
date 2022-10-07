namespace SphereCalc
{
    partial class FormRectcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRectcs));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxSide2 = new System.Windows.Forms.TextBox();
            this.textBoxSide1 = new System.Windows.Forms.TextBox();
            this.buttonMoveToTriangle = new System.Windows.Forms.Button();
            this.buttonMoveToSphere = new System.Windows.Forms.Button();
            this.labelPerimeter = new System.Windows.Forms.Label();
            this.labelUI_perimeter = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelUI_area = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(60, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 184);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxSide2
            // 
            this.textBoxSide2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSide2.Location = new System.Drawing.Point(195, 252);
            this.textBoxSide2.Name = "textBoxSide2";
            this.textBoxSide2.Size = new System.Drawing.Size(100, 30);
            this.textBoxSide2.TabIndex = 1;
            this.textBoxSide2.Text = "0";
            this.textBoxSide2.TextChanged += new System.EventHandler(this.textBoxSide2_TextChanged);
            // 
            // textBoxSide1
            // 
            this.textBoxSide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSide1.Location = new System.Drawing.Point(429, 153);
            this.textBoxSide1.Name = "textBoxSide1";
            this.textBoxSide1.Size = new System.Drawing.Size(100, 30);
            this.textBoxSide1.TabIndex = 2;
            this.textBoxSide1.Text = "0";
            this.textBoxSide1.TextChanged += new System.EventHandler(this.textBoxSide1_TextChanged);
            // 
            // buttonMoveToTriangle
            // 
            this.buttonMoveToTriangle.Location = new System.Drawing.Point(457, 382);
            this.buttonMoveToTriangle.Name = "buttonMoveToTriangle";
            this.buttonMoveToTriangle.Size = new System.Drawing.Size(110, 46);
            this.buttonMoveToTriangle.TabIndex = 9;
            this.buttonMoveToTriangle.Text = "<< Triangle";
            this.buttonMoveToTriangle.UseVisualStyleBackColor = true;
            this.buttonMoveToTriangle.Click += new System.EventHandler(this.buttonMoveToTriangle_Click);
            // 
            // buttonMoveToSphere
            // 
            this.buttonMoveToSphere.Location = new System.Drawing.Point(632, 382);
            this.buttonMoveToSphere.Name = "buttonMoveToSphere";
            this.buttonMoveToSphere.Size = new System.Drawing.Size(110, 46);
            this.buttonMoveToSphere.TabIndex = 10;
            this.buttonMoveToSphere.Text = "Sphere >>";
            this.buttonMoveToSphere.UseVisualStyleBackColor = true;
            this.buttonMoveToSphere.Click += new System.EventHandler(this.buttonMoveToSphere_Click);
            // 
            // labelPerimeter
            // 
            this.labelPerimeter.AutoSize = true;
            this.labelPerimeter.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerimeter.Location = new System.Drawing.Point(645, 212);
            this.labelPerimeter.Name = "labelPerimeter";
            this.labelPerimeter.Size = new System.Drawing.Size(0, 39);
            this.labelPerimeter.TabIndex = 14;
            // 
            // labelUI_perimeter
            // 
            this.labelUI_perimeter.AutoSize = true;
            this.labelUI_perimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUI_perimeter.Location = new System.Drawing.Point(586, 212);
            this.labelUI_perimeter.Name = "labelUI_perimeter";
            this.labelUI_perimeter.Size = new System.Drawing.Size(43, 32);
            this.labelUI_perimeter.TabIndex = 13;
            this.labelUI_perimeter.Text = "P:";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(645, 150);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(0, 39);
            this.labelArea.TabIndex = 12;
            // 
            // labelUI_area
            // 
            this.labelUI_area.AutoSize = true;
            this.labelUI_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUI_area.Location = new System.Drawing.Point(586, 150);
            this.labelUI_area.Name = "labelUI_area";
            this.labelUI_area.Size = new System.Drawing.Size(43, 32);
            this.labelUI_area.TabIndex = 11;
            this.labelUI_area.Text = "S:";
            // 
            // FormRectcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPerimeter);
            this.Controls.Add(this.labelUI_perimeter);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelUI_area);
            this.Controls.Add(this.buttonMoveToSphere);
            this.Controls.Add(this.buttonMoveToTriangle);
            this.Controls.Add(this.textBoxSide1);
            this.Controls.Add(this.textBoxSide2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormRectcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRectcs";
            this.Load += new System.EventHandler(this.FormRectcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSide2;
        private System.Windows.Forms.TextBox textBoxSide1;
        private System.Windows.Forms.Button buttonMoveToTriangle;
        private System.Windows.Forms.Button buttonMoveToSphere;
        private System.Windows.Forms.Label labelPerimeter;
        private System.Windows.Forms.Label labelUI_perimeter;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelUI_area;
    }
}