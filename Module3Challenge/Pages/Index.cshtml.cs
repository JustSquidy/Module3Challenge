using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module3Challenge.Pages
{
    public class IndexModel : PageModel
    {
        public string HungerMessage { get; set; } = string.Empty;
        public string SoundMessage { get; set; } = string.Empty;
        public string DayMessage { get; set; } = string.Empty;

        public void OnPost()
        {
            // Get the values from the form
            int hungerLevel = int.Parse(Request.Form["hungerLevel"]);
            int dayOfWeek = int.Parse(Request.Form["dayOfWeek"]);

            // Determine hunger response: if hungerLevel is 8 or more, choose the lion message,
            // otherwise fall through to the next conditions below.
            if (hungerLevel >= 8) // check for highest hunger tier
            {
                HungerMessage = "Lion: Roar! I need a big meal!";
            }
            else if (hungerLevel >= 5)
            {
                HungerMessage = "Monkey: Ooh ooh! I'll take some bananas.";
            }
            else
            {
                HungerMessage = "Tortoise: Slow and steady—I'll have some lettuce.";
            }

            SoundMessage = hungerLevel >= 8
                ? "Listen to the Lion: Roar!"
                : "Listen to the Monkey: Ooh ooh!";

            // Evaluate the selected day of the week and set a corresponding message for
            // each case (Sunday through Saturday), with a default for invalid input.
            switch (dayOfWeek) // choose day-based event message
            {
                case 1:
                    DayMessage = "Sunday: Free zoo entry for kids!";
                    break;
                case 2:
                    DayMessage = "Monday: Monkey Show at noon!";
                    break;
                case 3:
                    DayMessage = "Tuesday: Tortoise Feeding Time!";
                    break;
                case 4:
                    DayMessage = "Wednesday: Wildlife Education Day!";
                    break;
                case 5:
                    DayMessage = "Thursday: Lion Training Demo!";
                    break;
                case 6:
                    DayMessage = "Friday: Safari Tour Special!";
                    break;
                case 7:
                    DayMessage = "Saturday: Family Fun Zoo Games!";
                    break;
                default:
                    DayMessage = "Invalid day selected.";
                    break;
            }
        }
    }
}