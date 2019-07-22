using System;
using System.Collections.Generic;
using System.Text;

namespace Cake.GetNuGetLicense.ProjectFileResolver
{
    /// <summary>
    /// Returns a list project objects based on the given pathsToScan.
    /// </summary>
    class ProjectFileFinder
    {
        public ProjectFileFinder(IEnumerable<string> pathsToScan) => PathsToScan = pathsToScan;

        public IEnumerable<string> PathsToScan { get; }

    }
}
