namespace Lost.Input.LibInput;

using YamlDotNet.Serialization;

public class SystemInfo {
    [YamlMember(Alias = "os")]
    public string OS { get; set; }
    [YamlMember(Alias = "kernel")]
    public Version KernelVersion { get; set; }
    [YamlMember(Alias = "dmi")]
    public string DMI { get; set; }

    public override string ToString() => $"{this.OS} (linux-{this.KernelVersion})";
}