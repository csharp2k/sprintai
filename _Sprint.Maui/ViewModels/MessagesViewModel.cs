using System.Collections.ObjectModel;
using Sprint.Maui.Models;
using Sprint.Maui.Services;
using CommunityToolkit.Mvvm.Input;

namespace Sprint.Maui.ViewModels;

public partial class MessagesViewModel : BaseViewModel
{
    private readonly IMessageService _messageService;
    private readonly INavigationService _navigationService;

    public ObservableCollection<Conversation> Conversations { get; } = new();

    public MessagesViewModel(IMessageService messageService, INavigationService navigationService)
    {
        _messageService = messageService;
        _navigationService = navigationService;
        Title = "Messages";
    }

    [RelayCommand]
    public async Task LoadConversationsAsync()
    {
        if (IsBusy) return;

        try
        {
            IsBusy = true;
            var conversations = await _messageService.GetConversationsAsync();
            Conversations.Clear();
            foreach (var conversation in conversations)
            {
                Conversations.Add(conversation);
            }
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
        }
        finally
        {
            IsBusy = false;
        }
    }

    [RelayCommand]
    public async Task OpenConversationAsync(Conversation conversation)
    {
        // TODO: Navigate to chat page
        await Shell.Current.DisplayAlert("Chat", $"Opening conversation with {conversation.ParticipantName}", "OK");
    }

    [RelayCommand]
    public async Task MarkAsReadAsync(Conversation conversation)
    {
        if (conversation.UnreadCount > 0)
        {
            conversation.UnreadCount = 0;
            // TODO: Call service to mark as read
        }
    }
}