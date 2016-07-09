using System;

namespace PagerDuty.Net {
    [Serializable()]
    public class TriggerSummaryData {
        public string client { get; set; }
        public string description { get; set; }
    }
}
