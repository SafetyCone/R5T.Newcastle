using System;

using R5T.Derby;
using R5T.Richmond;

using RichmondApplicationBuilder = R5T.Richmond.ApplicationBuilder;


namespace R5T.Newcastle
{
    public class DesignTimeDbContextFactoryBuilder : RichmondApplicationBuilder
    {
        #region Static

        public static new DesignTimeDbContextFactoryBuilder New()
        {
            var designTimeDbContextFactoryBuilder = new DesignTimeDbContextFactoryBuilder();
            return designTimeDbContextFactoryBuilder;
        }

        #endregion
    }
}
