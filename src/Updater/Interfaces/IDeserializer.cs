namespace Updater.Interfaces
{
    public interface IDeserializer
    {
        T Deserialize<T>(string input);
    }
}