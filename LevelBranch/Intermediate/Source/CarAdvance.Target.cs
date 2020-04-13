using UnrealBuildTool;

public class CarAdvanceTarget : TargetRules
{
	public CarAdvanceTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("CarAdvance");
	}
}
