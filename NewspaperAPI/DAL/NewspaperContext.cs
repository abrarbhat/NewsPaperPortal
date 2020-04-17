namespace NewspaperAPI.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NewspaperContext : DbContext
    {
        public NewspaperContext()
            : base("name=NewspaperContext")
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Categor> Categors { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .Property(e => e.sefurl)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.definition)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.summary)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.article1)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.tags)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.insertdt)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.log)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.updatedt)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.updaterip)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.updatedlog)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.pass)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.birthday)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.from)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.lives)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.sex)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.regdt)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.regip)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.reglog)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.updatedt)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.updater)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.updaterip)
                .IsUnicode(false);

            modelBuilder.Entity<Categor>()
                .Property(e => e.sefurl)
                .IsUnicode(false);

            modelBuilder.Entity<Categor>()
                .Property(e => e.catname)
                .IsUnicode(false);

            modelBuilder.Entity<Categor>()
                .Property(e => e.catdetail)
                .IsUnicode(false);

            modelBuilder.Entity<Categor>()
                .Property(e => e.catimg)
                .IsUnicode(false);

            modelBuilder.Entity<Categor>()
                .Property(e => e.cattype)
                .IsUnicode(false);

            modelBuilder.Entity<Categor>()
                .Property(e => e.createddt)
                .IsUnicode(false);

            modelBuilder.Entity<Categor>()
                .Property(e => e.creator)
                .IsUnicode(false);

            modelBuilder.Entity<Categor>()
                .Property(e => e.creatorip)
                .IsUnicode(false);

            modelBuilder.Entity<Categor>()
                .Property(e => e.updateddt)
                .IsUnicode(false);

            modelBuilder.Entity<Categor>()
                .Property(e => e.updaterip)
                .IsUnicode(false);

            modelBuilder.Entity<Categor>()
                .Property(e => e.updater)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.commtype)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.fullname)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.nick)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.comment1)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.avatar)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.date)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.deletdt)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.deleter)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.updatedt)
                .IsUnicode(false);

            modelBuilder.Entity<Comment>()
                .Property(e => e.updaterip)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.sefurl)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.summary)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.news1)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.tags)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.breakingimg)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.date)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.browser)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.timezone)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.who)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.updatedt)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.updaterip)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.deldt)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.whodeleted)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.dtrip)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.sitename)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.copy)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.analytics)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.mailhost)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.mailport)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.mailuser)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.mailpassword)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.repmail)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.updatedt)
                .IsUnicode(false);

            modelBuilder.Entity<Setting>()
                .Property(e => e.updaterip)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.fullname)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.pass)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.from)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.lives)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.regdt)
                .HasPrecision(0);

            modelBuilder.Entity<Team>()
                .Property(e => e.regip)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.lastlog)
                .HasPrecision(0);

            modelBuilder.Entity<Team>()
                .Property(e => e.lastip)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.per)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.nick)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.pass)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.forgotpass)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.forgotpassdt)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.forgotpassip)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.passeddt)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.passedip)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.dt)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.dy)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.acctype)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.regdate)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.registerip)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.regkey)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.activationdt)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.activatorip)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.lastlogindt)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.lastip)
                .IsUnicode(false);

            modelBuilder.Entity<Video>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Video>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Video>()
                .Property(e => e.poster)
                .IsUnicode(false);

            modelBuilder.Entity<Video>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<Video>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<Video>()
                .Property(e => e.date)
                .HasPrecision(0);

            modelBuilder.Entity<Video>()
                .Property(e => e.who)
                .IsUnicode(false);

            modelBuilder.Entity<Video>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<Video>()
                .Property(e => e.updatedt)
                .IsUnicode(false);

            modelBuilder.Entity<Video>()
                .Property(e => e.updaterip)
                .IsUnicode(false);

            modelBuilder.Entity<Video>()
                .Property(e => e.tags)
                .IsUnicode(false);
        }
    }
}
