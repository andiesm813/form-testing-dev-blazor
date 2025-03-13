using TestingFormComponentDEV.Models.NorthwindSwagger;

namespace TestingFormComponentDEV.NorthwindSwagger
{
    public interface INorthwindSwaggerService
    {
        Task<CustomerDto> PostCustomerDto(object? data);
    }
}
