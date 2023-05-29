using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorApp1.Data;
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services
{
    public class EventWidgetService : IEventWidgetService
    {
        private readonly AppDbContext _dbContext;

        public EventWidgetService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<EventWidget>> GetAllWidgets()
        {
            return await _dbContext.EventWidgets.ToListAsync();
        }

        public async Task<EventWidget> GetWidgetById(int id)
        {
            return await _dbContext.EventWidgets.FindAsync(id);
        }

        public async Task AddWidget(EventWidget widget)
        {
            _dbContext.EventWidgets.Add(widget);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateWidget(EventWidget widget)
        {
            _dbContext.Entry(widget).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteWidget(int id)
        {
            var widget = await _dbContext.EventWidgets.FindAsync(id);
            _dbContext.EventWidgets.Remove(widget);
            await _dbContext.SaveChangesAsync();
        }
    }
}