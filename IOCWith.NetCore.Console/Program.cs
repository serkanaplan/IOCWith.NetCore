using IOCWith.NetCore.Console;

BusinessLogic bl = new(new OracleDAL());

bl.GetProducts().ForEach(x =>
    
    Console.WriteLine($"{x.Id}-{x.Name}-{x.Price}-{x.Stock}")
);
