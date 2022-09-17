namespace Models.Out;

public class UserBasicInfoModel
{

    public UserBasicInfoModel()
    {
        Name = "";
        Surname = "";
    }

    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Surname { get; set; }
}