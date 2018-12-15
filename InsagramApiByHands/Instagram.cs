using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace InsagramApiByHands
{
    public class Instagram : IDisposable
    {
        private bool isDisposed;
        private Random random;
        private IWebDriver webDriver;
        public Instagram()
        {
            InitializeWebDriverAsChromeDriver();
            isDisposed = false;
            random = new Random();
        }

        ~Instagram()
        {
            if(!isDisposed)
            {
                Dispose();
            }
        }
        public Instagram(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            isDisposed = false;
            random = new Random();
        }

        public void LoginAndDisableNotifications(string login, string password)
        {
            webDriver.Navigate().GoToUrl(@"https://www.instagram.com/accounts/login/?source=auth_switcher");
            IWebElement loginWebElement = webDriver.FindElement(By.Name("username"));
            loginWebElement.SendKeys(login);
            IWebElement passwordWebElement = webDriver.FindElement(By.Name("password"));
            passwordWebElement.SendKeys(password + OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(3000);
            DisableNotifications();
        }

        public int GetFollowersCount()
        {
            IWebElement followersCountElement;
            try
            {
                followersCountElement = webDriver.FindElement(By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(2) > a"));
            }
            catch
            {
                followersCountElement = webDriver.FindElement(By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(2) > span > span"));
            }
            return Parsers.ParseFollowersCount(followersCountElement.Text);
        }

        public bool GetAvatarEnable()//call on page of client
        {
            bool result = true;
            IWebElement avatar;
            try
            {
                avatar = webDriver.FindElement(By.CssSelector("#react-root > section > main > div > header > div > div > span > img"));
            }
            catch (Exception)
            {
                avatar = webDriver.FindElement(By.CssSelector("#react-root > section > main > div > header > div > div > div > button > img"));
            }
            if (avatar.GetAttribute("src").Contains("vp/a8539c22ed9fec8e1c43b538b1ebfd1d/5C5A1A7A/t51.2885-19/11906329_960233084022564_1448528159_a.jpg"))
            {
                result = false;
            }
            return result;
        }

        public int GetSubscriptionsCount()
        {
            IWebElement subscriptionsCountElement;
            try
            {
                subscriptionsCountElement = webDriver.FindElement(By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(3) > a > span"));
            }
            catch
            {
                subscriptionsCountElement = webDriver.FindElement(By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(3) > span > span"));
            }
            return Parsers.ParseFollowersCount(subscriptionsCountElement.Text);
        }

        public int GetPostsCount()
        {
            IWebElement postsCountElement = null;
            try
            {
                postsCountElement = webDriver.FindElement(By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(1) > span > span"));
            }
            catch
            {
                
            }
            return postsCountElement != null ? Parsers.ParseFollowersCount(postsCountElement.Text) : 0;
        }

        public void LikeTask()
        {
            IWebElement[] webElements = webDriver.FindElements(By.ClassName("eLAPa")).ToArray();
            int postForLike = random.Next(0, webElements.Length - 1);
            webElements[postForLike].Click();
            Thread.Sleep(2500);
            IWebElement heart = webDriver.FindElement(By.ClassName("fr66n"));
            heart.Click();
        }

        public void SubTask()
        {
            IJavaScriptExecutor jsExec = (IJavaScriptExecutor)webDriver;
            jsExec.ExecuteScript("var t = document.querySelector('._5f5mN.jIbKX._6VtSN.yZn4P');t.click();");
        }

        public void RunTasks(string filepath, List<InstaTask> instaTasks)
        {
            foreach (string follower in Parsers.ReadListOfStringFromFile(filepath))
            {
                webDriver.Navigate().GoToUrl(@"https://www.instagram.com/" + follower);
                string pageHTML = webDriver.PageSource;
                if (pageHTML.Contains("Страница не найдена") || pageHTML.Contains("Sorry, this page isn't available.") || pageHTML.Contains("Контент недоступен"))
                {
                    continue;
                }
                else
                {
                    foreach (InstaTask task in instaTasks)
                    {
                        switch (task.TaskTypeObject)
                        {
                            case TaskType.Liking:
                                LikeTask();
                                webDriver.Navigate().GoToUrl(@"https://www.instagram.com/" + follower);
                                break;
                            case TaskType.Subscribing:
                                SubTask();
                                break;
                            default:
                                break;
                        }
                        Thread.Sleep(1000 * random.Next(task.MinTimeBetweenIterations, task.MaxTimeBetweenIterations));

                    }
                }
            }

        }

        public void HideWebDriverWindow()
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Window.Position = new Point(Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height);
        }

        private void InitializeWebDriverAsChromeDriver()
        {
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            webDriver = new ChromeDriver(chromeDriverService, new ChromeOptions());
        }

        private void DisableNotifications()
        {
            IWebElement notificationsOff;
            try
            {
                notificationsOff = webDriver.FindElement(By.CssSelector("body > div:nth-child(15) > div > div > div > div.mt3GC > button.aOOlW.HoLwm"));
                notificationsOff.Click();
            }
            catch (Exception)
            {

            }
        }

        private void FrameScrollByCount(Label progressLabel,string frameClassName, string itemClassName, int elementsCount)
        {
            IJavaScriptExecutor jsExec = (IJavaScriptExecutor)webDriver;
            int itemsCount = webDriver.FindElements(By.ClassName(itemClassName)).Count;
            int triesCount = 0;
            while (itemsCount != elementsCount)
            {
                try
                {
                    progressLabel.Invoke((MethodInvoker)delegate ()
                    {
                        float progressValue = (float)itemsCount * 100 / elementsCount;
                        progressLabel.Text = "Прогресс:"
                        + Math.Round(progressValue, 2)
                        + "%";
                        if (progressValue >= 100)
                        {
                            triesCount = 49;
                        }
                    });
                    int newItemsCount;
                    jsExec.ExecuteScript("var t=document.querySelector('." + frameClassName + "');t.scrollIntoView(false);");
                    Thread.Sleep(50);
                    newItemsCount = webDriver.FindElements(By.ClassName(itemClassName)).Count;
                    if (newItemsCount != itemsCount)
                    {
                        itemsCount = newItemsCount;
                        triesCount = 0;
                    }
                    else
                    {
                        if (++triesCount == 50)
                        {
                            break;
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private List<string> WebElementsToStrings(List<IWebElement> webElements)
        {
            List<string> stringList = new List<string>();
            foreach (var webElement in webElements)
            {
                stringList.Add(webElement.Text);
            }
            return stringList;
        }

        private FollowerState GetFollowerState(string followerNickname, ref FiltersStatus filtersStatus)
        {
            webDriver.Navigate().GoToUrl(@"https://www.instagram.com/" + followerNickname);
            string pageHTML = webDriver.PageSource;
            if (pageHTML.Contains("Страница не найдена") || pageHTML.Contains("Sorry, this page isn't available.") || pageHTML.Contains("Контент недоступен"))
            {
                return new FollowerState()
                {
                    LeaveInList = false
                };
            }
            else
            {
                IWebElement description;
                try
                {
                    description = webDriver.FindElement(By.ClassName("-vDIg"));
                    foreach (string stopWord in filtersStatus.StopWordsFilter.Split(','))
                    {
                        if (description.Text.Contains(stopWord))
                        {
                            return new FollowerState()
                            {
                                LeaveInList = false
                            };
                        }
                    }

                }
                catch
                {
                }
            }
            return new FollowerState
            {
                FollowerObject = new Follower
                {
                    AvatarEnable = filtersStatus.AvatarEnableFilter ? GetAvatarEnable() : true,
                    FollowersCount = filtersStatus.FollowersCountFilter ? GetFollowersCount() : 0,
                    Nickname = followerNickname,
                    PostsCount = filtersStatus.PostsCountFilter ? GetPostsCount() : 0,
                    SubscriptionsCount = filtersStatus.SubscriptionsCountFilter ? GetSubscriptionsCount() : 0
                },
                LeaveInList = true
            };
        }

        private void FilteringProccess(ref FiltersStatus filtersStatus, 
            string baseToFilterFilepath,string baseFilepathAfterFiltering,
            int? followersMinCount,int? followersMaxCount, 
            int? postsMinCount, int? postsMaxCount, 
            int? subscriptionsMinCount, int? subscriptionsMaxCount)
        {
            StreamWriter streamWriter = new StreamWriter("temp.txt");
            //сообщить о получении базы
            List<FollowerState> followersList = new List<FollowerState>();
            foreach (var followerNickname in Parsers.ReadListOfStringFromFile(baseToFilterFilepath))
            {
                if (!string.IsNullOrEmpty(followerNickname))
                {
                    FollowerState followerState = GetFollowerState(followerNickname, ref filtersStatus);
                    followersList.Add(followerState);
                    if (!followerState.LeaveInList)
                    {
                        streamWriter.WriteLine(followerNickname + "\t\tEmpty page\n");
                    }
                }

            }
            followersList = (from follower in followersList where follower.LeaveInList select follower).ToList();//removing empty links
            if (filtersStatus.AvatarEnableFilter)
            {
                foreach (var followerState in followersList)
                {
                    Filters.AvatarFilter(followerState);
                }
                foreach (var followerNickname in (from follower in followersList where !follower.LeaveInList select follower.FollowerObject.Nickname).ToList())
                {
                    streamWriter.WriteLine(followerNickname + "\t\tNo avatar\n");
                }
                followersList = (from follower in followersList where follower.LeaveInList select follower).ToList();
            }
            if (filtersStatus.FollowersCountFilter)
            {
                foreach (var followerState in followersList)
                {
                    Filters.FollowersCountFilter(followerState, 
                        followersMinCount??0, followersMaxCount??100000);
                }
                foreach (var followerNickname in (from follower in followersList where !follower.LeaveInList select follower.FollowerObject.Nickname).ToList())
                {
                    streamWriter.WriteLine(followerNickname + "\t\tFollowers count\n");
                }
                followersList = (from follower in followersList where follower.LeaveInList select follower).ToList();
            }
            if (filtersStatus.PostsCountFilter)
            {
                foreach (var followerState in followersList)
                {
                    Filters.PostsCountFilter(followerState, postsMinCount??0, postsMaxCount??100000);
                }
                foreach (var followerNickname in (from follower in followersList where !follower.LeaveInList select follower.FollowerObject.Nickname).ToList())
                {
                    streamWriter.WriteLine(followerNickname + "\t\tPosts count\n");
                }
                followersList = (from follower in followersList where follower.LeaveInList select follower).ToList();
            }
            if (filtersStatus.SubscriptionsCountFilter)
            {
                foreach (var followerState in followersList)
                {
                    Filters.SubscriptionsCountFilter(followerState, subscriptionsMinCount ?? 0, subscriptionsMaxCount ?? 100000);
                }
                foreach (var followerNickname in (from follower in followersList where !follower.LeaveInList select follower.FollowerObject.Nickname).ToList())
                {
                    streamWriter.WriteLine(followerNickname + "\t\tSubscriptopns count\n");
                }
                followersList = (from follower in followersList where follower.LeaveInList select follower).ToList();
            }
            streamWriter.Close();
            List<string> followers = (from folwer in followersList select folwer.FollowerObject.Nickname).ToList();//ответ на один из методов выше
            Parsers.WriteListOfStringToFile(followers, baseFilepathAfterFiltering);
        }

        public void BaseFormingProccess(Label progressLabel, string profileLink, string baseFilepath)
        {
            ////UI
            progressLabel.Invoke((MethodInvoker)delegate ()
            {
                progressLabel.Text = "Статус:Сбор базы";
            });
            webDriver.Navigate().GoToUrl(profileLink);//идём в профиль
            IWebElement followersButton = webDriver.FindElement//кнопка "подписчики"
                (By.CssSelector("#react-root > section > main > div > header > section > ul > li:nth-child(2) > a"));
            followersButton.Click();//открываем окно подписчиков
            Thread.Sleep(500);//ждём открытия окна

            FrameScrollByCount(progressLabel,"PZuss", "d7ByH", Parsers.ParseFollowersCount(followersButton.Text));
            progressLabel.Invoke((MethodInvoker)delegate ()
            {
                progressLabel.Text = "Статус:Запись базы в файл";
            });
            List<IWebElement> followersWebElementsList = webDriver.FindElements(By.ClassName("d7ByH")).ToList();
            List<string> followersList = WebElementsToStrings(followersWebElementsList);
            Parsers.WriteListOfStringToFile(followersList, baseFilepath);
            MessageBox.Show("База сформирована!");
            progressLabel.Invoke((MethodInvoker)delegate ()
            {
                progressLabel.Text = "Статус:Задача выполнена!";
            });
            ////UI
        }

        public void Dispose()
        {
            isDisposed = true;
            if (webDriver != null)
            {
                try
                {
                    webDriver.Close();
                }
                catch
                {

                }
            }
        }
    }
}
