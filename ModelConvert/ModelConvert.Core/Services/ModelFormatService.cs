using ModelConvert.Abstractions;
using ModelConvert.Core.Abstractions.Services;
using System;
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
            return this.GetFormats(p => p.GetSupportedImportFormats());
        }

        List<IModelFormat> IModelFormatService.GetSupportedExportFormats()
        {
            return this.GetFormats(p => p.GetSupportedExportFormats());
        }

        private List<IModelFormat> GetFormats(Func<IPluginFactory, List<IModelFormat>> selector)
        {
            return this.Plugins.SelectMany(selector)
                .OrderBy(f => f.FileExtension)
                .ToList();
        }
    }
}