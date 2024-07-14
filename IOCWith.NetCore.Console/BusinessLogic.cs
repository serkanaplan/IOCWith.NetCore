namespace IOCWith.NetCore.Console;

public class BusinessLogic(IDAL dal)
{
    private readonly IDAL _dal = dal;
    public List<Product> GetProducts() => _dal.GetProducts();
}
