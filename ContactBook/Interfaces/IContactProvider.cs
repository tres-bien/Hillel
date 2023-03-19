namespace ContactBook;

/// <summary>
/// Provides contact collection
/// </summary>
public interface IContactProvider
{
    /// <summary>
    /// Gets contacts <see cref="IEnumerable{IContact}"/>
    /// </summary>
    /// <returns></returns>
    IEnumerable<IContact> Get();
}