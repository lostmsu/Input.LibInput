namespace Lost.Input.LibInput;

using System.IO;

using YamlDotNet.Serialization;

public class Recording {
    [YamlMember(Alias = "version")]
    public int Version { get; set; }
    [YamlMember(Alias = "ndevices")]
    public int DeviceCount { get; set; }
    [YamlMember(Alias = "libinput")]
    public LibInputInfo LibInputInfo { get; set; }
    [YamlMember(Alias = "system")]
    public SystemInfo System { get; set; }
    [YamlMember(Alias = "devices")]
    public DeviceInfo[] Devices { get; set; }

    public override string ToString() => string.Join("\n", (IEnumerable<DeviceInfo>)this.Devices);

    static readonly IDeserializer Deserializer = new DeserializerBuilder().Build();

    public static Recording ParseYaml(TextReader reader) {
        if (reader is null) throw new ArgumentNullException(nameof(reader));

        return Deserializer.Deserialize<Recording>(reader);
    }
}