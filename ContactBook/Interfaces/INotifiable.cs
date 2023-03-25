namespace ContactBook;

/// <summary>
/// Delegate for storing handler for future saving contacts
/// </summary>
/// <param name="contacts"></param>
/// <returns></returns>
public delegate bool SaveDelegate(IEnumerable<IContact> contacts);

/// <summary>
/// Notifies observers that save event is committed
/// </summary>
public interface INotifiable
{
    /// <summary>
    /// Raises save event
    /// </summary>
    event SaveDelegate SaveEvent;
}