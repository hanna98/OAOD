using MessageCodeExample.Context;

namespace MessageCodeExample.Services;

public class EmployedService
{
    public string Name { get; set; } = null!;

    public void ManageMSG()
    {
        SystemContext system = new();

        // Skriv och spara ett meddelande
        system.WriteAndSaveMSG("Hej!", Name, "Mottagare");

        // Hämta och visa meddelanden
        var messages = system.GetAndShowMSG();
        foreach (var message in messages)
        {
            Console.WriteLine($"Från: {message.Sender}, Innehåll: {message.MSGContent}");
        }

        // Implementera övriga meddelandehantering för den anställda
    }
}



