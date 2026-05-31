# 📖 Sözlükhane

Sözlükhane, C# programlama dili ve gelişmiş ilişkisel veritabanı (SQL) mimarileri kullanılarak geliştirilen, geniş kelime dağarcığına sahip, performans odaklı bir dijital sözlük projesidir.

Proje, özellikle büyük ölçekli SQL veri setleri üzerinde hızlı arama, indeksleme ve sorgulama optimizasyonlarını pratik etmek amacıyla modüler bir yapıda kurgulanmaktadır.

---

## 🚀 Planlanan Özellikler

*   **Hızlı ve Esnek Arama:** Kelimeleri yazmaya başladığınız andan itibaren (Autocomplete/Anlık arama) milisaniyeler içinde sonuç getirme.
*   **Gelişmiş Filtreleme:** Kelime türüne (isim, fiil, sıfat vb.), kökene veya kullanım alanına göre kelime filtreleme.
*   **Geniş SQL Veri Seti Entegrasyonu:** Binlerce kelime ve tanımı performans kaybı yaşamadan yönetebilen ilişkisel veritabanı altyapısı.
*   **Favoriler & Geçmiş Paneli:** Kullanıcıların sıkça baktığı kelimeleri kaydedebileceği ve arama geçmişini görebileceği yerel depolama mekanizması.
*   **Günün Kelimesi:** Kullanıcıların kelime dağarcığını zenginleştirmek amacıyla her gün ana sayfada rastgele/özel bir kelime gösterimi.

---

## 🛠 Mimari ve Teknolojiler

*   **Dil:** C# (.NET)
*   **Veritabanı:** Microsoft SQL Server (T-SQL, Stored Procedures ve İndeksleme Yapıları)
*   **Veri Erişim Katmanı:** ADO.NET veya Entity Framework (Mimarinin olgunlaşma sürecine göre optimize edilecektir)

---

## 📂 Proje Yapısı

```text
Sözlükhane/
├── Sözlükhane.sln         # Proje çözüm (Solution) dosyası
└── Sözlükhane/
    ├── Sözlükhane.csproj  # C# Proje konfigürasyon dosyası
    ├── Data/              # SQL bağlantı sınıfları ve scriptleri (Planlanan)
    ├── Models/            # Kelime ve Kategori veri modelleri (Planlanan)
    └── Views/             # Kullanıcı arayüzü bileşenleri (Planlanan)
