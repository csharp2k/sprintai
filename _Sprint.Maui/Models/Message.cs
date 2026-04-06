namespace Sprint.Maui.Models;

public class Message
{
    public string Id { get; set; }
    public string SenderId { get; set; }
    public string SenderName { get; set; }
    public string SenderAvatar { get; set; }
    public string ReceiverId { get; set; }
    public string Content { get; set; }
    public DateTime SentAt { get; set; }
    public bool IsRead { get; set; }
    public MessageType Type { get; set; }
}

public enum MessageType
{
    Text,
    Image,
    System
}

public class Conversation
{
    public string Id { get; set; }
    public string ParticipantId { get; set; }
    public string ParticipantName { get; set; }
    public string ParticipantAvatar { get; set; }
    public string LastMessage { get; set; }
    public DateTime LastMessageTime { get; set; }
    public int UnreadCount { get; set; }
    public bool IsOnline { get; set; }
}