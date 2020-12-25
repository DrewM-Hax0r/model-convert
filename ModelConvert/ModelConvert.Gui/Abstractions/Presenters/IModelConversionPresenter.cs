using ModelConvert.Gui.Abstractions.Views;

namespace ModelConvert.Gui.Abstractions.Presenters
{
    internal interface IModelConversionPresenter
    {
        internal void Initialize(IModelConversionView view);
        internal string GetImportFormatsFilter();
    }
}