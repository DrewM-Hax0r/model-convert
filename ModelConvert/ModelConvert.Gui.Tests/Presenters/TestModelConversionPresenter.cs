using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelConvert.Abstractions;
using ModelConvert.Core.Abstractions.Services;
using ModelConvert.Gui.Abstractions.Presenters;
using ModelConvert.Gui.Presenters;
using ModelConvert.Testing;
using Moq;
using System.Collections.Generic;

namespace ModelConvert.Gui.Tests.Presenters
{
    [TestClass]
    public class TestModelConversionPresenter
    {
        private readonly IModelConversionPresenter Presenter;
        private readonly Mock<IModelFormatService> FormatService;

        public TestModelConversionPresenter()
        {
            this.FormatService = new Mock<IModelFormatService>();
            this.Presenter = new ModelConversionPresenter(this.FormatService.Object);
        }

        [TestMethod]
        public void GetImportFormatsFilter_None()
        {
            this.FormatService.Setup(s => s.GetSupportedImportFormats())
                .Returns(new List<IModelFormat>());

            var result = this.Presenter.GetImportFormatsFilter();

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetImportFormatsFilter()
        {
            var formats = new List<IModelFormat>()
            {
                new ModelFormat() { FileExtension = ".obj", Description = "Wavefront Object File" },
                new ModelFormat() { FileExtension = ".blend", Description = "Blender File" }
            };

            this.FormatService.Setup(s => s.GetSupportedImportFormats())
                .Returns(formats);

            var result = this.Presenter.GetImportFormatsFilter();

            Assert.AreEqual("(*.obj) Wavefront Object File|*.obj|(*.blend) Blender File|*.blend", result);
        }
    }
}