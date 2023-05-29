using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp2.Data;
using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Services
{
    public class EventWidgetService : IEventWidgetService
    {
        private readonly AppDbContext _context;

        public EventWidgetService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<EventWidget>> GetWidgetsForCurrentDate()
        {
            var currentDate = DateTime.Now.Date;

            return await _context.EventWidgets
                .Where(widget => widget.EventDate.Date == currentDate)
                .ToListAsync();
        }

        public async Task AddWidget(EventWidget widget)
        {
            _context.EventWidgets.Add(widget);
            await _context.SaveChangesAsync();
        }
    }

}