using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorApp2.Models;


namespace BlazorApp2.Services
{
    public interface IEventWidgetService
    {
        Task<List<EventWidget>> GetWidgetsForCurrentDate();
        Task AddWidget(EventWidget widget, List<byte[]> images);
        Task<EventWidget> GetWidgetById(int id);
        Task UpdateWidget(EventWidget widget);
        Task DeleteWidget(int id);
    }
}
