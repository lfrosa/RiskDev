using System.Globalization;
using RiskDev.Models;
namespace RiskDev.Services;

public class Start
{

    private DateTime dateReference = new();
    private int operationsNumber = 0;
    private List<Trade> trades = [];

    public void Run()
    {
        GetReferenceDate();
        GetAmount();
        GetLines();
        Submit();

    }

    public void GetLines()
    {
        for (int x = 0; x < operationsNumber; x++)
        {
            var enteredOperation = Console.ReadLine()?.Split(" ") ?? [];

            if (enteredOperation.Length < 3)
            {
                Console.WriteLine("Operação inválida, tente novamente");
                x--;
                continue;
            }

            double resultValue = 0;
            DateTime resultDate = new();

            double.TryParse(enteredOperation[0], out resultValue);
            DateTime.TryParseExact(enteredOperation[2], "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out resultDate);

            string[] posibilities = { "private", "public" };

            if (!posibilities.Contains(enteredOperation[1].ToLower()))
            {
                Console.WriteLine("Setor inválido, tente novamente");
                x--;
                continue;
            }


            trades.Add(new Trade(resultValue, enteredOperation[1], resultDate));
        }
    }


    public void Submit()
    {
        var service = new RiskCategorizationService();

        foreach (var trade in trades)
        {
            var riskCategory = service.Evaluate(trade, dateReference);

            Console.WriteLine(Enum.GetName(riskCategory)?.ToUpper() ?? "ERRO");
        }

    }

    private void GetReferenceDate()
    {
        Console.WriteLine("Entre com uma data de referência:");
        string? enteredDate = Console.ReadLine();

        while (!DateTime.TryParseExact(enteredDate, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateReference))
        {
            Console.WriteLine("Entre com uma data de referência válida:");
            enteredDate = Console.ReadLine();
        }
    }

    private void GetAmount()
    {
        Console.WriteLine("Entre com a quantidade de operações:");
        string? operactionsCont = Console.ReadLine();

        while (!Int32.TryParse(operactionsCont, out operationsNumber))
        {
            Console.WriteLine("Entre com a quantidade de operações válida (inteiro):");
            operactionsCont = Console.ReadLine();
        }
    }


}
