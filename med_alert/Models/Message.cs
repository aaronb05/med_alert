﻿namespace med_alert.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Read { get; set; }
        public string SenderId { get; set; }
        public string RecipientId { get; set; }


        public virtual ApplicationUser Recipient { get; set; }
        public virtual ApplicationUser Sender { get; set; }

    }
}
