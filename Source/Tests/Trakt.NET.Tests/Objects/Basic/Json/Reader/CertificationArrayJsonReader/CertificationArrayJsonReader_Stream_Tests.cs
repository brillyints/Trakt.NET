﻿namespace TraktNet.Tests.Objects.Basic.Json.Reader
{
    using FluentAssertions;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using TestUtils;
    using Traits;
    using TraktNet.Objects.Basic.Json.Reader;
    using Xunit;

    [Category("Objects.Basic.JsonReader")]
    public partial class CertificationArrayJsonReader_Tests
    {
        [Fact]
        public async Task Test_CertificationArrayJsonReader_ReadArray_From_Stream_Empty_Array()
        {
            var traktJsonReader = new CertificationArrayJsonReader();

            using (var stream = JSON_EMPTY_ARRAY.ToStream())
            {
                var traktCertifications = await traktJsonReader.ReadArrayAsync(stream);
                traktCertifications.Should().NotBeNull().And.BeEmpty();
            }
        }

        [Fact]
        public async Task Test_CertificationArrayJsonReader_ReadArray_From_Stream_Complete()
        {
            var traktJsonReader = new CertificationArrayJsonReader();

            using (var stream = JSON_COMPLETE.ToStream())
            {
                var traktCertifications = await traktJsonReader.ReadArrayAsync(stream);

                traktCertifications.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(2);
                var items = traktCertifications.ToArray();

                items[0].Should().NotBeNull();
                items[0].Name.Should().Be("PG");
                items[0].Slug.Should().Be("pg");
                items[0].Description.Should().Be("Parental Guidance Suggested");

                items[1].Should().NotBeNull();
                items[1].Name.Should().Be("PG-13");
                items[1].Slug.Should().Be("pg-13");
                items[1].Description.Should().Be("Parents Strongly Cautioned - Ages 13+ Recommended");
            }
        }

        [Fact]
        public async Task Test_CertificationArrayJsonReader_ReadArray_From_Stream_Incomplete_1()
        {
            var traktJsonReader = new CertificationArrayJsonReader();

            using (var stream = JSON_INCOMPLETE_1.ToStream())
            {
                var traktCertifications = await traktJsonReader.ReadArrayAsync(stream);

                traktCertifications.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(2);
                var items = traktCertifications.ToArray();

                items[0].Should().NotBeNull();
                items[0].Name.Should().BeNull();
                items[0].Slug.Should().Be("pg");
                items[0].Description.Should().Be("Parental Guidance Suggested");

                items[1].Should().NotBeNull();
                items[1].Name.Should().Be("PG-13");
                items[1].Slug.Should().Be("pg-13");
                items[1].Description.Should().Be("Parents Strongly Cautioned - Ages 13+ Recommended");
            }
        }

        [Fact]
        public async Task Test_CertificationArrayJsonReader_ReadArray_From_Stream_Incomplete_2()
        {
            var traktJsonReader = new CertificationArrayJsonReader();

            using (var stream = JSON_INCOMPLETE_2.ToStream())
            {
                var traktCertifications = await traktJsonReader.ReadArrayAsync(stream);

                traktCertifications.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(2);
                var items = traktCertifications.ToArray();

                items[0].Should().NotBeNull();
                items[0].Name.Should().Be("PG");
                items[0].Slug.Should().BeNull();
                items[0].Description.Should().Be("Parental Guidance Suggested");

                items[1].Should().NotBeNull();
                items[1].Name.Should().Be("PG-13");
                items[1].Slug.Should().Be("pg-13");
                items[1].Description.Should().Be("Parents Strongly Cautioned - Ages 13+ Recommended");
            }
        }

        [Fact]
        public async Task Test_CertificationArrayJsonReader_ReadArray_From_Stream_Incomplete_3()
        {
            var traktJsonReader = new CertificationArrayJsonReader();

            using (var stream = JSON_INCOMPLETE_3.ToStream())
            {
                var traktCertifications = await traktJsonReader.ReadArrayAsync(stream);

                traktCertifications.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(2);
                var items = traktCertifications.ToArray();

                items[0].Should().NotBeNull();
                items[0].Name.Should().Be("PG");
                items[0].Slug.Should().Be("pg");
                items[0].Description.Should().BeNull();

                items[1].Should().NotBeNull();
                items[1].Name.Should().Be("PG-13");
                items[1].Slug.Should().Be("pg-13");
                items[1].Description.Should().Be("Parents Strongly Cautioned - Ages 13+ Recommended");
            }
        }

        [Fact]
        public async Task Test_CertificationArrayJsonReader_ReadArray_From_Stream_Incomplete_4()
        {
            var traktJsonReader = new CertificationArrayJsonReader();

            using (var stream = JSON_INCOMPLETE_4.ToStream())
            {
                var traktCertifications = await traktJsonReader.ReadArrayAsync(stream);

                traktCertifications.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(2);
                var items = traktCertifications.ToArray();

                items[0].Should().NotBeNull();
                items[0].Name.Should().Be("PG");
                items[0].Slug.Should().Be("pg");
                items[0].Description.Should().Be("Parental Guidance Suggested");

                items[1].Should().NotBeNull();
                items[1].Name.Should().Be("PG-13");
                items[1].Slug.Should().BeNull();
                items[1].Description.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_CertificationArrayJsonReader_ReadArray_From_Stream_Incomplete_5()
        {
            var traktJsonReader = new CertificationArrayJsonReader();

            using (var stream = JSON_INCOMPLETE_5.ToStream())
            {
                var traktCertifications = await traktJsonReader.ReadArrayAsync(stream);

                traktCertifications.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(2);
                var items = traktCertifications.ToArray();

                items[0].Should().NotBeNull();
                items[0].Name.Should().Be("PG");
                items[0].Slug.Should().Be("pg");
                items[0].Description.Should().Be("Parental Guidance Suggested");

                items[1].Should().NotBeNull();
                items[1].Name.Should().BeNull();
                items[1].Slug.Should().Be("pg-13");
                items[1].Description.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_CertificationArrayJsonReader_ReadArray_From_Stream_Incomplete_6()
        {
            var traktJsonReader = new CertificationArrayJsonReader();

            using (var stream = JSON_INCOMPLETE_6.ToStream())
            {
                var traktCertifications = await traktJsonReader.ReadArrayAsync(stream);

                traktCertifications.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(2);
                var items = traktCertifications.ToArray();

                items[0].Should().NotBeNull();
                items[0].Name.Should().Be("PG");
                items[0].Slug.Should().Be("pg");
                items[0].Description.Should().Be("Parental Guidance Suggested");

                items[1].Should().NotBeNull();
                items[1].Name.Should().BeNull();
                items[1].Slug.Should().BeNull();
                items[1].Description.Should().Be("Parents Strongly Cautioned - Ages 13+ Recommended");
            }
        }

        [Fact]
        public async Task Test_CertificationArrayJsonReader_ReadArray_From_Stream_Not_Valid_1()
        {
            var traktJsonReader = new CertificationArrayJsonReader();

            using (var stream = JSON_NOT_VALID_1.ToStream())
            {
                var traktCertifications = await traktJsonReader.ReadArrayAsync(stream);

                traktCertifications.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(2);
                var items = traktCertifications.ToArray();

                items[0].Should().NotBeNull();
                items[0].Name.Should().BeNull();
                items[0].Slug.Should().Be("pg");
                items[0].Description.Should().Be("Parental Guidance Suggested");

                items[1].Should().NotBeNull();
                items[1].Name.Should().Be("PG-13");
                items[1].Slug.Should().Be("pg-13");
                items[1].Description.Should().Be("Parents Strongly Cautioned - Ages 13+ Recommended");
            }
        }

        [Fact]
        public async Task Test_CertificationArrayJsonReader_ReadArray_From_Stream_Not_Valid_2()
        {
            var traktJsonReader = new CertificationArrayJsonReader();

            using (var stream = JSON_NOT_VALID_2.ToStream())
            {
                var traktCertifications = await traktJsonReader.ReadArrayAsync(stream);

                traktCertifications.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(2);
                var items = traktCertifications.ToArray();

                items[0].Should().NotBeNull();
                items[0].Name.Should().Be("PG");
                items[0].Slug.Should().Be("pg");
                items[0].Description.Should().Be("Parental Guidance Suggested");

                items[1].Should().NotBeNull();
                items[1].Name.Should().Be("PG-13");
                items[1].Slug.Should().BeNull();
                items[1].Description.Should().Be("Parents Strongly Cautioned - Ages 13+ Recommended");
            }
        }

        [Fact]
        public async Task Test_CertificationArrayJsonReader_ReadArray_From_Stream_Not_Valid_3()
        {
            var traktJsonReader = new CertificationArrayJsonReader();

            using (var stream = JSON_NOT_VALID_3.ToStream())
            {
                var traktCertifications = await traktJsonReader.ReadArrayAsync(stream);

                traktCertifications.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(2);
                var items = traktCertifications.ToArray();

                items[0].Should().NotBeNull();
                items[0].Name.Should().Be("PG");
                items[0].Slug.Should().Be("pg");
                items[0].Description.Should().BeNull();

                items[1].Should().NotBeNull();
                items[1].Name.Should().Be("PG-13");
                items[1].Slug.Should().Be("pg-13");
                items[1].Description.Should().Be("Parents Strongly Cautioned - Ages 13+ Recommended");
            }
        }

        [Fact]
        public async Task Test_CertificationArrayJsonReader_ReadArray_From_Stream_Not_Valid_4()
        {
            var traktJsonReader = new CertificationArrayJsonReader();

            using (var stream = JSON_NOT_VALID_4.ToStream())
            {
                var traktCertifications = await traktJsonReader.ReadArrayAsync(stream);

                traktCertifications.Should().NotBeNull().And.NotBeEmpty().And.HaveCount(2);
                var items = traktCertifications.ToArray();

                items[0].Should().NotBeNull();
                items[0].Name.Should().Be("PG");
                items[0].Slug.Should().BeNull();
                items[0].Description.Should().Be("Parental Guidance Suggested");

                items[1].Should().NotBeNull();
                items[1].Name.Should().Be("PG-13");
                items[1].Slug.Should().Be("pg-13");
                items[1].Description.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_CertificationArrayJsonReader_ReadArray_From_Stream_Null()
        {
            var traktJsonReader = new CertificationArrayJsonReader();

            var traktCertifications = await traktJsonReader.ReadArrayAsync(default(Stream));
            traktCertifications.Should().BeNull();
        }

        [Fact]
        public async Task Test_CertificationArrayJsonReader_ReadArray_From_Stream_Empty()
        {
            var traktJsonReader = new CertificationArrayJsonReader();

            using (var stream = string.Empty.ToStream())
            {
                var traktCertifications = await traktJsonReader.ReadArrayAsync(stream);
                traktCertifications.Should().BeNull();
            }
        }
    }
}
