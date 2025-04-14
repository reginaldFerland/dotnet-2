namespace SNS.EventChannel;

/// <summary>
/// Configuration for a single event channel
/// </summary>
public class EventChannelConfig<T>
{
    public required EventChannelWorkerConfig<T> WorkerConfig { get; init; }

    /// <summary>
    /// The type of events that will be published to this topic
    /// </summary>
    public Type EventType { get; set; } = null!;

    /// <summary>
    /// The maximum number of items that can be stored in the channel
    /// </summary>
    public int BoundedCapacity { get; set; } = 1_000_000;
}

/// <summary>
/// Configuration for event channels and workers
/// </summary>
public class EventChannelConfiguration<T>
{
    /// <summary>
    /// List of channel configurations
    /// </summary>
    public List<EventChannelConfig<T>> Channels { get; set; } = new List<EventChannelConfig<T>>();
}