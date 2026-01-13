# 🌿 PeakManage – Personel ve İK Yönetim Sistemi
PeakManage, personel yönetimi, izin süreçleri, performans takibi ve maaş raporlamasını tek bir uygulama altında toplayan, katmanlı mimari ile geliştirilmiş bir Windows Forms (C#) uygulamasıdır.
Bu proje, İnsan Kaynakları Personel Takip Sistemi kapsamında geliştirilmiştir.

📌 Proje Amacı
- Kurum içi personel süreçlerini düzenli ve kontrollü bir şekilde yönetmek
- Farklı kullanıcı rollerine göre yetkilendirme sağlamak
- Gerçek hayattaki İK süreçlerini simüle eden bir masaüstü uygulaması geliştirmektir

👤 Kullanıcı Rollerı ve Yetkiler

🔑 1. Admin (Yönetici)  
Tüm personelleri listeleyebilir  
İzin taleplerini onaylayabilir veya reddedebilir  
Maaş raporlarını görüntüleyebilir  
Toplam maaş analizlerini görebilir  

🧑‍💼 2. İK Personeli  
Personel ekleyebilir  
Personel listesini görüntüleyebilir  
Seçilen personele:  
İzin ekleyebilir  
Performans puanı ekleyebilir  

👩‍💻 3. Kullanıcı (Personel)  
Kendi izin taleplerini oluşturabilir  
İzin durumlarını görüntüleyebilir  
Onaylanan / reddedilen izinleri takip edebilir

🧱 Kullanılan Mimari (Katmanlı Yapı)
Proje katmanlı mimari prensibine uygun olarak geliştirilmiştir:  
Entities  
→ Veritabanı tablolarına karşılık gelen sınıflar  
DAL (Data Access Layer)  
→ MySQL veritabanı işlemleri  
BLL (Business Logic Layer)  
→ İş kuralları ve kontrol mekanizmaları  
UI (Windows Forms)  
→ Kullanıcı arayüzleri

🗄️ Veritabanı  
MySQL kullanılmıştır.

Temel tablolar:  
users  
izin_talepleri  
personel_performans  
personel_listele

🖥️ Uygulama Özellikleri  
🔐 Rol bazlı giriş sistemi  
📋 Personel listeleme  
📝 İzin alma ve onaylama  
⭐ Performans puanı ekleme  
💰 Maaş raporu görüntüleme  
📊 Departman bazlı maaş toplamları  
🎨 Renkli durum göstergeleri (Onaylandı / Reddedildi / Beklemede)  
🎨 Uygulama Adı & Tasarım

Uygulama Adı: PeakManage

Tema: Yeşil – Turkuaz tonları  
Amaç: Sade, anlaşılır ve kullanıcı dostu arayüz

🛠️ Kullanılan Teknolojiler  
C#  
Windows Forms  
MySQL  
ADO.NET  
Katmanlı Mimari  

✨ Geliştirici  
Şahika Elif Yıldıran  
PeakManage – Personel ve İK Yönetim Sistemi

📌 Not  
Bu proje eğitim amaçlı geliştirilmiştir ve gerçek hayattaki insan kaynakları süreçlerini temel alır.

## 🎥 Youtube Video Linki
(https://youtu.be/83VhOV83Q6o)
### 🔐 Login Sayfası
Kullanıcıların sisteme kullanıcı adı, şifre ve departman bilgisi ile giriş yaptığı ekrandır.  
Giriş yapan kullanıcının rolüne göre (Admin, IK, User) ilgili sayfaya yönlendirme yapılır.  
Sayfada motivasyon amaçlı her girişte rastgele bir söz gösterilmektedir.

<img width="934" height="583" alt="Login" src="https://github.com/user-attachments/assets/f139c6e0-e3aa-4041-bf89-7e612620c81c" />

### 📝 İzin İşlemleri
Kullanıcılar bu ekran üzerinden izin talebinde bulunabilir.  
Talep edilen izinler tarih aralığı, açıklama ve durum bilgileri ile birlikte listelenmektedir.
Admin kullanıcı, **İzin Onay Sayfası** üzerinden gelen izin taleplerini inceleyebilir.  
İzin durumları görsel olarak ayırt edilebilmesi için renklendirilmiştir:
- Beklemede → Sarı
- Onaylandı → Yeşil
- Reddedildi → Kırmızı

<img width="934" height="597" alt="UsersForm" src="https://github.com/user-attachments/assets/888ded11-845d-4479-830f-a8799ce72a26" />

### 🧑‍💻 IK Sayfası
İnsan kaynakları personelinin çalışan ekleme, personel listeleme, performans ekleme ve izin yönetimi işlemlerini yaptığı ekrandır.  
Personel bilgileri düzenli bir tablo halinde gösterilmektedir.

<img width="933" height="577" alt="IKForm" src="https://github.com/user-attachments/assets/f9bb5d53-ce20-4d27-9d85-68e87f86a753" />

### 📝 İK – İzin İşlemleri

İK panelindeki izin ekranı, normal kullanıcıların kullandığı izin alma ekranı ile aynı altyapıyı kullanır.
Ancak İK kullanıcıları, kendi adlarına değil, listeden seçtikleri personel adına izin girişi yapabilir.

<img width="936" height="576" alt="IKİzinForm" src="https://github.com/user-attachments/assets/39c9d711-6ec1-48ea-a743-839218374637" />

### 📊 Performans Takibi
Personellerin performans puanlarının eklendiği ve listelendiği ekrandır.  
Performans puanları renklendirilerek görsel olarak vurgulanmıştır.

<img width="932" height="578" alt="PerformansForm" src="https://github.com/user-attachments/assets/4508b08b-8d1c-49bd-8851-81bbe87e4b64" />

### 👩‍💼 Admin Paneli
Admin kullanıcılarının sisteme genel olarak hakim olduğu ana ekrandır.  
Personel listeleri görüntülenebilir, izin onayları yapılabilir ve maaş raporlarına erişim sağlanır.

<img width="926" height="585" alt="AdminForm" src="https://github.com/user-attachments/assets/47243b0e-93c4-4623-a904-20b6dafbe485" />

### ✅ İzin Onay Formu
Admin kullanıcısının izin taleplerini yönettiği ekrandır.  
Bu sayfada yalnızca **beklemede olan izin talepleri** listelenmektedir.
Seçilen izin talebi;
- Onaylanabilir
- Reddedilebilir  
Yapılan işlem sonrasında izin durumu güncellenir ve tablo otomatik olarak yenilenir.  
İzin durumu değiştikten sonra renklendirme ile kullanıcıya görsel geri bildirim sağlanır.

<img width="932" height="581" alt="AdminİzinOnayForm" src="https://github.com/user-attachments/assets/8de737bb-64e7-49f5-9775-5a0f7d5248d1" />

### 💰 Maaş Raporu
Bu ekranda tüm personellerin maaş bilgileri listelenir.
Departmanlara göre toplam maaşlar ve şirket genelindeki toplam maaş hesaplanarak gösterilir.
Maaşlar görsel olarak daha anlaşılır olması için renklendirilmiştir.

<img width="928" height="589" alt="AdminMaasRaporForm" src="https://github.com/user-attachments/assets/9d12b453-20e1-4791-af97-40509c0704b9" />
