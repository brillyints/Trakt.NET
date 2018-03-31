﻿namespace TraktApiSharp.Tests.Modules.TraktCalendarModuleTests
{
    using System;

    public partial class TraktCalendarModuleTests_Tests
    {
        private const string START_DATE = "Tue, 08 Mar 2016 00:00:00 GMT";
        private const string END_DATE = "Mon, 14 Mar 2016 23:59:59 GMT";

        private static DateTime DT_START_DATE;
        private static DateTime DT_END_DATE;

        private const string CALENDAR_ALL_MOVIES_JSON =
            @"[
                {
                  ""released"": ""2014-08-01"",
                  ""movie"": {
                    ""title"": ""Guardians of the Galaxy"",
                    ""year"": 2014,
                    ""ids"": {
                      ""trakt"": 28,
                      ""slug"": ""guardians-of-the-galaxy-2014"",
                      ""imdb"": ""tt2015381"",
                      ""tmdb"": 118340
                    }
                  }
                },
                {
                  ""released"": ""2014-08-01"",
                  ""movie"": {
                    ""title"": ""Get On Up"",
                    ""year"": 2014,
                    ""ids"": {
                      ""trakt"": 29,
                      ""slug"": ""get-on-up-2014"",
                      ""imdb"": ""tt2473602"",
                      ""tmdb"": 239566
                    }
                  }
                },
                {
                  ""released"": ""2014-08-08"",
                  ""movie"": {
                    ""title"": ""Teenage Mutant Ninja Turtles"",
                    ""year"": 2014,
                    ""ids"": {
                      ""trakt"": 30,
                      ""slug"": ""teenage-mutant-ninja-turtles-2014"",
                      ""imdb"": ""tt1291150"",
                      ""tmdb"": 98566
                    }
                  }
                }
              ]";

        private const string CALENDAR_ALL_SHOWS_JSON =
            @"[
                {
                  ""first_aired"": ""2014-07-14T01:00:00.000Z"",
                  ""episode"": {
                    ""season"": 7,
                    ""number"": 4,
                    ""title"": ""Death is Not the End"",
                    ""ids"": {
                      ""trakt"": 443,
                      ""tvdb"": 4851180,
                      ""imdb"": ""tt3500614"",
                      ""tmdb"": 988123,
                      ""tvrage"": null
                    }
                  },
                  ""show"": {
                    ""title"": ""True Blood"",
                    ""year"": 2008,
                    ""ids"": {
                      ""trakt"": 5,
                      ""slug"": ""true-blood"",
                      ""tvdb"": 82283,
                      ""imdb"": ""tt0844441"",
                      ""tmdb"": 10545,
                      ""tvrage"": 12662
                    }
                  }
                },
                {
                  ""first_aired"": ""2014-07-14T02:00:00.000Z"",
                  ""episode"": {
                    ""season"": 1,
                    ""number"": 3,
                    ""title"": ""Two Boats and a Helicopter"",
                    ""ids"": {
                      ""trakt"": 499,
                      ""tvdb"": 4854797,
                      ""imdb"": ""tt3631218"",
                      ""tmdb"": 988346,
                      ""tvrage"": null
                    }
                  },
                  ""show"": {
                    ""title"": ""The Leftovers"",
                    ""year"": 2014,
                    ""ids"": {
                      ""trakt"": 7,
                      ""slug"": ""the-leftovers"",
                      ""tvdb"": 269689,
                      ""imdb"": ""tt2699128"",
                      ""tmdb"": 54344,
                      ""tvrage"": null
                    }
                  }
                }
              ]";

        private const string CALENDAR_DVD_MOVIES_JSON =
            @"[
                {
                  ""released"": ""2014-08-01"",
                  ""movie"": {
                    ""title"": ""Guardians of the Galaxy"",
                    ""year"": 2014,
                    ""ids"": {
                      ""trakt"": 28,
                      ""slug"": ""guardians-of-the-galaxy-2014"",
                      ""imdb"": ""tt2015381"",
                      ""tmdb"": 118340
                    }
                  }
                },
                {
                  ""released"": ""2014-08-01"",
                  ""movie"": {
                    ""title"": ""Get On Up"",
                    ""year"": 2014,
                    ""ids"": {
                      ""trakt"": 29,
                      ""slug"": ""get-on-up-2014"",
                      ""imdb"": ""tt2473602"",
                      ""tmdb"": 239566
                    }
                  }
                },
                {
                  ""released"": ""2014-08-08"",
                  ""movie"": {
                    ""title"": ""Teenage Mutant Ninja Turtles"",
                    ""year"": 2014,
                    ""ids"": {
                      ""trakt"": 30,
                      ""slug"": ""teenage-mutant-ninja-turtles-2014"",
                      ""imdb"": ""tt1291150"",
                      ""tmdb"": 98566
                    }
                  }
                }
              ]";
    }
}
