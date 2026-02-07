using System;
using System.Collections.Generic;
using System.Linq;

#region Entities

public class Transaction
{
    public string TransactionId { get; set; }
    public string CardNumber { get; set; }
    public decimal Amount { get; set; }
    public string City { get; set; }
    public DateTime Timestamp { get; set; }
}

public class FraudAlert
{
    public string CardNumber { get; set; }
    public string Reason { get; set; }
    public DateTime DetectedAt { get; set; }
}

#endregion

#region Fraud Detection Logic

public class FraudDetectionService
{
    public List<FraudAlert> DetectFraud(List<Transaction> txns)
    {
        List<FraudAlert> alerts = new List<FraudAlert>();

        // Group by card number
        var groupedByCard = txns
            .OrderBy(t => t.Timestamp)
            .GroupBy(t => t.CardNumber);

        foreach (var cardGroup in groupedByCard)
        {
            List<Transaction> cardTxns = cardGroup.ToList();

            // Apply fraud rules
            if (CheckHighValueBurst(cardTxns))
            {
                alerts.Add(new FraudAlert
                {
                    CardNumber = cardGroup.Key,
                    Reason = "3+ high-value transactions within 2 minutes",
                    DetectedAt = cardTxns.Last().Timestamp
                });
            }
            else if (CheckMultiCityUsage(cardTxns))
            {
                alerts.Add(new FraudAlert
                {
                    CardNumber = cardGroup.Key,
                    Reason = "Same card used in multiple cities within 10 minutes",
                    DetectedAt = cardTxns.Last().Timestamp
                });
            }
        }

        return alerts;
    }

    // RULE 1
    private bool CheckHighValueBurst(List<Transaction> txns)
    {
        Queue<Transaction> window = new Queue<Transaction>();

        foreach (var txn in txns)
        {
            if (txn.Amount > 50000)
                window.Enqueue(txn);

            // Sliding window of 2 minutes
            while (window.Count > 0 &&
                   txn.Timestamp - window.Peek().Timestamp >
                   TimeSpan.FromMinutes(2))
            {
                window.Dequeue();
            }

            if (window.Count >= 3)
                return true;
        }

        return false;
    }

    // RULE 2
    private bool CheckMultiCityUsage(List<Transaction> txns)
    {
        for (int i = 0; i < txns.Count; i++)
        {
            for (int j = i + 1; j < txns.Count; j++)
            {
                // Break if window exceeds 10 minutes
                if (txns[j].Timestamp - txns[i].Timestamp >
                    TimeSpan.FromMinutes(10))
                    break;

                if (!txns[i].City.Equals(txns[j].City,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
        }

        return false;
    }
}

#endregion

#region Program (Demo)

class Program
{
    static void Main()
    {
        List<Transaction> transactions = new List<Transaction>
        {
            new Transaction
            {
                TransactionId = "T1",
                CardNumber = "CARD100",
                Amount = 60000,
                City = "Delhi",
                Timestamp = DateTime.Now
            },
            new Transaction
            {
                TransactionId = "T2",
                CardNumber = "CARD100",
                Amount = 70000,
                City = "Delhi",
                Timestamp = DateTime.Now.AddSeconds(30)
            },
            new Transaction
            {
                TransactionId = "T3",
                CardNumber = "CARD100",
                Amount = 80000,
                City = "Delhi",
                Timestamp = DateTime.Now.AddSeconds(90)
            },
            new Transaction
            {
                TransactionId = "T4",
                CardNumber = "CARD200",
                Amount = 2000,
                City = "Mumbai",
                Timestamp = DateTime.Now
            },
            new Transaction
            {
                TransactionId = "T5",
                CardNumber = "CARD200",
                Amount = 3000,
                City = "Pune",
                Timestamp = DateTime.Now.AddMinutes(5)
            }
        };

        FraudDetectionService service = new FraudDetectionService();
        var alerts = service.DetectFraud(transactions);

        Console.WriteLine("FRAUD ALERTS:\n");
        foreach (var alert in alerts)
        {
            Console.WriteLine($"Card   : {alert.CardNumber}");
            Console.WriteLine($"Reason : {alert.Reason}");
            Console.WriteLine($"Time   : {alert.DetectedAt}");
            Console.WriteLine();
        }
    }
}

#endregion
