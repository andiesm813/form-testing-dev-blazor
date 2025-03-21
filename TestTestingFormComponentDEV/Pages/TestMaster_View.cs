using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TestingFormComponentDEV.Pages;
using TestingFormComponentDEV.NorthwindSwagger;

namespace TestTestingFormComponentDEV
{
  [Collection("TestingFormComponentDEV")]
  public class TestMaster_View
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbInputModule),
        typeof(IgbButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbSnackbarModule),
        typeof(IgbListModule),
        typeof(IgbAvatarModule),
        typeof(IgbRadioGroupModule),
        typeof(IgbRadioModule));
      ctx.Services.AddScoped<INorthwindSwaggerService>(sp => new MockNorthwindSwaggerService());
      var componentUnderTest = ctx.RenderComponent<Master_View>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
