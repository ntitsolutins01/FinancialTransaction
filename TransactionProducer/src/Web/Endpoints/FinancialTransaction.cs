using Microsoft.AspNetCore.Http.HttpResults;
using TransactionProducer.Application.FinancialTransactions.Commands.CreateTransactionProducer;
using TransactionProducer.Application.FinancialTransactions.Commands.Queries.GetTransactions;

namespace TransactionProducer.Web.Endpoints;

public class FinancialTransaction : IEndpointGroup
{
    public static void Map(RouteGroupBuilder groupBuilder)
    {
        //groupBuilder.RequireAuthorization();

        groupBuilder.MapGet(GetTransactions);
        groupBuilder.MapPost(CreateTransactionProducer);
    }

    [EndpointSummary("Create a new Transaction Producer")]
    [EndpointDescription("Creates a new transaction producer using the provided details and returns the ID of the created item.")]
    public static async Task<Created<string>> CreateTransactionProducer(ISender sender, CreateTransactionProducerCommand command)
    {
        var id = await sender.Send(command);

        return TypedResults.Created($"/{nameof(FinancialTransaction)}/{id}", id);
    }

    [EndpointSummary("Get all Transactions")]
    [EndpointDescription("Retrieves all transactions along with their details.")]
    public static async Task<Ok<string>> GetTransactions(ISender sender)
    {
        var vm = await sender.Send(new GetTransactionsQuery());

        return TypedResults.Ok(vm);
    }
}
