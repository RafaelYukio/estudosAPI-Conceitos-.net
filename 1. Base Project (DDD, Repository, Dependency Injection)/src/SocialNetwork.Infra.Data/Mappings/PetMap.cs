using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedeSocial.Domain.Entities;
namespace SocialNetwork.Infra.Data.Mappings
{
    internal class PetMap : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            //Precisa do pacote EntityFrameworkCore.Relational
            builder.ToTable(nameof(Pet));

            builder.HasKey(pet => pet.Id);

            builder.Property(pet => pet.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(pet => pet.Age)
                .HasColumnType("int");

            builder.HasOne(pet => pet.Owner)
                .WithMany(owner => owner.Pets)
                .HasForeignKey(pet => pet.Id);
        }
    }
}
