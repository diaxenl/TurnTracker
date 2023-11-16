using Microsoft.AspNetCore.Mvc;
using Player_NPC_Tracker.Services;
using System.Threading.Tasks;

namespace Player_NPC_Tracker.Controllers
{
    public class TurnOrderController : Controller
    {
        private readonly DndApiClient _apiClient;

        public TurnOrderController(DndApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<IActionResult> Index()
        {
            // Example endpoint might be "monsters" or "spells"
            string endpoint = "monsters";
            string result = await _apiClient.GetAsync(endpoint);

            // Process the result as needed and pass it to the view
            // For now, let's just print it to the console
            Console.WriteLine(result);

            return View();
        }
    }
}
