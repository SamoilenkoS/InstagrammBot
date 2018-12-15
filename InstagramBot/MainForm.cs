using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsagramApiByHands;
using OpenQA.Selenium;

/// <summary>
/// TODO
/// 1) Debug Closing when browser closed            +
/// 2) Thread for second task                       +
/// 3) Debug info 
/// 4) Count of User filter using                   +
/// 5) Count of post filter using                   +
/// 6) try/catch for every iwebdriver call
/// 7) Check of link which user input
/// 8) Open dialog for source base                  +
/// 9) Liking option                                +
/// 10) Subscribe option                            +
/// 11) All str identifiers move to config file
/// 12) Try without ref (Filtering base)
/// 13) Page not found catch
/// 14) Analize of forbidden words GetFollowerState +
/// 15) When Navigate add check for not found page
/// </summary>
namespace InstagramBot
{

    public partial class MainForm : Form
    {
        private Instagram instagram;
        public MainForm(Instagram instagram)
        {
            InitializeComponent();
            this.instagram = instagram;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            instagram.Dispose();
        }

        #region Browse buttons
        private void SetFilepath(TextBox textBox)
        {
            if (SaveBaseDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = SaveBaseDialog.FileName;
            }
        }

        private void BrowseFilepathButton_Click(object sender, EventArgs e)
        {
            SetFilepath(BaseFilepathTextBox);
        }

        private void BrowseBaseToFiltering_Click(object sender, EventArgs e)
        {
            if (OpenBaseDialog.ShowDialog() == DialogResult.OK)
            {
                BaseFilterFilepathTextBox.Text = OpenBaseDialog.FileName;
            }
        }

        private void BaseFilepathAfterFilteringSetButton_Click(object sender, EventArgs e)
        {
            SetFilepath(BaseFilepathAfterFilteringTextBox);
        }

        #endregion



        #region Functional

        private void BaseFormingProccess()
        {
            SetButtonsEnableStatus(false);
            instagram.BaseFormingProccess(ProgressLabel, ProfileLinkTextBox.Text, BaseFilepath.Text);
            SetButtonsEnableStatus(true);
        }

        private void StartBaseFormingButton_Click(object sender, EventArgs e)
        {
            if (BaseFilepathTextBox.Text != string.Empty && ProfileLinkTextBox.Text != string.Empty)
            {
                Thread baseFormingThread = new Thread(BaseFormingProccess);
                baseFormingThread.Start();
            }
            else
            {
                MessageBox.Show("Поля ссылки на профиль и пути к базе должны быть заполнены!", "Внимание!");
            }
        }
        
        private FiltersStatus GetFiltersStatus()
        {
            return new FiltersStatus
            {
                AvatarEnableFilter = AvatarMustBeCheckBox.Checked,
                FollowersCountFilter = FollowersCount.IsEnabled,
                PostsCountFilter = PostsCount.IsEnabled,
                StopWordsFilter = StopWordsTextBox.Text,
                SubscriptionsCountFilter = SubscriptionsCount.IsEnabled
            };
        }

        private void FilteringBegingButton_Click(object sender, EventArgs e)
        {
            if (BaseFilterFilepathTextBox.Text != string.Empty && BaseFilepathAfterFilteringTextBox.Text != string.Empty)
            {
                FiltersStatus filtersStatus = GetFiltersStatus();
                if(filtersStatus.OneFilterEnabled())
                {
                    Thread filteringThread = new Thread(() => FilteringProccess(ref filtersStatus));
                    filteringThread.Start();
                    return;
                }
            }
            MessageBox.Show("Поля пути к базе до и после фильтрации должны быть заполнены, также должен быть выбран хотя бы 1 фильтр","Внимание!");
        }

        #endregion


        private void SetButtonsEnableStatus(bool status)
        {
            WorkWithBaseStartButton.Invoke((MethodInvoker)delegate ()
            {
                WorkWithBaseStartButton.Enabled = status;
            });
            FilteringBegingButton.Invoke((MethodInvoker)delegate () 
            {
                FilteringBegingButton.Enabled = status;
            });
            StartBaseFormingButton.Invoke((MethodInvoker)delegate ()
            {
                StartBaseFormingButton.Enabled = status;
            });

        }
        private void WorkWithBaseProccess()
        {
            SetButtonsEnableStatus(false);
            List<InstaTask> instaTasks = new List<InstaTask>();
            if(LikingMinMax.IsEnabled)
            {
                instaTasks.Add(new InstaTask()
                {
                    TaskTypeObject = TaskType.Liking,
                    MinTimeBetweenIterations = LikingMinMax.MinValue,
                    MaxTimeBetweenIterations = LikingMinMax.MaxValue
                });
            }
            if(SubMinMax.IsEnabled)
            {
                instaTasks.Add(new InstaTask()
                {
                    TaskTypeObject = TaskType.Subscribing,
                    MinTimeBetweenIterations = SubMinMax.MinValue,
                    MaxTimeBetweenIterations = SubMinMax.MaxValue
                });
            }
            instagram.RunTasks(BaseToWorkFilepathTextBox.Text, instaTasks);
            SetButtonsEnableStatus(true);
        }
        private void WorkWithBaseStartButton_Click(object sender, EventArgs e)
        {
            Thread workThread = new Thread(WorkWithBaseProccess);
            workThread.Start();
        }



        private void BaseToWorkFilepathBrowseButton_Click(object sender, EventArgs e)
        {
            if (OpenBaseDialog.ShowDialog() == DialogResult.OK)
            {
                BaseToWorkFilepathTextBox.Text = OpenBaseDialog.FileName;
            }
        }
    }
}
