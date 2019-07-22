
namespace Cake.GetNuGetLicense.ProjectFileResolver
{
    using Microsoft.Build.Evaluation;

    public static class ProjectFactory
    {
        public static Project Create(string pathToProjectFile)
        {
            if (string.IsNullOrEmpty(pathToProjectFile))
            {
                throw new System.ArgumentException("message", nameof(pathToProjectFile));
            }

            return Project.FromFile(pathToProjectFile, new Microsoft.Build.Definition.ProjectOptions());
        }

    }
}
