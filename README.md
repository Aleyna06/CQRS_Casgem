# CQRS_Casgem

Bu proje, .NET Core 3.1 kullanılarak oluşturulan ve CQRS (Command Query Responsibility Segregation) tasarım desenini kullanan bir örnek uygulamadır. CQRS deseni, komutları (Command) ve sorguları (Query) birbirinden ayrı olarak ele alır. Böylece, uygulamada veri yazma ve veri okuma işlemleri için farklı modeller ve mekanizmalar kullanılır.

Komutlar (Commands)
Proje, aşağıdaki komutları kabul eder:

CreateProductCommand: Yeni bir ürün eklemek için kullanılır.
UpdateProductCommand: Varolan bir ürünü güncellemek için kullanılır.
DeleteProductCommand: Bir ürünü silmek için kullanılır.
Sorgular (Queries)
Proje, aşağıdaki sorguları destekler:

GetProductByIdQuery: Ürünleri ürün kimliğiyle sorgular.
GetProductsByCategoryQuery: Belirli bir kategoriye ait ürünleri sorgular.
GetProductsByPriceRangeQuery: Belirli bir fiyat aralığındaki ürünleri sorgular.
