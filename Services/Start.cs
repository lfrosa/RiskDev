using System.Globalization;
using RiskDev.Models;
namespace RiskDev.Services;

public class Start : StartBase
{

    private DateTime? dateReference = new();
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
        Console.WriteLine($"Entre com o(s) {operationsNumber} registro(s) de operação:");
        
        for (int x = 0; x < operationsNumber; x++)
        {
            var enteredOperation = Console.ReadLine()?.Split(" ") ?? [];

            if (enteredOperation.Length < 3)
            {
                Console.WriteLine("Operação inválida, tente novamente");
                x--;
                continue;
            }

            double? resultValue = 0;
            DateTime? resultDate = new();

            if ((resultDate = StringToDate(enteredOperation[2])) is null)
            {
                Console.WriteLine("Data inválida, tente novamente");
                x--;
                continue;
            }

            if ((resultValue = StringToDouble(enteredOperation[0])) is null)
            {
                Console.WriteLine("Valor inválido, tente novamente");
                x--;
                continue;
            }

            if (!IsSectorValid(enteredOperation[1]))
            {
                Console.WriteLine("Setor inválido, tente novamente");
                x--;
                continue;
            }

            trades.Add(new Trade(resultValue.Value, enteredOperation[1], resultDate.Value));
        }
    }

    private bool IsSectorValid(string sector)
    {
        string[] posibilities = { "private", "public" };
        return posibilities.Contains(sector.ToLower());
    }


    public void Submit()
    {
        var service = new RiskCategorizationService();

        Console.WriteLine("Resultados:\n");


        foreach (var trade in trades)
        {
            var riskCategory = service.Evaluate(trade, dateReference!.Value);

            Console.WriteLine(Enum.GetName(riskCategory)?.ToUpper() ?? "ERRO");
        }
    }

    private void GetReferenceDate()
    {
        Console.WriteLine("Entre com uma data de referência:");
        string? enteredDate = Console.ReadLine();

        while ((dateReference = StringToDate(enteredDate ?? "")) is null)
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
