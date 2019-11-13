using System.Collections.Generic;

namespace chefsndishes.Models
{
    public class DisplayDishesViewModel
    {
        public Dish Dishes { get; set; }
        public List<Chef> Chefs { get; set; }
        public Chef chef { get; set;}
    }
}