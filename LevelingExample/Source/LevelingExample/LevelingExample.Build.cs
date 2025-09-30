// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LevelingExample : ModuleRules
{
	public LevelingExample(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"LevelingExample",
			"LevelingExample/Variant_Platforming",
			"LevelingExample/Variant_Platforming/Animation",
			"LevelingExample/Variant_Combat",
			"LevelingExample/Variant_Combat/AI",
			"LevelingExample/Variant_Combat/Animation",
			"LevelingExample/Variant_Combat/Gameplay",
			"LevelingExample/Variant_Combat/Interfaces",
			"LevelingExample/Variant_Combat/UI",
			"LevelingExample/Variant_SideScrolling",
			"LevelingExample/Variant_SideScrolling/AI",
			"LevelingExample/Variant_SideScrolling/Gameplay",
			"LevelingExample/Variant_SideScrolling/Interfaces",
			"LevelingExample/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
