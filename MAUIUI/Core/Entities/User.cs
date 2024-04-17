using System;
namespace MAUIUI.Core.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string? KVKK1 { get; set; } = "No";
        public string? KVKK2 { get; set; } = "No";
        public string? KVKK3 { get; set; } = "No";
        public string? KVKK4 { get; set; } = "No";
        public Byte[] PasswordHash { get; set; }
        public Byte[] PasswordSalt { get; set; }

        public Dictionary<string, Func<string, object>> Mapping()
        {
            throw new NotImplementedException();
        }
    }
}

