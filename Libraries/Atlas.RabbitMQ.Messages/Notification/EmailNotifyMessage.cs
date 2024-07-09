using System;
using System.Collections.Generic;
using System.IO;
using Priority = Atlas.Enumerators.Notification;


namespace Atlas.RabbitMQ.Messages.Notification
{
    [Serializable]
    public class EmailNotifyMessage : IMessage
    {
        public EmailNotifyMessage(Guid correlationId)
        {
            CorrelationId = correlationId;
            CreatedAt = DateTime.UtcNow;
        }

        public Guid CorrelationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? MessageId { get; set; }


        /* Message */
        public string From { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsHTML { get; set; }
        public List<Tuple<string, string, string>> Attachments { get; set; }
        public Priority.NotificationPriority Priority { get; set; }
        public Priority.NotificationTemplate NotificationType { get; set; }
        public DateTime ActionDate { get; set; }

        /* Meta data */
        public string MailMedia { get; set; }
        public byte[] fStream { get; set; }
        public long BulkId { get; set; }
        public bool IntermediateReport { get; set; }
        public long ApplicationId { get; set; }
        public string docType { get; set; }

    }
}
