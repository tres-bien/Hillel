namespace HomeWork.Interfaces;

/// <summary>
/// Represent interface for managing contacts
/// </summary>
public interface IManageable
{
    /// <summary>
    /// Creates contact
    /// </summary>
    /// <param name="contact"></param>
    void Create(IContact contact);

    /// <summary>
    /// Removes contacts
    /// </summary>
    /// <param name="id"></param>
    /// <returns>If contact has been removed returns true</returns>
    bool Remove(int id);

    /// <summary>
    /// Gets contact by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns>If contact didn't find returns null</returns>
    IContact GetById(int id);

    /// <summary>
    /// Gets contact by name
    /// </summary>
    /// <param name="name"></param>
    /// <returns>If contact didn't find returns null</returns>
    IEnumerable<IContact> GetByName(string name);

    /// <summary>
    /// Gets contact by phoneNumber
    /// </summary>
    /// <param name="phoneNumber"></param>
    /// <returns>If contact didn't find returns null</returns>
    IEnumerable<IContact> GetByPhoneNumber(string phoneNumber);

    /// <summary>
    /// Updates contact
    /// </summary>
    /// <param name="contact"></param>
    void Update(IContact contact);
}