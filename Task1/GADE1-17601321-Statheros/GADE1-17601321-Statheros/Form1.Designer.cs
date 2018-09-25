namespace GADE1_17601321_Statheros
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
            this.TimerBox = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimerBox
            // 
            this.TimerBox.AutoSize = true;
            this.TimerBox.Location = new System.Drawing.Point(13, 27);
            this.TimerBox.Name = "TimerBox";
            this.TimerBox.Size = new System.Drawing.Size(33, 13);
            this.TimerBox.TabIndex = 0;
            this.TimerBox.Text = "Timer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 1;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(16, 109);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            // 
            // PauseBtn
            // 
            this.PauseBtn.Location = new System.Drawing.Point(115, 109);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(75, 23);
            this.PauseBtn.TabIndex = 3;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TimerBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimerBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button PauseBtn;
    }
}

