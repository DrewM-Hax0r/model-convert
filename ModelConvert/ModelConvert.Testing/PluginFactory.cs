using ModelConvert.Abstractions;
using System.Collections.Generic;

namespace ModelConvert.Testing
{
    public class PluginFactory : IPluginFactory
    {
        private List<IModelFormat> SupportedImportFormats;

        public PluginFactory(List<IModelFormat> supportedImportFormats = null)
        {
            this.SupportedImportFormats = supportedImportFormats;
        }

        public List<IModelFormat> GetSupportedImportFormats() => this.SupportedImportFormats;
    }
}