using System.ComponentModel.DataAnnotations;

namespace BlazorLIMS.Data {

public enum Role {

    GUEST,
    USER,
    ADMIN
}

public class UserModel {

    [Key]
    public int UserModelId { get; set; }

    public string Username { get; set; }
    public string Password { get; set; }
    public Role UserRole { get; set; }
}



}