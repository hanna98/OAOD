using MessageCodeExample.Services;
using static MessageCodeExample.Entities.Messages;

namespace MessageCodeExample;

public class Program
{
    static void Main(string[] args)
    {
        EmployedService employed = new EmployedService { Name = "AnställdNamn" };
        employed.ManageMSG();
    }
}
