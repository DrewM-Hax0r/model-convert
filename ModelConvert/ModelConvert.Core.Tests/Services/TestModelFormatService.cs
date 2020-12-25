using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelConvert.Abstractions;
using ModelConvert.Core.Abstractions.Services;
using ModelConvert.Core.Services;
using ModelConvert.Testing;
using System.Collections.Generic;

namespace ModelConvert.Core.Tests
{
    [TestClass]
    public class TestModelFormatService
    {
        [TestMethod]
        public void GetSupportedImportFormats_NullPluginFactory()
        {
            var service = GetService(plugins: null);
            var results = service.GetSupportedImportFormats();
            Assert.AreEqual(0, results.Count);
        }

        [TestMethod]
        public void GetSupportedImportFormats_EmptyPluginFactory()
        {
            var service = GetService(plugins: new List<IPluginFactory>());
            var results = service.GetSupportedImportFormats();
            Assert.AreEqual(0, results.Count);
        }

        [TestMethod]
        public void GetSupportedImportFormats_FromPluginFactory()
        {
            var plugins = new List<IPluginFactory>()
            {
                new PluginFactory(supportedImportFormats: new List<IModelFormat>()
                {
                    new ModelFormat() { FileExtension = ".a", Description = "A File" }
                })
            };

            var service = GetService(plugins: plugins);
            var results = service.GetSupportedImportFormats();

            Assert.AreEqual(1, results.Count);
            ModelFormat.Assert(results[0], fileExtension: ".a", description: "A File");
        }

        [TestMethod]
        public void GetSupportedImportFormats_Sorting()
        {
            var plugins = new List<IPluginFactory>()
            {
                new PluginFactory(supportedImportFormats: new List<IModelFormat>()
                {
                    new ModelFormat() { FileExtension = ".a", Description = "Some File" },
                    new ModelFormat() { FileExtension = ".c", Description = "Good File" }
                }),
                new PluginFactory(supportedImportFormats: new List<IModelFormat>()
                {
                    new ModelFormat() { FileExtension = ".b", Description = "Bad File" }
                })
            };

            var service = GetService(plugins: plugins);
            var results = service.GetSupportedImportFormats();

            Assert.AreEqual(3, results.Count);
            ModelFormat.Assert(results[0], fileExtension: ".a", description: "Some File");
            ModelFormat.Assert(results[1], fileExtension: ".b", description: "Bad File");
            ModelFormat.Assert(results[2], fileExtension: ".c", description: "Good File");
        }

        private static IModelFormatService GetService(IEnumerable<IPluginFactory> plugins = null)
        {
            return new ModelFormatService(plugins);
        }
    }
}