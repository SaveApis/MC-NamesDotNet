namespace MCNamesApi.Core.Models;

public class Name
{
    public Guid Uuid { get; set; }
    public string DisplayName { get; set; }
    public DateTime Since { get; set; }
}