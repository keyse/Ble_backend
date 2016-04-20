using System;

namespace DomainModels
{
    public class Transfere
    {
        public int Id { get; set; }
        public decimal SendAmount { get; set; }

        public string SenderName { get; set; }

        public string ReceiverName { get; set; }

        public string ReceiverDestination { get; set; }

        public string ReceiverPassCode { get; set; }
        public DateTime SendDate { get; set; }
    }
}
