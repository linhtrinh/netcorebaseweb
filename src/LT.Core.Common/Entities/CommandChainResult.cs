namespace LT.Core.Common.Entities;

public class CommandChainResult
{
    public bool IsSuccess { get; set; }
    public List<string> MessageLanguageKeys { get; set; }
    public List<string> Messages { get; set; }
    public Dictionary<string, object> ResultData { get; set; }
}