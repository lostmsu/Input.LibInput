namespace Lost.Input.LibInput;

using YamlDotNet.Serialization;

public class Event {
    [YamlMember(Alias = "evdev")]
    public int[][] EvDev { get; set; }

    [YamlIgnore]
    public EvDevEvent[]? EvDevEvents => this.EvDev?.Select(EvDevEvent.Parse).ToArray();

    public override string ToString()
        => string.Join("\n", (IEnumerable<EvDevEvent>?)this.EvDevEvents ?? []);
}

public class EvDevEvent {
    public TimeSpan Timestamp { get; set; }

    internal static EvDevEvent Parse(int[] @event) {
        return new() {
            Timestamp = TimeSpan.FromTicks(checked((long)@event[1] * 10)),
        };
    }

    public override string ToString() => $"{this.Timestamp}";
}