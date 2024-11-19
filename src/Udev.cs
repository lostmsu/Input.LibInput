namespace Lost.Input.LibInput;

using YamlDotNet.Serialization;

public class Udev {
    [YamlMember(Alias = "properties")]
    public string[] Properties { get; set; }

    public override string ToString() => string.Join("\n", this.Properties);
}