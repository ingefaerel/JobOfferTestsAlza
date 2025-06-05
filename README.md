# JobOfferTests Automated Test Suite

This repository contains an automated test suite for validating job advertisement data from Alza's career API. The tests are built using .NET 8 and NUnit, and designed to verify that every job posting includes all mandatory information.

## Project Goals

As a QA engineer, the goal is to automate validation of job ads to ensure each listing contains:

* Job **description**
* **Place** of employment
* Name of the **executive** (supervisor)
* Executive’s **photo** and **description**
* Whether the job is **suitable for students**

---

## Test Cases Implemented

1. `All_Fields_Are_Present` — Validates presence of all required fields.
2. `Description_IsFilled` — Confirms description is non-empty (via linked endpoint).
3. `IsSuitableForStudents` — Checks student suitability flag.
4. `Place_of_employment_is_correct` — Validates workplace address.
5. `Executive_Info_IsValid` — Asserts executive data and photo presence.
6. `InvalidSlug_Returns404` — Verifies 404 response for a bad job slug.

---

## About the Endpoint

Due to restrictions (403 errors likely caused by Cloudflare or origin header filtering), real-time API calls were not reliable, even with recommended headers. Therefore, **mock data** is used in tests, simulating responses from the following:

* Job detail endpoint
* Description sub-endpoint
* Executive metadata sub-endpoint

Mock data is located in the `MockData.cs`.

---

## Requirements

This project uses the following stack:

### .NET & Testing

* [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
* NUnit
* NUnit3TestAdapter
* Microsoft.NET.Test.Sdk

### Logging

* Microsoft.Extensions.Logging
* Serilog.Extensions.Logging.File — to log into a file.

### JSON

* Newtonsoft.Json (for `JObject` parsing)

### Logging Output Location

To make sure logs are saved in the **project root**, this line is used:

```csharp
string logPath = Path.Combine(AppContext.BaseDirectory, @"..\..\..\logs\test.log");
logPath = Path.GetFullPath(logPath);
```

This ensures that even when tests run from `bin/`, the folder `logs/` is created in the **project root**.

### Project File Setup (.csproj)

Ensure your `.csproj` contains:

```xml
<PropertyGroup>
  <TargetFramework>net8.0</TargetFramework>
  <GenerateDocumentationFile>true</GenerateDocumentationFile>
  <DocumentationFile>bin\Debug\net8.0\JobOfferTests.xml</DocumentationFile>
  <IsTestProject>true</IsTestProject>
</PropertyGroup>
```

---

## 📚 Documentation

Auto-generated using [DocFX](https://dotnet.github.io/docfx/):

### Steps:

1. Ensure `GenerateDocumentationFile` is set in your `.csproj`
2. Install DocFX globally:

```bash
dotnet tool install -g docfx
```

3. Run metadata and build:

```bash
docfx metadata
```

```bash
docfx build
```

4. Serve locally:

```bash
docfx serve _site
```

If the documentation appears empty:

* Ensure your test class is inside a `namespace`
* Confirm `.xml` docs are generated after build

---

## 🔧 Configuration

Update `appsettings.json` as needed:

```json
{
  "ApiBaseUrl": "https://webapi.alza.cz/api/career/v1/positions/",
  "JobSlug": "java-developer-/",
  "InvalidSlug": "invalid-slug",
  "LogFilePath": "logs/test.log"
}
```

This file is read by the test suite to configure URLs and log output.
