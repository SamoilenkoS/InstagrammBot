using System;
using System.Collections.Generic;
using System.Text;

namespace InsagramApiByHands
{
    public static class Filters
    {
        public static void AvatarFilter(FollowerState followerState)
        {
            followerState.LeaveInList = followerState.FollowerObject.AvatarEnable;
        }

        public static void FollowersCountFilter(FollowerState followerState, uint? minValue, uint? maxValue)
        {
            followerState.LeaveInList = 
                (followerState.FollowerObject.FollowersCount >= minValue) && 
                (followerState.FollowerObject.FollowersCount <= maxValue);
        }

        public static void PostsCountFilter(FollowerState followerState, uint? minValue, uint? maxValue)
        {
            followerState.LeaveInList =
                 (followerState.FollowerObject.PostsCount >= minValue) &&
                 (followerState.FollowerObject.PostsCount <= maxValue);
        }

        public static void SubscriptionsCountFilter(FollowerState followerState, uint? minValue, uint? maxValue)
        {
            followerState.LeaveInList =
                 (followerState.FollowerObject.SubscriptionsCount >= minValue) &&
                 (followerState.FollowerObject.SubscriptionsCount <= maxValue);
        }
    }
}
