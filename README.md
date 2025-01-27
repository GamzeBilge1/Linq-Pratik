# LINQ Kullanımı Örnek Kod

Bu proje, C# dilinde LINQ kullanılarak bir liste üzerinde çeşitli işlemler yapılmasını göstermektedir. 

## Amaç
- Bir sayı listesi üzerinden LINQ kullanarak filtreleme, dönüşüm ve diğer işlemleri gerçekleştirmek.

## Yapılan İşlemler
1. **Çift Sayıları Bulma**:
   - `numbers.Where(num => num % 2 == 0)` ifadesi ile çift sayılar filtrelenir.
   - Sonuçlar ekrana yazdırılır.

2. **Tek Sayıları Bulma**:
   - `numbers.Where(num => num % 2 != 0)` ifadesi ile tek sayılar filtrelenir.
   - Sonuçlar ekrana yazdırılır.

3. **Negatif Sayıları Bulma**:
   - `numbers.Where(num => num < 0)` ifadesi ile negatif sayılar filtrelenir.
   - Sonuçlar ekrana yazdırılır.

4. **Pozitif Sayıları Bulma**:
   - `numbers.Where(num => num > 0)` ifadesi ile pozitif sayılar filtrelenir.
   - Sonuçlar ekrana yazdırılır.

5. **Belirli Bir Aralıktaki Sayıları Bulma**:
   - `numbers.Where(num => num > 15 && num < 22)` ifadesi ile 15 ile 22 arasında (15 ve 22 hariç) sayılar filtrelenir.
   - Sonuçlar ekrana yazdırılır.

6. **Sayıların Karelerini Hesaplama**:
   - `numbers.Select(x => x * x)` ifadesi ile sayıların kareleri hesaplanır.
   - Kareler bir listeye eklenir ve ekrana yazdırılır.

## Kullanılan Teknolojiler
- **C#**
- **.NET Framework**
- LINQ (Language Integrated Query)
