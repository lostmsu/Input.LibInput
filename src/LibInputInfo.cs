namespace Lost.Input.LibInput;

using YamlDotNet.Serialization;

public class LibInputInfo {
    [YamlMember(Alias = "version")]
    public Version Version { get; set; }
    [YamlMember(Alias = "git")]
    public string Git { get; set; }
    [YamlMember(Alias = "autorestart")]
    public int? AutorestartMilliseconds { get; set; }

    public override string ToString() => $"{this.Git} {this.Version}";
}