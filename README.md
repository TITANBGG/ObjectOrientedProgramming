# ObjectOrientedProgramming
# 🧠 MyArrayList – Dynamic, Object-Oriented ArrayList Implementation in C#

> 🌐 **Language:** C# (.NET Core)  
> 🎓 **Course:** BMU260 - Object-Oriented Programming  
> 👨‍💻 **Developer:** Ali – Firat University, Computer Engineering  
> 🧪 **Goal:** To design a fully custom dynamic ArrayList class using object-oriented principles

---

### 📌 Project Overview

This project is a from-scratch implementation of a simplified version of the classic `ArrayList` data structure. It's written entirely in C# using an internal `object[]` array and follows solid object-oriented programming design.

**Key Features:**

- 🔄 **Auto-resizing**: Capacity doubles automatically when full  
- 🧱 **Encapsulation**: Private fields, public accessors  
- ➕ `Add`, `Insert`, `RemoveAt`, `Get`, `Count`, and `ToString()` methods implemented  
- 🧼 Minimalist and efficient: No external libraries used  
- 🖥️ Designed and tested as a .NET Core Console Application

---

### 🎯 Why I Built This Project

> "A real engineer builds their own tools."

With this project, I challenged myself to:
- Understand the foundations of **OOP** beyond using built-in collections  
- Practice manual memory management by expanding arrays dynamically  
- Strengthen my understanding of low-level data structures  
- Build confidence in implementing core concepts without external dependencies

---

### 💡 Sample Usage

```csharp
MyArrayList list = new MyArrayList();
list.Add("Ali");
list.Add("Enver");
list.Insert(1, "Firat");
list.RemoveAt(2);
Console.WriteLine(list.ToString()); // Ali, Firat


# 🧠 MyArrayList - C# ile Dinamik, Nesne Tabanlı ArrayList Tasarımı

> 🌍 **Language:** C# (.NET Core)  
> 🏫 **Ders:** BMU260 - Nesne Tabanlı Programlama  
> 👨‍💻 **Geliştirici:** Ali – Fırat Üniversitesi, Bilgisayar Mühendisliği  
> 🧪 **Amaç:** OOP prensiplerine uygun, sıfırdan dinamik bir ArrayList sınıfı yazmak

---

### 📌 Kısaca Proje

Bu proje, klasik `ArrayList` yapısının tüm temel işlevlerini kendi başına gerçekleştiren, tamamen `object[]` dizisi kullanılarak yazılmış **özelleştirilmiş bir veri yapısı**dır. 👇

- 🔄 **Dinamik olarak genişleyen kapasite**
- 🧱 **Kapsülleme (Encapsulation)** prensibine tam uyum
- ➕ `Add`, `Insert`, `RemoveAt`, `Get`, `Count`, `ToString()` gibi temel metodlar
- 📈 Verimli ve temiz yapı: gereksiz kütüphane ya da sınıf kullanılmadı
- 🚀 .NET Core Console App olarak tasarlandı, test edildi ve çalışıyor ✅

---

### 🎯 Neden Bu Projeyi Yaptım?

> “Gerçek mühendis, kendi aracını kendi yapar!”  
> Bu projeyle .NET dünyasında kendi `ArrayList` sınıfımı yazarak:
>
> - OOP (Nesne Tabanlı Programlama) prensiplerini derinlemesine anladım  
> - Kendi veri yapımı sıfırdan oluşturmanın keyfini yaşadım  
> - Dinamik bellek yönetimi, dizi genişletme gibi konularda tecrübe kazandım  
> - Gerçek dünya projelerine sağlam bir temel attım 🚀

---

### 💡 Kullanım Örneği

```csharp
MyArrayList list = new MyArrayList();
list.Add("Ali");
list.Add("Enver");
list.Insert(1, "Fırat");
list.RemoveAt(2);
Console.WriteLine(list.ToString()); // Ali, Fırat

