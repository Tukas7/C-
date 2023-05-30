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

        public async Task AddWidget(EventWidget widget, List<byte[]> images)
        {
            widget.Images = images;
            _context.EventWidgets.Add(widget);
            await _context.SaveChangesAsync();
        }

        public async Task<EventWidget> GetWidgetById(int id)
        {
            return await _context.EventWidgets.FindAsync(id);
        }

        public async Task UpdateWidget(EventWidget widget)
        {
            _context.Entry(widget).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteWidget(int id)
        {
            var widget = await _context.EventWidgets.FindAsync(id);
            _context.EventWidgets.Remove(widget);
            await _context.SaveChangesAsync();
        }
    }

}