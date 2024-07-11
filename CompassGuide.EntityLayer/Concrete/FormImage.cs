namespace CompassGuide.EntityLayer.Concrete;

public class FormImage
{
    public int FormImageId { get; set; }
    public string ImageFileName { get; set; }
    public string ContentType { get; set; }
    public byte[] Content { get; set; }
    public int size { get; set; }
    public string ImagePath { get; set; }
    public int GuideFormId { get; set; }
    public GuideForm GuideForm { get; set; }

}