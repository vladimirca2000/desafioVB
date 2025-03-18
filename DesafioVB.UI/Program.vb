Imports Microsoft.EntityFrameworkCore
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting
Imports DesafioVB.Data.DesafioVB.Data.Context

Friend Module Program

    <STAThread()>
    Friend Sub Main()
        ' Criar um HostApplicationBuilder manualmente
        Dim builder As HostApplicationBuilder = Host.CreateApplicationBuilder()

        ' Connection String
        Dim connectionString As String = "Server=(localdb)\mssqllocaldb;Database=DataBaseXYZ;Trusted_Connection=True;"

        ' Adiciona o DbContext ao container de DI
        builder.Services.AddDbContext(Of XYZContext)(
            Sub(options) options.UseSqlServer(connectionString)
        )

        ' Adiciona Form1 ao container de DI
        builder.Services.AddTransient(Of Form1)()

        ' Compila o provedor de serviços
        Dim app = builder.Build()

        ' Inicializa a aplicação Windows Forms com injeção de dependência
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Obtém uma instância de Form1 injetada com XYZContext
        Dim form1 = app.Services.GetRequiredService(Of Form1)()
        Application.Run(form1)
    End Sub

End Module