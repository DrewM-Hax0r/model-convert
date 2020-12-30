using System.Collections.Generic;

namespace ModelConvert.Abstractions
{
    /// <summary>
    /// The core implementation of a plugin adding support for additional model formats.
    /// </summary>
    public interface IPluginFactory
    {
        /// <returns>
        /// The model formats this plugin is capable of importing.
        /// </returns>
        List<IModelFormat> GetSupportedImportFormats();

        /// <returns>
        /// The model formats this plugin is capable of exporting.
        /// </returns>
        List<IModelFormat> GetSupportedExportFormats();
    }
}