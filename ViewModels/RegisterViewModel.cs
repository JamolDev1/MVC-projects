namespace MVCLP.ViewModels;


public class RegisterViewModel
{
    public string ReturnUrl { get; set; }
    
    public string Fullname { get; set; }
    public string Username { get; set; }
    
    public string Password { get; set; }
    
    public Guid Email { get; set; }
    
}