namespace ContactBook;

public interface IContactSaveable
{
    /// <summary>
    /// Saves contacts to any storage
    /// </summary>
    /// <param name="items"></param>
    /// <returns></returns>
    bool Save(IEnumerable<IContact> items);
}