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
    public class UserProfileConfig : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.ToTable("Игроки");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Name)
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);
            builder.HasOne(x => x.User)
                .WithOne(x => x.UserProfile)
                .HasForeignKey(nameof(User), "UserProfileId");

            builder.Ignore(x => x.HP);
            builder.Ignore(x => x.Damage);
            builder.Ignore(x => x.Victoris);
            builder.Ignore(x => x.UserId);
        }
    }
}
