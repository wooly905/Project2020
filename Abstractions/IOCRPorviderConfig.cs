﻿namespace Abstractions
{
    public interface IOCRProviderConfig
    {
        string Provider { get; }
        string Endpoint { get; }
        string Key { get; }
    }
}
