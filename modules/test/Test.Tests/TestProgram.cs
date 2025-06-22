using Test.Tests;
using Microsoft.AspNetCore.Builder;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("Test.csproj"); 
await builder.RunAbpModuleAsync<TestTestsModule>(applicationName: "Test");

public partial class TestProgram
{
}
