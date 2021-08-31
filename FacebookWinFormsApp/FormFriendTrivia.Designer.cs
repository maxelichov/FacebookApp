namespace FacebookWinFormsApp
{
    partial class FormFriendTrivia
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
            this.label_Question = new System.Windows.Forms.Label();
            this.button_FirstAnswer = new System.Windows.Forms.Button();
            this.button_SecondAnswer = new System.Windows.Forms.Button();
            this.button_ThirdAnswer = new System.Windows.Forms.Button();
            this.button_FourthAnswer = new System.Windows.Forms.Button();
            this.pictureBox_TriviaPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TriviaPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Question
            // 
            this.label_Question.AutoSize = true;
            this.label_Question.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Question.Location = new System.Drawing.Point(205, 410);
            this.label_Question.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(247, 64);
            this.label_Question.TabIndex = 0;
            this.label_Question.Text = "Question";
            // 
            // button_FirstAnswer
            // 
            this.button_FirstAnswer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_FirstAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FirstAnswer.Location = new System.Drawing.Point(744, 551);
            this.button_FirstAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_FirstAnswer.Name = "button_FirstAnswer";
            this.button_FirstAnswer.Size = new System.Drawing.Size(322, 100);
            this.button_FirstAnswer.TabIndex = 1;
            this.button_FirstAnswer.Text = "button1";
            this.button_FirstAnswer.UseVisualStyleBackColor = false;
            this.button_FirstAnswer.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button_SecondAnswer
            // 
            this.button_SecondAnswer.BackColor = System.Drawing.Color.Yellow;
            this.button_SecondAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SecondAnswer.Location = new System.Drawing.Point(92, 551);
            this.button_SecondAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_SecondAnswer.Name = "button_SecondAnswer";
            this.button_SecondAnswer.Size = new System.Drawing.Size(321, 100);
            this.button_SecondAnswer.TabIndex = 2;
            this.button_SecondAnswer.Text = "button2";
            this.button_SecondAnswer.UseVisualStyleBackColor = false;
            this.button_SecondAnswer.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button_ThirdAnswer
            // 
            this.button_ThirdAnswer.BackColor = System.Drawing.Color.Red;
            this.button_ThirdAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThirdAnswer.Location = new System.Drawing.Point(744, 717);
            this.button_ThirdAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ThirdAnswer.Name = "button_ThirdAnswer";
            this.button_ThirdAnswer.Size = new System.Drawing.Size(322, 100);
            this.button_ThirdAnswer.TabIndex = 3;
            this.button_ThirdAnswer.Text = "button3";
            this.button_ThirdAnswer.UseVisualStyleBackColor = false;
            this.button_ThirdAnswer.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button_FourthAnswer
            // 
            this.button_FourthAnswer.BackColor = System.Drawing.Color.Lime;
            this.button_FourthAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FourthAnswer.Location = new System.Drawing.Point(92, 717);
            this.button_FourthAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_FourthAnswer.Name = "button_FourthAnswer";
            this.button_FourthAnswer.Size = new System.Drawing.Size(321, 100);
            this.button_FourthAnswer.TabIndex = 4;
            this.button_FourthAnswer.Text = "button4";
            this.button_FourthAnswer.UseVisualStyleBackColor = false;
            this.button_FourthAnswer.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // pictureBox_TriviaPicture
            // 
            this.pictureBox_TriviaPicture.Location = new System.Drawing.Point(14, 14);
            this.pictureBox_TriviaPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_TriviaPicture.Name = "pictureBox_TriviaPicture";
            this.pictureBox_TriviaPicture.Size = new System.Drawing.Size(1178, 366);
            this.pictureBox_TriviaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TriviaPicture.TabIndex = 5;
            this.pictureBox_TriviaPicture.TabStop = false;
            // 
            // FormFriendTrivia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1204, 949);
            this.Controls.Add(this.pictureBox_TriviaPicture);
            this.Controls.Add(this.button_FourthAnswer);
            this.Controls.Add(this.button_ThirdAnswer);
            this.Controls.Add(this.button_SecondAnswer);
            this.Controls.Add(this.button_FirstAnswer);
            this.Controls.Add(this.label_Question);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormFriendTrivia";
            this.Text = "Trivia Game";
            this.Load += new System.EventHandler(this.FormFriendTrivia_Load);
            this.Click += new System.EventHandler(this.checkAnswerEvent);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TriviaPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.Button button_FirstAnswer;
        private System.Windows.Forms.Button button_SecondAnswer;
        private System.Windows.Forms.Button button_ThirdAnswer;
        private System.Windows.Forms.Button button_FourthAnswer;
        private System.Windows.Forms.PictureBox pictureBox_TriviaPicture;
    }
}