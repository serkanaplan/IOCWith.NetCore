﻿namespace IOCWith.NetCore.Console.DAL;

public class OracleDAL : IDAL
{
    public List<Product> GetProducts() => 
    [
        new Product{Id=1, Name="Oracle Kalem 1",Price=100,Stock=200},
        new Product{Id=2, Name="Oracle Kalem 2",Price=100,Stock=200},
        new Product{Id=3, Name="OracleKalem 3",Price=100,Stock=200},
        new Product{Id=4, Name="OracleKalem 4",Price=100,Stock=200}
    ];
}
