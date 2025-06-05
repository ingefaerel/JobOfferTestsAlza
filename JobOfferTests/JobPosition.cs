using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JobOfferDataClasses
{
    public class JobPosition
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("seoName")]
        public string SeoName { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("workplace")]
        public string Workplace { get; set; }

        [JsonPropertyName("boardEstimation")]
        public object BoardEstimation { get; set; }

        [JsonPropertyName("level")]
        public object Level { get; set; }

        [JsonPropertyName("forStudents")]
        public bool ForStudents { get; set; }

        [JsonPropertyName("gestorUser")]
        public User GestorUser { get; set; }

        [JsonPropertyName("executiveUser")]
        public User ExecutiveUser { get; set; }

        [JsonPropertyName("people")]
        public MetaContainer People { get; set; }

        [JsonPropertyName("positionItems")]
        public MetaContainer PositionItems { get; set; }

        [JsonPropertyName("relatedPositions")]
        public MetaContainer RelatedPositions { get; set; }

        [JsonPropertyName("hreflangs")]
        public List<Hreflang> Hreflangs { get; set; }

        [JsonPropertyName("placeOfEmployment")]
        public PlaceOfEmployment PlaceOfEmployment { get; set; }

        [JsonPropertyName("department")]
        public Department Department { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    public class User
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    public class MetaContainer
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    public class Meta
    {
        [JsonPropertyName("href")]
        public string Href { get; set; }

        [JsonPropertyName("rel")]
        public List<string> Rel { get; set; }
    }

    public class Hreflang
    {
        [JsonPropertyName("languageCode")]
        public string LanguageCode { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class PlaceOfEmployment
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public object Description { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("streetName")]
        public string StreetName { get; set; }

        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }
    }

    public class Department
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("seoName")]
        public string SeoName { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    public class ExecutiveUserProfile
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("linkedInUrl")]
        public string LinkedInUrl { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    public class JobDescriptionPage
    {
        [JsonPropertyName("paging")]
        public Paging Paging { get; set; }

        [JsonPropertyName("items")]
        public List<JobDescriptionItem> Items { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    public class Paging
    {
        [JsonPropertyName("offset")]
        public int Offset { get; set; }

        [JsonPropertyName("limit")]
        public int Limit { get; set; }

        [JsonPropertyName("size")]
        public int Size { get; set; }

        [JsonPropertyName("first")]
        public FirstPage First { get; set; }
    }

    public class FirstPage
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    public class JobDescriptionItem
    {
        [JsonPropertyName("text")]
        public string? Text { get; set; }

        [JsonPropertyName("label")]
        public string? Label { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("subContent")]
        public List<string> SubContent { get; set; }

        [JsonPropertyName("type")]
        public int Type { get; set; }
    }
}