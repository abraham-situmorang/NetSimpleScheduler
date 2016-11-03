using System;

namespace NetSimpleScheduler
{
    public class CustomerModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime ScheduleDate { get; set; }

        public bool IsSent { get; set; }
    }
}
