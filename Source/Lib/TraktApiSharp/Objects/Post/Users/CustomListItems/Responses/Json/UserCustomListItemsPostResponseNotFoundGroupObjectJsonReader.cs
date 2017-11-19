﻿namespace TraktApiSharp.Objects.Post.Users.CustomListItems.Responses.Json
{
    using Implementations;
    using Newtonsoft.Json;
    using Objects.Json;
    using Post.Responses.Json;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    internal class UserCustomListItemsPostResponseNotFoundGroupObjectJsonReader : IObjectJsonReader<ITraktUserCustomListItemsPostResponseNotFoundGroup>
    {
        public Task<ITraktUserCustomListItemsPostResponseNotFoundGroup> ReadObjectAsync(string json, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrEmpty(json))
                return Task.FromResult(default(ITraktUserCustomListItemsPostResponseNotFoundGroup));

            using (var reader = new StringReader(json))
            using (var jsonReader = new JsonTextReader(reader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public Task<ITraktUserCustomListItemsPostResponseNotFoundGroup> ReadObjectAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (stream == null)
                return Task.FromResult(default(ITraktUserCustomListItemsPostResponseNotFoundGroup));

            using (var streamReader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public async Task<ITraktUserCustomListItemsPostResponseNotFoundGroup> ReadObjectAsync(JsonTextReader jsonReader, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (jsonReader == null)
                return await Task.FromResult(default(ITraktUserCustomListItemsPostResponseNotFoundGroup));

            if (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.StartObject)
            {
                var notFoundMoviesReader = new PostResponseNotFoundMovieArrayJsonReader();
                var notFoundShowsReader = new PostResponseNotFoundShowArrayJsonReader();
                var notFoundSeasonsReader = new PostResponseNotFoundSeasonArrayJsonReader();
                var notFoundEpisodesReader = new PostResponseNotFoundEpisodeArrayJsonReader();
                var notFoundPeopleReader = new PostResponseNotFoundPersonArrayJsonReader();
                ITraktUserCustomListItemsPostResponseNotFoundGroup customListItemsPostResponseNotFoundGroup = new TraktUserCustomListItemsPostResponseNotFoundGroup();

                while (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.PropertyName)
                {
                    var propertyName = jsonReader.Value.ToString();

                    switch (propertyName)
                    {
                        case JsonProperties.USER_CUSTOM_LIST_ITEMS_POST_RESPONSE_NOT_FOUND_GROUP_PROPERTY_NAME_MOVIES:
                            customListItemsPostResponseNotFoundGroup.Movies = await notFoundMoviesReader.ReadArrayAsync(jsonReader, cancellationToken);
                            break;
                        case JsonProperties.USER_CUSTOM_LIST_ITEMS_POST_RESPONSE_NOT_FOUND_GROUP_PROPERTY_NAME_SHOWS:
                            customListItemsPostResponseNotFoundGroup.Shows = await notFoundShowsReader.ReadArrayAsync(jsonReader, cancellationToken);
                            break;
                        case JsonProperties.USER_CUSTOM_LIST_ITEMS_POST_RESPONSE_NOT_FOUND_GROUP_PROPERTY_NAME_SEASONS:
                            customListItemsPostResponseNotFoundGroup.Seasons = await notFoundSeasonsReader.ReadArrayAsync(jsonReader, cancellationToken);
                            break;
                        case JsonProperties.USER_CUSTOM_LIST_ITEMS_POST_RESPONSE_NOT_FOUND_GROUP_PROPERTY_NAME_EPISODES:
                            customListItemsPostResponseNotFoundGroup.Episodes = await notFoundEpisodesReader.ReadArrayAsync(jsonReader, cancellationToken);
                            break;
                        case JsonProperties.USER_CUSTOM_LIST_ITEMS_POST_RESPONSE_NOT_FOUND_GROUP_PROPERTY_NAME_PEOPLE:
                            customListItemsPostResponseNotFoundGroup.People = await notFoundPeopleReader.ReadArrayAsync(jsonReader, cancellationToken);
                            break;
                        default:
                            await JsonReaderHelper.ReadAndIgnoreInvalidContentAsync(jsonReader, cancellationToken);
                            break;
                    }
                }

                return customListItemsPostResponseNotFoundGroup;
            }

            return await Task.FromResult(default(ITraktUserCustomListItemsPostResponseNotFoundGroup));
        }
    }
}
