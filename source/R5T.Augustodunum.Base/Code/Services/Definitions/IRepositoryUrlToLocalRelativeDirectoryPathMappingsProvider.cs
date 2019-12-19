using System;
using System.Collections.Generic;

using R5T.Augustodunum.Types;


namespace R5T.Augustodunum
{
    public interface IRepositoryUrlToLocalRelativeDirectoryPathMappingsProvider
    {
        IEnumerable<RepositoryUrlToLocalRelativeDirectoryPathMapping> GetRepositoryUrlToLocalRelativeDirectoryPathMappings();
    }
}
