using ModelConvert.Gui.Abstractions.Presenters;
using ModelConvert.Gui.Abstractions.Views;
using System;
using System.Windows.Forms;

namespace ModelConvert.Gui.Forms
{
    public partial class ModelConversion : Form, IModelConversionView
    {
        private readonly IModelConversionPresenter Presenter;

        public ModelConversion()
        {
            InitializeComponent();

            this.Presenter = Program.DependencyFactory.GetDependency<IModelConversionPresenter>();
            this.Presenter.Initialize(this);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using var fileDialog = new OpenFileDialog()
            {
                Filter = this.Presenter.GetImportFormatsFilter()
            };
            
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtInput.Text = fileDialog.FileName;
            }
        }
    }
}