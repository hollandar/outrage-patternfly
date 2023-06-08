using Outrage.EventBus;

namespace Outrage.Patternfly.Components.ManySelect;

public class ManySelectKeysChangedMessage<TKey>: IMessage {

    public ManySelectKeysChangedMessage() { }

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
    public ICollection<TValue> Values { get; set; }
}
