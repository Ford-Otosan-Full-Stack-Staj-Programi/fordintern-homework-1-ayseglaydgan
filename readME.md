Asagida Verilen Modeli Kullanarak CRUD Islemleri Gerceklestiren Bir Controller
Bu proje, Asagida verilen modeli kullanarak GetAll, GetById, Put, Post, Delete methodlarini iceren bir controllerin gelistirilmesini aciklar. EF ile generic repository ve UnitOfWork kullanmak istege baglidir. Put ve Post API'lerinde model validasyonu hazirlanmalidir. Bunun icin Fluent validation kullanilabilir. Ayni zamanda, Query parameterlere gore filtreleme yapan iki Filter API'si eklenmistir. (GET) ve WHERE sarti ile database den filtreleme yapilmaktadir.

Proje, SOLID prensiplerine uymaya ozen gosterir. Kullanilmayan controller ve methodlar projeye dahil edilmez. Projenin odak noktasi, asagida belirtilen gereksinimleri karsilamaktir.

Gereksinimler
Asagida verilen bir model kullanilarak bir controller gelistirilmelidir.
Controller, GetAll, GetById, Put, Post, ve Delete methodlarini icerir.
EF ile generic repository ve UnitOfWork kullanmak istege baglidir.
Put ve Post API'lerinde model validasyonu yapilmalidir. Bu icin Fluent validation kullanabilirsiniz.
Query parametrelere gore filtreleme yapan iki Filter API'si eklenmistir. (GET) ve WHERE sarti ile database den filtreleme yapilmaktadir.
Proje, SOLID prensiplerine uymaya ozen gosterir.
Kullanilmayan controller ve methodlar projeye dahil edilmez.
Kurulum
Projenin calistirilabilmesi icin gereksinimler asagidaki gibidir:

.NET 5.0
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.Tools
FluentValidation
Projenin calistirilmasi icin asagidaki adimlar izlenmelidir:

Repository'yi kopyalayin.
Proje klasorunde terminali acin.
dotnet restore komutunu calistirin.
dotnet run komutunu calistirin.
Kullanim
API, REST mimarisini kullandigi icin, HTTP istekleri kullanilarak calistirilabilir. Asagidaki methodlar desteklenmektedir:
*Not: PROJE ICINDE ÖRNEK OLARAK "STAFF" ŞEKLİNDE ADLANDIRILAN CLASS YAPISI "PERSON" OLARAK DEĞİŞTİRİLMİŞ VE O ŞEKİLDE KULLANILMIŞTIR.
 
                                public class Staff 
                                   {
                                   public int Id { get; set; }
                                   public string CreatedBy { get; set; }
                                   public DateTime CreatedAt { get; set; }
                                   public string FirstName { get; set; }
                                   public string LastName { get; set; }
                                   public string Email { get; set; }
                                   public string Phone { get; set; }
                                   public DateTime DateOfBirth { get; set; }
                                   public string AddressLine1 { get; set; }
                                   public string City { get; set; }
                                   public string Country { get; set; }
                                   public string Province { get; set; }
                                   [NotMapped]
                                   public string FullName
                                   {
                                       get { return FirstName +   + LastName; }
                                   }
                                }

Ödevinizin teslim tarihi 24.03.2023 saat 23.59

