using System;
using System.Collections.Generic;
using System.Text;

namespace InsagramApiByHands
{
    public class FiltersStatus
    {
        public bool FollowersCountFilter { get; set; }
        public bool SubscriptionsCountFilter { get; set; }
        public bool AvatarEnableFilter { get; set; }
        public bool PostsCountFilter { get; set; }
        public string StopWordsFilter { get; set; }
        public bool OneFilterEnabled()
        {
            return FollowersCountFilter || SubscriptionsCountFilter || AvatarEnableFilter || PostsCountFilter || !string.IsNullOrEmpty(StopWordsFilter);
        }
    }
}
