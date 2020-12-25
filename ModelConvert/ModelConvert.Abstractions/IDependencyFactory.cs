namespace ModelConvert.Abstractions
{
    /// <summary>
    /// A factory capable of dependency resolution for application components.
    /// </summary>
    public interface IDependencyFactory
    {
        /// <summary>
        /// Instantiates the specified dependency with all child dependencies also instantiated.
        /// </summary>
        /// <returns>The instantiated dependency.</returns>
        TDependency GetDependency<TDependency>();
    }
}