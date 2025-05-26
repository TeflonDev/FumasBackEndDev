using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Utilities;

namespace BackEndDevApi.Data.Entities
{
	
	public class BackEndDbContext:DbContext

	{
		public BackEndDbContext(DbContextOptions<BackEndDbContext> options): base(options)
		{
			
		}
		public	virtual DbSet<Users> users { get; set; }
		public virtual DbSet<Accounts> accounts { get; set; }
		public virtual DbSet<si> si { get; set; }
		public virtual DbSet<SubCateg> sub_sc { get; set; }
		public virtual DbSet<Locations> sl { get; set; }
		public virtual DbSet<Categ> sc { get; set; }
	}
}
