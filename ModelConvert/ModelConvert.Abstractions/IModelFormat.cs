namespace ModelConvert.Abstractions
{
    /// <summary>
    /// Specifications of a supported file format.
    /// </summary>
    public interface IModelFormat
    {
        /// <summary>
        /// A short description of the format.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The typical file extension of the format.
        /// </summary>
        string FileExtension { get; }
    }
}