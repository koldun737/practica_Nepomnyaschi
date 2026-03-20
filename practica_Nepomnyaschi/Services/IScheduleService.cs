using practica_Nepomnyaschi.DTO;
namespace practica_Nepomnyaschi.Services
{
    public interface IScheduleService
    {
        Task<List<ScheduleByDateDto>> GetScheduleForGroup(string groupName, DateTime
       startDate, DateTime endDate);
    }
}
