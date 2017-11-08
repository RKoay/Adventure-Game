namespace Adventure_Game
{
    partial class mainDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainDisplay));
            this.outputDisplay = new System.Windows.Forms.Label();
            this.optionOne = new System.Windows.Forms.Label();
            this.optionTwo = new System.Windows.Forms.Label();
            this.optionThree = new System.Windows.Forms.Label();
            this.imageDisplay = new System.Windows.Forms.Label();
            this.controlOne = new System.Windows.Forms.Label();
            this.controlTwo = new System.Windows.Forms.Label();
            this.controlThree = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputDisplay
            // 
            this.outputDisplay.BackColor = System.Drawing.Color.Silver;
            this.outputDisplay.Font = new System.Drawing.Font("Adobe Caslon Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDisplay.Location = new System.Drawing.Point(3, 286);
            this.outputDisplay.Name = "outputDisplay";
            this.outputDisplay.Size = new System.Drawing.Size(296, 143);
            this.outputDisplay.TabIndex = 0;
            // 
            // optionOne
            // 
            this.optionOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.optionOne.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionOne.Location = new System.Drawing.Point(330, 286);
            this.optionOne.Name = "optionOne";
            this.optionOne.Size = new System.Drawing.Size(239, 35);
            this.optionOne.TabIndex = 1;
            // 
            // optionTwo
            // 
            this.optionTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.optionTwo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionTwo.Location = new System.Drawing.Point(330, 336);
            this.optionTwo.Name = "optionTwo";
            this.optionTwo.Size = new System.Drawing.Size(239, 37);
            this.optionTwo.TabIndex = 2;
            // 
            // optionThree
            // 
            this.optionThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.optionThree.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionThree.Location = new System.Drawing.Point(330, 386);
            this.optionThree.Name = "optionThree";
            this.optionThree.Size = new System.Drawing.Size(239, 37);
            this.optionThree.TabIndex = 3;
            // 
            // imageDisplay
            // 
            this.imageDisplay.Location = new System.Drawing.Point(-5, -1);
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Size = new System.Drawing.Size(574, 270);
            this.imageDisplay.TabIndex = 4;
            // 
            // controlOne
            // 
            this.controlOne.BackColor = System.Drawing.Color.Red;
            this.controlOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlOne.Location = new System.Drawing.Point(305, 286);
            this.controlOne.Name = "controlOne";
            this.controlOne.Size = new System.Drawing.Size(19, 23);
            this.controlOne.TabIndex = 5;
            this.controlOne.Text = "R ";
            // 
            // controlTwo
            // 
            this.controlTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.controlTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlTwo.Location = new System.Drawing.Point(305, 336);
            this.controlTwo.Name = "controlTwo";
            this.controlTwo.Size = new System.Drawing.Size(19, 23);
            this.controlTwo.TabIndex = 6;
            this.controlTwo.Text = "T";
            // 
            // controlThree
            // 
            this.controlThree.BackColor = System.Drawing.Color.Lime;
            this.controlThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlThree.Location = new System.Drawing.Point(305, 386);
            this.controlThree.Name = "controlThree";
            this.controlThree.Size = new System.Drawing.Size(19, 23);
            this.controlThree.TabIndex = 7;
            this.controlThree.Text = "E";
            // 
            // mainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(570, 432);
            this.Controls.Add(this.controlThree);
            this.Controls.Add(this.controlTwo);
            this.Controls.Add(this.controlOne);
            this.Controls.Add(this.optionThree);
            this.Controls.Add(this.optionTwo);
            this.Controls.Add(this.optionOne);
            this.Controls.Add(this.outputDisplay);
            this.Controls.Add(this.imageDisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainDisplay";
            this.Text = "A Mistake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainDisplay_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputDisplay;
        private System.Windows.Forms.Label optionOne;
        private System.Windows.Forms.Label optionTwo;
        private System.Windows.Forms.Label optionThree;
        private System.Windows.Forms.Label imageDisplay;
        private System.Windows.Forms.Label controlOne;
        private System.Windows.Forms.Label controlTwo;
        private System.Windows.Forms.Label controlThree;
    }
}

