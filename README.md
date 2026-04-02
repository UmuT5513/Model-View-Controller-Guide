# ASP.NET Core MVC - Duzce University CE308 Web Programming Lecture Notes

# Git History

## 1 ve 2. Haftalar -> a10db21fbc664009099f0742ec88fcc340451430

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
1) ProductRepository e Add ve Remove işlemlerini ekle -> d1686cfc209d71f9015825547c61ddc30b37e3a8
2) ProductRepository e Update işlemini ekle -> e99809be0b85b0e09d0db58a6af0e0708ad3b29a
3) Controllers/ProductController ile Controller bağlantısı sağla ve Views/Product/Index.cshtml de göster -> 9bb1d627c9fec8a19322e11d335407a02c061e57
4) Productları Views/Product/Index.cshtml sayfasında göster -> 43fee5a8529baae6b5aa444e8d178956e49f712a

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




## 5.hafta




# Kavramlar
*Razor Syntax*= @ {...}, cshtml uzantılı dosyalarda geçerlidir. Bize html dosyalarının içinde c# kodu yazma olanağı sağlar.
