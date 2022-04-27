using System;

using R5T.T0064;


namespace R5T.Augustodunum
{
    [ServiceDefinitionMarker]
    public interface ISourceControlProtocolRepositoryUrlAdjuster : IServiceDefinition
    {
        string AdjustRepositoryUrl(string repositoryUrl);
    }
}
