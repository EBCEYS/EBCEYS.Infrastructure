# Summary
<details open><summary>Summary</summary>

|||
|:---|:---|
| Generated on: | 03/12/2026 - 05:09:38 |
| Coverage date: | 03/12/2026 - 05:08:56 - 03/12/2026 - 05:09:35 |
| Parser: | MultiReport (4x Cobertura) |
| Assemblies: | 4 |
| Classes: | 128 |
| Files: | 92 |
| **Line coverage:** | 46.2% (2195 of 4744) |
| Covered lines: | 2195 |
| Uncovered lines: | 2549 |
| Coverable lines: | 4744 |
| Total lines: | 10172 |
| **Branch coverage:** | 24.4% (314 of 1282) |
| Covered branches: | 314 |
| Total branches: | 1282 |
| **Method coverage:** | [Feature is only available for sponsors](https://reportgenerator.io/pro) |

</details>

## Coverage
<details><summary>Ebceys.Infrastructure - 53.1%</summary>

|**Name**|**Line**|**Branch**|
|:---|---:|---:|
|**Ebceys.Infrastructure**|**53.1%**|**37.9%**|
|Ebceys.Infrastructure.ConfiguredApp|0%|0%|
|Ebceys.Infrastructure.ControllerFilters.ApiExceptionFilter|100%|100%|
|Ebceys.Infrastructure.Controllers.ServiceController|67.8%|50%|
|Ebceys.Infrastructure.DatabaseRegistration.Conversions.DateTimeOffsetConver<br/>ter|100%||
|Ebceys.Infrastructure.DatabaseRegistration.DbContextRegistrationExtensions|76%||
|Ebceys.Infrastructure.DatabaseRegistration.DbContextRegistrationOptions|100%||
|Ebceys.Infrastructure.DatabaseRegistration.DbContextRegistrationOptionsVali<br/>dator|100%||
|Ebceys.Infrastructure.DatabaseRegistration.MigrationApplierService`1|80%|75%|
|Ebceys.Infrastructure.Exceptions.ApiException|100%||
|Ebceys.Infrastructure.Exceptions.ApiExceptionHelper|83.1%|53.3%|
|Ebceys.Infrastructure.Extensions.EbIApplicationBuilderExtensions|100%||
|Ebceys.Infrastructure.Extensions.EbIServiceCollectionExtensions|40%||
|Ebceys.Infrastructure.Extensions.EbIServiceProviderExtensions|50%||
|Ebceys.Infrastructure.Extensions.EbObjectExtensions|100%||
|Ebceys.Infrastructure.Extensions.EbServerExtensions|100%|100%|
|Ebceys.Infrastructure.ExtraStartupBase|97.8%|90.9%|
|Ebceys.Infrastructure.HealthChecks.HealthCheckConfiguration|100%||
|Ebceys.Infrastructure.HealthChecks.HealthChecksCollectorService|100%||
|Ebceys.Infrastructure.HealthChecks.HealthchecksRegistrationExtensions|100%|100%|
|Ebceys.Infrastructure.Helpers.CommandExecutor|7.1%|0%|
|Ebceys.Infrastructure.Helpers.Json.DefaultJsonSerializerOptions|100%||
|Ebceys.Infrastructure.Helpers.Jwt.JwtGenerator|85%|50%|
|Ebceys.Infrastructure.Helpers.Jwt.JwtObjectsExtensions|100%||
|Ebceys.Infrastructure.Helpers.Jwt.JwtValidator|58.3%||
|Ebceys.Infrastructure.Helpers.PaginationData|100%||
|Ebceys.Infrastructure.Helpers.PaginationExecutor|94.2%|80%|
|Ebceys.Infrastructure.Helpers.ScopedCommandExecutor|100%|75%|
|Ebceys.Infrastructure.Helpers.Sequences.AtomicGeneratorsExtensions|100%||
|Ebceys.Infrastructure.Helpers.Sequences.AtomicIntGenerator|100%|50%|
|Ebceys.Infrastructure.Helpers.Sequences.AtomicLongGenerator|100%|50%|
|Ebceys.Infrastructure.Helpers.Swagger.ConfigureSwaggerOptions|86.9%|83.3%|
|Ebceys.Infrastructure.HttpClient.ClientBase|70.5%|77.2%|
|Ebceys.Infrastructure.HttpClient.ClientBaseTokenResolver|45.4%|50%|
|Ebceys.Infrastructure.HttpClient.ClientBaseUrlResolver|72.7%||
|Ebceys.Infrastructure.HttpClient.ClientRegistration.ClientBaseRegistrationR<br/>egistrator`2|69.3%|61.1%|
|Ebceys.Infrastructure.HttpClient.ClientRegistration.ClientConfiguration|100%||
|Ebceys.Infrastructure.HttpClient.ClientRegistration.ClientConfigurationVali<br/>dator|100%||
|Ebceys.Infrastructure.HttpClient.ClientRegistration.ClientRegistrationExten<br/>sions|100%||
|Ebceys.Infrastructure.HttpClient.DefaultClientPollyHelper|85.7%|0%|
|Ebceys.Infrastructure.HttpClient.OperationResult`1|100%|100%|
|Ebceys.Infrastructure.HttpClient.OperationResult`2|74.4%|50%|
|Ebceys.Infrastructure.HttpClient.ServiceClient.ServiceSystemClient|75.6%|50%|
|Ebceys.Infrastructure.HttpClient.TokenManager.FromContextClientTokenManager<br/>`1|100%|75%|
|Ebceys.Infrastructure.Middlewares.ExceptionCatcherMiddleware|90%||
|Ebceys.Infrastructure.Middlewares.HttpLoggingOptions|100%||
|Ebceys.Infrastructure.Middlewares.RequestLoggingMiddleware|83.6%|81.2%|
|Ebceys.Infrastructure.Middlewares.RequestMetricsMiddleware|79.1%|75%|
|Ebceys.Infrastructure.Models.ProblemDetailsResult|100%||
|Ebceys.Infrastructure.Models.ServiceApiInfo|100%||
|Ebceys.Infrastructure.Options.JwtOptions|100%||
|Ebceys.Infrastructure.Options.RabbitMqExtensions|13.2%|6.2%|
|Ebceys.Infrastructure.Options.SimpleRabbitMqConfiguration|100%|100%|
|Ebceys.Infrastructure.Options.SimpleRabbitMqConfigurationExtensions|100%|100%|
|Ebceys.Infrastructure.Options.SimpleRabbitMqConfigurationValidator|100%||
|Ebceys.Infrastructure.RabbitMq.EbRabbitMqClient|54.9%||
|Ebceys.Infrastructure.RabbitMq.RabbitMqRegistrationExtensions|88.4%|66.6%|
|Ebceys.Infrastructure.Scheduling.ScheduledJobsRunner|100%||
|Ebceys.Infrastructure.Scheduling.ScheduledJobsRunnerOptions|100%||
|Ebceys.Infrastructure.Scheduling.SchedulingExtensions|72.5%||
|Ebceys.Infrastructure.Services.ExecutedServices.BeforeHostingStartedService<br/>Extensions|100%|100%|
|Ebceys.Infrastructure.Validation.ValidatorExtensions|50%|50%|
|Ebceys.Infrastructure.WebApplicationBase`1|0%|0%|
|Microsoft.AspNetCore.OpenApi.Generated|0%|0%|
|System.Runtime.CompilerServices|0%||

</details>
<details><summary>Ebceys.Infrastructure.AuthorizationTestApplication - 18.3%</summary>

|**Name**|**Line**|**Branch**|
|:---|---:|---:|
|**Ebceys.Infrastructure.AuthorizationTestApplication**|**18.3%**|**4.5%**|
|Ebceys.Infrastructure.AuthorizationTestApplication.AuthorizationStartup|100%||
|Ebceys.Infrastructure.AuthorizationTestApplication.BoundedContext.GenerateT<br/>okenRequest|100%||
|Ebceys.Infrastructure.AuthorizationTestApplication.BoundedContext.GenerateT<br/>okenResponse|100%||
|Ebceys.Infrastructure.AuthorizationTestApplication.Client.AppRabbitClient|100%||
|Ebceys.Infrastructure.AuthorizationTestApplication.Client.AuthAppClient|90.3%|75%|
|Ebceys.Infrastructure.AuthorizationTestApplication.Controllers.AuthControll<br/>er|75%|66.6%|
|Ebceys.Infrastructure.AuthorizationTestApplication.Program|0%||
|Ebceys.Infrastructure.AuthorizationTestApplication.Rabbit.RabbitMqControlle<br/>r|100%||
|Ebceys.Infrastructure.AuthorizationTestApplication.SchedulingJobs.LogSomeJo<br/>b|100%||
|Microsoft.AspNetCore.OpenApi.Generated|0%|0%|
|System.Runtime.CompilerServices|0%||

</details>
<details><summary>Ebceys.Infrastructure.TestApplication - 47.2%</summary>

|**Name**|**Line**|**Branch**|
|:---|---:|---:|
|**Ebceys.Infrastructure.TestApplication**|**47.2%**|**13%**|
|Ebceys.Infrastructure.TestApplication.BoundedContext.Requests.ChangeNameReq<br/>uest|100%||
|Ebceys.Infrastructure.TestApplication.BoundedContext.Requests.SomeBodyReque<br/>st|100%||
|Ebceys.Infrastructure.TestApplication.BoundedContext.Responses.CommandResul<br/>tResponse|100%||
|Ebceys.Infrastructure.TestApplication.BoundedContext.Responses.EntityRespon<br/>seDto|100%||
|Ebceys.Infrastructure.TestApplication.BoundedContext.Responses.SomeBodyResp<br/>onse|100%||
|Ebceys.Infrastructure.TestApplication.Client.Implementations.TestApplicatio<br/>nClient|100%||
|Ebceys.Infrastructure.TestApplication.Client.Implementations.TestClient|85.9%|69%|
|Ebceys.Infrastructure.TestApplication.Commands.AddEntityCommand|100%||
|Ebceys.Infrastructure.TestApplication.Commands.AddEntityCommandContext|100%||
|Ebceys.Infrastructure.TestApplication.Commands.AddEntityCommandResult|100%||
|Ebceys.Infrastructure.TestApplication.Commands.DeleteElementCommand|100%||
|Ebceys.Infrastructure.TestApplication.Commands.DeleteElementCommandContext|100%||
|Ebceys.Infrastructure.TestApplication.Commands.DeleteElementCommandResult|100%||
|Ebceys.Infrastructure.TestApplication.Commands.GetEntitiesCommand|100%||
|Ebceys.Infrastructure.TestApplication.Commands.GetEntitiesCommandResult|100%||
|Ebceys.Infrastructure.TestApplication.Commands.UpdateEntityCommand|100%|100%|
|Ebceys.Infrastructure.TestApplication.Commands.UpdateEntityCommandContext|100%||
|Ebceys.Infrastructure.TestApplication.Controllers.TestController|100%|100%|
|Ebceys.Infrastructure.TestApplication.Controllers.V2.TestV2Controller|0%||
|Ebceys.Infrastructure.TestApplication.DaL.DataModelContext|100%||
|Ebceys.Infrastructure.TestApplication.DaL.TestTableDbo|100%||
|Ebceys.Infrastructure.TestApplication.Migrations.DataModelContextModelSnaps<br/>hot|100%||
|Ebceys.Infrastructure.TestApplication.Migrations.Initial|92%||
|Ebceys.Infrastructure.TestApplication.Program|0%||
|Ebceys.Infrastructure.TestApplication.Startup|100%||
|Ebceys.Infrastructure.TestApplication.TestAppInitiator|0%||
|Ebceys.Infrastructure.TestApplication.Validators.ChangeNameRequestValidator|100%||
|Ebceys.Infrastructure.TestApplication.Validators.SomeBodyRequestValidator|100%||
|Microsoft.AspNetCore.OpenApi.Generated|0%|0%|
|System.Runtime.CompilerServices|0%||

</details>
<details><summary>Ebceys.Tests.Infrastructure - 43.9%</summary>

|**Name**|**Line**|**Branch**|
|:---|---:|---:|
|**Ebceys.Tests.Infrastructure**|**43.9%**|**26.2%**|
|AutoGeneratedProgram|0%||
|Ebceys.Tests.Infrastructure.Helpers.EbRandomizer|73.1%|96.4%|
|Ebceys.Tests.Infrastructure.Helpers.PortSelector|78.5%|50%|
|Ebceys.Tests.Infrastructure.Helpers.StopWatchElapser|100%||
|Ebceys.Tests.Infrastructure.Helpers.TestCaseSources.EbTestCaseData`1|100%||
|Ebceys.Tests.Infrastructure.Helpers.TestCaseSources.EbTestDataInvalidExecut<br/>or`2|100%||
|Ebceys.Tests.Infrastructure.Helpers.TestCaseSources.EbTestDataValidExecutor<br/>`2|100%|100%|
|Ebceys.Tests.Infrastructure.Helpers.TestCaseSources.TestCaseEnumerator`1|100%|100%|
|Ebceys.Tests.Infrastructure.IntegrationTests.ExternalServices.Containers.Ex<br/>ternalDependenciesExtensions|79.1%|100%|
|Ebceys.Tests.Infrastructure.IntegrationTests.ExternalServices.Containers.Po<br/>stgresInitializer|83.3%|50%|
|Ebceys.Tests.Infrastructure.IntegrationTests.ExternalServices.Containers.Ra<br/>bbitMqInitializer|100%|50%|
|Ebceys.Tests.Infrastructure.IntegrationTests.TestRoutingMessageHandler|94.4%|75%|
|Ebceys.Tests.Infrastructure.IntegrationTests.TestsExtensions|100%||
|Ebceys.Tests.Infrastructure.IntegrationTests.WebApplication.ClientTestConte<br/>xt`2|95.8%|100%|
|Ebceys.Tests.Infrastructure.IntegrationTests.WebApplication.RoutingMessageH<br/>andler|33.3%|14.2%|
|Ebceys.Tests.Infrastructure.IntegrationTests.WebApplication.RoutingMessageH<br/>andlerConfiguration|72.7%||
|Ebceys.Tests.Infrastructure.IntegrationTests.WebApplication.ServiceTestCont<br/>ext`1|92.3%|88.8%|
|Ebceys.Tests.Infrastructure.IntegrationTests.WebApplication.TestClientIniti<br/>alizeOptions|100%||
|Ebceys.Tests.Infrastructure.IntegrationTests.WebApplication.TestWebApplicat<br/>ionFactory`1|44.3%|100%|
|Microsoft.AspNetCore.OpenApi.Generated|0%|0%|
|System.Runtime.CompilerServices|0%||
|System.Text.RegularExpressions.Generated|100%|87.5%|
|System.Text.RegularExpressions.Generated.<RegexGenerator_g>F6EC8DEE418DE02E<br/>CF1F285F160C4E86EB83028C77905B7D401FAD9968140E17A__LatAlphabetAndNumsRegex_<br/>0|100%|100%|

</details>
