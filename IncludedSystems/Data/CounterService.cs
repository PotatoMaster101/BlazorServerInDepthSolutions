namespace IncludedSystems.Data;

public class CounterService : ICounterService
{
    private readonly ILogger<CounterService> _logger;
    private int _value;

    public int Value
    {
        get => _value;
        set
        {
            _value = value;
            _logger.LogInformation("Counter value changed to {Counter}", value);
        }
    }

    public CounterService(ILogger<CounterService> logger)
    {
        _logger = logger;
    }
}
