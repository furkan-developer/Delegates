Delegate, fonksiyonların referanslarını temsil eden yapılardır. 

Delegate ler, diğer metotlara bir metodu parametre olarak geçmek için kullanılır.

Delegate neden kullanır? Delegate ler bir nesnenin davranışının özelleştirilebilmesine izin vermek için kullanılır. Bu sayede nesnenin davranışı nesneyi kullanacak developer ın iradesine kalır. Bunu yapabilmek içni nesneye developer ın opsiyonel olarak ayarlayabileceği bir delegate verilebilir ve developer buna ihtiyacı var ise kullanır ve nesnenin davranışı ona göre şekillenir.

Delegate ler referans türlü yapılardır. Özünde bir class dır. System.Delegate sınıfı sayesinde delegate yapısı kullanılabiliyor. Runtime da delegate sınıfı nesnesi oluşturularak delegate yapısı çalışıyor.

Delegate ler generic yapıyı destekler. Action ve Func özel delegate tanımlarıda bunun sayesinde oluşturulmuştur.

Event based programlama mantığını kullanabilmek için delegate ler kullanılır. Event Handler lar metotlardan başka bir şey değildir. Metotlar delegateler aracılığı ile çağrılırlar.

Multi delegate ler bir event e birden fazla abone eklemek için kullanılır. Multi delegate ler sayesinde aynı imzaya sahip birden fazla metot zincirlenebilir ve tek bir event üzerinden çağrılabilirler.

Delegate isimlendirilir iken sonuna handler eklenmelidir.
