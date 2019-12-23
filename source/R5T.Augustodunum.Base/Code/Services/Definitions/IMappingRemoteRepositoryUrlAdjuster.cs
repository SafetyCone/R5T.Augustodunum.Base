using System;


namespace R5T.Augustodunum
{
    /// <summary>
    /// Adjusts remote repository URLs to conform to a specified standard.
    /// Useful for standardizing SVN repository URLs that end with ".git/trunk" and Git repository URLs that just end with ".git".
    /// </summary>
    public interface IMappingRemoteRepositoryUrlAdjuster
    {
        string AdjustRemoteRepositoryUrl(string repositoryUrl);
    }
}
