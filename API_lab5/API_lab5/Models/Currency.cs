namespace API_lab5.Models;

public class Currency
{
    public string code { get; set; }
    public string msg { get; set; }
    public Convert_Result convert_result { get; set; }
    public Time_Update time_update { get; set; }
}
