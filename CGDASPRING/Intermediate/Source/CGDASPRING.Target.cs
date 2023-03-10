using UnrealBuildTool;

public class CGDASPRINGTarget : TargetRules
{
	public CGDASPRINGTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("CGDASPRING");
	}
}
