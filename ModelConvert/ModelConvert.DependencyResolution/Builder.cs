using ModelConvert.Abstractions;

namespace ModelConvert.DependencyResolution
{
    public static class Builder
    {
        public static IDependencyFactory GetFactory()
        {
            return new DependencyFactory();
        }
    }
}