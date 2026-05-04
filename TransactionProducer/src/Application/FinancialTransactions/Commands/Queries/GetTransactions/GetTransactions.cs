using Confluent.Kafka;
using Microsoft.Extensions.Logging;
using TransactionProducer.Application.Common.Interfaces;

namespace TransactionProducer.Application.FinancialTransactions.Commands.Queries.GetTransactions;

public record GetTransactionsQuery : IRequest<string>;

public class GetTransactionsQueryHandler : IRequestHandler<GetTransactionsQuery, string>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly ILogger<GetTransactionsQueryHandler> _logger;

    public GetTransactionsQueryHandler(IApplicationDbContext context, IMapper mapper, ILogger<GetTransactionsQueryHandler> logger)
    {
        _context = context;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<string> Handle(GetTransactionsQuery request, CancellationToken cancellationToken)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "financial_transactions-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();

        consumer.Subscribe("financial_transactions");

        while (!cancellationToken.IsCancellationRequested)
        {
            try
            {
                var consumeResult = consumer.Consume(TimeSpan.FromSeconds(5));

                if (consumeResult == null)
                {
                    continue;
                }

                _logger.LogInformation($"Consumed message '{consumeResult.Message.Value}' at: '{consumeResult.Offset}'");
            }
            catch (Exception)
            {
                // Ignore
            }
        }

        return "OK";
    }
}
