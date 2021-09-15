namespace FacebookWinFormsApp
{
    partial class FormMain
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.ListBox_Friends = new System.Windows.Forms.ListBox();
            this.linkedLabel_FriendEvolution = new System.Windows.Forms.LinkLabel();
            this.cb_RememberMe = new System.Windows.Forms.CheckBox();
            this.pb_ProfilePicture = new System.Windows.Forms.PictureBox();
            this.label_Trivia = new System.Windows.Forms.Label();
            this.cb_ShowFriendProfilePictures = new System.Windows.Forms.CheckBox();
            this.cb_FriendTrivia = new System.Windows.Forms.CheckBox();
            this.button_ShowFriendProfilePictures = new System.Windows.Forms.Button();
            this.button_FriendTrivia = new System.Windows.Forms.Button();
            this.label_pickAFriend = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.locationLabel1 = new System.Windows.Forms.Label();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ListBoxEvents = new System.Windows.Forms.ListBox();
            this.ListBox_Posts = new System.Windows.Forms.ListBox();
            this.Label_Posts = new System.Windows.Forms.Label();
            this.ComboBox_Posts = new System.Windows.Forms.ComboBox();
            descriptionLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ProfilePicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(50, 75);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(50, 185);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(80, 20);
            endTimeLabel.TabIndex = 2;
            endTimeLabel.Text = "End Time:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(50, 238);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(74, 20);
            locationLabel.TabIndex = 6;
            locationLabel.Text = "Location:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(50, 144);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(86, 20);
            startTimeLabel.TabIndex = 8;
            startTimeLabel.Text = "Start Time:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogin.BackgroundImage")));
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.Location = new System.Drawing.Point(564, 97);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(270, 168);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogout.BackgroundImage")));
            this.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(60, 97);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(270, 168);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // ListBox_Friends
            // 
            this.ListBox_Friends.BackColor = System.Drawing.Color.LightPink;
            this.ListBox_Friends.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Friends.FormattingEnabled = true;
            this.ListBox_Friends.ItemHeight = 29;
            this.ListBox_Friends.Location = new System.Drawing.Point(489, 654);
            this.ListBox_Friends.Name = "ListBox_Friends";
            this.ListBox_Friends.Size = new System.Drawing.Size(252, 207);
            this.ListBox_Friends.TabIndex = 53;
            this.ListBox_Friends.Tag = "llFriends";
            this.ListBox_Friends.SelectedIndexChanged += new System.EventHandler(this.ListBox_Friends_SelectedIndexChanged);
            // 
            // linkedLabel_FriendEvolution
            // 
            this.linkedLabel_FriendEvolution.AutoSize = true;
            this.linkedLabel_FriendEvolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkedLabel_FriendEvolution.LinkColor = System.Drawing.Color.IndianRed;
            this.linkedLabel_FriendEvolution.Location = new System.Drawing.Point(8, 491);
            this.linkedLabel_FriendEvolution.Name = "linkedLabel_FriendEvolution";
            this.linkedLabel_FriendEvolution.Size = new System.Drawing.Size(386, 55);
            this.linkedLabel_FriendEvolution.TabIndex = 54;
            this.linkedLabel_FriendEvolution.TabStop = true;
            this.linkedLabel_FriendEvolution.Text = "Friend Evolution";
            this.linkedLabel_FriendEvolution.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFriends_LinkClicked);
            // 
            // cb_RememberMe
            // 
            this.cb_RememberMe.AutoSize = true;
            this.cb_RememberMe.Enabled = false;
            this.cb_RememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_RememberMe.ForeColor = System.Drawing.Color.DeepPink;
            this.cb_RememberMe.Location = new System.Drawing.Point(564, 365);
            this.cb_RememberMe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_RememberMe.Name = "cb_RememberMe";
            this.cb_RememberMe.Size = new System.Drawing.Size(211, 33);
            this.cb_RememberMe.TabIndex = 55;
            this.cb_RememberMe.Text = "Remember Me";
            this.cb_RememberMe.UseVisualStyleBackColor = true;
            // 
            // pb_ProfilePicture
            // 
            this.pb_ProfilePicture.Location = new System.Drawing.Point(958, 97);
            this.pb_ProfilePicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_ProfilePicture.Name = "pb_ProfilePicture";
            this.pb_ProfilePicture.Size = new System.Drawing.Size(230, 168);
            this.pb_ProfilePicture.TabIndex = 56;
            this.pb_ProfilePicture.TabStop = false;
            // 
            // label_Trivia
            // 
            this.label_Trivia.AutoSize = true;
            this.label_Trivia.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Trivia.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_Trivia.Location = new System.Drawing.Point(870, 491);
            this.label_Trivia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Trivia.Name = "label_Trivia";
            this.label_Trivia.Size = new System.Drawing.Size(302, 55);
            this.label_Trivia.TabIndex = 57;
            this.label_Trivia.Text = "Friend Trivia";
            this.label_Trivia.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_ShowFriendProfilePictures
            // 
            this.cb_ShowFriendProfilePictures.AutoSize = true;
            this.cb_ShowFriendProfilePictures.Enabled = false;
            this.cb_ShowFriendProfilePictures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ShowFriendProfilePictures.ForeColor = System.Drawing.Color.Aqua;
            this.cb_ShowFriendProfilePictures.Location = new System.Drawing.Point(18, 632);
            this.cb_ShowFriendProfilePictures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_ShowFriendProfilePictures.Name = "cb_ShowFriendProfilePictures";
            this.cb_ShowFriendProfilePictures.Size = new System.Drawing.Size(402, 33);
            this.cb_ShowFriendProfilePictures.TabIndex = 58;
            this.cb_ShowFriendProfilePictures.Text = "To See How A Friend Chnaged";
            this.cb_ShowFriendProfilePictures.UseVisualStyleBackColor = true;
            this.cb_ShowFriendProfilePictures.CheckedChanged += new System.EventHandler(this.cb_ShowFriendProfilePictures_CheckedChanged);
            // 
            // cb_FriendTrivia
            // 
            this.cb_FriendTrivia.AutoSize = true;
            this.cb_FriendTrivia.Enabled = false;
            this.cb_FriendTrivia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_FriendTrivia.ForeColor = System.Drawing.Color.Fuchsia;
            this.cb_FriendTrivia.Location = new System.Drawing.Point(880, 632);
            this.cb_FriendTrivia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_FriendTrivia.Name = "cb_FriendTrivia";
            this.cb_FriendTrivia.Size = new System.Drawing.Size(336, 33);
            this.cb_FriendTrivia.TabIndex = 59;
            this.cb_FriendTrivia.Text = "Take A Friend Trivia Test";
            this.cb_FriendTrivia.UseVisualStyleBackColor = true;
            this.cb_FriendTrivia.CheckedChanged += new System.EventHandler(this.cb_FriendTrivia_CheckedChanged);
            // 
            // button_ShowFriendProfilePictures
            // 
            this.button_ShowFriendProfilePictures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button_ShowFriendProfilePictures.Location = new System.Drawing.Point(18, 682);
            this.button_ShowFriendProfilePictures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ShowFriendProfilePictures.Name = "button_ShowFriendProfilePictures";
            this.button_ShowFriendProfilePictures.Size = new System.Drawing.Size(332, 100);
            this.button_ShowFriendProfilePictures.TabIndex = 60;
            this.button_ShowFriendProfilePictures.Text = "To See How A Friend Chnaged";
            this.button_ShowFriendProfilePictures.UseVisualStyleBackColor = false;
            this.button_ShowFriendProfilePictures.Click += new System.EventHandler(this.button_ShowFriendProfilePictures_Click);
            // 
            // button_FriendTrivia
            // 
            this.button_FriendTrivia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_FriendTrivia.Location = new System.Drawing.Point(880, 685);
            this.button_FriendTrivia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_FriendTrivia.Name = "button_FriendTrivia";
            this.button_FriendTrivia.Size = new System.Drawing.Size(308, 97);
            this.button_FriendTrivia.TabIndex = 61;
            this.button_FriendTrivia.Text = "Take A Friend Trivia Test";
            this.button_FriendTrivia.UseVisualStyleBackColor = false;
            this.button_FriendTrivia.Click += new System.EventHandler(this.button_FriendTrivia_Click);
            // 
            // label_pickAFriend
            // 
            this.label_pickAFriend.AutoSize = true;
            this.label_pickAFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pickAFriend.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_pickAFriend.Location = new System.Drawing.Point(524, 606);
            this.label_pickAFriend.Name = "label_pickAFriend";
            this.label_pickAFriend.Size = new System.Drawing.Size(152, 22);
            this.label_pickAFriend.TabIndex = 62;
            this.label_pickAFriend.Text = "PICK A FRIEND";
            this.label_pickAFriend.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(endTimeLabel);
            this.panel1.Controls.Add(this.endTimeDateTimePicker);
            this.panel1.Controls.Add(this.imageNormalPictureBox);
            this.panel1.Controls.Add(locationLabel);
            this.panel1.Controls.Add(this.locationLabel1);
            this.panel1.Controls.Add(startTimeLabel);
            this.panel1.Controls.Add(this.startTimeDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(1313, 474);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 308);
            this.panel1.TabIndex = 63;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(168, 72);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 51);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(168, 180);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.endTimeDateTimePicker.TabIndex = 3;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(54, 17);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(64, 50);
            this.imageNormalPictureBox.TabIndex = 5;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // locationLabel1
            // 
            this.locationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.locationLabel1.Location = new System.Drawing.Point(168, 238);
            this.locationLabel1.Name = "locationLabel1";
            this.locationLabel1.Size = new System.Drawing.Size(200, 23);
            this.locationLabel1.TabIndex = 7;
            this.locationLabel1.Text = "label1";
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(168, 140);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.startTimeDateTimePicker.TabIndex = 9;
            // 
            // ListBoxEvents
            // 
            this.ListBoxEvents.BackColor = System.Drawing.Color.LightPink;
            this.ListBoxEvents.DataSource = this.eventBindingSource;
            this.ListBoxEvents.DisplayMember = "Name";
            this.ListBoxEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxEvents.FormattingEnabled = true;
            this.ListBoxEvents.ItemHeight = 29;
            this.ListBoxEvents.Location = new System.Drawing.Point(1313, 206);
            this.ListBoxEvents.Name = "ListBoxEvents";
            this.ListBoxEvents.Size = new System.Drawing.Size(420, 207);
            this.ListBoxEvents.TabIndex = 64;
            this.ListBoxEvents.Tag = "llFriends";
            this.ListBoxEvents.SelectedIndexChanged += new System.EventHandler(this.ListBoxEvents_SelectedIndexChanged);
            // 
            // ListBox_Posts
            // 
            this.ListBox_Posts.FormattingEnabled = true;
            this.ListBox_Posts.ItemHeight = 20;
            this.ListBox_Posts.Location = new System.Drawing.Point(1759, 474);
            this.ListBox_Posts.Name = "ListBox_Posts";
            this.ListBox_Posts.Size = new System.Drawing.Size(267, 304);
            this.ListBox_Posts.TabIndex = 65;
            this.ListBox_Posts.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Label_Posts
            // 
            this.Label_Posts.AutoSize = true;
            this.Label_Posts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Posts.Location = new System.Drawing.Point(1824, 360);
            this.Label_Posts.Name = "Label_Posts";
            this.Label_Posts.Size = new System.Drawing.Size(102, 37);
            this.Label_Posts.TabIndex = 66;
            this.Label_Posts.Text = "Posts";
            // 
            // ComboBox_Posts
            // 
            this.ComboBox_Posts.FormattingEnabled = true;
            this.ComboBox_Posts.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.ComboBox_Posts.Location = new System.Drawing.Point(1759, 421);
            this.ComboBox_Posts.Name = "ComboBox_Posts";
            this.ComboBox_Posts.Size = new System.Drawing.Size(267, 28);
            this.ComboBox_Posts.TabIndex = 67;
            this.ComboBox_Posts.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Posts_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(2052, 874);
            this.Controls.Add(this.ComboBox_Posts);
            this.Controls.Add(this.Label_Posts);
            this.Controls.Add(this.ListBox_Posts);
            this.Controls.Add(this.ListBoxEvents);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_pickAFriend);
            this.Controls.Add(this.button_FriendTrivia);
            this.Controls.Add(this.button_ShowFriendProfilePictures);
            this.Controls.Add(this.cb_FriendTrivia);
            this.Controls.Add(this.cb_ShowFriendProfilePictures);
            this.Controls.Add(this.label_Trivia);
            this.Controls.Add(this.pb_ProfilePicture);
            this.Controls.Add(this.cb_RememberMe);
            this.Controls.Add(this.linkedLabel_FriendEvolution);
            this.Controls.Add(this.ListBox_Friends);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ProfilePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ListBox ListBox_Friends;
        private System.Windows.Forms.LinkLabel linkedLabel_FriendEvolution;
        private System.Windows.Forms.CheckBox cb_RememberMe;
        private System.Windows.Forms.PictureBox pb_ProfilePicture;
        private System.Windows.Forms.Label label_Trivia;
        private System.Windows.Forms.CheckBox cb_ShowFriendProfilePictures;
        private System.Windows.Forms.CheckBox cb_FriendTrivia;
        private System.Windows.Forms.Button button_ShowFriendProfilePictures;
        private System.Windows.Forms.Button button_FriendTrivia;
        private System.Windows.Forms.Label label_pickAFriend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.Label locationLabel1;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
        private System.Windows.Forms.ListBox ListBoxEvents;
        private System.Windows.Forms.Label Label_Posts;
        private System.Windows.Forms.ComboBox ComboBox_Posts;
        private System.Windows.Forms.ListBox ListBox_Posts;
    }
}

