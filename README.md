# Oyun-Projesi

  Bu proje, Unity ile geliştirilen 2D bir oyunda oyuncu karakterinin temel hareketleri ve yeteneklerini kontrol eden C# scriptlerini içerir.

 Not: Henüz tüm scriptleri yazmadım zamanla eklenecektir.
 
 Not 2: videoda kullanılan öğeler Stickman dosyasındadır.
  

YETENEKLER

  Yetenekler; göz, gövde, kollar, bacaklar ve çekirdek olarak 5 farklı bölüme ayrılıyor. Yetenekler ve açıklamaları şu şekilde;

# GÖZ
  
- Navigasyon

Seviye 1: Ekranın sağ üst köşesinde minimap açılır.

Seviye 2: Minimap üzerinde düşmanlar ve hazineler görünür.

- Tuzak Algılama

Seviye 1: Tuzaklar ve gizli geçitler algılanır.

Seviye 2: Taret ve mayınlar hacklenerek dost birime dönüşür.

- Zaman Hızlandırıcı

Düşmanlar ve mermiler yavaşlar.

Enerjiye bağlı süresi vardır, tuşla aktif edilir ve tekrar basıldığında veya enerji bittiğinde sona erer.

Ekran grileşir ve ses efektleri oynatılır.

- Kritik Saldırı

Seviye 1: Daha fazla hasar ve %20 ihtimalle sersemletme.

Seviye 2: Kalkanları %20 ihtimalle kırma ve mekanik düşmanlara ek hasar.

# Vücut Yetenekleri
- Kalkan

Can yerine enerji tükenir, enerji bittiğinde can azalmaya başlar.

- Hasar Azaltıcı

Seviye 1: Hasar %20 azalır.

Seviye 2: Hasar %50 azalır.

- Enerji Emici

Gelen saldırılar enerji biriktirir.

Seviye 1: Enerji dolduğunda düşmanları iten ve hasar veren enerji dalgası açığa çıkar.

Seviye 2: Ek olarak mekanik düşmanları sersemleten EMP etkisi yapar.

- Sağlam Vücut

Seviye 1: Zehir, şok gibi durum etkileri yarı yarıya azalır, sersemleme süresi kısalır.

Seviye 2: Etkilenilen durum etkisi (zehir, şok, yanma) düşmanlara yayılır.

- Çılgınlık

Tuşa basıldığında aktif olur.

Verilen hasar %40, alınan hasar %20 artar.

Enerjiye bağlı süre, sona erdiğinde Aşırı Isınma durumu başlar (5 sn):

Hareket hızı %20, saldırı gücü %10 azalır.

Görsel efektler: Kırmızı parıltı ve aşırı ısınma için kararma efekti.

- Adrenalin Patlaması

Can %30'un altına düştüğünde:

Enerji yenilenmesi %50 artar.

Hareket hızı %20 artar.

Görsel efekt: Parlayan mavi ışıklar.

- Rejenerasyon

Tuşa basıldığında enerji harcanarak can yenilenir.

Seviye 1: 5 sn boyunca enerjinin %50'sini harcayarak canın %20'sini doldurur.

Seviye 2: 5 sn boyunca enerjinin %50'sini harcayarak canın %40'ını doldurur.

Görsel efekt: Yeşil ışıklar.

- Görünmezlik

Tuşa basıldığında aktif olur.

Tuzaklar etkinleşmez ve düşmanlar karakteri görüş mesafesinin yarısında fark eder.

Düşmanlara arkadan saldırıldığında kalkana takılmadan büyük hasar verir.

Hareketsizken az enerji harcar, hareket edince daha fazla enerji tüketir.

Görsel efekt: Yarı saydamlık efekti ve ses efekti.

# Bacak Yetenekleri


- Sıçra

Tuşa basıldığında karakter 5 birim ileri sıçrar ve saldırılardan kaçar.

Seviye 1: 4 sn bekleme süresi.

Seviye 2: 2 sn bekleme süresi ve havada da kullanılabilir.

Görsel efekt: Hareket izi.

- Çoklu Zıplama

Havada bir kez daha zıplama.

Seviye 1: Enerjinin %20'sini harcar, yere düşme hasarı yarıya iner.

Seviye 2: Düşerken düşmanları iter, düşme hasarı alınmaz.

Görsel efekt: Havada zıplama efekti.

- Hız Patlaması

Tuşa basıldığında 7 saniye boyunca:

Seviye 1: Hareket hızı %20 artar, enerji %30 azalır.

Seviye 2: Hareket hızı %35, saldırı hızı %10 artar, enerji %30 azalır.

- Sis Adım

Tuşa basıldığında karakter sessiz hareket eder.

Tuzaklar etkinleşmez, düşmanlar arkadan fark edemez.

Seviye 1: Hareket edilen her birim için 3 enerji azalır.

Seviye 2: Her birimde 1 enerji azalır.
# Kol Yetenekleri
- Ağır Saldırı
Aktif edilir: Tuşla açılır/kapanır.

Enerji Tüketimi: Her saldırı %10 enerji harcar.

Seviye 1: +%35 saldırı gücü

Seviye 2: +%40 saldırı gücü + sersemletme ihtimali

- Kontra Attack
Aktif edilir: Düşman saldırırken doğru anda tuşa basılır.

Etki: Hasar alınmaz, düşman zarar görür.

- Tavana Tutunma
Tuşla aktif edilir, 7 birim yukarı ip fırlatır.

Tavan varsa karakter tırmanır ve tavanda hareket edebilir.

# Çekirdek Yetenekleri
-Depolama Yükseltmesi

Seviye 1: Maksimum enerji miktarı %20 artar.

Seviye 2: Maksimum enerji miktarı %50 artar.

-Geri Dönüşüm

Saldırı sırasında enerji yenilenmesi %20 artar.

-Fedakarlık

Enerji yenilemek için canın bir kısmını feda eder.

-Aşırı Yükleme

10 saniyeliğine maksimum enerji miktarı ve enerji yenilenmesi %50 artar.

Süre bitince aşırı ısınma durumuna girer (saldırı gücü ve saldırı hızı %30 azalır).

-Direniş

Can %20 altına düştüğünde enerji yenilenmesi %40 artar.

-İkinci Şans

Tüm can bittiğinde tek seferliğine %20 can yenilenir, 5 saniyeliğine enerji yenilenmesi %30 artar.

Görsel Efekt: Mavi ve beyaz enerji dalgaları, parlama animasyonu ve özel ses efekti.

# Silah Yetenekleri

--- KILIÇ MODÜLLERİ

- Zehir Kaplama

Seviye 1: %10 ihtimalle düşmanı zehirler.

Seviye 2: %25 ihtimalle düşmanı zehirler.

Seviye 3: %50 ihtimalle düşmanı zehirler.

- Yanıcı Kaplama

Seviye 1: %5 ihtimalle düşmanı yakar.

Seviye 2: %15 ihtimalle düşmanı yakar.

Seviye 3: %35 ihtimalle düşmanı yakar.


- Elektrik Akımı

Seviye 1: %10 ihtimalle düşmanı sersemletir.

Seviye 2: %25 ihtimalle düşmanı sersemletir.

Seviye 3: %50 ihtimalle düşmanı sersemletir.

- Sonik Titreşim

Seviye 1: Kritik ihtimali %5, zırhlara verilen hasar %15 artar.

Seviye 2: Kritik ihtimali %15, zırhlara verilen hasar %30 artar.

Seviye 3: Kritik ihtimali %40, zırhlara verilen hasar %50 artar.


- Ağır Bıçak

Seviye 1: Saldırı gücü %20 artar, saldırı hızı %20 azalır.

Seviye 2: Saldırı gücü %30 artar, saldırı hızı %20 azalır.

Seviye 3: Saldırı gücü %50 artar, saldırı hızı %20 azalır.

- Hafifletici Kaplama

Seviye 1: Saldırı hızı %20 artar, saldırı gücü %20 azalır.

Seviye 2: Saldırı hızı %30 artar, saldırı gücü %20 azalır.

Seviye 3: Saldırı hızı %50 artar, saldırı gücü %20 azalır.

- Enerji Saklayıcı

Seviye 1: Her saldırıda +10 enerji, saldırı gücü %20 azalır.

Seviye 2: Her saldırıda +20 enerji, saldırı gücü %20 azalır.

Seviye 3: Her saldırıda +40 enerji, saldırı gücü %20 azalır.

--- TABANCA MODÜLLERİ
-Zehir Mermileri

Seviye 1: %20 ihtimalle zehirleme.

Seviye 2: %40 ihtimalle zehirleme.

Seviye 3: %75 ihtimalle zehirleme.

-Ateş Mermileri

Seviye 1: %20 ihtimalle yakma.

Seviye 2: %40 ihtimalle yakma.

Seviye 3: %75 ihtimalle yakma.

-Şok Mermileri

Seviye 1: %20 ihtimalle sersemletme.

Seviye 2: %40 ihtimalle sersemletme.

Seviye 3: %75 ihtimalle sersemletme.

-Lazer Atış

Seviye 1: %25 enerji harcar, zincirleme hasar.

Seviye 3: Tüm düşmanlara tam hasar.

-Ağır Kalibre

Seviye 1: %20 daha fazla hasar, her atış %20 enerji harcar

Seviye 2: %40 daha fazla hasar, her atış %20 enerji harcar

Seviye 3: %60 daha fazla hasar, her atış %20 enerji harcar

-Hayalet Mermi

Etraftaki düşmanlar farketmez, %20 daha az hasar.

-Zırh Delici


Seviye 1: Zırhlara karşı %20 daha fazla hasar.

Seviye 2: Zırhlara karşı %40 daha fazla hasar.

Seviye 3: Zırhlara karşı %60 daha fazla hasar.

-Zayıf Nokta Bulucu

Kritik ve zırh delme avantajı sağlar, %25 enerji harcar.

  
