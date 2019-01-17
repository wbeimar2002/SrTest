
namespace SrTest.DM.Configuration
{
    using AutoMapper;
    using SrTest.DM.Persistance;
    using SrTest.DTO;

    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeDTO>();
                cfg.CreateMap<Employee, HourlyEmployeeDTO>();
                cfg.CreateMap<Employee, MonthlyEmployeeDTO>();
                cfg.CreateMap<EmployeePayload, HourlyEmployeeDTO>();
                cfg.CreateMap<EmployeePayload, MonthlyEmployeeDTO>();
                cfg.CreateMap<EmployeePayload, EmployeeDTO>();
                cfg.CreateMap<Employee, EmployeePayload>();

            }
            );
        }
    }
}
