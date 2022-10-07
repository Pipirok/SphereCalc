namespace SphereCalc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textboxRadius = new System.Windows.Forms.TextBox();
            this.labelUI_instr = new System.Windows.Forms.Label();
            this.labelUI_area = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelUI_volume = new System.Windows.Forms.Label();
            this.toolTipArea = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipVolume = new System.Windows.Forms.ToolTip(this.components);
            this.buttonMoveToTriangle = new System.Windows.Forms.Button();
            this.buttonMoveToRectangle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 367);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textboxRadius
            // 
            this.textboxRadius.Location = new System.Drawing.Point(243, 243);
            this.textboxRadius.Name = "textboxRadius";
            this.textboxRadius.Size = new System.Drawing.Size(100, 22);
            this.textboxRadius.TabIndex = 1;
            this.textboxRadius.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelUI_instr
            // 
            this.labelUI_instr.AutoSize = true;
            this.labelUI_instr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUI_instr.Location = new System.Drawing.Point(29, 14);
            this.labelUI_instr.Name = "labelUI_instr";
            this.labelUI_instr.Size = new System.Drawing.Size(275, 25);
            this.labelUI_instr.TabIndex = 2;
            this.labelUI_instr.Text = "Enter the sphere radius below!";
            // 
            // labelUI_area
            // 
            this.labelUI_area.AutoSize = true;
            this.labelUI_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUI_area.Location = new System.Drawing.Point(455, 171);
            this.labelUI_area.Name = "labelUI_area";
            this.labelUI_area.Size = new System.Drawing.Size(43, 32);
            this.labelUI_area.TabIndex = 3;
            this.labelUI_area.Text = "S:";
            this.toolTipArea.SetToolTip(this.labelUI_area, "Sphere\'s surface area");
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(514, 171);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(0, 39);
            this.labelArea.TabIndex = 4;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolume.Location = new System.Drawing.Point(514, 233);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(0, 39);
            this.labelVolume.TabIndex = 6;
            // 
            // labelUI_volume
            // 
            this.labelUI_volume.AutoSize = true;
            this.labelUI_volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUI_volume.Location = new System.Drawing.Point(455, 233);
            this.labelUI_volume.Name = "labelUI_volume";
            this.labelUI_volume.Size = new System.Drawing.Size(43, 32);
            this.labelUI_volume.TabIndex = 5;
            this.labelUI_volume.Text = "V:";
            this.toolTipVolume.SetToolTip(this.labelUI_volume, "Sphere\'s volume");
            // 
            // toolTipArea
            // 
            this.toolTipArea.IsBalloon = true;
            // 
            // toolTipVolume
            // 
            this.toolTipVolume.IsBalloon = true;
            // 
            // buttonMoveToTriangle
            // 
            this.buttonMoveToTriangle.Location = new System.Drawing.Point(601, 421);
            this.buttonMoveToTriangle.Name = "buttonMoveToTriangle";
            this.buttonMoveToTriangle.Size = new System.Drawing.Size(110, 46);
            this.buttonMoveToTriangle.TabIndex = 7;
            this.buttonMoveToTriangle.Text = "Triangle >>";
            this.buttonMoveToTriangle.UseVisualStyleBackColor = true;
            this.buttonMoveToTriangle.Click += new System.EventHandler(this.buttonMoveToTriangle_Click);
            // 
            // buttonMoveToRectangle
            // 
            this.buttonMoveToRectangle.Location = new System.Drawing.Point(421, 421);
            this.buttonMoveToRectangle.Name = "buttonMoveToRectangle";
            this.buttonMoveToRectangle.Size = new System.Drawing.Size(110, 46);
            this.buttonMoveToRectangle.TabIndex = 8;
            this.buttonMoveToRectangle.Text = "<< Rectangle";
            this.buttonMoveToRectangle.UseVisualStyleBackColor = true;
            this.buttonMoveToRectangle.Click += new System.EventHandler(this.buttonMoveToRectangle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 493);
            this.Controls.Add(this.buttonMoveToRectangle);
            this.Controls.Add(this.buttonMoveToTriangle);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.labelUI_volume);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelUI_area);
            this.Controls.Add(this.labelUI_instr);
            this.Controls.Add(this.textboxRadius);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sphere Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textboxRadius;
        private System.Windows.Forms.Label labelUI_instr;
        private System.Windows.Forms.Label labelUI_area;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelUI_volume;
        private System.Windows.Forms.ToolTip toolTipArea;
        private System.Windows.Forms.ToolTip toolTipVolume;
        private System.Windows.Forms.Button buttonMoveToTriangle;
        private System.Windows.Forms.Button buttonMoveToRectangle;
    }
}

