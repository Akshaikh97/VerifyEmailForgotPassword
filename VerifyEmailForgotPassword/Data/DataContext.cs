namespace VerifyEmailForgotPassword.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseSqlServer("server=DESKTOP-LF6HS9V\\SQLEXPRESS; database=userdb;trusted_connection=true;");
        }
        public DbSet<User> Users => Set<User>();
    }
}
