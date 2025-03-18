Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting
Imports DesafioVB.Data

Friend Module Program

    <STAThread()>
    Friend Sub Main()
        ' Criar um HostApplicationBuilder manualmente
        Dim builder As HostApplicationBuilder = Host.CreateApplicationBuilder()

        ' Connection String
        Dim connectionString As String = "Server=(localdb)\mssqllocaldb;Database=DataBaseXYZ;Trusted_Connection=True;"

        ' Adiciona o repositório ao container de DI
        builder.Services.AddSingleton(Of TransacaoRepository)(Function(provider) New TransacaoRepository(connectionString))

        ' Adiciona Form1 ao container de DI
        builder.Services.AddTransient(Of Form1)()

        ' Compila o provedor de serviços
        Dim app = builder.Build()

        ' Inicializa a aplicação Windows Forms com injeção de dependência
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Obtém uma instância de Form1 injetada com TransacaoRepository
        Dim form1 = app.Services.GetRequiredService(Of Form1)()
        Application.Run(form1)
    End Sub

End Module
