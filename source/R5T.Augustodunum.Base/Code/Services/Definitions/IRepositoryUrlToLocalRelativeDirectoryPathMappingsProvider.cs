using System;
using System.Collections.Generic;

using R5T.Augustodunum.Types;

using R5T.T0064;


namespace R5T.Augustodunum
{
    [ServiceDefinitionMarker]
    public interface IRepositoryUrlToLocalRelativeDirectoryPathMappingsProvider : IServiceDefinition
    {
        IEnumerable<RepositoryUrlToLocalRelativeDirectoryPathMapping> GetRepositoryUrlToLocalRelativeDirectoryPathMappings();
    }
}
