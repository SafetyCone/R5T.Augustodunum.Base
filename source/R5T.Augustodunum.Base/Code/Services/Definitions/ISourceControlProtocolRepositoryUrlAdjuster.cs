using System;


namespace R5T.Augustodunum
{
    public interface ISourceControlProtocolRepositoryUrlAdjuster
    {
        string AdjustRepositoryUrl(string repositoryUrl);
    }
}
