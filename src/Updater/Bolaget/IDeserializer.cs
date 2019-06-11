namespace Updater.Bolaget
{
    public interface IDeserializer
    {
        T Deserialize<T>(string input);
    }
}