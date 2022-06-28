using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto_DevChat.Data;

namespace Proyecto_DevChat.ViewComponents
{
    public class RoomListViewComponent : ViewComponent
    {
        public readonly ApplicationDbContext db;

        public RoomListViewComponent(ApplicationDbContext db)
        {
            this.db = db;
        }

    }
}
