using MessageCodeExample.Entities;

namespace MessageCodeExample.Context;

public class MessageDBContext
{
    private List<Messages> _messages = [];

    public void SaveMessage(Messages message)
    {
        // Spara meddelandet i databasen
        _messages.Add(message);
    }

    public List<Messages> GetMessage()
    {
        // Hämta alla meddelanden från databasen
        return _messages;
    }

    // Implementera övriga metoder för att hantera meddelanden i databasen
}



