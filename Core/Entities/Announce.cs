namespace Core.Entities
{
    public class Announce : BaseEntity
    {        
        public string Header { get; set; }
        public string Text { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Source { get; set; }
        public AnnounceType AnnounceType { get; set; }
        public int ProductTypeId { get; set; }
        public string Location { get; set; }
        public string? AdditionalDetails { get; set; }


    }
}
