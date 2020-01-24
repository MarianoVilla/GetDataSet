using System.ComponentModel;

public enum MendeleyDataType
{
    [Description("DATASET")]
    Dataset,
    [Description("DOCUMENT")]
    Document,
    [Description("IMAGE")]
    Image,
    [Description("AUDIO")]
    Audio,
    [Description("VIDEO")]
    Video
}