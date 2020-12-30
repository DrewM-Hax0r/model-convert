using ModelConvert.Abstractions;
using System.Collections.Generic;

namespace ModelConvert.Testing
{
    public class PluginFactory : IPluginFactory
    {
        private List<IModelFormat> SupportedImportFormats;
        private List<IModelFormat> SupportedExportFormats;

        public PluginFactory(List<IModelFormat> supportedImportFormats = null, List<IModelFormat> supportedExportFormats = null)
        {
            this.SupportedImportFormats = supportedImportFormats;
            this.SupportedExportFormats = supportedExportFormats;
        }

        List<IModelFormat> IPluginFactory.GetSupportedExportFormats() => this.SupportedExportFormats;

        List<IModelFormat> IPluginFactory.GetSupportedImportFormats() => this.SupportedImportFormats;
    }
}