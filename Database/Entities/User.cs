using Database.Interfaces;

namespace Database.Entities;

public class User : IUser
{
    public int Id { get; set; }
    public string Name { get; set; }
}