using Sprint.Maui.Models;

namespace Sprint.Maui.Services;

public interface IMessageService
{
    Task<List<Conversation>> GetConversationsAsync();
    Task<List<Message>> GetMessagesAsync(string conversationId);
    Task<bool> SendMessageAsync(string receiverId, string content);
    Task<int> GetUnreadCountAsync();
}

public class MessageService : IMessageService
{
    public async Task<List<Conversation>> GetConversationsAsync()
    {
        // TODO: Implement actual API call
        await Task.Delay(1000);

        return new List<Conversation>
        {
            new Conversation
            {
                Id = "1",
                ParticipantId = "2",
                ParticipantName = "Jane Smith",
                ParticipantAvatar = "avatar2.png",
                LastMessage = "Thanks for the update!",
                LastMessageTime = DateTime.Now.AddMinutes(-30),
                UnreadCount = 2,
                IsOnline = true
            },
            new Conversation
            {
                Id = "2",
                ParticipantId = "3",
                ParticipantName = "Bob Wilson",
                ParticipantAvatar = "avatar3.png",
                LastMessage = "See you tomorrow",
                LastMessageTime = DateTime.Now.AddHours(-2),
                UnreadCount = 0,
                IsOnline = false
            }
        };
    }

    public async Task<List<Message>> GetMessagesAsync(string conversationId)
    {
        // TODO: Implement actual API call
        await Task.Delay(500);

        return new List<Message>
        {
            new Message
            {
                Id = "1",
                SenderId = "2",
                SenderName = "Jane Smith",
                Content = "Hey, how's the project going?",
                SentAt = DateTime.Now.AddHours(-1),
                IsRead = true
            },
            new Message
            {
                Id = "2",
                SenderId = "1",
                SenderName = "You",
                Content = "Going well! Just finished the main features.",
                SentAt = DateTime.Now.AddMinutes(-45),
                IsRead = true
            },
            new Message
            {
                Id = "3",
                SenderId = "2",
                SenderName = "Jane Smith",
                Content = "Thanks for the update!",
                SentAt = DateTime.Now.AddMinutes(-30),
                IsRead = false
            }
        };
    }

    public async Task<bool> SendMessageAsync(string receiverId, string content)
    {
        // TODO: Implement actual API call
        await Task.Delay(500);
        return true;
    }

    public async Task<int> GetUnreadCountAsync()
    {
        var conversations = await GetConversationsAsync();
        return conversations.Sum(c => c.UnreadCount);
    }
}