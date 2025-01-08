# OtelBul Projesi

🏨 Bu proje M&Y Yazılım Eğitim Akademi Danışmanlık bünyesinde Murat Yücedağ eğitmenliği tarafından verilen eğitim kapsamındaki 6. projedir. OtelBul adını verdiğim bu proje [RapidApi](https://rapidapi.com/) üzerinde bulunan Booking API kullanılarak geliştirilmiş bir otel bulma projesidir. Kullanıcıların belirlediği kriterlere uygun otelleri api üzerinden çekip sitede listeleme işlemi gerçekleştirilmiştir.

## Anasayfa

🔍 Kullanıcılardan aşağıdaki bilgiler alınır:

* 🗺️ Filtrelemek istedikleri şehir bilgisi

* 📅 Giriş ve çıkış tarihleri

* 👤 Yetişkin kişi sayısı

* 🧒 Çocuk sayısı

## Sonuç Sayfası

✔️ Girilen kriterlere uyan oteller liste halinde gösterilir.

ℹ️ Kullanıcılar listelenen otellerin şu bilgilerine erişebilir:

* 🏠 Otel adı

* ⭐ Otel puanı

* 👥 Kaç kişi tarafından değerlendirme yapıldığı


## 🛠️ Kullanılan Teknolojiler

💻 Asp.Net Core(6.0) ile geliştirildi.

🏗️ Tek katmanlı yapı ile işlemler gerçekleştirildi.

🌐 Booking API'nin üç farklı endpoint'i kullanıldı:

🔍 Auto Complete Endpoint:

* Kullanıcının girdiği şehir bilgisine karşılık gelen şehir ID'si ve Destination ID'si elde edildi.

🏨 Search Hotels Endpoint:

* Elde edilen şehir ID'si ve diğer filtreleme kriterleri kullanılarak otellerin listesi çekildi.

🖼️ Get Hotel Photos Endpoint:

* Elde edilen otellerin ID'si kullanılarak ilgili otellerin fotoğrafları çekildi.

📦 ViewModel Kullanımı:

* API'den gelen JSON verilerini karşılamak ve yönetmek için ViewModel yapıları oluşturuldu.

## 📌 Proje Detayları

1️⃣ API entegrasyonu sırasında şehir ID'si ve Destination ID'sine ulaşmak için öncelikle Auto Complete Endpoint'ine istek gönderilir, parametre olarak kullanıcının girdiği şehir bilgisi gönderilir.

2️⃣ Buradan elde edilen şehir ID'si, sonrasında Search Hotels Endpoint'ine gönderilerek kriterlere uygun otel bilgileri alınır, parametre olarak şehir ID'si dışında kullanıcının girdiği diğer kriterler de bu aşamada gönderilir. 

3️⃣ Uygun otel bilgileri alındıktan sonra buradaki otellerin otel ID'leri alınır ve Get Hotel Photos Endpoint'ine istek gönderilir. Buradan gelen yanıt ile ilgili otellerin fotoğrafları da elde edilmiş olur.

4️⃣ JSON veri yapısı, ViewModel'ler ile düzenlenip proje içerisinde kullanılabilir hale getirilmiştir.


## 🖼️ Görseller

https://github.com/user-attachments/assets/c609632a-a70f-4c08-ac67-f034cd67026a

![otelbul-anasayfa](https://github.com/user-attachments/assets/21f23b0d-6105-44a2-91c5-e509c5179a26)

![otelbul-sonuclar](https://github.com/user-attachments/assets/6a393ddf-20e9-4a67-9a07-958637c7f19a)
