Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting
Imports DesafioVB.Data
Imports DesafioVB.Business.Services
Imports DesafioVB.Entities.Interfaces.Repositories
Imports DesafioVB.CossCutting.DesafioVB.Common
Imports DesafioVB.Business.Interfaces.Services
Imports DesafioVB.CossCutting
Imports Microsoft.Extensions.Logging
Imports DesafioVB.Entities.Notifications

Friend Module Program

    <STAThread()>
    Friend Sub Main()

        Dim builder As HostApplicationBuilder = Host.CreateApplicationBuilder()

        Dim connectionString As String = "Server=(localdb)\mssqllocaldb;Database=DataBaseXYZ;Trusted_Connection=True;"

        builder.Services.Configure(Of DatabaseSettings)(Sub(options) options.ConnectionString = connectionString)

        builder.Services.AddTransient(Of ITransacaoService, TransacaoService)()
        builder.Services.AddTransient(Of ITransacaoRepository, TransacaoRepository)()
        builder.Services.AddScoped(Of INotification, MessageBoxNotification)()

        builder.Services.AddLogging()


        builder.Services.AddTransient(Of Form1)()

        ConfiguracaoMapeamento.RegistrarMapeamentos()

        Dim app = builder.Build()

        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Dim form1 = app.Services.GetRequiredService(Of Form1)()
        Application.Run(form1)

    End Sub
End Module
