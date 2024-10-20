using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedeSocial.Domain.Entities;

namespace SocialNetwork.Infra.Data.Mappings
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            //Precisa do pacote EntityFrameworkCore.Relational
            builder.ToTable(nameof(Person));

            builder.HasKey(person => person.Id);

            builder.Property(person => person.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(person => person.Age)
                .HasColumnType("int");

            builder.Property(person => person.Description)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.HasMany(person => person.Friends)
                .WithMany(person => person.Friends);

            builder.HasMany(person => person.Pets)
                .WithOne(pet => pet.Owner)
                .HasForeignKey(pet => pet.Id);

            builder.HasOne(person => person.BestFriend)
                .WithOne(person => person.BestFriend)
                .HasForeignKey<Person>(person => person.Id);
        }
    }
}
