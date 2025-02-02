namespace GitPractice.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestI => !string.IsNullOrEmpty(RequestId);
    }
}
