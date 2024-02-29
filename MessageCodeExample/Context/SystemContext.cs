using MessageCodeExample.Entities;

namespace MessageCodeExample.Context;

public class SystemContext
{
    private readonly MessageDBContext _messageDB = new();

    public void WriteAndSaveMSG(string msgcontent, string sender, string receiver)
    {
        // Skapa ett nytt meddelande objekt
        var message = new Messages
        {
            MSGContent = msgcontent,
            Sender = sender,
            SentDate = DateTime.Now
        };

        // Spara meddelandet i databasen
        _messageDB.SaveMessage(message);
    }

    public List<Messages> GetAndShowMSG()
    {
        // Hämta alla meddelanden från databasen och returnera dom
        return _messageDB.GetMessage();
    }

}



