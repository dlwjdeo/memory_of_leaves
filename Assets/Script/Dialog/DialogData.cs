using System.Collections.Generic;

[System.Serializable]
public class DialogLine
{
    public SpeakerType speaker;
    public string content;
    public PortraitType portrait;

    public DialogLine(SpeakerType speaker, string content, PortraitType portrait = PortraitType.None)
    {
        this.speaker = speaker;
        this.content = content;
        this.portrait = portrait;
    }
}
[System.Serializable]
public class DialogBlock
{
    public List<DialogLine> lines = new();

    public DialogBlock(List<DialogLine> lines)
    {
        this.lines = lines;
    }
}