using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using poc.SearchCity.Api.Data.Entities;

namespace poc.SearchCity.Api.Data
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("cidades", "public");
        }
    }
}
