using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorApp2.Models;


namespace BlazorApp2.Services
{
    public interface IEventWidgetService
    {
        Task<List<EventWidget>> GetAllWidgets();
        Task<List<EventWidget>> GetWidgetsForCurrentDate();

        Task<List<EventWidget>> SortWidgetsByDate();
        Task AddWidget(EventWidget widget, List<byte[]> images);
        Task<EventWidget> GetWidgetById(Guid id);
        Task UpdateWidget(EventWidget widget, List<byte[]> images);
        Task DeleteWidget(Guid id);

    }
}
