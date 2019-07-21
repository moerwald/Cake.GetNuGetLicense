var target         = Argument("target", "Default");
var solutionFile   = @".\src\Cake.GetNuGetLicenseSolution.sln";
var configuration  = "Release";


/////////////////////////////////////
// Restore
/////////////////////////////////////
Task("Restore")
    .Does(() =>
	{
		NuGetRestore(solutionFile);
    });

/////////////////////////////////////
// Build
/////////////////////////////////////
Task("Build")
    .IsDependentOn("Restore")
    .Does(() =>
	{
		MSBuild(solutionFile, settings => settings
			.SetConfiguration(configuration)
			.WithTarget("Rebuild")
			.SetVerbosity(Verbosity.Minimal));
    });


/////////////////////////////////////
// Default
/////////////////////////////////////
Task("Default")
    .IsDependentOn("Build")
    .Does(() =>
    {
    });

RunTarget(target);