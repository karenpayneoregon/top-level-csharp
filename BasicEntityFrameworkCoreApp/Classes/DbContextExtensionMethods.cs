using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BasicEntityFrameworkCoreApp.Classes
{
    public static class ExtensionMethods
    {
        
        public static async Task<bool> TestConnectionTask(this DbContext context) 
            => await Task.Run(async () => await context.Database.CanConnectAsync());

        public static async Task<bool> TestConnectionTask(this DbContext context, CancellationToken token) 
            => await Task.Run(async () => await context.Database.CanConnectAsync(token), token);
    }
}