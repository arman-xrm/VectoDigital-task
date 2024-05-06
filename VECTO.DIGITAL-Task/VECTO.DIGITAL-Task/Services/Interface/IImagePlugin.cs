using System.Drawing;

namespace VECTO.DIGITAL_Task.Services.Interface
{
    public interface IImagePlugin
    {
        string Name { get; }
        Task<byte[]> ApplyEffect(byte[] image, int radius, int size);
    }
}
