namespace LT.Core.Common.Entities;

public class ServiceContext{
    public int UserId { get; set; }
    public string UserType { get; set; }
    public string Username { get; set; }
    public string FullName { get; set; }
    public string EmailAddress { get; set; }
    public string UserAgent { get; set; }
    public string IpAddress { get; set; }
    public string UserCulture { get; set; }
    public string UserLanguage { get; set; }
    public Dictionary<string, string> UserInfo { get; set; }
    public Guid UserGuid { get; set; }
    public List<Guid> RolesGuid { get; set; }
    public List<Guid> PermissionsGuid { get; set; }

    public ServiceContext()
    {
        this.UserInfo = new Dictionary<string, string>();
        this.RolesGuid = new List<Guid>();
        this.PermissionsGuid = new List<Guid>();
    }
}