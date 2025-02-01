# LINQ Uygulamaları
Bu repoda [LINQ Oynatma Listesi](https://www.youtube.com/playlist?list=PL2gZB_AT1f5a9xv-qLDSwJDLVZsTNidFz) içerisinde anlatılan konulara ait uygulamalar bulunmaktadır.

## 1-Giriş ve Temel Kavramlar
`NOT:Bu başlık için uygulama yok`
* LINQ Nedir?
* LINQ ile SQL Arasındaki Farklar
* LINQ Çeşitleri: LINQ to Objects, LINQ to SQL, LINQ to XML, LINQ to Entities
* LINQ Kullanımı için Gerekli Ortam ve Kütüphaneler

## 2-LINQ Sorgu Temelleri
* LINQ Sorgularının Temel Yapısı
* From, Where, Select Kullanımı
* LINQ Lambda İfadeleri (Lambda Expressions)

## 3-LINQ İle Veri Yapıları
* Array ile Kullanımı
* List ile Kullanımı
* Dictionary ile Kullanımı

## 4-LINQ Operatörleri-Filtreleme ve Sıralama
* IEnumerable, Enumerable, IQueryable, Queryable Nedir?
* Where
* OrderBy
* OrderByDescending
* ThenBy
* ThenByDescending

## 5-LINQ Operatörleri-Projeksiyon
* Select
* SelectMany

## 6-LINQ Operatörleri-Gruplama
* GroupBy

## 7-LINQ Operatörleri-Matematiksel İşlemler
* Count
* Sum
* Average
* Min
* Max

## 8-LINQ Operatörleri-Birleştirme Operasyonları
* Distinct
* Union
* Intersect
* Expect
* Join
* GroupJoin

## 9-LINQ Operatörleri-Diğer
* First
* FirstOrDefault
* Last
* LastOrDefault
* Single
* SingleOrDefault
* Take
* Skip
* TakeWhile
* SkipWhile

## 10-LINQ ile Koleksiyon İşlemleri
* Koleksiyonlardan Eleman Çekme
* Koleksiyonları Manipüle Etme (Ekleme, Çıkarma ve Güncelleme)
* Nested Koleksiyonlarla Çalışma

## 11-Performans ve Optimizasyon
* LINQ Sorgularının Performans Etkisi
* Deferred Execution Kavramı
* Immediate Execution Kavramı
* DotnetBenchmark İle Performans Testi

## 12-Veri ile Çalışmak
* Jsonplaceholder Verileri ile LINQ Senaryo Sorguları Oluşturma
* * Kullanıcı Analizleri
* * Post-Yorum İlişkisi
* * Albüm-Fotoğraf Analizi
* * Todo Analizi
* * Coğrafi Analiz
* Jsonplaceholder Verileri ile LINQ Yardımcı Sorgular Oluşturma
* * `Select:` Kullanıcı verilerini özet formatta projekte et (ID, kısaltılmış isim ve şehir)
* * `OrderBy/ThenBy:` Postları önce kullanıcı ID'sine sonra başlık uzunluğuna göre sırala
* * `Count:` "important" veya "urgent" içeren yorumları say
* * `Take/Skip:` Sayfalama yaparak 2. sayfadaki postları getir
* * `Any/All:` Tüm görevleri tamamlanmamış en az bir kullanıcı olup olmadığını kontrol et
* * `FirstOrDefault:` Belirli kriterlere uyan ilk postu getirir
* * `Distinct:` Kullanıcıların benzersiz posta kodlarını listele
* * `GroupBy:` Postları 100'lük karakter gruplarına göre kategorize et
* * `Aggregate:` En uzun e-posta adresini bul
* * `SelectMany:` İç içe koleksiyonlardan (kullanıcı->albüm->fotoğraf) tek liste oluştur

