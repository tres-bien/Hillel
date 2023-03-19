using System.Collections;
using HomeWork.Interfaces;

namespace HomeWork;

/// <summary>
/// Implements base functionality for contact store
/// </summary>
public abstract class BaseContactStore : IEnumerable<IContact>
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
}