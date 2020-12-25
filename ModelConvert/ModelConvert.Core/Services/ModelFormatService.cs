using ModelConvert.Abstractions;
using ModelConvert.Core.Abstractions.Services;
using System.Collections.Generic;
using System.Linq;

namespace ModelConvert.Core.Services
{
    internal class ModelFormatService : IModelFormatService
    {
        private readonly IReadOnlyList<IPluginFactory> Plugins;

        public ModelFormatService(IEnumerable<IPluginFactory> plugins)
        {
            plugins ??= new List<IPluginFactory>();
            this.Plugins = new List<IPluginFactory>(plugins ?? new List<IPluginFactory>()).AsReadOnly();
        }

        List<IModelFormat> IModelFormatService.GetSupportedImportFormats()
        {
            return this.Plugins.SelectMany(p => p.GetSupportedImportFormats())
                .OrderBy(f => f.FileExtension)
                .ToList();
        }
    }
}