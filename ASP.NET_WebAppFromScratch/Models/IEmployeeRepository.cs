namespace ASP.NET_WebAppFromScratch.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
    }
}