using IOCWith.NetCore.Console.DAL;

namespace IOCWith.NetCore.Console.Factory;

// eğer DI ile nesne oluşturma işlemini constructor ile yapmayacaksan bunun yerine bir factory sınıfı oluşturur
public class DalFactory
{
    public static IDAL CreateDal()
    {
        // return new MySqlDAL();
        return new OracleDAL();
    }
}