using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

public class MyHostedService : IHostedService, IDisposable
{
    private Timer? _timer;


    public Task StartAsync(CancellationToken cancellationToken)
    {
        _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
        return Task.CompletedTask;
    }

    private void DoWork(object? state)
    {
        try
        {
            // Lógica do serviço a ser executada periodicamente
            Console.WriteLine("Executando serviço...");

            // Adicione qualquer lógica adicional que você precise executar aqui

            // Exemplo: Lidar com erros
            //throw new Exception("Erro durante a execução do serviço.");

            // Exemplo: Realizar outras tarefas específicas
            //RealizarOutraTarefa();
        }
        catch (Exception ex)
        {
            // Trate o erro de acordo com a sua necessidade
            Console.WriteLine("Ocorreu um erro durante a execução do serviço: " + ex.Message);
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _timer?.Change(Timeout.Infinite, 0);
        return Task.CompletedTask;
    }

    public void Dispose()
    {
        _timer?.Dispose();
    }
}
