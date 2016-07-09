using System;
using PagerDuty.Net.Enums;

namespace PagerDuty.Net {
    [Serializable()]
    public class IncidentFilter {
        public bool ReturnAll { get; set; }
        public DateTime since { get; set; }
        public DateTime until { get; set; }
        public string fields { get; set; }
        public Status status { get; set; }
        public string incident_key { get; set; }
        public string service { get; set; }
        public string assigned_to_user { get; set; }
    }
}
