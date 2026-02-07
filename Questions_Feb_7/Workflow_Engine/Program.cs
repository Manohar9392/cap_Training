using System;
using System.Collections.Generic;

#region Enums

public enum LoanState
{
    Draft,
    Submitted,
    InReview,
    Approved,
    Rejected,
    Disbursed
}

public enum LoanAction
{
    Submit,
    Review,
    Approve,
    Reject,
    Disburse
}

#endregion

#region Entity

public class LoanApplication
{
    public string ApplicationId { get; set; }
    public LoanState CurrentState { get; set; }
    public List<LoanState> StateHistory { get; set; }
}

#endregion

#region Workflow Engine

public class LoanWorkflowEngine
{
    private Dictionary<string, LoanApplication> store
        = new Dictionary<string, LoanApplication>();

    public void CreateApplication(string appId)
    {
        store[appId] = new LoanApplication
        {
            ApplicationId = appId,
            CurrentState = LoanState.Draft,
            StateHistory = new List<LoanState> { LoanState.Draft }
        };
    }

    public void ChangeState(string appId, LoanAction action)
    {
        if (!store.ContainsKey(appId))
            throw new Exception("Application not found");

        var app = store[appId];

        // Rule: cannot disburse unless approved
        if (action == LoanAction.Disburse &&
            app.CurrentState != LoanState.Approved)
        {
            throw new Exception("Cannot disburse unless Approved");
        }

        LoanState nextState = GetNextState(app.CurrentState, action);

        app.CurrentState = nextState;
        app.StateHistory.Add(nextState);
    }

    private LoanState GetNextState(LoanState current, LoanAction action)
    {
        return (current, action) switch
        {
            (LoanState.Draft, LoanAction.Submit) => LoanState.Submitted,

            (LoanState.Submitted, LoanAction.Review) => LoanState.InReview,

            (LoanState.InReview, LoanAction.Approve) => LoanState.Approved,
            (LoanState.InReview, LoanAction.Reject) => LoanState.Rejected,

            (LoanState.Approved, LoanAction.Disburse) => LoanState.Disbursed,

            _ => throw new Exception(
                $"Invalid transition: {current} → {action}")
        };
    }

    public LoanApplication GetApplication(string appId)
    {
        return store[appId];
    }
}

#endregion

#region Program (User Input)

class Program
{
    static void Main()
    {
        LoanWorkflowEngine engine = new LoanWorkflowEngine();

        Console.Write("Enter Loan Application ID: ");
        string appId = Console.ReadLine();

        engine.CreateApplication(appId);

        while (true)
        {
            var app = engine.GetApplication(appId);

            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"Current State: {app.CurrentState}");
            Console.WriteLine("Choose Action:");
            Console.WriteLine("1. Submit");
            Console.WriteLine("2. Review");
            Console.WriteLine("3. Approve");
            Console.WriteLine("4. Reject");
            Console.WriteLine("5. Disburse");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");

            string input = Console.ReadLine();

            if (input == "6")
                break;

            try
            {
                LoanAction action = input switch
                {
                    "1" => LoanAction.Submit,
                    "2" => LoanAction.Review,
                    "3" => LoanAction.Approve,
                    "4" => LoanAction.Reject,
                    "5" => LoanAction.Disburse,
                    _ => throw new Exception("Invalid option")
                };

                engine.ChangeState(appId, action);
                Console.WriteLine("State updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }

        Console.WriteLine("\nSTATE HISTORY:");
        foreach (var state in engine.GetApplication(appId).StateHistory)
        {
            Console.WriteLine(" - " + state);
        }
    }
}

#endregion
