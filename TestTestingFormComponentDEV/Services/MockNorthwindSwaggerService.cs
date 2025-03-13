using TestingFormComponentDEV.Models.NorthwindSwagger;

namespace TestingFormComponentDEV.NorthwindSwagger
{
    public class MockNorthwindSwaggerService : INorthwindSwaggerService
    {
        public Task<CustomerDto> PostCustomerDto(object? data)
        {
            return Task.FromResult<CustomerDto>(new());
        }
    }
}
