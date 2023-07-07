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
    public class GridConfig : IEntityTypeConfiguration<Grid>
    {
        public void Configure(EntityTypeBuilder<Grid> builder)
        {
            builder.ToTable("Турниры");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TournamentDate);
            builder.HasMany(x => x.Users)
                .WithMany(x => x.Grid)
                .UsingEntity<UsersInGrids>(
                    j => j
                    .HasOne( x => x.User)
                    .WithMany(x=>x.UsersInGrids)
                    .HasForeignKey(x=>x.UserId),
                    j => j
                    .HasOne(x => x.Grid)
                    .WithMany(x=>x.UsersInGrids)
                    .HasForeignKey(x =>x.GridId),
                    j =>
                    {
                        //j.HasKey(x => new(x.GridId, x.UserId)),
                        //j.ToTable("Список участников");
                    }
                );
            builder.Property(x => x.TournamentStatus);

            builder.Ignore(x => x.MinPlayers);
            builder.Ignore(x => x.MaxPlayers);
            builder.Ignore(x => x.PlayersCount);
            //builder.Ignore(x => x.StartTournament);
        }
    }
}
