﻿namespace P2020.ImageServiceProxy.Azure
{
    internal interface IAzureRecognizeTextResponse
    {
        string Status { get; set; }
        IAzureRecognizeResult RecognitionResult { get; set; }
    }
}
