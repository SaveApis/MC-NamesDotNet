using System.Collections.ObjectModel;

namespace MCNamesApi.Core.Models;

public class HistoryName
{
    public Name Name { get; set; }
    public ReadOnlyCollection<HistNameDateRelation> HistNameDateRelations { get; set; }
}