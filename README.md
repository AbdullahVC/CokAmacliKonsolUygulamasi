# Çok Amaçlı Konsol Uygulaması

## Proje Özeti

Bu proje, kullanıcıların çeşitli uygulamaları çalıştırabileceği bir çok amaçlı konsol uygulamasıdır. Uygulama, rastgele sayı bulma oyunu, hesap makinesi ve not ortalaması hesaplama gibi temel işlevler sunar. Kullanıcı, konsol üzerinden bir menü aracılığıyla istediği uygulamayı seçebilir ve kullanabilir.

## Kullanılan Teknolojiler

- **C#**: Projenin ana programlama dili.
- **.NET Core**: Uygulamanın çalıştırıldığı platform.
- **Visual Studio**: Geliştirme ortamı.

## Nasıl Çalıştırılır

1. **Projeyi Klonlayın veya İndirin**
    ```sh
    git clone <repository-url>
    cd <repository-directory>
    ```

2. **Visual Studio ile Açın**
    - Proje dizininde `*.sln` dosyasını bulun ve Visual Studio ile açın.

3. **Proje Yapılandırması**
    - Projenin doğru yapılandırıldığından emin olun. Gerekli bağımlılıkların yüklü olduğundan emin olun.

4. **Uygulamayı Çalıştırın**
    - F5 tuşuna basarak veya menüden `Debug > Start Debugging` seçeneğini kullanarak uygulamayı çalıştırın.
    - Konsolda açılan menüde ilgili seçeneği girerek istediğiniz uygulamayı çalıştırabilirsiniz.

## Uygulamalar

### Rastgele Sayı Bulma Oyunu
- Bilgisayar 1-100 arasında rastgele bir sayı seçer.
- Kullanıcı, bu sayıyı tahmin etmeye çalışır.
- Kullanıcıya daha yüksek veya daha düşük bir sayı girmesi gerektiği söylenir.
- Kullanıcının 5 tahmin hakkı vardır.

### Hesap Makinesi
- Kullanıcıdan iki sayı ve bir işlem (+, -, *, /) seçmesi istenir.
- İşlem sonucunda hesaplanan değer ekranda gösterilir.
- Sıfıra bölme hatası kontrol edilir ve kullanıcıya bildirilir.

### Ortalama Hesaplama
- Kullanıcıdan üç ders notu girmesi istenir.
- Girilen notların ortalaması hesaplanır ve harf notu olarak gösterilir.
- Notların 0 ile 100 arasında olup olmadığı kontrol edilir.

## Ek Bilgiler

- **Hata Kontrolleri**: Kullanıcı girişlerinin geçerliliği kontrol edilmiştir. Geçersiz girişlerde kullanıcıya hatalı giriş yaptığı bildirilir ve tekrar giriş yapması istenir.
- **Kullanıcı Dostu Arayüz**: Uygulama, kullanıcıların kolayca anlayabileceği ve kullanabileceği şekilde tasarlanmıştır.
- **Modüler Yapı**: Her bir işlev, ayrı bir metot olarak tanımlanmış ve bu metotlar ana döngüde çağrılmaktadır.

## Katkıda Bulunma

Eğer projeye katkıda bulunmak isterseniz, lütfen bir pull request gönderin veya bir issue açın.

## Lisans

Bu proje MIT Lisansı altında lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasını inceleyebilirsiniz.

---

Umarım bu proje sizin için faydalı olur. İyi çalışmalar!
