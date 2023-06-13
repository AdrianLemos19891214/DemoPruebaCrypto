namespace CryptoAPI.Models
{
    [Serializable]
    public class Status
    {
        public DateTime Timestamp { get; set; }
        public int Error_Code { get; set; }
        public object Error_Message { get; set; }
        public int Elapsed { get; set; }
        public int Credit_Count { get; set; }
        public object Notice { get; set; }
    }

    [Serializable]
    public class USD
    {
        public double Price { get; set; }
        public double Volume_24h { get; set; }
        public double Volume_Change_24h { get; set; }
        public double Percent_Change_1h { get; set; }
        public double Percent_Change_24h { get; set; }
        public double Percent_Change_7d { get; set; }
        public double Percent_Change_30d { get; set; }
        public double Market_Cap { get; set; }
        public int Market_Cap_Dominance { get; set; }
        public double Fully_Diluted_Market_Cap { get; set; }
        public DateTime Last_Updated { get; set; }
    }

    [Serializable]
    public class Quote
    {
        public USD USD { get; set; }
    }

    [Serializable]
    public class CryptoData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Slug { get; set; }
        public int Is_Active { get; set; }
        public object Is_Fiat { get; set; }
        public int Circulating_Supply { get; set; }
        public int Total_Supply { get; set; }
        public int Max_Supply { get; set; }
        public DateTime Date_Added { get; set; }
        public int Num_Market_Pairs { get; set; }
        public int Cmc_Rank { get; set; }
        public DateTime Last_Updated { get; set; }
        public List<string> Tags { get; set; }
        public object Platform { get; set; }
        public object Self_Reported_Circulating_Supply { get; set; }
        public object Self_Reported_Market_Cap { get; set; }
        public Quote Quote { get; set; }
    }

    [Serializable]
    public class Response
    {
        public Status Status { get; set; }
        public Dictionary<string, CryptoData> Data { get; set; }
    }
}
