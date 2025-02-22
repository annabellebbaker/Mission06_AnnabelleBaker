namespace Mission06_AnnabelleBaker.Models
{
    public class ErrorViewModel // error handling model
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
