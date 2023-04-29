
using WindowsFormsUPSKILLINGGAMA.DAL;

namespace WindowsFormsUPSKILLINGGAMA.Configurations
{
    public static class ConfigurationBase<T>
    {

        public static GenericRepository<T> SelecionaDriver(TipoBaseEnum driver)
        {
            switch(driver)
            {
                case TipoBaseEnum.Sql:
                    return new GenericRepository<T>(new SqlGenericRepository<T>());
                break;

                case TipoBaseEnum.Json:
                    return new GenericRepository<T>(new JsonGenericRepository<T>());
                break;

                case TipoBaseEnum.Csv:
                    return new GenericRepository<T>(new CsvGenericRepository<T>());
                break;

                default:
                    return new GenericRepository<T>(new SqlGenericRepository<T>());
                break;
            }

        }
    }
}
