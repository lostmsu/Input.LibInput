namespace Lost.Input.LibInput;

using YamlDotNet.Serialization;

public class Event {
    [YamlMember(Alias = "evdev")]
    public int[][] EvDev { get; set; }
}