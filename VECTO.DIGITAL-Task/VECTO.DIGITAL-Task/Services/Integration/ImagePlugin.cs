using VECTO.DIGITAL_Task.Services.Interface;

namespace VECTO.DIGITAL_Task.Services.Integration
{
    public class ImagePlugin : IImagePlugin
    {
        public string Name { get; private set; }
        public ImagePlugin(string name)
        {
            Name = name;
        }
        public async Task<byte[]> ApplyEffect(byte[] image, int radius, int size)
        {
            return new byte[] { 0x00, 0x00, 0x00, 0x00 };
        }
    }
    
}
