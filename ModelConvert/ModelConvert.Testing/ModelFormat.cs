using ModelConvert.Abstractions;
using Verify = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace ModelConvert.Testing
{
    public class ModelFormat : IModelFormat
    {
        public string Description { get; set; }
        public string FileExtension { get; set; }

        public static void Assert(IModelFormat actual, string fileExtension = null, string description = null)
        {
            Verify.AreEqual(fileExtension, actual.FileExtension);
            Verify.AreEqual(description, actual.Description);
        }
    }
}