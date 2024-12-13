# Bilet Satış Otomasyonu

Bu proje, etkinlikler için bilet satışını yönetmek amacıyla tasarlanmış bir Windows Forms uygulamasıdır. Kullanıcılar, çeşitli etkinlikler için salon bilgileri girerek bilet satış işlemlerini yönetebilir ve bilet satın alabilir.

## Özellikler
![image](https://github.com/user-attachments/assets/a1ad7a3a-787e-4b76-9d37-0896fbc3ac4e)

- **Salon Yönetimi:** Salon adı ve kapasitesi girilerek salon kaydı yapma.
- **Etkinlik Yönetimi:** Etkinlikler için ad, salon, bilet ücreti, yaş sınırı ve zaman aralığı gibi bilgileri girme. Bitiş zamanı, başlangıç tarihinden veya saatinden önce belirlenemez.

![image](https://github.com/user-attachments/assets/77676060-c18d-47f1-abb1-31f3e6735bf6)

![image](https://github.com/user-attachments/assets/d12e988b-e268-4439-ab18-0779e4ddf37b)

Etkinliğin bitiş saatini başlangıç saaatinden önce belirleyip eklemek istediğimizde hata mesajı ile karşılaşıyoruz.
  
- **Bilet Satış:** Kullanıcılara bilet satışı yapma, bilet bilgilerini içeren Adı Soyadı, telefon, cinsiyet, doğum tarihi ve indirim durumu gibi detayları kaydetme. Bilet almak istediğimizde, etkinliğin yaş sınırına takılırsak hata mesajı alıyoruz.

![image](https://github.com/user-attachments/assets/dfd09dd3-b128-4b44-a746-d36a2a3849f3)

![image](https://github.com/user-attachments/assets/28f5bdce-f557-45fe-a2bf-0bc7e80dfe77)

Örneğin bugün doğmuş biri Suç ve Ceza tiyatrosuna katılmak istediğinde(bilgileri bu şekilde doldurduğumuzda) ""Yaş sınırına takıldınız"" mesajını alacaktır.

- **Güncelleme ve Silme İşelmleri:**
![image](https://github.com/user-attachments/assets/0bf3f58d-3421-433d-9167-c2656854b5d7)

Güncelleme veya silme işlemi yapmak istiyorsak tablodaki hücreye sağ tıklayıp istediğimiz komutu seçebiliriz. Güncelleme işlemi bittikten sonra Güncelle butonuna tıklamayı unutmayınız.

 
## Kullanılan Teknolojiler

- **C#**
- **.NET Framework**
- **Windows Forms**

## Kurulum

Bu repository'yi klonlayın:

git clone https://github.com/<your-username>/Bilet-Satis-Otomasyonu.git
