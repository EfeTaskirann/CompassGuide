namespace CompassGuide.EntityLayer.Concrete;

public class Menu
{
    public int MenuId { get; set; }
    public int MenuParentId { get; set; }
    public string MenuName { get; set; }
    public int MenuOrder { get; set; }
    public string? MenuIcon { get; set; }
    public string MenuUrl { get; set; }
    public bool MenuStatus{ get; set; }

}

