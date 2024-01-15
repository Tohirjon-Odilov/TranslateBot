using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace _25_lesson_TelegramBot_Basic
{
    public partial class Basic
    {

        private async Task HandleTextMessageAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        private async Task HandleVideoMessageAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        private async Task HandleAudioMessageAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        private async Task HandleStickerMessageAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        private async Task HandlePhotoMessageAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        private async Task HandleContactMessageAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            ReplyKeyboardMarkup markup =
                    new ReplyKeyboardMarkup
                            (KeyboardButton.WithRequestContact("Telefon raqam yuborish"));
            markup.ResizeKeyboard = true;
            Message test = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: "Contact",
                    replyMarkup: markup
            );

        }

        private async Task HandleDocumentMessageAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        private async Task HandleLocationMessageAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        private async Task HandlePollMessageAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        private async Task HandleVoiceMessageAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        private async Task HandleMessagePinnedMessageAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        private async Task HandleUnknownMessageTypeAsync(Update update1, Update update2, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

    }
}
