using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TODO.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string Message { get; private set; } = "Hello, world";
        public uint counter;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            counter++;
            Message = $"{counter}";
        }
    }
}