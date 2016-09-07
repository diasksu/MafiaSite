using MafiaDomain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MafiaDomain
{
    public class MafiaContext : DbContext
    {
        // Имя будущей базы данных можно указать через
        // вызов конструктора базового класса
        public MafiaContext() : base("MafiaDb")
        { }

        // Отражение таблиц базы данных на свойства с типом DbSet
        public DbSet<Event> Events { get; set; }
        public DbSet<EventPhoto> EventPhotos { get; set; }
        public DbSet<StaticPage> StaticPages { get; set; }
    }
}