using ModelConvert.Abstractions;

namespace ModelConvert.Assimp
{
    internal class ModelFormat : IModelFormat
    {
        public ModelFormat(string description, string fileExtension)
        {
            this.Description = description;
            this.FileExtension = fileExtension;
        }

        public string Description { get; }
        public string FileExtension { get; }
    }
}