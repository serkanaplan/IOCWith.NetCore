namespace IOCWith.NetCore.Console;

public class MySqlDAL: IDAL
{
    public List<Product> GetProducts()
    {
        return [
            new Product{Id=1, Name="Kalem 1",Price=100,Stock=200},
            new Product{Id=2, Name="Kalem 2",Price=100,Stock=200},
            new Product{Id=3, Name="Kalem 3",Price=100,Stock=200},
            new Product{Id=4, Name="Kalem 4",Price=100,Stock=200}
           ];
    }
    public int Hesapla() => 100;
}
