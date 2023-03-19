using System.Collections;

namespace ContactBook;

/// <summary>
/// Implements base functionality for contact store
/// </summary>
public abstract class BaseContactStore : IEnumerable<IContact>, IManageable
{
    /// <summary>
    /// Provides source for contact collection
    /// </summary>
    private readonly IContactProvider _contactProvider;

    /// <summary>
    /// Contact collection
    /// </summary>
    protected List<IContact> _contacts;

    /// <summary>
    /// Creates base contact store with contact provider injected
    /// </summary>
    /// <param name="contactProvider"></param>
    protected BaseContactStore(IContactProvider contactProvider)
    {
        _contactProvider = contactProvider;
        _contacts = _contactProvider.Get().ToList();
    }

    /// <summary>
    /// Enumerator for using contact generic collection in the foreach
    /// </summary>
    /// <returns></returns>
    public IEnumerator<IContact> GetEnumerator()
    {
        return _contacts.GetEnumerator();
    }

    /// <summary>
    /// Enumerator for using collection in the foreach
    /// </summary>
    /// <returns></returns>
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public abstract void Create(IContact contact);

    public abstract IContact GetById(int id);

    public abstract IEnumerable<IContact> GetByName(string name);

    public abstract IEnumerable<IContact> GetByPhoneNumber(string phoneNumber);

    public abstract bool Remove(int id);

    public abstract void Update(IContact contact);
}