using Autofac;
using CoVID.Parser;
using CoVID.Parser.Wiki;

namespace CoVID
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Database>().As<IDatabase>();
            builder.RegisterType<WikiParser>().As<IParser>();
            builder.RegisterType<WikiSettings>().As<IParserSettings>();
            builder.RegisterType<PdfConverter>().As<IConverter>();

            return builder.Build();
        }
    }
}
