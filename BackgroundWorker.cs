using System;
using System.Threading;
using System.Threading.Tasks;
using Contracts;
using MassTransit;
using Microsoft.Extensions.Hosting;

namespace GloriousMassTransit
{
    public class BackgroundWorker : BackgroundService
    {
        private readonly IBus _bus;

        public BackgroundWorker(IBus bus)
        {
            _bus = bus;
        }


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await _bus.Publish(new GloriousMessage()
                {
                    Name = "Amjad"
                }, stoppingToken);

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}