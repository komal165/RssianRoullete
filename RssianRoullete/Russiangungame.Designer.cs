namespace RssianRoullete
{
    partial class Russiangungame
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
            this.gunloadbtn = new System.Windows.Forms.Button();
            this.Spingunbtn = new System.Windows.Forms.Button();
            this.Shootgunbtn = new System.Windows.Forms.Button();
            this.Shootabtn = new System.Windows.Forms.Button();
            this.Playagainbtn = new System.Windows.Forms.Button();
            this.imglooder = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imglooder)).BeginInit();
            this.SuspendLayout();
            // 
            // gunloadbtn
            // 
            this.gunloadbtn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunloadbtn.Location = new System.Drawing.Point(520, 122);
            this.gunloadbtn.Name = "gunloadbtn";
            this.gunloadbtn.Size = new System.Drawing.Size(112, 47);
            this.gunloadbtn.TabIndex = 0;
            this.gunloadbtn.Text = "load gun";
            this.gunloadbtn.UseVisualStyleBackColor = true;
            this.gunloadbtn.Click += new System.EventHandler(this.gunloadbtn_Click);
            // 
            // Spingunbtn
            // 
            this.Spingunbtn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spingunbtn.Location = new System.Drawing.Point(520, 185);
            this.Spingunbtn.Name = "Spingunbtn";
            this.Spingunbtn.Size = new System.Drawing.Size(112, 47);
            this.Spingunbtn.TabIndex = 1;
            this.Spingunbtn.Text = "Spin";
            this.Spingunbtn.UseVisualStyleBackColor = true;
            this.Spingunbtn.Click += new System.EventHandler(this.Spingunbtn_Click);
            // 
            // Shootgunbtn
            // 
            this.Shootgunbtn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shootgunbtn.Location = new System.Drawing.Point(520, 248);
            this.Shootgunbtn.Name = "Shootgunbtn";
            this.Shootgunbtn.Size = new System.Drawing.Size(112, 47);
            this.Shootgunbtn.TabIndex = 2;
            this.Shootgunbtn.Text = "Shoot";
            this.Shootgunbtn.UseVisualStyleBackColor = true;
            this.Shootgunbtn.Click += new System.EventHandler(this.Shootgunbtn_Click);
            // 
            // Shootabtn
            // 
            this.Shootabtn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shootabtn.Location = new System.Drawing.Point(661, 122);
            this.Shootabtn.Name = "Shootabtn";
            this.Shootabtn.Size = new System.Drawing.Size(112, 75);
            this.Shootabtn.TabIndex = 3;
            this.Shootabtn.Text = "Away Shoot";
            this.Shootabtn.UseVisualStyleBackColor = true;
            this.Shootabtn.Click += new System.EventHandler(this.Shootabtn_Click);
            // 
            // Playagainbtn
            // 
            this.Playagainbtn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playagainbtn.Location = new System.Drawing.Point(661, 212);
            this.Playagainbtn.Name = "Playagainbtn";
            this.Playagainbtn.Size = new System.Drawing.Size(112, 83);
            this.Playagainbtn.TabIndex = 4;
            this.Playagainbtn.Text = "Play Again";
            this.Playagainbtn.UseVisualStyleBackColor = true;
            this.Playagainbtn.Click += new System.EventHandler(this.Playagainbtn_Click);
            // 
            // imglooder
            // 
            this.imglooder.Location = new System.Drawing.Point(22, 54);
            this.imglooder.Name = "imglooder";
            this.imglooder.Size = new System.Drawing.Size(492, 365);
            this.imglooder.TabIndex = 5;
            this.imglooder.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "lRussian Roullete";
            // 
            // Russiangungame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imglooder);
            this.Controls.Add(this.Playagainbtn);
            this.Controls.Add(this.Shootabtn);
            this.Controls.Add(this.Shootgunbtn);
            this.Controls.Add(this.Spingunbtn);
            this.Controls.Add(this.gunloadbtn);
            this.Name = "Russiangungame";
            this.Text = "Russiangungame";
            this.Load += new System.EventHandler(this.Russiangungame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imglooder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gunloadbtn;
        private System.Windows.Forms.Button Spingunbtn;
        private System.Windows.Forms.Button Shootgunbtn;
        private System.Windows.Forms.Button Shootabtn;
        private System.Windows.Forms.Button Playagainbtn;
        private System.Windows.Forms.PictureBox imglooder;
        private System.Windows.Forms.Label label1;
    }
}