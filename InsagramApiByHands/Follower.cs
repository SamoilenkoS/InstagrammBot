using System;

namespace InsagramApiByHands
{
    public class Follower
    {
        //public bool 
        public string Nickname { get; set; }
        public int? FollowersCount { get; set; }
        public int? SubscriptionsCount { get; set; }
        public int? PostsCount { get; set; }
        public bool AvatarEnable { get; set; }
    }
}
