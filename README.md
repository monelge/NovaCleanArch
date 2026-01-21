# NovaCleanArch (NovaCore)

Katmanlı ve paketlenebilir bir Nova çekirdek seti ile örnek StarterProject uygulamasını içerir. Tüm paketler `src/corePackages` altında bağımsız NuGet/kitaplık olarak tasarlanmış, `src/starterProject` ise uygulama katmanlarını (Domain, Application, Persistence, Infrastructure, WebAPI) gösterir.

## Çözüm yapısı
- **NovaCore.sln** – Tüm projelerin çözümü.
- **src/corePackages/** – Yeniden kullanılabilir çekirdek paketleri.
- **src/starterProject/** – Örnek uygulama katmanları.
- **tests/StarterProject.Application.Tests/** – Uygulama testi paketi.

## Çekirdek paketler (src/corePackages)
- **Core.Application** – CQRS altyapısı, davranışlar (pipeline), bağımlılık ekleme yardımcıları.
- **Core.CrossCuttingConcerns.Exception** – Ortak exception türleri ve yardımcıları.
- **Core.CrossCuttingConcerns.Exception.WebAPI** – ASP.NET Web API için global exception/response altyapısı.
- **Core.CrossCuttingConcerns.Logging.Abstraction** – Logging arayüzleri.
- **Core.CrossCuttingConcerns.Logging** – Temel logging implementasyonları.
- **Core.CrossCuttingConcerns.Logging.DependencyInjection** – Logging için DI kayıtları.
- **Core.CrossCuttingConcerns.Logging.Serilog / Serilog.File** – Serilog ve dosya logging entegrasyonları.
- **Core.ElasticSearch** – Elasticsearch entegrasyon katmanı.
- **Core.Localization.Abstraction / Localization.Resource.Yaml / Localization.Resource.Yaml.DependencyInjection / Localization.WebApi / Localization.Translation** – Lokalizasyon sözleşmeleri, YAML kaynak sağlayıcıları ve WebAPI entegrasyonu.
- **Core.Mailing / Core.Mailing.MailKit** – E-posta sözleşmeleri ve MailKit tabanlı gönderim.
- **Core.Persistence** – EF Core tabanlı repository, transaction ve unit of work altyapısı.
- **Core.Persistence.DependencyInjection / Core.Persistence.WebApi** – Persistence DI kayıtları ve WebAPI yardımcıları.
- **Core.Security** – Kimlik, token, kullanıcı/roller, yetkilendirme bileşenleri.
- **Core.Security.DependencyInjection / Core.Security.WebApi.Swagger** – Güvenlik DI kayıtları ve swagger/jwt entegrasyonları.
- **Core.Test** – Testler için base sınıflar, faker/seed yardımcıları.
- **Core.Translation.Abstraction / Core.Translation.AmazonTranslate / Core.Translation.AmazonTranslate.DependencyInjection** – Çeviri sözleşmeleri, Amazon Translate entegrasyonu ve DI kayıtları.

## StarterProject (src/starterProject)
- **Domain** – Temel varlıklar ve değer nesneleri.
- **Application** – Use case’ler, komut/sorgular, validasyon, iş kuralları.
- **Persistence** – EF Core context, konfigürasyonlar ve repository uygulamaları.
- **Infrastructure** – Harici servis adaptörleri ve altyapı implementasyonları.
- **WebAPI** – API uçları, middleware, DI kompozisyonu.

## Testler
- **tests/StarterProject.Application.Tests** – Uygulama katmanı için birim/entegrasyon testleri ve sahte veri/depolar.

## Derleme ve çalıştırma
```bash
dotnet restore NovaCore.sln
dotnet build NovaCore.sln
# Testler
dotnet test tests/StarterProject.Application.Tests/StarterProject.Application.Tests.csproj
```

## Notlar
- Tüm paket adları `Nova.*` namespace’i ile hizalanmıştır.
- StarterProject, corePackages üzerinde proje referanslarıyla çalışır; NuGet paket referansı gerekmez.
