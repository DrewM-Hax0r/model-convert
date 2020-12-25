using ModelConvert.Abstractions;
using System.Collections.Generic;

namespace ModelConvert.Core.Abstractions.Services
{
    public interface IModelFormatService
    {
        List<IModelFormat> GetSupportedImportFormats();
    }
}