using System.Reflection;
using SPTarkov.Server.Core.Models.Spt.Mod;
using Range = SemanticVersioning.Range;
using Version = SemanticVersioning.Version;

namespace ExpandedTaskText;

public record EttMetadata : AbstractModMetadata
{
    public override string ModGuid { get; init; } = "com.cj.ett";
    public override string Name { get; init; } = "Expanded Task Text";
    public override string Author { get; init; } = "Cj";
    public override List<string>? Contributors { get; init; }
    public override Version Version { get; init; } = new("2.0.2");
    public override Range SptVersion { get; init; } = new("~4.0");
    public override List<string>? Incompatibilities { get; init; }
    public override Dictionary<string, Range>? ModDependencies { get; init; }
    public override string? Url { get; init; }
    public override bool? IsBundleMod { get; init; }
    public override string License { get; init; } = "MIT";
    
    public static readonly string ResourcesDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, "Resources");
}