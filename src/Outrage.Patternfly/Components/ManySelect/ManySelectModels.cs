using Outrage.EventBus;
using System.Data;

namespace Outrage.Patternfly.Components.ManySelect;

public class ManySelectKeysChangedMessage<TKey>: IMessage {

    public ManySelectKeysChangedMessage() {
        this.Keys = new();
    }

    public ManySelectKeysChangedMessage(HashSet<TKey> keys)
    {
        this.Keys = keys;
    }

    public HashSet<TKey> Keys { get; set; }
}

public class ManySelectLoadArgs
{
    public ManySelectLoadArgs(int page, int pageSize, string? search)
    {
        this.Page = page;
        this.PageSize = pageSize;
        this.Search = search;
    }

    public int Page { get; }
    public int PageSize { get; }
    public string? Search { get; }
}

public class ManySelectLoadResponse<TValue>
{
    public int Page { get; set; }
    public int PageSize { get; set; }
    public int TotalRecords { get; set; }
    public ICollection<TValue> Values { get; set; } = Array.Empty<TValue>();

    public static ManySelectLoadResponse<TValue> Empty = new ManySelectLoadResponse<TValue> { Page=0, PageSize=0, TotalRecords=0, Values = new List<TValue>() };
}
