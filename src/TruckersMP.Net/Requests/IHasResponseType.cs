using System.Threading.Tasks;

namespace TruckersMP.Net.Requests
{
    public interface IRequestHasNoParams<TResponse>
    {
        public Task<TResponse> SendAsync();
    }

    public interface IRequestHasOneParam<TResponse, in T1>
    {
        public Task<TResponse> SendAsync(T1 arg1);
    }

    public interface IRequestHasTwoParams<TResponse, in T1, in T2>
    {
        public Task<TResponse> SendAsync(T1 arg1, T2 memberId);
    }
}