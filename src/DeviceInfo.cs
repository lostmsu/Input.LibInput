namespace Lost.Input.LibInput;

using YamlDotNet.Serialization;

public class DeviceInfo {
    [YamlMember(Alias = "node")]
    public string Node { get; set; }
    [YamlMember(Alias = "evdev")]
    public EvDevInfo EvDev { get; set; }
    [YamlMember(Alias = "hid")]
    public byte[] HID { get; set; }
    [YamlMember(Alias = "udev")]
    public Udev Udev { get; set; }
    [YamlMember(Alias = "quirks")]
    public Dictionary<string, object> Quirks { get; set; }
    [YamlMember(Alias = "events")]
    public Event[] Events { get; set; }

    public override string ToString() => $"{this.Node}: {this.EvDev} [{this.Events?.Length}]";
}