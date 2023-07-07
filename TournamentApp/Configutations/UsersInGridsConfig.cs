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
    public class UsersInGridsConfig : IEntityTypeConfiguration<UsersInGrids>
    {
        public void Configure(EntityTypeBuilder<UsersInGrids> builder)
        {
            builder.ToTable("Список участников");
            //builder.HasKey(x => new( x.UserId, x.GridId));
        }
    }
}
