﻿namespace TraktNet.Tests.Objects.Basic.Json.Reader
{
    public partial class RatingArrayJsonReader_Tests
    {
        private const string JSON_EMPTY_ARRAY = "[]";

        private const string JSON_COMPLETE =
            @"[
                {
                  ""rating"": 8.32715,
                  ""votes"": 9274,
                  ""distribution"": {
                    ""1"": 78,
                    ""2"": 45,
                    ""3"": 55,
                    ""4"": 96,
                    ""5"": 183,
                    ""6"": 545,
                    ""7"": 1361,
                    ""8"": 2259,
                    ""9"": 1772,
                    ""10"": 2863
                  }
                },
                {
                  ""rating"": 8.32715,
                  ""votes"": 9274,
                  ""distribution"": {
                    ""1"": 78,
                    ""2"": 45,
                    ""3"": 55,
                    ""4"": 96,
                    ""5"": 183,
                    ""6"": 545,
                    ""7"": 1361,
                    ""8"": 2259,
                    ""9"": 1772,
                    ""10"": 2863
                  }
                }
              ]";

        private const string JSON_INCOMPLETE_1 =
            @"[
                {
                  ""rating"": 8.32715,
                  ""votes"": 9274,
                  ""distribution"": {
                    ""1"": 78,
                    ""2"": 45,
                    ""3"": 55,
                    ""4"": 96,
                    ""5"": 183,
                    ""6"": 545,
                    ""7"": 1361,
                    ""8"": 2259,
                    ""9"": 1772,
                    ""10"": 2863
                  }
                },
                {
                  ""votes"": 9274,
                  ""distribution"": {
                    ""1"": 78,
                    ""2"": 45,
                    ""3"": 55,
                    ""4"": 96,
                    ""5"": 183,
                    ""6"": 545,
                    ""7"": 1361,
                    ""8"": 2259,
                    ""9"": 1772,
                    ""10"": 2863
                  }
                }
              ]";

        private const string JSON_INCOMPLETE_2 =
            @"[
                {
                  ""votes"": 9274,
                  ""distribution"": {
                    ""1"": 78,
                    ""2"": 45,
                    ""3"": 55,
                    ""4"": 96,
                    ""5"": 183,
                    ""6"": 545,
                    ""7"": 1361,
                    ""8"": 2259,
                    ""9"": 1772,
                    ""10"": 2863
                  }
                },
                {
                  ""rating"": 8.32715,
                  ""votes"": 9274,
                  ""distribution"": {
                    ""1"": 78,
                    ""2"": 45,
                    ""3"": 55,
                    ""4"": 96,
                    ""5"": 183,
                    ""6"": 545,
                    ""7"": 1361,
                    ""8"": 2259,
                    ""9"": 1772,
                    ""10"": 2863
                  }
                }
              ]";

        private const string JSON_NOT_VALID_1 =
            @"[
                {
                  ""ra"": 8.32715,
                  ""votes"": 9274,
                  ""distribution"": {
                    ""1"": 78,
                    ""2"": 45,
                    ""3"": 55,
                    ""4"": 96,
                    ""5"": 183,
                    ""6"": 545,
                    ""7"": 1361,
                    ""8"": 2259,
                    ""9"": 1772,
                    ""10"": 2863
                  }
                },
                {
                  ""rating"": 8.32715,
                  ""votes"": 9274,
                  ""distribution"": {
                    ""1"": 78,
                    ""2"": 45,
                    ""3"": 55,
                    ""4"": 96,
                    ""5"": 183,
                    ""6"": 545,
                    ""7"": 1361,
                    ""8"": 2259,
                    ""9"": 1772,
                    ""10"": 2863
                  }
                }
              ]";

        private const string JSON_NOT_VALID_2 =
            @"[
                {
                  ""rating"": 8.32715,
                  ""votes"": 9274,
                  ""distribution"": {
                    ""1"": 78,
                    ""2"": 45,
                    ""3"": 55,
                    ""4"": 96,
                    ""5"": 183,
                    ""6"": 545,
                    ""7"": 1361,
                    ""8"": 2259,
                    ""9"": 1772,
                    ""10"": 2863
                  }
                },
                {
                  ""raating"": 8.32715,
                  ""votes"": 9274,
                  ""distribution"": {
                    ""1"": 78,
                    ""2"": 45,
                    ""3"": 55,
                    ""4"": 96,
                    ""5"": 183,
                    ""6"": 545,
                    ""7"": 1361,
                    ""8"": 2259,
                    ""9"": 1772,
                    ""10"": 2863
                  }
                }
              ]";

        private const string JSON_NOT_VALID_3 =
            @"[
                {
                  ""ra"": 8.32715,
                  ""votes"": 9274,
                  ""distribution"": {
                    ""1"": 78,
                    ""2"": 45,
                    ""3"": 55,
                    ""4"": 96,
                    ""5"": 183,
                    ""6"": 545,
                    ""7"": 1361,
                    ""8"": 2259,
                    ""9"": 1772,
                    ""10"": 2863
                  }
                },
                {
                  ""raating"": 8.32715,
                  ""votes"": 9274,
                  ""distribution"": {
                    ""1"": 78,
                    ""2"": 45,
                    ""3"": 55,
                    ""4"": 96,
                    ""5"": 183,
                    ""6"": 545,
                    ""7"": 1361,
                    ""8"": 2259,
                    ""9"": 1772,
                    ""10"": 2863
                  }
                }
              ]";
    }
}
