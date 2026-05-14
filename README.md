# ASP.NET Core MVC - Duzce University CE308 Web Programming Lecture Notes

# Git History

## 1 ve 2. Haftalar -> [a10db21fbc664009099f0742ec88fcc340451430](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/a10db21fbc664009099f0742ec88fcc340451430)

### Controllers/FirstController.cs

### Controllers/HomeController.cs

### Controllers/ExampleController.cs
  pageWithOutLayout kullanımı ?

### Models/Product.cs
  sadece .cs dosyası oluşurulmuş henüz attribute'ler (db de column karşılıkları) tanımlanmamış.



### Views/Example/Index.cshtml

Example index inin layout sayfası *ExampleLayout* dur.

**Exaample/Index.cshtml içinde @section tanımları**

<img width="516" height="446" alt="{3D443994-6504-41FD-8593-6D53B7C7F338}" src="https://github.com/user-attachments/assets/5664bb1b-23b2-4825-bc22-576189a75605" />

**Bu tanımların example ın ilgili layout sayfasında (ExampleLayout) tanımlanması**
<img width="920" height="944" alt="{F80B2003-856E-4916-B800-569FFD17099F}" src="https://github.com/user-attachments/assets/aa5278ee-ec04-4eef-a999-89646e3184b0" />

**required:True** olursa Index.cshtml de sectionlar tanımlanmazsa hata verir.



### Views/First/Index.cshtml
First index inin layout sayfası zaten default olan *_layout* dur.

**First/Index.cshtml içinde @section tanımları**

<img width="976" height="793" alt="{2A547FD8-4CB8-40B7-B96D-40EE430721EB}" src="https://github.com/user-attachments/assets/074382bf-686e-493c-b9bc-add59d8ce203" />

**_Layout da tanımlanmaları**

**CSS**
<img width="893" height="290" alt="{896D9987-EF91-446D-9BAE-33793936F614}" src="https://github.com/user-attachments/assets/ccef2b32-3370-4879-81fd-1c1837c687af" />

**JS**

<img width="828" height="112" alt="{204A0724-C9AD-4205-B5A1-6EAB0705CF31}" src="https://github.com/user-attachments/assets/751dc9bc-d548-4481-bc41-d4f6045e2f51" />






### Program.cs
  MapControllerRoute önemli !! proje çalıştırıldığında ilk olarak açılacak sayfayı belirtir.
  `pattern: "{controller=Home}/{action=Index}/{id?}"`

## 3.hafta 
**3.hafta Commitleri sırasıyla:**
1) ProductRepository e Add ve Remove işlemlerini ekle -> [d1686cfc209d71f9015825547c61ddc30b37e3a8](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/d1686cfc209d71f9015825547c61ddc30b37e3a8)
2) ProductRepository e Update işlemini ekle -> [e99809be0b85b0e09d0db58a6af0e0708ad3b29a](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/e99809be0b85b0e09d0db58a6af0e0708ad3b29a)
3) Controllers/ProductController ile Controller bağlantısı sağla ve Views/Product/Index.cshtml de göster -> [9bb1d627c9fec8a19322e11d335407a02c061e57](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/9bb1d627c9fec8a19322e11d335407a02c061e57)
4) Productları Views/Product/Index.cshtml sayfasında göster ->  [43fee5a8529baae6b5aa444e8d178956e49f712a](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/43fee5a8529baae6b5aa444e8d178956e49f712a)

### Models/Product.cs

Product nesnesinin tanımlanması


### Models/ProductRepository.cs

**Temel CRUD işlemleri => Add, Remove  ve Update**

Henüz db kurmadığımız için productlarımızı depolayabileceğimiz bir repository oluşturup bu repository üzerinden CRUD işlemlerini gerçekleştiriyoruz.


### Controllers/ProductController.cs

Models/ProductReporsitory.cs de oluşturduğumuz repository nesnesinin bir değişkenini tanımlıyoruz. Controller dosyalarının içinde asıl crud işlemleri gerçekleşir. 

### Views/Product/Index.cshtml


<img width="443" height="592" alt="{48F7BAA8-1DA9-424B-A2D8-5BD488F5039D}" src="https://github.com/user-attachments/assets/ce7d2a32-0f8e-4c39-a23e-8c51af875be4" />


* `@model List<Product>` ile product repository de ki listemizi index sayfası için karşılıyoruz/tanımlıyoruz.

* Foreach döngüsü tanımında ki Model in 'M' si büyük olmalı.


## 4.hafta

1) Views/Product/Index.cshtml de tag helper ile tag içi controller ve action tanımlama -> [ddbf43b600af0efc90f233cd2d0289eb9741c45a](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/ddbf43b600af0efc90f233cd2d0289eb9741c45a)
2) Views/Product/ klasörüne Add ve Update işlemleri için Add ve Update sayfalarını ekle. -> [66a06417cb1421122cd674bee1f0c458ffbbf856](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/66a06417cb1421122cd674bee1f0c458ffbbf856)
<img width="603" height="965" alt="{98F381D6-38AB-421A-8D64-86A41FC077FE}" src="https://github.com/user-attachments/assets/ca67c1c9-c2fe-4679-bdbb-1b7016b263ed" />

### Veri Tabanı İşlemleri

#### SQL Connection String alma ve appsettings.json a ekleme

**`Ctrl + Shift + P`** ye basıp **"sql server object explorer"** şeklinde arat. Kurduğun sql serverin üstüne sağ tıkla **Özelliklere** bas. **General** sekmesinin altında **Connection String** belirtilmiş. O nu al **appsettings.json** da şu şekilde belirt:

<img width="636" height="221" alt="{44F86B51-2235-4F81-AA61-1FB7097EBBA7}" src="https://github.com/user-attachments/assets/d96fbe20-3305-49ce-80d0-a0d47bb62887" />



3) models içinde AppDbContext.cs oluştur -> [4c09d8238055c53e956147de2b0aa33161974235](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/4c09d8238055c53e956147de2b0aa33161974235)
4) ProductController da ki CRUD işlemlerini SQL Server Db ye göre ayarla -> [7dc2516f356ca0da8f8f38f1dc1edc3a706eeb29](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/7dc2516f356ca0da8f8f38f1dc1edc3a706eeb29)

Controller da `private AppDbContext _context;` context tanımla. CRUD fonksiyonlarına parametre olarak ver. 

5) Program.cs e veritabanı servisini ekle -> [1a0255847004c364ad7505093490fb8d2f52695a](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/1a0255847004c364ad7505093490fb8d2f52695a)

6) Daha önce oluşturulan AppDbContext.cs e db yi tanıt -> [6c48fd8dffed36e7508d174e30ca56193e2b625b](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/6c48fd8dffed36e7508d174e30ca56193e2b625b)



## 5.hafta
1) Models/Product.cs de yeni sütunları tanımla ve View/Product/Index sayfasında göster -> [a4240b74b283b69f13e2c5134b0f63268da07811](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/a4240b74b283b69f13e2c5134b0f63268da07811)

2) Migration Oluşturma

1) code-first yaklaşımını uygulamak için sqlserver da olan db yi sil(varsa) direkt `add-migration initial` ile migration oluştur **migration/** sekmesinde kodlar oluşacak.

2) projeye gel, navigasyondan **Araçlar -> NuGet Paket Yöneticisi -> Paket Yöneticisi** Konsolu nu bul. Ardından açılan konsolda `add-migration initial` yaz ve ilk migration u ekle. Migration sistemi gite benzer çalışır. Git nasıl ki projeyi versiyonlara bölerek takibini ve olası bir hata da geri dönüşü sağlıyorsa migration sistemi de db lerde bu ihtiyacı karşılar. `add-migration` diyerek bir nevi db yi commit ediyoruz. Push lamak için, yani değişikliklerimizin db de gözükmesi için, `update-database` komutunu yaz. Eğer hata olduğunu düşünüyorsan pushlamadan önce `remove-migration` şeklinde en son ki migration u silebilir bir önceki migration a dönebilirsin.**


* `add-migration` // migration oluşturur
   
* `remove-migration` // db yansıtılmamış en son eklenen migration'ı siler (elle silme bunu kullan)
   
* `update-database` // migration'ları veritabanına uygular
   
* `script-migration` // migration'ları sql script olarak verir
      
* `update-database -migration:initial` // initial migration'ına geri dön
      
* `update-database 0` // komple silme


## 6.hafta Product Add Page

#### **2 yöntemi var: Uzun yöntem ve Kısa yöntem**

##### Uzun yöntem -> [aefd43e3c7ff5709c1ef4616ba61efea7d00f826](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/aefd43e3c7ff5709c1ef4616ba61efea7d00f826)

##### Kısa yöntem (Model Binding) -> [4fbc01a368fe85c55bd16575804e9674610968e0](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/4fbc01a368fe85c55bd16575804e9674610968e0)


#### Kullanıcıya uyaru mesajları gönderme -> [f04851c7ee9fa40e3117384359efd46b55b64135](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/f04851c7ee9fa40e3117384359efd46b55b64135)
<img width="977" height="984" alt="{19A7684B-B79C-422D-A028-F53E6B890BE6}" src="https://github.com/user-attachments/assets/8c37ad23-d768-4213-9b61-4498cff89a33" />



## 7.hafta -> Product a yeni attributelar ekle: isPublished, Expire, PublishedDate. View da göster. Product add page i düzenle. -> [a96c8cb1cddadf7b9bfce3210d443540ccd9598d](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/a96c8cb1cddadf7b9bfce3210d443540ccd9598d)
**Update sayfası ödev**



## 8.hafta
1) Update.cshtml sayfasını ekle -> [f0affa1c908a9d2df23cc3fb83fcaf3fc15486dd](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/f0affa1c908a9d2df23cc3fb83fcaf3fc15486dd)
2) ProductViewModel ve IMapper (AutoMapper) ekle -> [2a94b3f26b74b81092ce6e96c1f4791ef4059c39](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/2a94b3f26b74b81092ce6e96c1f4791ef4059c39)
3) Product doğrulamalarını (validation) ekle -> [e1f2c987a80ace26b92f4b5604f352af35c5b39d](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/e1f2c987a80ace26b92f4b5604f352af35c5b39d)

### Views/Product/Update.cshtml
Product update formu oluşturuldu ve ürün güncelleme işlemi için alanlar eklendi.

### ViewModels/ProductViewModel.cs
Ürün doğrulamaları (validation) için veri anotasyonları tanımlandı.

### Mapping/ViewModelMapping.cs
AutoMapper ile Product <-> ProductViewModel eşlemesi yapıldı.


## 9.hafta
1) Tag helper kullanımını ekle -> [4779e6a9c6b4b08f886c200d5f6b999d81b6256f](https://github.com/UmuT5513/Model-View-Controller-Guide/commit/4779e6a9c6b4b08f886c200d5f6b999d81b6256f)

### TagHelpers/ItalicTagHelper.cs ve TagHelpers/ProductShowTagHelper.cs
Custom tag helper sınıfları oluşturuldu.

### Views/_ViewImports.cshtml
Custom tag helper'lar projeye tanıtıldı.

### Views/Home/Index.cshtml
`<italic>` ve `<product-show>` etiketleri kullanıldı.

# Kavramlar
*Razor Syntax*= @ {...}, cshtml uzantılı dosyalarda geçerlidir. Bize html dosyalarının içinde c# kodu yazma olanağı sağlar.
