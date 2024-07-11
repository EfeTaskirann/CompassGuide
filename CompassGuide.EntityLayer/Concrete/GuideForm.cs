namespace CompassGuide.EntityLayer.Concrete;

public class GuideForm
{
    public int GuideFormId { get; set; }
    public string GuideFormTitle {get; set; }
    public string FormName { get; set; }
    public string FormDescription { get; set; }
    public List<FormImage> FormImages { get; set; }
    public bool FormStatus { get; set; }

    public int MenuId { get; set; }
    public Menu Menu { get; set; }


}