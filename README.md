# AR Landmark Gezgini Uygulaması

Bu depo, Unity ile geliştirilmiş olan AR Landmark Gezgini mobil uygulamasının kaynak kodunu içermektedir.

## Links
* **APK Linki :** https://drive.google.com/drive/folders/1mL9et52QBqdMMUbXEMDcvaWUEONxu2oK?usp=drive_link
* **Site Linki:** https://worldexplorer-ar.vercel.app/

## Projenin Kaynak Kodunu İndirme

Bu projeyi bilgisayarınıza indirmenin birkaç yolu vardır. Önerilen yöntem, projeye katkıda bulunmayı (değişiklik yapıp geri göndermeyi) planlayıp planlamadığınıza bağlıdır.

### Seçenek 1: Git ile Klonlama (Katkıda Bulunacaklar İçin Önerilir)

Bu yöntem, Git yüklüysa ve projede değişiklikler yapmayı, potansiyel olarak bunları bu depoya geri göndermeyi planlıyorsanız en iyisidir.

#### Önkoşullar:
* **Git Yüklü:** Git yüklü değilse, [git-scm.com](https://git-scm.com/downloads) adresinden indirin.
* **Unity Hub Yüklü:** Unity Hub'ı [unity.com](https://unity.com/download) adresinden indirin.

#### Adımlar:

1.  **Terminal veya Git Bash**'i (Windows'ta) veya **Komut Satırı/Terminal**'i açın.
2.  Unity projelerinizi depolamak istediğiniz **dizine gidin**. Örneğin:
    ```bash
    cd Belgeler/UnityProjeleri
    ```
    (Dilediğiniz başka bir yolu `Belgeler/UnityProjeleri` yerine kullanabilirsiniz.)
3.  **Depoyu klonlayın:** Bu GitHub deposunun HTTPS URL'sini kopyalayın (depo sayfasındaki yeşil `< > Code` düğmesine tıklayarak bulabilirsiniz). Ardından, URL'yi gerçek URL ile değiştirerek aşağıdaki komutu çalıştırın:
    ```bash
    git clone [https://github.com/kullanici-adiniz/depo-adiniz.git](https://github.com/kullanici-adiniz/depo-adiniz.git)
    ```
    (Lütfen `https://github.com/kullanici-adiniz/depo-adiniz.git` kısmını kopyaladığınız gerçek URL ile değiştirin).
4.  **İndirmenin tamamlanmasını bekleyin.** Git, tüm proje dosyalarını deponuzun adıyla yeni bir klasöre (örn. `ar-landmark-gezgin-uygulamasi`) indirecektir.


### Seçenek 2: ZIP Dosyası Olarak İndirme (Hızlı Anlık Görüntü - Katkı İçin Değil)

Bu, Git'i sürüm kontrolü için kurmadan sadece kodu görüntülemek veya uygulamayı test etmek isteyenler için en basit yöntemdir. **Bu yöntem, değişiklikler yapmayı ve depoya geri katkıda bulunmayı planlıyorsanız ÖNERİLMEZ.**

#### Önkoşullar:
* **Unity Hub Yüklü:** Unity Hub'ı [unity.com](https://unity.com/download) adresinden indirin.

#### Adımlar:

1.  GitHub.com'daki depo sayfasına gidin.
2.  Yeşil **`< > Code`** düğmesine tıklayın.
3.  **`Download ZIP`** (ZIP İndir) seçeneğini seçin.
4.  `.zip` dosyasını bilgisayarınızda istediğiniz bir konuma kaydedin.
5.  İndirilen dosyayı yeni bir klasöre **ayıklayın (açın)**.

---

## Projeyi Unity'de Açma

Proje dosyalarını bilgisayarınıza edindikten sonra (yukarıdaki seçeneklerden herhangi birini kullanarak):

1.  **Unity Hub'ı açın.**
2.  **`Add Project`** (Proje Ekle) düğmesine (veya Unity Hub sürümünüze bağlı olarak `Open` - Aç) tıklayın.
3.  İndirilen/klonlanan projenin **ana dizinine gidin.** Bu, `Assets`, `ProjectSettings` ve `Packages` klasörlerini içeren klasördür.
4.  **Bu ana klasörü seçin.**
5.  Unity Hub projeyi listesine ekleyecektir. Projeyi seçin ve açmak için uygun Unity Editor sürümünü (tercihen projenin oluşturulduğu sürüm veya uyumlu bir sürüm) seçin.

---

## Uygulamayı Bir Android Cihazda Derleme ve Çalıştırma

Proje Unity'de açıldıktan sonra, bir Android cihazda derleyebilir ve çalıştırabilirsiniz:

#### Önkoşullar:
* ARCore destekli bir Android cihaz.
* Android cihazınızda Geliştirici Seçenekleri ve USB Hata Ayıklama etkinleştirilmiş olmalı.
* Unity Hub aracılığıyla Android SDK ve NDK yüklü olmalı.

#### Adımlar:

1.  Android cihazınızı USB aracılığıyla bilgisayarınıza **bağlayın.**
2.  Unity'de, `File` > `Build Settings...` (Dosya > Derleme Ayarları...) yolunu izleyin.
3.  Platform olarak `Android`'in seçili olduğundan emin olun. Seçili değilse, seçin ve sağ alttaki `Switch Platform` (Platform Değiştir) düğmesine tıklayın.
4.  "Scenes In Build" (Derlemedeki Sahneler) kutusunda `WelcomeScene` ve `LandmarkScene`'in işaretli olduğundan emin olun.
5.  Sol alttaki `Player Settings...` (Oynatıcı Ayarları...) düğmesine tıklayın.
    * `Android` sekmesi > `Other Settings` (Diğer Ayarlar) > `Configuration` (Yapılandırma) altında, `Scripting Backend`'in `IL2CPP` olduğundan ve `Target Architectures` (Hedef Mimariler) altında `ARM64`'ün işaretli olduğundan emin olun.
    * `Other Settings` (Diğer Ayarlar) > `Rendering` (Oluşturma) altında, cihazınızın API Seviyesi 29'dan düşükse (örn. Android Pie 9), `Graphics APIs` (Grafik API'leri) listesinde `Vulkan`'ın **OLMADIĞINDAN** emin olun. `OpenGLES3` mevcut olmalıdır.
6.  Oynatıcı Ayarları penceresini kapatın.
7.  Derleme Ayarları penceresinde `Build And Run` (Derle ve Çalıştır) düğmesine tıklayın.
8.  Unity, `.apk` dosyasını derleyecek ve bağlı cihazınıza kuracaktır.

---

Keyifli keşifler!
