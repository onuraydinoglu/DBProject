# DbPROJECT

## Proje Özeti
Bu proje, öğrencilerin bootcamp'lere kayıt olabildiği ve yönetilebildiği bir web uygulamasıdır. Uygulama, temel CRUD işlemleri ile öğrenci ve bootcamp yönetimini sağlamaktadır. Eğitim amaçlı olarak tasarlanmış bu proje, temel web uygulama geliştirme becerilerini pekiştirmek için iyi bir örnek teşkil eder.

## Projenin Amacı
- Öğrenci kayıt yönetimi
- Bootcamp yönetimi
- Bootcamp kayıtlarının takibi

## Kullanılan Teknolojiler

### Web Teknolojileri:
- **ASP.NET Core MVC**: Web uygulama çatısı olarak kullanılmıştır.
- **MVC (Model-View-Controller)**: Uygulama mimarisi olarak uygulanmıştır.

### Veri Tabanı:
- **Entity Framework Core**: ORM (Object-Relational Mapping) aracı olarak kullanılmıştır.
- **SQLite**: Hafif ve hızlı veritabanı sistemi olarak entegre edilmiştir.

## Proje Yapısı

### Modeller (Models):
- **Ogrenci:**
  - `OgrenciId` (Primary Key)
  - `OgrenciAd`
  - `OgrenciSoyad`
  - `Eposta`
  - `Telefon`
- **Bootcamp:**
  - `BootcampId` (Primary Key)
  - `Baslik`
- **BootcampKayit:**
  - `KayitId` (Primary Key)
  - `OgrenciId` (Foreign Key)
  - `BootcampId` (Foreign Key)
  - `KayitTarihi`

### Kontrolcüler (Controllers):
- **HomeController:**
  - Temel sayfa yönlendirmeleri (Index, Privacy)
  - Hata yönetimi
- **OgrenciController:**
  - Öğrenci oluşturma işlemleri
  - `Create` metodu ile yeni öğrenci kaydı

### Görünümler (Views):
- **Home/Index.cshtml**: Ana sayfa görünümü
- **Home/Privacy.cshtml**: Gizlilik politikası sayfası
- **Ogrenci/Create.cshtml**: Öğrenci kayıt formu

## Kullanılan Design Patterns
- **Dependency Injection (DI):** Tüm bağımlılıkların yönetilmesi için kullanılmıştır.
- **Repository Pattern:** Veri erişim katmanı için kısmen uygulanmıştır.
- **MVC Pattern:** Uygulama genelinde uygulanmıştır.

## Özet
DbPROJECT, öğrencilerin bootcamp'lere kayıt olabildiği ve yönetilebildiği bir web uygulamasıdır. Uygulama temel CRUD işlemlerini kapsamakta olup, eğitim amaçlı bir proje olarak tasarlanmıştır. Gelecekte daha fazla özellik eklenerek genişletilebilir bir altyapıya sahiptir.
