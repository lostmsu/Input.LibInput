namespace Lost.Input.LibInput;

using YamlDotNet.Serialization;

public class EvDevInfo {
    [YamlMember(Alias = "name")]
    public string Name { get; set; }
    [YamlMember(Alias = "id")]
    public int[] ID { get; set; }
    [YamlMember(Alias = "codes")]
    public Dictionary<int, int[]> Codes { get; set; }
    [YamlMember(Alias = "properties")]
    public object[] Properties { get; set; }

    public override string ToString() => $"{this.Name} {string.Join(", ", this.ID)}";
}