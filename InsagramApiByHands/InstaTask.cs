using System;
using System.Collections.Generic;
using System.Text;

namespace InsagramApiByHands
{
    public enum TaskType { Liking, Subscribing}
    public class InstaTask
    {
        public TaskType TaskTypeObject { get; set; }
        public int MinTimeBetweenIterations { get; set; }
        public int MaxTimeBetweenIterations { get; set; }
    }
}
