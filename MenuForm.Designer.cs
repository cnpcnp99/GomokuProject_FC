namespace Client
{
    partial class MenuForm
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
            this.singleStartButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // singleStartButton
            // 
            this.singleStartButton.Location = new System.Drawing.Point(342, 141);
            this.singleStartButton.Name = "singleStartButton";
            this.singleStartButton.Size = new System.Drawing.Size(100, 40);
            this.singleStartButton.TabIndex = 0;
            this.singleStartButton.Text = "혼자 하기";
            this.singleStartButton.UseVisualStyleBackColor = true;
            this.singleStartButton.Click += new System.EventHandler(this.singleButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(341, 231);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 40);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "종료하기";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.singleStartButton);
            this.Name = "MenuForm";
            this.Text = "Gomoku Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button singleStartButton;
        private System.Windows.Forms.Button exitButton;
    }
}