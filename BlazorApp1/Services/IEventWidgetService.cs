using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorApp1.Models;


namespace BlazorApp1.Services
{
    public interface IEventWidgetService
    {
        Task<List<EventWidget>> GetAllWidgets();
        Task<EventWidget> GetWidgetById(int id);
        Task AddWidget(EventWidget widget);
        Task UpdateWidget(EventWidget widget);
        Task DeleteWidget(int id);
    }
}
