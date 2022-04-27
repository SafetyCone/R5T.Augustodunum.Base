using System;

using R5T.T0064;


namespace R5T.Augustodunum
{
    [ServiceDefinitionMarker]
    public interface ISourceControlProtocolRepositoryLocalDirectoryPathAdjuster : IServiceDefinition
    {
        string AdjustLocalDirectoryPath(string localDirectoryPath);
    }
}
