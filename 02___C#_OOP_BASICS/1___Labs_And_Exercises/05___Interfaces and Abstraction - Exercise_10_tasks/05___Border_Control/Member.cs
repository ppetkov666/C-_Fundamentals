public abstract class Member : IIdentifiable
{
    protected Member(string id)
    {
        this.Id = id;
    }

    public string Id { get; }

    public bool HasInvalidIdEnding(string pattern)
    {
        return this.Id.EndsWith(pattern);
    }
}