namespace IdentityChatProje.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public string SenderEmail { get; set; }
        public string ReceiverMessage { get; set; }
        public string Subjet { get; set; }
        public string MessageDetail { get; set; }
        public bool IsRead { get; set; }
        public DateTime SendDate { get; set; }
    }
}
