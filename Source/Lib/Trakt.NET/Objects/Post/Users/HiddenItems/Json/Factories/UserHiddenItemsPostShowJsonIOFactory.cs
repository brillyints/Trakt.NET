﻿namespace TraktNet.Objects.Post.Users.HiddenItems.Json.Factories
{
    using Objects.Json;
    using Reader;
    using Writer;

    internal class UserHiddenItemsPostShowJsonIOFactory : IJsonIOFactory<ITraktUserHiddenItemsPostShow>
    {
        public IObjectJsonReader<ITraktUserHiddenItemsPostShow> CreateObjectReader() => new UserHiddenItemsPostShowObjectJsonReader();

        public IArrayJsonReader<ITraktUserHiddenItemsPostShow> CreateArrayReader() => new UserHiddenItemsPostShowArrayJsonReader();

        public IObjectJsonWriter<ITraktUserHiddenItemsPostShow> CreateObjectWriter() => new UserHiddenItemsPostShowObjectJsonWriter();
    }
}
