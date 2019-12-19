using System;


namespace R5T.Augustodunum
{
    public interface ISourceControlProtocolRepositoryLocalDirectoryPathAdjuster
    {
        string AdjustLocalDirectoryPath(string localDirectoryPath);
    }
}
