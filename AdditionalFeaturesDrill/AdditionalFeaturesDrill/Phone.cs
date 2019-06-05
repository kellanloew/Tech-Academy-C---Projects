using System;

namespace AdditionalFeaturesDrill
{
    public class Phone
    {
        public Phone(string os, string net) : this(os, net, "Black") { }
        public Phone(string os, string net, string phoneColor)
        {
            OS = os;
            network = net;
            color = phoneColor;
        }
        public string OS { get; set; }
        public string network { get; set; }
        public string color { get; set; }
    }
}
