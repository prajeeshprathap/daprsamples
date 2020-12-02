using System.Threading;
using System.Threading.Tasks;

namespace Dapr.Samples.UI.Services
{
    public class CalculatorService
    {
        public async Task<int> Add(int a, int b, CancellationToken cancellationToken)
        {
            return a + b;
        }
        public async Task<int> Subtract(int a, int b, CancellationToken cancellationToken)
        {
            return a - b;
        }
        public async Task<int> Multiply(int a, int b, CancellationToken cancellationToken)
        {
            return a * b;
        }
        public async Task<int> Divide(int a, int b, CancellationToken cancellationToken)
        {

            return a / b;
        }
    }
}
