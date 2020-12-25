using ModelConvert.Core.Abstractions.Services;
using ModelConvert.Gui.Abstractions.Presenters;
using ModelConvert.Gui.Abstractions.Views;
using System.Linq;

namespace ModelConvert.Gui.Presenters
{
    internal class ModelConversionPresenter : IModelConversionPresenter
    {
        private IModelConversionView View;
        private readonly IModelFormatService FormatService;

        public ModelConversionPresenter(IModelFormatService formatService)
        {
            this.FormatService = formatService;
        }

        void IModelConversionPresenter.Initialize(IModelConversionView view)
        {
            this.View = view;
        }

        string IModelConversionPresenter.GetImportFormatsFilter()
        {
            var formats = this.FormatService.GetSupportedImportFormats();
            var filterParts = formats.Select(f => $"(*{f.FileExtension}) {f.Description}|*{f.FileExtension}");
            return filterParts.Any() ? string.Join('|', filterParts) : null;
        }
    }
}