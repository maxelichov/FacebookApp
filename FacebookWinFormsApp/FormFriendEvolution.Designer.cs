namespace FacebookWinFormsApp
{
    partial class FormFriendEvolution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFriendEvolution));
            this.label_FriendProfilePicturesDisplay = new System.Windows.Forms.Label();
            this.panel_ProfilePictures = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_FriendProfilePicturesDisplay
            // 
            this.label_FriendProfilePicturesDisplay.AutoSize = true;
            this.label_FriendProfilePicturesDisplay.BackColor = System.Drawing.Color.Tan;
            this.label_FriendProfilePicturesDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FriendProfilePicturesDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_FriendProfilePicturesDisplay.Location = new System.Drawing.Point(13, 21);
            this.label_FriendProfilePicturesDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FriendProfilePicturesDisplay.Name = "label_FriendProfilePicturesDisplay";
            this.label_FriendProfilePicturesDisplay.Size = new System.Drawing.Size(205, 61);
            this.label_FriendProfilePicturesDisplay.TabIndex = 0;
            this.label_FriendProfilePicturesDisplay.Text = "Header";
            this.label_FriendProfilePicturesDisplay.Click += new System.EventHandler(this.label_FriendProfilePicturesDisplay_Click);
            // 
            // panel_ProfilePictures
            // 
            this.panel_ProfilePictures.AutoScroll = true;
            this.panel_ProfilePictures.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_ProfilePictures.BackColor = System.Drawing.Color.LightSalmon;
            this.panel_ProfilePictures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_ProfilePictures.Location = new System.Drawing.Point(720, 362);
            this.panel_ProfilePictures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_ProfilePictures.Name = "panel_ProfilePictures";
            this.panel_ProfilePictures.Size = new System.Drawing.Size(452, 331);
            this.panel_ProfilePictures.TabIndex = 1;
            // 
            // FormProfilePictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel_ProfilePictures);
            this.Controls.Add(this.label_FriendProfilePicturesDisplay);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormProfilePictures";
            this.Text = "FormProfilePictures";
            this.Load += new System.EventHandler(this.FormProfilePictures_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FriendProfilePicturesDisplay;
        private System.Windows.Forms.Panel panel_ProfilePictures;
    }
}