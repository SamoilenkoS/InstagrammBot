namespace InstagramBot
{
    partial class MainForm
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
            this.StartBaseFormingButton = new System.Windows.Forms.Button();
            this.BrowseFilepathButton = new System.Windows.Forms.Button();
            this.ProfileLinkLabel = new System.Windows.Forms.Label();
            this.BaseFormingGroupBox = new System.Windows.Forms.GroupBox();
            this.BaseFilepathTextBox = new System.Windows.Forms.TextBox();
            this.BaseFilepath = new System.Windows.Forms.Label();
            this.ProfileLinkTextBox = new System.Windows.Forms.TextBox();
            this.StopWordsTextBox = new System.Windows.Forms.TextBox();
            this.StopWordsLabel = new System.Windows.Forms.Label();
            this.SaveBaseDialog = new System.Windows.Forms.SaveFileDialog();
            this.BaseFilteringGroupBox = new System.Windows.Forms.GroupBox();
            this.AvatarMustBeCheckBox = new System.Windows.Forms.CheckBox();
            this.BaseFilepathAfterFilteringLabel = new System.Windows.Forms.Label();
            this.BaseFilepathAfterFilteringTextBox = new System.Windows.Forms.TextBox();
            this.BaseFilepathAfterFilteringSetButton = new System.Windows.Forms.Button();
            this.FilteringBegingButton = new System.Windows.Forms.Button();
            this.BaseFilepathLabel = new System.Windows.Forms.Label();
            this.BaseFilterFilepathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseBaseToFilteringButton = new System.Windows.Forms.Button();
            this.WorkWithBaseGroupBox = new System.Windows.Forms.GroupBox();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.OpenBaseDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.BaseToWorkFilepathTextBox = new System.Windows.Forms.TextBox();
            this.BaseToWorkFilepathBrowseButton = new System.Windows.Forms.Button();
            this.WorkWithBaseStartButton = new System.Windows.Forms.Button();
            this.SubMinMax = new InstagramBot.MinMaxParameter();
            this.LikingMinMax = new InstagramBot.MinMaxParameter();
            this.PostsCount = new InstagramBot.MinMaxParameter();
            this.SubscriptionsCount = new InstagramBot.MinMaxParameter();
            this.FollowersCount = new InstagramBot.MinMaxParameter();
            this.BaseFormingGroupBox.SuspendLayout();
            this.BaseFilteringGroupBox.SuspendLayout();
            this.WorkWithBaseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartBaseFormingButton
            // 
            this.StartBaseFormingButton.Location = new System.Drawing.Point(7, 101);
            this.StartBaseFormingButton.Name = "StartBaseFormingButton";
            this.StartBaseFormingButton.Size = new System.Drawing.Size(321, 44);
            this.StartBaseFormingButton.TabIndex = 0;
            this.StartBaseFormingButton.Text = "Начать";
            this.StartBaseFormingButton.UseVisualStyleBackColor = true;
            this.StartBaseFormingButton.Click += new System.EventHandler(this.StartBaseFormingButton_Click);
            // 
            // BrowseFilepathButton
            // 
            this.BrowseFilepathButton.Location = new System.Drawing.Point(256, 75);
            this.BrowseFilepathButton.Name = "BrowseFilepathButton";
            this.BrowseFilepathButton.Size = new System.Drawing.Size(72, 23);
            this.BrowseFilepathButton.TabIndex = 1;
            this.BrowseFilepathButton.Text = "Обзор";
            this.BrowseFilepathButton.UseVisualStyleBackColor = true;
            this.BrowseFilepathButton.Click += new System.EventHandler(this.BrowseFilepathButton_Click);
            // 
            // ProfileLinkLabel
            // 
            this.ProfileLinkLabel.AutoSize = true;
            this.ProfileLinkLabel.Location = new System.Drawing.Point(105, 16);
            this.ProfileLinkLabel.Name = "ProfileLinkLabel";
            this.ProfileLinkLabel.Size = new System.Drawing.Size(108, 13);
            this.ProfileLinkLabel.TabIndex = 2;
            this.ProfileLinkLabel.Text = "Ссылка на профиль";
            // 
            // BaseFormingGroupBox
            // 
            this.BaseFormingGroupBox.Controls.Add(this.BaseFilepathTextBox);
            this.BaseFormingGroupBox.Controls.Add(this.BrowseFilepathButton);
            this.BaseFormingGroupBox.Controls.Add(this.BaseFilepath);
            this.BaseFormingGroupBox.Controls.Add(this.StartBaseFormingButton);
            this.BaseFormingGroupBox.Controls.Add(this.ProfileLinkTextBox);
            this.BaseFormingGroupBox.Controls.Add(this.ProfileLinkLabel);
            this.BaseFormingGroupBox.Location = new System.Drawing.Point(12, 9);
            this.BaseFormingGroupBox.Name = "BaseFormingGroupBox";
            this.BaseFormingGroupBox.Size = new System.Drawing.Size(334, 153);
            this.BaseFormingGroupBox.TabIndex = 3;
            this.BaseFormingGroupBox.TabStop = false;
            this.BaseFormingGroupBox.Text = "Сбор базы";
            // 
            // BaseFilepathTextBox
            // 
            this.BaseFilepathTextBox.Enabled = false;
            this.BaseFilepathTextBox.Location = new System.Drawing.Point(6, 75);
            this.BaseFilepathTextBox.Name = "BaseFilepathTextBox";
            this.BaseFilepathTextBox.Size = new System.Drawing.Size(241, 20);
            this.BaseFilepathTextBox.TabIndex = 7;
            // 
            // BaseFilepath
            // 
            this.BaseFilepath.AutoSize = true;
            this.BaseFilepath.Location = new System.Drawing.Point(101, 59);
            this.BaseFilepath.Name = "BaseFilepath";
            this.BaseFilepath.Size = new System.Drawing.Size(112, 13);
            this.BaseFilepath.TabIndex = 8;
            this.BaseFilepath.Text = "Куда сохранять базу";
            // 
            // ProfileLinkTextBox
            // 
            this.ProfileLinkTextBox.Location = new System.Drawing.Point(6, 36);
            this.ProfileLinkTextBox.Name = "ProfileLinkTextBox";
            this.ProfileLinkTextBox.Size = new System.Drawing.Size(321, 20);
            this.ProfileLinkTextBox.TabIndex = 0;
            this.ProfileLinkTextBox.Text = "https://www.instagram.com/blood_s_honey/";
            // 
            // StopWordsTextBox
            // 
            this.StopWordsTextBox.Location = new System.Drawing.Point(8, 261);
            this.StopWordsTextBox.Name = "StopWordsTextBox";
            this.StopWordsTextBox.Size = new System.Drawing.Size(315, 20);
            this.StopWordsTextBox.TabIndex = 5;
            // 
            // StopWordsLabel
            // 
            this.StopWordsLabel.AutoSize = true;
            this.StopWordsLabel.Location = new System.Drawing.Point(75, 245);
            this.StopWordsLabel.Name = "StopWordsLabel";
            this.StopWordsLabel.Size = new System.Drawing.Size(198, 13);
            this.StopWordsLabel.TabIndex = 6;
            this.StopWordsLabel.Text = "Стоп слова\\сочетания через запятую";
            // 
            // SaveBaseDialog
            // 
            this.SaveBaseDialog.Filter = "\".txt\"|*.txt";
            // 
            // BaseFilteringGroupBox
            // 
            this.BaseFilteringGroupBox.Controls.Add(this.AvatarMustBeCheckBox);
            this.BaseFilteringGroupBox.Controls.Add(this.PostsCount);
            this.BaseFilteringGroupBox.Controls.Add(this.SubscriptionsCount);
            this.BaseFilteringGroupBox.Controls.Add(this.BaseFilepathAfterFilteringLabel);
            this.BaseFilteringGroupBox.Controls.Add(this.BaseFilepathAfterFilteringTextBox);
            this.BaseFilteringGroupBox.Controls.Add(this.BaseFilepathAfterFilteringSetButton);
            this.BaseFilteringGroupBox.Controls.Add(this.FilteringBegingButton);
            this.BaseFilteringGroupBox.Controls.Add(this.BaseFilepathLabel);
            this.BaseFilteringGroupBox.Controls.Add(this.StopWordsTextBox);
            this.BaseFilteringGroupBox.Controls.Add(this.StopWordsLabel);
            this.BaseFilteringGroupBox.Controls.Add(this.FollowersCount);
            this.BaseFilteringGroupBox.Controls.Add(this.BaseFilterFilepathTextBox);
            this.BaseFilteringGroupBox.Controls.Add(this.BrowseBaseToFilteringButton);
            this.BaseFilteringGroupBox.Location = new System.Drawing.Point(12, 168);
            this.BaseFilteringGroupBox.Name = "BaseFilteringGroupBox";
            this.BaseFilteringGroupBox.Size = new System.Drawing.Size(334, 387);
            this.BaseFilteringGroupBox.TabIndex = 7;
            this.BaseFilteringGroupBox.TabStop = false;
            this.BaseFilteringGroupBox.Text = "Фильтрация базы";
            // 
            // AvatarMustBeCheckBox
            // 
            this.AvatarMustBeCheckBox.AutoSize = true;
            this.AvatarMustBeCheckBox.Location = new System.Drawing.Point(21, 225);
            this.AvatarMustBeCheckBox.Name = "AvatarMustBeCheckBox";
            this.AvatarMustBeCheckBox.Size = new System.Drawing.Size(124, 17);
            this.AvatarMustBeCheckBox.TabIndex = 16;
            this.AvatarMustBeCheckBox.Text = "Аватар обязателен";
            this.AvatarMustBeCheckBox.UseVisualStyleBackColor = true;
            // 
            // BaseFilepathAfterFilteringLabel
            // 
            this.BaseFilepathAfterFilteringLabel.AutoSize = true;
            this.BaseFilepathAfterFilteringLabel.Location = new System.Drawing.Point(101, 286);
            this.BaseFilepathAfterFilteringLabel.Name = "BaseFilepathAfterFilteringLabel";
            this.BaseFilepathAfterFilteringLabel.Size = new System.Drawing.Size(164, 13);
            this.BaseFilepathAfterFilteringLabel.TabIndex = 14;
            this.BaseFilepathAfterFilteringLabel.Text = "Путь к базе после фильтрации";
            // 
            // BaseFilepathAfterFilteringTextBox
            // 
            this.BaseFilepathAfterFilteringTextBox.Enabled = false;
            this.BaseFilepathAfterFilteringTextBox.Location = new System.Drawing.Point(8, 311);
            this.BaseFilepathAfterFilteringTextBox.Name = "BaseFilepathAfterFilteringTextBox";
            this.BaseFilepathAfterFilteringTextBox.Size = new System.Drawing.Size(241, 20);
            this.BaseFilepathAfterFilteringTextBox.TabIndex = 13;
            // 
            // BaseFilepathAfterFilteringSetButton
            // 
            this.BaseFilepathAfterFilteringSetButton.Location = new System.Drawing.Point(252, 308);
            this.BaseFilepathAfterFilteringSetButton.Name = "BaseFilepathAfterFilteringSetButton";
            this.BaseFilepathAfterFilteringSetButton.Size = new System.Drawing.Size(72, 23);
            this.BaseFilepathAfterFilteringSetButton.TabIndex = 12;
            this.BaseFilepathAfterFilteringSetButton.Text = "Обзор";
            this.BaseFilepathAfterFilteringSetButton.UseVisualStyleBackColor = true;
            this.BaseFilepathAfterFilteringSetButton.Click += new System.EventHandler(this.BaseFilepathAfterFilteringSetButton_Click);
            // 
            // FilteringBegingButton
            // 
            this.FilteringBegingButton.Location = new System.Drawing.Point(0, 337);
            this.FilteringBegingButton.Name = "FilteringBegingButton";
            this.FilteringBegingButton.Size = new System.Drawing.Size(321, 44);
            this.FilteringBegingButton.TabIndex = 11;
            this.FilteringBegingButton.Text = "Начать";
            this.FilteringBegingButton.UseVisualStyleBackColor = true;
            this.FilteringBegingButton.Click += new System.EventHandler(this.FilteringBegingButton_Click);
            // 
            // BaseFilepathLabel
            // 
            this.BaseFilepathLabel.AutoSize = true;
            this.BaseFilepathLabel.Location = new System.Drawing.Point(105, 16);
            this.BaseFilepathLabel.Name = "BaseFilepathLabel";
            this.BaseFilepathLabel.Size = new System.Drawing.Size(152, 13);
            this.BaseFilepathLabel.TabIndex = 10;
            this.BaseFilepathLabel.Text = "Путь к базе для фильтрации";
            // 
            // BaseFilterFilepathTextBox
            // 
            this.BaseFilterFilepathTextBox.Enabled = false;
            this.BaseFilterFilepathTextBox.Location = new System.Drawing.Point(12, 41);
            this.BaseFilterFilepathTextBox.Name = "BaseFilterFilepathTextBox";
            this.BaseFilterFilepathTextBox.Size = new System.Drawing.Size(241, 20);
            this.BaseFilterFilepathTextBox.TabIndex = 9;
            // 
            // BrowseBaseToFilteringButton
            // 
            this.BrowseBaseToFilteringButton.Location = new System.Drawing.Point(256, 38);
            this.BrowseBaseToFilteringButton.Name = "BrowseBaseToFilteringButton";
            this.BrowseBaseToFilteringButton.Size = new System.Drawing.Size(72, 23);
            this.BrowseBaseToFilteringButton.TabIndex = 8;
            this.BrowseBaseToFilteringButton.Text = "Обзор";
            this.BrowseBaseToFilteringButton.UseVisualStyleBackColor = true;
            this.BrowseBaseToFilteringButton.Click += new System.EventHandler(this.BrowseBaseToFiltering_Click);
            // 
            // WorkWithBaseGroupBox
            // 
            this.WorkWithBaseGroupBox.Controls.Add(this.WorkWithBaseStartButton);
            this.WorkWithBaseGroupBox.Controls.Add(this.SubMinMax);
            this.WorkWithBaseGroupBox.Controls.Add(this.LikingMinMax);
            this.WorkWithBaseGroupBox.Controls.Add(this.label1);
            this.WorkWithBaseGroupBox.Controls.Add(this.BaseToWorkFilepathTextBox);
            this.WorkWithBaseGroupBox.Controls.Add(this.BaseToWorkFilepathBrowseButton);
            this.WorkWithBaseGroupBox.Location = new System.Drawing.Point(352, 9);
            this.WorkWithBaseGroupBox.Name = "WorkWithBaseGroupBox";
            this.WorkWithBaseGroupBox.Size = new System.Drawing.Size(332, 236);
            this.WorkWithBaseGroupBox.TabIndex = 8;
            this.WorkWithBaseGroupBox.TabStop = false;
            this.WorkWithBaseGroupBox.Text = "Работа с базой";
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(355, 545);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(59, 13);
            this.ProgressLabel.TabIndex = 15;
            this.ProgressLabel.Text = "Прогресс:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(355, 521);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(44, 13);
            this.StatusLabel.TabIndex = 16;
            this.StatusLabel.Text = "Статус:";
            // 
            // OpenBaseDialog
            // 
            this.OpenBaseDialog.FileName = "OpenBaseDialog";
            this.OpenBaseDialog.Filter = "\".txt\"|*.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Путь к базе";
            // 
            // BaseToWorkFilepathTextBox
            // 
            this.BaseToWorkFilepathTextBox.Enabled = false;
            this.BaseToWorkFilepathTextBox.Location = new System.Drawing.Point(6, 156);
            this.BaseToWorkFilepathTextBox.Name = "BaseToWorkFilepathTextBox";
            this.BaseToWorkFilepathTextBox.Size = new System.Drawing.Size(248, 20);
            this.BaseToWorkFilepathTextBox.TabIndex = 12;
            // 
            // BaseToWorkFilepathBrowseButton
            // 
            this.BaseToWorkFilepathBrowseButton.Location = new System.Drawing.Point(261, 153);
            this.BaseToWorkFilepathBrowseButton.Name = "BaseToWorkFilepathBrowseButton";
            this.BaseToWorkFilepathBrowseButton.Size = new System.Drawing.Size(63, 23);
            this.BaseToWorkFilepathBrowseButton.TabIndex = 11;
            this.BaseToWorkFilepathBrowseButton.Text = "Обзор";
            this.BaseToWorkFilepathBrowseButton.UseVisualStyleBackColor = true;
            this.BaseToWorkFilepathBrowseButton.Click += new System.EventHandler(this.BaseToWorkFilepathBrowseButton_Click);
            // 
            // WorkWithBaseStartButton
            // 
            this.WorkWithBaseStartButton.Location = new System.Drawing.Point(6, 182);
            this.WorkWithBaseStartButton.Name = "WorkWithBaseStartButton";
            this.WorkWithBaseStartButton.Size = new System.Drawing.Size(321, 44);
            this.WorkWithBaseStartButton.TabIndex = 16;
            this.WorkWithBaseStartButton.Text = "Начать";
            this.WorkWithBaseStartButton.UseVisualStyleBackColor = true;
            this.WorkWithBaseStartButton.Click += new System.EventHandler(this.WorkWithBaseStartButton_Click);
            // 
            // SubMinMax
            // 
            this.SubMinMax.IsEnabled = false;
            this.SubMinMax.Location = new System.Drawing.Point(3, 86);
            this.SubMinMax.MaxValue = 36;
            this.SubMinMax.MinValue = 28;
            this.SubMinMax.Name = "SubMinMax";
            this.SubMinMax.Size = new System.Drawing.Size(320, 45);
            this.SubMinMax.TabIndex = 15;
            this.SubMinMax.TitleText = "Подписка (сек между подписками)";
            // 
            // LikingMinMax
            // 
            this.LikingMinMax.IsEnabled = false;
            this.LikingMinMax.Location = new System.Drawing.Point(4, 24);
            this.LikingMinMax.MaxValue = 36;
            this.LikingMinMax.MinValue = 28;
            this.LikingMinMax.Name = "LikingMinMax";
            this.LikingMinMax.Size = new System.Drawing.Size(320, 45);
            this.LikingMinMax.TabIndex = 14;
            this.LikingMinMax.TitleText = "Лайкинг (сек между лайками)";
            // 
            // PostsCount
            // 
            this.PostsCount.IsEnabled = false;
            this.PostsCount.Location = new System.Drawing.Point(8, 169);
            this.PostsCount.MaxValue = 500;
            this.PostsCount.MinValue = 5;
            this.PostsCount.Name = "PostsCount";
            this.PostsCount.Size = new System.Drawing.Size(320, 45);
            this.PostsCount.TabIndex = 4;
            this.PostsCount.TitleText = "Кол-во постов";
            // 
            // SubscriptionsCount
            // 
            this.SubscriptionsCount.IsEnabled = false;
            this.SubscriptionsCount.Location = new System.Drawing.Point(9, 118);
            this.SubscriptionsCount.MaxValue = 1000;
            this.SubscriptionsCount.MinValue = 10;
            this.SubscriptionsCount.Name = "SubscriptionsCount";
            this.SubscriptionsCount.Size = new System.Drawing.Size(320, 45);
            this.SubscriptionsCount.TabIndex = 15;
            this.SubscriptionsCount.TitleText = "Кол-во подписок";
            // 
            // FollowersCount
            // 
            this.FollowersCount.IsEnabled = false;
            this.FollowersCount.Location = new System.Drawing.Point(8, 67);
            this.FollowersCount.MaxValue = 1000000;
            this.FollowersCount.MinValue = 5;
            this.FollowersCount.Name = "FollowersCount";
            this.FollowersCount.Size = new System.Drawing.Size(320, 45);
            this.FollowersCount.TabIndex = 3;
            this.FollowersCount.TitleText = "Кол-во подписчиков";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 567);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.WorkWithBaseGroupBox);
            this.Controls.Add(this.BaseFilteringGroupBox);
            this.Controls.Add(this.BaseFormingGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.BaseFormingGroupBox.ResumeLayout(false);
            this.BaseFormingGroupBox.PerformLayout();
            this.BaseFilteringGroupBox.ResumeLayout(false);
            this.BaseFilteringGroupBox.PerformLayout();
            this.WorkWithBaseGroupBox.ResumeLayout(false);
            this.WorkWithBaseGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartBaseFormingButton;
        private System.Windows.Forms.Button BrowseFilepathButton;
        private System.Windows.Forms.Label ProfileLinkLabel;
        private System.Windows.Forms.GroupBox BaseFormingGroupBox;
        private System.Windows.Forms.TextBox ProfileLinkTextBox;
        private MinMaxParameter FollowersCount;
        private System.Windows.Forms.TextBox BaseFilepathTextBox;
        private System.Windows.Forms.Label BaseFilepath;
        private System.Windows.Forms.TextBox StopWordsTextBox;
        private System.Windows.Forms.Label StopWordsLabel;
        private MinMaxParameter PostsCount;
        private System.Windows.Forms.SaveFileDialog SaveBaseDialog;
        private System.Windows.Forms.GroupBox BaseFilteringGroupBox;
        private System.Windows.Forms.Label BaseFilepathLabel;
        private System.Windows.Forms.TextBox BaseFilterFilepathTextBox;
        private System.Windows.Forms.Button BrowseBaseToFilteringButton;
        private System.Windows.Forms.Label BaseFilepathAfterFilteringLabel;
        private System.Windows.Forms.TextBox BaseFilepathAfterFilteringTextBox;
        private System.Windows.Forms.Button BaseFilepathAfterFilteringSetButton;
        private System.Windows.Forms.Button FilteringBegingButton;
        private System.Windows.Forms.GroupBox WorkWithBaseGroupBox;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Label StatusLabel;
        private MinMaxParameter SubscriptionsCount;
        private System.Windows.Forms.CheckBox AvatarMustBeCheckBox;
        private System.Windows.Forms.OpenFileDialog OpenBaseDialog;
        private MinMaxParameter SubMinMax;
        private MinMaxParameter LikingMinMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BaseToWorkFilepathTextBox;
        private System.Windows.Forms.Button BaseToWorkFilepathBrowseButton;
        private System.Windows.Forms.Button WorkWithBaseStartButton;
    }
}