using Microsoft.AspNetCore.Mvc;
using MovieRating_App.Models;

namespace MovieRating_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private static readonly IEnumerable<ItemModel> Items = new[]
        {
            new ItemModel{Id =1, Title = "The Godfather", ImageId=1, Ranking=0,ItemType=1 },
            new ItemModel{Id =2, Title = "Highlander", ImageId=2, Ranking=0,ItemType=1 },
            new ItemModel{Id =3, Title = "Highlander II", ImageId=3, Ranking=0,ItemType=1 },
            new ItemModel{Id =4, Title = "The Last of the Mohicans", ImageId=4, Ranking=0,ItemType=1 },
            new ItemModel{Id =5, Title = "Police Academy 6", ImageId=5, Ranking=0,ItemType=1 },
            new ItemModel{Id =6, Title = "Rear Window", ImageId=6, Ranking=0,ItemType=1 },
            new ItemModel{Id =7, Title = "Road House", ImageId=7, Ranking=0,ItemType=1 },
            new ItemModel{Id =8, Title = "The Shawshank Redemption", ImageId=8, Ranking=0,ItemType=1 },
            new ItemModel{Id =9, Title = "Star Treck IV", ImageId=9, Ranking=0,ItemType=1 },
            new ItemModel{Id =10, Title = "Superman 4", ImageId=10, Ranking=0,ItemType=1 },
        };
        [HttpGet("{itemType:int}")]
        public ItemModel[] Get(int itemType)
        {
            ItemModel[] items = Items.Where(i => i.ItemType == itemType).ToArray();
            return items;
        }
    }
}
