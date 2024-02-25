using aplicationAPI_Relatorio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aplicationAPI_Relatorio.Data.Map
{
    public class ContaMap : IEntityTypeConfiguration<ContaModel>
    {
        public void Configure(EntityTypeBuilder<ContaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Vencimento).IsRequired();
            builder.Property(x => x.CodBarras).IsRequired();
            builder.Property(x => x.TitularConta).IsRequired();
            builder.Property(x => x.PrestadorServico).IsRequired();
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.Banco).IsRequired();
        }
    }
}
