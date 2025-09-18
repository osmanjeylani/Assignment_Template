namespace Infrastructure.Models;

public interface FileResult
{
    public bool Succeeded { get; set; }
    public string? Error { get; set; }
    public string? Content { get; set; }
}
