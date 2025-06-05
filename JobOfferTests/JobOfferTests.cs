using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using JobOfferData;
using Serilog.Extensions.Logging.File;
using NUnit.Framework;
using System.Net.Http;
using System.Text.Json;
using JobOfferDataClasses;

namespace JobOfferTests
{
    /// <summary>
    /// Tests for job offers.
    /// </summary>
    [TestFixture]
    public class JobOfferTests
    {
        private JobPosition _job;
        private string _baseUrl = "";
        private string _invalidSlug = "";
        private ILogger<JobOfferTests> _logger;
        private readonly HttpClient _client = new();

        /// <summary>
        /// Setup of test class
        /// </summary>
        [OneTimeSetUp]
        public void Setup()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            _baseUrl = config["ApiBaseUrl"] ?? throw new ArgumentNullException("Missing ApiBaseUrl in config");
            var slug = config["JobSlug"] ?? throw new ArgumentNullException("Missing JobSlug");
            _invalidSlug = config["InvalidSlug"] ?? throw new ArgumentNullException("Missing InvalidSlug");
            var logPath = Path.Combine(AppContext.BaseDirectory, @"..\..\..\..\logs\test.log");
            logPath = Path.GetFullPath(logPath);

            Directory.CreateDirectory(Path.GetDirectoryName(logPath)!);

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
                builder.AddFile(logPath); // with Serilog.Extensions.Logging.File
            });
            _logger = loggerFactory.CreateLogger<JobOfferTests>();
            _logger.LogInformation("Logger initialized");

            _client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/136.0.0.0 Safari/537.36");
            _client.DefaultRequestHeaders.Add("X-Firebase-AppCheck", "app-check-token");

            // string response = _client.GetStringAsync(_baseUrl + slug).Result;
            // _job = JsonSerializer.Deserialize<JobPosition>(response);

            _job = JsonSerializer.Deserialize<JobPosition>(MockData.JsonMock);
        }

        /// <summary>
        /// Checking all the fields are present test
        /// </summary>
        [Test]
        public void All_Fields_Are_Present()
        {
            _logger.LogInformation("Checking presence of fields");
            var execLink = _job.ExecutiveUser?.Meta?.Href;
            var descLink = _job.PositionItems?.Meta?.Href;
            var place = _job.PlaceOfEmployment;

            Assert.Multiple(() =>
            {
                Assert.That(!string.IsNullOrWhiteSpace(descLink), "Missing job description link");
                Assert.That(place, Is.Not.Null, "Missing place of employment");

                Assert.That(place?.Name, Is.Not.Null.Or.Empty, "Missing location name");
                Assert.That(place?.State, Is.Not.Null.Or.Empty, "Missing location state");
                Assert.That(place?.City, Is.Not.Null.Or.Empty, "Missing location city");
                Assert.That(place?.StreetName, Is.Not.Null.Or.Empty, "Missing location street");
                Assert.That(place?.PostalCode, Is.Not.Null.Or.Empty, "Missing location postal code");

                Assert.That(!string.IsNullOrWhiteSpace(execLink), "Missing executiveUser link");
            });
        }

        /// <summary>
        /// Checking description is filled
        /// </summary>
        [Test]
        public void Description_IsFilled()
        {
            _logger.LogInformation("Checking description...");
            // string posItemsResponse = _client.GetStringAsync(_job.PositionItems.Meta.Href).Result;
            // var descriptionPage = JsonSerializer.Deserialize<JobDescriptionPage>(posItemsResponse);

            var descriptionPage = JsonSerializer.Deserialize<JobDescriptionPage>(MockData.JsonMockDescription);
            Assert.That(descriptionPage?.Items, Is.Not.Null);

            foreach (var item in descriptionPage.Items)
            {
                if (item.Type == 1)
                {
                    Assert.IsFalse(string.IsNullOrWhiteSpace(item.Content), "Description is empty");
                }
            }
        }

        /// <summary>
        /// Checking if suitable for students
        /// </summary>
        [Test]
        public void IsSuitableForStudents()
        {
            _logger.LogInformation("Checking student suitability...");
            Assert.That(_job.ForStudents, Is.True, "Job should be marked suitable for students.");
        }

        /// <summary>
        /// Checking place of employment is correct
        /// </summary>
        [Test]
        public void Place_of_employment_is_correct()
        {
            _logger?.LogInformation("Checking place of employment...");
            var place = _job.PlaceOfEmployment;

            Assert.Multiple(() =>
            {
                Assert.That(place?.Name, Is.EqualTo("Hall office park"));
                Assert.That(place?.State, Is.EqualTo("Česká republika"));
                Assert.That(place?.City, Is.EqualTo("Praha"));
                Assert.That(place?.StreetName, Is.EqualTo("U Pergamenky 2"));
                Assert.That(place?.PostalCode, Is.EqualTo("17000"));
            });
        }

        /// <summary>
        /// Checking executive info isValid
        /// </summary>
        [Test]
        public void Executive_Info_IsValid()
        {
            _logger?.LogInformation("Checking executiveUser...");
            // string execResponse = _client.GetStringAsync(_job.ExecutiveUser.Meta.Href).Result;
            // var boss = JsonSerializer.Deserialize<ExecutiveUserProfile>(execResponse);

            var boss = JsonSerializer.Deserialize<ExecutiveUserProfile>(MockData.JsonMockExec);

            Assert.That(boss, Is.Not.Null);
            Assert.That(boss?.Name, Is.EqualTo("Kozák Michal"));
            Assert.That(!string.IsNullOrWhiteSpace(boss?.Image), "Executive must have photo.");
            Assert.That(!string.IsNullOrWhiteSpace(boss?.Description), "Executive must have description.");
        }

        /// <summary>
        /// Checking 404 response on invalid job position url
        /// </summary>
        [Test]
        public void InvalidSlug_Returns404()
        {
            _logger?.LogInformation("Checking invalid slug...");
            var response = _client.GetAsync(_baseUrl + _invalidSlug).Result;
            Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.NotFound));
        }
    }
}