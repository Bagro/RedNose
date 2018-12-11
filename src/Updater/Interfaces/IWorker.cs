using System.Threading.Tasks;

namespace Updater.Interfaces
{
    public interface IWorker
    {
        Task DoWork();
    }
}