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
    Video,
    [Description("COLLECTION")]
    Collection,
    [Description("PHYSICAL_OBJECT")]
    PhysicalObject,
    [Description("INTERACTIVE_RESOURCE")]
    InteractiveResource,
    [Description("TEXT")]
    Text,
    [Description("OTHER")]
    Other,
    [Description("SLIDES")]
    Slides,
    [Description("SOFTWARE_CODE")]
    SoftwareCode,
    [Description("GEO_DATA")]
    GeoData,
    [Description("TABULAR_DATA")]
    TabularData,
    [Description("FILE_SET")]
    FileSet,
    [Description("WORKFLOW")]
    WorkFlow
}