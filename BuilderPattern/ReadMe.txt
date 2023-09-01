builder tasarım deseni işleri parça parça yapmamız gerektiğinde kullanılır. bir director class'ı olur ve bu 
işleri bizim için tek tek yapar.
genel olarak factory patterne benzese de director class'ı ve abstract class üzerinden alt sınıfı türetme ile factory den ayrılır 
factory de tip gönderiyorduk o tipe göre bize obje dönüyordu. burada objeyi direk abstract üzerinden alt sınıfa ürettirip
director class a çalış diye emir veriyoruz. 

karmaşıklık yapısı itibariyle factory den daha ileride abstract factory den geride görünüyor. 


bu yapı eğer contructorumuz fazla yüklendi ise ya da gelen parametreler sürekli bazı çağrımlarda null geliyor ve kötü bir görünüm
oluşuyorsa artık bu yapıyı düşünme zamanımız çoktan gelmiş demektir.
böyle olacağına classları parçalayıp ilgili classı çağırmak daha akıllıcadır.