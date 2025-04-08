MyArrayList - C# ile Özelleştirilmiş ArrayList Sınıfı

Bu proje, BMU260 Nesne Tabanlı Programlama dersi kapsamında verilen "ArrayList Tasarımı" ödevi için geliştirilmiştir. Proje, C# dilinde nesne yönelimli programlama prensipleriyle yazılmıştır.

🎯 Proje Amacı

Kendi `ArrayList` veri yapımızı oluşturarak;

- Nesne tabanlı programlamayı uygulamak
- Kapsülleme (encapsulation) ilkelerini kullanmak
- Dinamik dizi yapısını öğrenmek

amaçlanmıştır.

---

🔧 Kullanılan Teknolojiler

- 👨‍💻 Programlama Dili: **C#**
- 💻 Platform: **.NET Core Console App**
- 🧱 Geliştirme Ortamı: **Visual Studio**

---

 🛠️ Sınıf Özellikleri (`MyArrayList.cs`)

| Metot / Özellik         | Açıklama                                                                 |
|-------------------------|--------------------------------------------------------------------------|
| `Add(object item)`      | Yeni bir öğeyi sona ekler.                                               |
| `Insert(int index, object item)` | Belirtilen konuma öğe ekler, diğerlerini sağa kaydırır.              |
| `RemoveAt(int index)`   | Belirtilen indeksteki öğeyi siler.                                      |
| `Get(int index)`        | İstenen indeksteki öğeyi döndürür.                                      |
| `Count` (özellik)       | Listedeki eleman sayısını verir.                                        |
| `ToString()`            | Listedeki öğeleri virgül ile ayrılmış string olarak döndürür.           |
| 🔄 Dinamik kapasite     | Dizi dolduğunda kapasite otomatik olarak 2 katına çıkarılır.             |

---

 Nesne Tabanlı Yapı ve Kapsülleme

- `object[] items`, `int count`, `int capacity` gibi alanlar `private` olarak tanımlanmıştır.
- Dışarıdan erişim `public` metotlar aracılığıyla kontrollü şekilde yapılır.
- Bu, **encapsulation (kapsülleme)** ilkesine uygun bir tasarımdır.

---

 Başlangıç Ayarları

- Başlangıç kapasitesi: `4`
- Veriler `object[]` dizisi içinde tutulur.
- Dizi kapasitesi dolunca otomatik olarak 2 katına çıkarılır.

---

 Örnek Kullanım

csharp
MyArrayList list = new MyArrayList();

list.Add("Ali");
list.Add("Enver");
list.Add(42);
list.Insert(1, "Fırat");

Console.WriteLine(list.ToString()); // Ali, Fırat, Enver, 42

list.RemoveAt(2);
Console.WriteLine(list.ToString()); // Ali, Fırat

Console.WriteLine(list.Get(1));     // Fırat
Console.WriteLine(list.Count);      // 2



----------------Geliştiren---------------------------
Ad Soyad: Ali Nebi ER 

Öğrenci No : 230260152

Okul: Fırat Üniversitesi

Bölüm: Bilgisayar Mühendisliği

Ders: BMU260 Nesne Tabanlı Programlama
