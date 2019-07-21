namespace Cake.GetNuGetLicense.Alias
{
    using Cake.Core;
    using Cake.Core.Annotations;
    using System.Collections.Generic;
    using System.Linq;
    using Cake.Common;

    public static class GetNuGetLicenseAlias
    {
        [CakeMethodAlias]
        public static void GetNuGetLicense(this CakeContext context, IEnumerable<string> pathsToProjects)
        {
            // Parameter checks
            if (context == null)
            {
                throw new System.ArgumentNullException(nameof(context));
            }

            if (pathsToProjects == null || !pathsToProjects.Any())
            {
                throw new System.ArgumentNullException(nameof(pathsToProjects));
            }

            context?.Log.Write(Core.Diagnostics.Verbosity.Normal, Core.Diagnostics.LogLevel.Information, "Hello World");
            //new Cake.Common.Tools.NuGet.Restore.NuGetRestorer();
        }
    }
}
