using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOfferData
{
    public class MockData
    {
        public const string JsonMock = @"{
    ""name"": ""Java Developer"",
    ""seoName"": ""java-developer-"",
    ""url"": ""/kariera/pozice/java-developer-"",
    ""workplace"": ""ČR"",
    ""boardEstimation"": null,
    ""level"": null,
    ""forStudents"": false,
    ""gestorUser"": {
        ""meta"": {
            ""href"": ""https://webapi.alza.cz/api/career/v1/employees/32385"",
            ""rel"": [
                ""subs"",
                ""self""
            ]
        }
    },
    ""executiveUser"": {
        ""meta"": {
            ""href"": ""https://webapi.alza.cz/api/career/v1/employees/59484"",
            ""rel"": [
                ""subs"",
                ""self""
            ]
        }
    },
    ""people"": {
        ""meta"": {
            ""href"": ""https://webapi.alza.cz/api/career/v1/employees?jobPositionId=3279"",
            ""rel"": [
                ""subs"",
                ""self"",
                ""collection""
            ]
        }
    },
    ""positionItems"": {
        ""meta"": {
            ""href"": ""https://webapi.alza.cz/api/career/v1/positions/java-developer-/items"",
            ""rel"": [
                ""subs"",
                ""self"",
                ""collection""
            ]
        }
    },
    ""relatedPositions"": {
        ""meta"": {
            ""href"": ""https://webapi.alza.cz/api/career/v2/positions/it-development"",
            ""rel"": [
                ""parent""
            ]
        }
    },
    ""hreflangs"": [
        {
            ""languageCode"": ""cs-CZ"",
            ""url"": ""alza.cz/kariera/pozice/java-developer-""
        }
    ],
    ""placeOfEmployment"": {
        ""name"": ""Hall office park"",
        ""description"": null,
        ""state"": ""Česká republika"",
        ""city"": ""Praha"",
        ""streetName"": ""U Pergamenky 2"",
        ""postalCode"": ""17000"",
        ""latitude"": 50.108450000,
        ""longitude"": 14.452610000
    },
    ""department"": {
        ""name"": ""IT"",
        ""seoName"": ""it"",
        ""url"": ""/kariera/oddeleni/it"",
        ""meta"": {
            ""href"": ""https://webapi.alza.cz/api/career/v2/departments/it"",
            ""rel"": [
                ""subs"",
                ""self""
            ]
        }
    },
    ""meta"": {
        ""href"": ""https://webapi.alza.cz/api/career/v2/positions/java-developer-"",
        ""rel"": [
            ""self""
        ]
    }
}";
        public const string JsonMockExec = @"{
  ""name"": ""Kozák Michal"",
  ""image"": ""https://cdn.alza.cz/foto/JobPositions/orig/329a7370-c034-4f0a-b011-09cfd59b71ef.jpg"",
  ""description"": ""Začínal jsem jako programátor a vyzkoušel jsem hodně jazyků a technologií. Do Alzy jsem nastoupil do pozice team leadera nově vznikající platformy. Vybudoval jsem nový, báječný tým a společně stavíme budoucnost Alzy. Zastávám myšlenku týmové přístupu. Všichni (i já) jsme na stejné lodi, sdílíme společně úspěchy i pády. Já tým netlačím, ale umožňuji mu pracovat a rozhodovat se, abychom dosáhli potřebných cílů.\r\nVelmi rád čtu - sci-fi i fantasy, rád si zahraji deskovky a ve zbylém volném času zkoumám nové technologie."",
  ""linkedInUrl"": ""https://www.linkedin.com/in/michal-koz%C3%A1k-03093463/"",
  ""meta"": {
    ""href"": ""https://webapi.alza.cz/api/career/v1/employees/59484"",
    ""rel"": [
      ""self""
    ]
}
}";
        public const string JsonMockDescription = @"{
  ""paging"": {
    ""offset"": 0,
    ""limit"": 20,
    ""size"": 6,
    ""first"": {
      ""meta"": {
        ""href"": ""https://webapi.alza.cz/api/career/v1/positions/java-developer-/items?limit=20"",
        ""rel"": [
          ""first""
        ]
      }
    }
  },
  ""items"": [
    {
      ""text"": null,
      ""label"": null,
      ""content"": ""\u003Cp style=\""margin: 0cm 0cm 8pt; line-height: 107%; font-size: 15px; font-family: Calibri, sans-serif; text-align: center;\""\u003E\u003Cspan style=\""font-size:16px;line-height:107%;\""\u003EV&nbsp;našem vlastním IS pracuje celá firma – od skladů, přes kanceláře až po naše pobočky. Našimi zákazníky jsou všichni zaměstnanci, všechna oddělení Alzy.\u003C/span\u003E\u003C/p\u003E\u003Cp style=\""margin: 0cm 0cm 8pt; line-height: 107%; font-size: 15px; font-family: Calibri, sans-serif; text-align: center;\""\u003E\u003Cspan style=\""font-size:16px;line-height:107%;\""\u003EVývojem modulů, aplikací na míru a dalšími projekty se snažíme zefektivnit a řešit problémy businessu a usnadnit kolegům jejich práci.\u003C/span\u003E\u003C/p\u003E\u003Cp style=\""margin: 0cm 0cm 8.25pt; line-height: 105%; font-size: 15px; font-family: Calibri, sans-serif; text-align: center;\""\u003E\u003Cspan style=\""font-size:16px;line-height:105%;\""\u003ENyní do našeho ERP core týmu&nbsp;\u003Cstrong\u003Ehledáme zkušeného, aktivně programujícího javistu\u003C/strong\u003E (3+ let) se znalostí moderních trendů jazyka včetně standardních knihoven, ideálně se zájmem o alternativní JVM jazyky.\u003C/span\u003E\u003C/p\u003E\u003Cp style=\""margin: 0cm 0cm 8.25pt; line-height: 105%; font-size: 15px; font-family: Calibri, sans-serif; text-align: center;\""\u003E\u003Cspan style=\""font-size:16px;line-height:105%;\""\u003E\u003Cstrong\u003ENěkoho, kdo rád buduje, komplexně tvoří a také dále realizuje.&nbsp;\u003C/strong\u003E\u003C/span\u003E\u003C/p\u003E\u003Cp style=\""margin: 0cm 0cm 8.25pt; line-height: 105%; font-size: 15px; font-family: Calibri, sans-serif; text-align: center;\""\u003E\u003Cspan style=\""font-size:16px;line-height:105%;\""\u003EChceme Java Developera s vlastními názory, schopného samostatně uvažovat, navrhovat vhodná řešení, volit správné technologie a framework.\u003C/span\u003E\u003C/p\u003E"",
      ""subContent"": [],
      ""type"": 1
    },
    {
      ""text"": null,
      ""label"": ""Na co se u nás může Java Developer těšit?"",
      ""content"": ""fa-align-justify"",
      ""subContent"": [
        ""Práce v menším týmu zkušených profesionálů na klíčovém ERP projektu - vytváříme zde platformu pro ostatní vývojáře"",
        ""Jedeme v agilní metodice (škálovaný scrum), využíváme domain driven design a microservices architekturu"",
        ""Velká podpora a fungující spolupráce s DevOps""
      ],
      ""type"": 3
    },
    {
      ""text"": null,
      ""label"": ""S jakými technologiemi pracujeme?"",
      ""content"": ""fa-align-justify"",
      ""subContent"": [
        ""Spring Boot"",
        ""Apache Kafka"",
        ""K8s"",
        ""Debezium"",
        ""Git"",
        ""ElasticSearch""
      ],
      ""type"": 3
    },
    {
      ""text"": null,
      ""label"": ""Jaký má u nás Java Developer být?"",
      ""content"": ""fa-align-justify"",
      ""subContent"": [
        ""Zkušený, aktivně programující v Java (Java 8+) se znalostí moderních trendů jazyka včetně standardních knihoven."",
        ""Zná Spring Boot"",
        ""Zvyklý aktivně hledat cesty, překonávat překážky a čelit výzvám."",
        ""Schopný aktivně spolupracovat v teamu s dalšími developery, analytiky a testery."",
        ""S angličtinou – mluvíme česky, ale určitě je potřeba umět číst a psát technickou dokumentaci i v angličtině (mluvit tě v případě potřeby doučíme, od toho tu máme jazykové kurzy)""
      ],
      ""type"": 3
    },
    {
      ""text"": null,
      ""label"": ""Plusy navíc jsou:"",
      ""content"": ""fa-align-justify"",
      ""subContent"": [
        ""Groovy - Spock based unit tests"",
        ""Typescript"",
        ""C#""
      ],
      ""type"": 3
    },
    {
      ""text"": null,
      ""label"": ""Co za to nabízíme?"",
      ""content"": ""fa-align-justify"",
      ""subContent"": [
        ""Zaměstnanecké slevy na celý sortiment Alzy. Takže od elektroniky, přes sekačky až po sprchový gel. A možnost vyzvednutí objednávky přímo v AlzaBoxu v kancelářích."",
        ""Máme Multisportku, jazykové vzdělávání od jazykovky na míru, stravenky a další benefity"",
        ""Zcela nové kanceláře a moderní zázemí. Navíc v našich prostorách najdeš pro posílení Tvé fyzičky posilovnu, pro relax solnou jeskyni, pro protažení těla lezeckou stěnu a pro pobavení s kolegy stolní fotbálek či playstation."",
        ""Možnost HPP i externí spolupráce""
      ],
      ""type"": 3
    }
  ],
  ""meta"": {
    ""href"": ""https://webapi.alza.cz/api/career/v1/positions/java-developer-/items?limit=20"",
    ""rel"": [
      ""self"",
      ""collection""
    ]
  }
}";
    }


}
