using TransactionProducer.Application.Common.Interfaces;
using Confluent.Kafka;

namespace TransactionProducer.Application.FinancialTransactions.Commands.CreateTransactionProducer;

public record CreateTransactionProducerCommand : IRequest<string>
{
    public int Id { get; init; }
}

public class CreateTransactionProducerCommandHandler : IRequestHandler<CreateTransactionProducerCommand, string>
{
    private readonly IApplicationDbContext _context;

    public CreateTransactionProducerCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<string> Handle(CreateTransactionProducerCommand request, CancellationToken cancellationToken)
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9292",
            AllowAutoCreateTopics = true,
            Acks = Acks.All
        };

        using var producer = new ProducerBuilder<Null, string>(config).Build();

        var deliveryResult = await producer.ProduceAsync(topic: "test-topic",
            new Message<Null, string>
            {
                Value = $"Hello, Fabio! {request.Id}"
            },
            cancellationToken);

        producer.Flush(cancellationToken);

        return deliveryResult.Value;
    }
}
