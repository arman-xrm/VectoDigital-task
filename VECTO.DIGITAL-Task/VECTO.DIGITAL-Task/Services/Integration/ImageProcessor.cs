using Microsoft.Extensions.Options;
using VECTO.DIGITAL_Task.Models.Config;
using VECTO.DIGITAL_Task.Services.Interface;

namespace VECTO.DIGITAL_Task.Services.Integration
{
    public class ImageProcessor : IImageProcessor
    {

        private List<IImagePlugin> plugins = new List<IImagePlugin>();
        private IOptions<PluginConfigs> _pluginConfigs;

        public ImageProcessor(IOptions<PluginConfigs> pluginConfigs)
        {
            _pluginConfigs = pluginConfigs;
        }
        public async Task AddPlugin()
        {
            foreach (var pluginName in _pluginConfigs.Value.Plugins)
            {
                plugins.Add(new ImagePlugin(pluginName));
            }
            
        }
        public async Task<IEnumerable<string>> GetActivePlugins()
        {
            return plugins.Select(x => x.Name).ToList();
        }
        public async Task<byte[]> ApplyEffects(byte[] image, int radius, int size, string effectName)
        {
            
               return await plugins.FirstOrDefault(x => x.Name == effectName).ApplyEffect(image, radius, size);
            
        }
    }
}
