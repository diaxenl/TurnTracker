using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Player_NPC_Tracker.Pages
{
    public class IndexModel : PageModel
    {
        public List<Character> Characters { get; set; } = new List<Character>();

        public void OnGet()
        {
            // This method gets called on every new session, characters won't be saved.
        }

        public void OnPostAddPlayer(string characterName, int initiative)
        {
            if (characterName == "") return;
            Characters.Add(new Character { Name = characterName, Initiative = initiative });
            Characters.Sort((x, y) => y.Initiative.CompareTo(x.Initiative));
        }

        public void Clear()
        {
            Characters.Clear();
        }
    }

    public class Character
    {
        public string Name { get; set; }
        public int Initiative { get; set; }
        public int HPTotal { get; set; }
        public int CurrentHP {  get; set; }
    }
}
