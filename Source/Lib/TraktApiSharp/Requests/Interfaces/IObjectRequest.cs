﻿namespace TraktNet.Requests.Interfaces
{
    using Requests.Base;

    internal interface IObjectRequest
    {
        RequestObjectType RequestObjectType { get; }
    }
}
