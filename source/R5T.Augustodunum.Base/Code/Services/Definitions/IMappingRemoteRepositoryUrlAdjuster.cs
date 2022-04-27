using System;

using R5T.T0064;


namespace R5T.Augustodunum
{
    /// <summary>
    /// Adjusts remote repository URLs to conform to a specified standard.
    /// Useful for standardizing SVN repository URLs that end with ".git/trunk" and Git repository URLs that just end with ".git".
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IMappingRemoteRepositoryUrlAdjuster : IServiceDefinition
    {
        string AdjustRemoteRepositoryUrl(string repositoryUrl);
    }
}
