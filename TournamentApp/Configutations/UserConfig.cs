using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentApp.Models;

namespace TournamentApp.Configutations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Пользователи");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Login)
                .HasMaxLength(50)
                .HasColumnType("varchar(50)");
            builder.Property(x => x.Password)
                .HasMaxLength(50)
                .HasColumnType("varchar(50)");
        }
    }
}
