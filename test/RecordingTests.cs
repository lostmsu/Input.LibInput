namespace Lost.Input.LibInput;

using System.IO;

public class RecordingTests {
    [Fact]
    public void Keyboard() {
        using var yaml = new StreamReader("kbd.yml");
        var recording = Recording.ParseYaml(yaml);

        Assert.Equal(42, 42);
    }

    [Fact]
    public void Mouse() {
        using var yaml = new StreamReader("mouse.yml");
        var recording = Recording.ParseYaml(yaml);

        Assert.Equal(42, 42);
    }
}