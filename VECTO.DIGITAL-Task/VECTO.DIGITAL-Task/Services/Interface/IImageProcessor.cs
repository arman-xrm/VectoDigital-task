namespace VECTO.DIGITAL_Task.Services.Interface
{
    public interface IImageProcessor
    {
        Task AddPlugin();
        Task<byte[]> ApplyEffects(byte[] image, int radius, int size, string name);
        Task<IEnumerable<string>> GetActivePlugins();
    }
}
