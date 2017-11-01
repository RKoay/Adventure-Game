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
            this.outputDisplay = new System.Windows.Forms.Label();
            this.optionOne = new System.Windows.Forms.Label();
            this.optionTwo = new System.Windows.Forms.Label();
            this.optionThree = new System.Windows.Forms.Label();
            this.imageDisplay = new System.Windows.Forms.Label();
            this.controlOne = new System.Windows.Forms.Button();
            this.controlTwo = new System.Windows.Forms.Button();
            this.controlThree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputDisplay
            // 
            this.outputDisplay.BackColor = System.Drawing.Color.White;
            this.outputDisplay.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDisplay.Location = new System.Drawing.Point(12, 235);
            this.outputDisplay.Name = "outputDisplay";
            this.outputDisplay.Size = new System.Drawing.Size(210, 106);
            this.outputDisplay.TabIndex = 0;
            // 
            // optionOne
            // 
            this.optionOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.optionOne.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionOne.Location = new System.Drawing.Point(299, 244);
            this.optionOne.Name = "optionOne";
            this.optionOne.Size = new System.Drawing.Size(91, 23);
            this.optionOne.TabIndex = 1;
            // 
            // optionTwo
            // 
            this.optionTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.optionTwo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionTwo.Location = new System.Drawing.Point(299, 273);
            this.optionTwo.Name = "optionTwo";
            this.optionTwo.Size = new System.Drawing.Size(91, 23);
            this.optionTwo.TabIndex = 2;
            // 
            // optionThree
            // 
            this.optionThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.optionThree.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionThree.Location = new System.Drawing.Point(299, 302);
            this.optionThree.Name = "optionThree";
            this.optionThree.Size = new System.Drawing.Size(91, 23);
            this.optionThree.TabIndex = 3;
            // 
            // imageDisplay
            // 
            this.imageDisplay.Location = new System.Drawing.Point(-5, -1);
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Size = new System.Drawing.Size(437, 236);
            this.imageDisplay.TabIndex = 4;
            this.imageDisplay.Click += new System.EventHandler(this.imageDisplay_Click);
            // 
            // controlOne
            // 
            this.controlOne.BackColor = System.Drawing.Color.Red;
            this.controlOne.ForeColor = System.Drawing.Color.Red;
            this.controlOne.Location = new System.Drawing.Point(228, 246);
            this.controlOne.Name = "controlOne";
            this.controlOne.Size = new System.Drawing.Size(48, 23);
            this.controlOne.TabIndex = 5;
            this.controlOne.Text = " ";
            this.controlOne.UseVisualStyleBackColor = false;
            // 
            // controlTwo
            // 
            this.controlTwo.AutoSize = true;
            this.controlTwo.BackColor = System.Drawing.Color.Blue;
            this.controlTwo.ForeColor = System.Drawing.Color.Blue;
            this.controlTwo.Location = new System.Drawing.Point(228, 275);
            this.controlTwo.Name = "controlTwo";
            this.controlTwo.Size = new System.Drawing.Size(48, 23);
            this.controlTwo.TabIndex = 6;
            this.controlTwo.Text = " ";
            this.controlTwo.UseVisualStyleBackColor = false;
            // 
            // controlThree
            // 
            this.controlThree.AutoSize = true;
            this.controlThree.BackColor = System.Drawing.Color.Lime;
            this.controlThree.ForeColor = System.Drawing.Color.Lime;
            this.controlThree.Location = new System.Drawing.Point(228, 304);
            this.controlThree.Name = "controlThree";
            this.controlThree.Size = new System.Drawing.Size(48, 23);
            this.controlThree.TabIndex = 7;
            this.controlThree.Text = " ";
            this.controlThree.UseVisualStyleBackColor = false;
            // 
            // mainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(431, 339);
            this.Controls.Add(this.controlThree);
            this.Controls.Add(this.controlTwo);
            this.Controls.Add(this.controlOne);
            this.Controls.Add(this.optionThree);
            this.Controls.Add(this.optionTwo);
            this.Controls.Add(this.optionOne);
            this.Controls.Add(this.outputDisplay);
            this.Controls.Add(this.imageDisplay);
            this.Name = "mainDisplay";
            this.Text = "A Mistake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainDisplay_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputDisplay;
        private System.Windows.Forms.Label optionOne;
        private System.Windows.Forms.Label optionTwo;
        private System.Windows.Forms.Label optionThree;
        private System.Windows.Forms.Label imageDisplay;
        private System.Windows.Forms.Button controlOne;
        private System.Windows.Forms.Button controlTwo;
        private System.Windows.Forms.Button controlThree;
    }
}

