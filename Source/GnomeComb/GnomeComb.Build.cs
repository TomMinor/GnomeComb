// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GnomeComb : ModuleRules
{
	public GnomeComb(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
