﻿namespace TraktNet.Objects.Basic.Json.Factories
{
    using Objects.Basic.Json.Reader;
    using Objects.Basic.Json.Writer;
    using Objects.Json;

    internal class CertificationJsonIOFactory : IJsonIOFactory<ITraktCertification>
    {
        public IObjectJsonReader<ITraktCertification> CreateObjectReader() => new CertificationObjectJsonReader();

        public IArrayJsonReader<ITraktCertification> CreateArrayReader() => new CertificationArrayJsonReader();

        public IObjectJsonWriter<ITraktCertification> CreateObjectWriter() => new CertificationObjectJsonWriter();
    }
}
