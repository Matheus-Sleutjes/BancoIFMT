using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banco.Models;

[Table("User", Schema = "Authenticacao")]
public class UserModel
{
    public UserModel( string userName, string password)
    {
        UserName = userName;
        Password = password;
    }
    
    [Key]
    public int? UserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
