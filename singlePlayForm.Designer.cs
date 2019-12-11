namespace Client
{
    partial class SinglePlayForm
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
            this.boardPicture = new System.Windows.Forms.PictureBox();
            this.boardPicture2 = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boardPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardPicture2)).BeginInit();
            this.SuspendLayout();
            // 
            // boardPicture
            // 
            this.boardPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(216)))));
            this.boardPicture.Location = new System.Drawing.Point(20, 20);
            this.boardPicture.Name = "boardPicture";
            this.boardPicture.Size = new System.Drawing.Size(500, 500);
            this.boardPicture.TabIndex = 0;
            this.boardPicture.TabStop = false;
            this.boardPicture.Click += new System.EventHandler(this.boardPicture_Click);
            this.boardPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boardPicture_MouseDown_1);
            // 
            // boardPicture2
            // 
            this.boardPicture2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(216)))));
            this.boardPicture2.Location = new System.Drawing.Point(20, 20);
            this.boardPicture2.Name = "boardPicture2";
            this.boardPicture2.Size = new System.Drawing.Size(500, 500);
            this.boardPicture2.TabIndex = 1;
            this.boardPicture2.TabStop = false;
            this.boardPicture2.Paint += new System.Windows.Forms.PaintEventHandler(this.boardPicture2_Paint);
            this.boardPicture2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boardPicture2_MouseDown);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(645, 39);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 40);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Game Start";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(563, 94);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(272, 15);
            this.status.TabIndex = 3;
            this.status.Text = "Please press the start button!";
            this.status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SinglePlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 533);
            this.Controls.Add(this.status);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.boardPicture2);
            this.Controls.Add(this.boardPicture);
            this.Name = "SinglePlayForm";
            this.Text = "SinglePlayForm";
            this.Load += new System.EventHandler(this.SinglePlayForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.boardPicture_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boardPicture_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.boardPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardPicture2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox boardPicture;
        private System.Windows.Forms.PictureBox boardPicture2;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label status;
    }
}