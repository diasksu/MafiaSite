namespace MafiaDomain.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MafiaDomain.MafiaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MafiaDomain.MafiaContext";
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MafiaDomain.MafiaContext>());
        }

        protected override void Seed(MafiaDomain.MafiaContext context)
        {
            context.Events.RemoveRange(context.Events);
            context.EventPhotos.RemoveRange(context.EventPhotos);
            context.SaveChanges();
            SeedEvents(context);
            SeedEventPhotos(context);
            SeedStaticPages(context);
        }

        private void SeedStaticPages(MafiaContext context)
        {
            context.StaticPages.AddOrUpdate(p => p.Name,
                new StaticPage()
                { Name = "About_us", Content = "<h1>From db</h1>", Header = "� ���" },
                new StaticPage()
                { Name = "News", Content = "<h1>From db</h1>", Header = "�������" },
                new StaticPage()
                { Name = "Bands", Content = "<h1>From db</h1>", Header = "�����" },
                new StaticPage()
                { Name = "GameInfo", Content = "<h1>From db</h1>", Header = "�������� ����" },
                new StaticPage()
                { Name = "Roles", Content = "<h1>From db</h1>", Header = "����" },
                new StaticPage()
                { Name = "Tactics", Content = "<h1>From db</h1>", Header = "�������" },
                new StaticPage()
                { Name = "Media", Content = "<h1>From db</h1>", Header = "�����" },
                new StaticPage()
                { Name = "Shop", Content = "<h1>From db</h1>", Header = "�������" },
                new StaticPage()
                { Name = "Partys", Content = "<h1>From db</h1>", Header = "�����������" },
                new StaticPage()
                { Name = "Login", Content = "<h1>From db</h1>", Header = "����" });
        }

        private void SeedEventPhotos(MafiaContext context)
        {
            Event evt1 = context.Events.First(e => e.Name == "�������� �����");
            Event evt2 = context.Events.First(e => e.Name == "������ ������");
            Event evt3 = context.Events.First(e => e.Name == "���������");
            Event evt4 = context.Events.First(e => e.Name == "������ ������");

            context.EventPhotos.AddOrUpdate(p => p.Path,
                new EventPhoto() { Path = @"/Images/1/image (1).jpg", EventPhotoId = 1, ParentEvent = evt1 },
                new EventPhoto() { Path = @"/Images/1/image (1).png", EventPhotoId = 2, ParentEvent = evt1 },
                new EventPhoto() { Path = @"/Images/1/image (3).png", EventPhotoId = 3, ParentEvent = evt1 },
                new EventPhoto() { Path = @"/Images/1/image (4).png", EventPhotoId = 4, ParentEvent = evt1 },
                new EventPhoto() { Path = @"/Images/2/image (1).png", EventPhotoId = 5, ParentEvent = evt2 },
                new EventPhoto() { Path = @"/Images/2/image (2).png", EventPhotoId = 6, ParentEvent = evt2 },
                new EventPhoto() { Path = @"/Images/2/image (3).png", EventPhotoId = 7, ParentEvent = evt2 },
                new EventPhoto() { Path = @"/Images/3/image (1).png", EventPhotoId = 8, ParentEvent = evt3 },
                new EventPhoto() { Path = @"/Images/3/image (4).png", EventPhotoId = 9, ParentEvent = evt3 },
                new EventPhoto() { Path = @"/Images/3/image (3).png", EventPhotoId = 10, ParentEvent = evt3 },
                new EventPhoto() { Path = @"/Images/4/image (1).png", EventPhotoId = 11, ParentEvent = evt4 },
                new EventPhoto() { Path = @"/Images/4/image (2).png", EventPhotoId = 12, ParentEvent = evt4 },
                new EventPhoto() { Path = @"/Images/4/image (3).png", EventPhotoId = 13, ParentEvent = evt4 });
        }

        private void SeedEvents(MafiaDomain.MafiaContext context)
        {
            context.Events.AddOrUpdate(e => e.Name,
                new Event
                {
                    City = "������",
                    Country = "������",
                    Address = "�������, 23",
                    Date = new DateTime(2016, 09, 15, 15, 20, 00),
                    EventId = 1,
                    Name = "�������� �����",
                    GameType = EGameType.Classic,
                    Photo = @"/Images/1/image (2).jpg",
                    Description = "Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui"
                },
                new Event
                {
                    City = "������",
                    Country = "������",
                    Address = "��. ������, 213",
                    Date = new DateTime(2016, 09, 16, 15, 20, 00),
                    EventId = 2,
                    Name = "������ ������",
                    GameType = EGameType.Cartel,
                    Photo = @"/Images/2/image (1).jpg",
                    Description = "Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui"
                },
               new Event
               {
                   City = "������",
                   Country = "������",
                   Address = "��. ������, 213",
                   Date = new DateTime(2016, 09, 17, 15, 20, 00),
                   EventId = 3,
                   Name = "���������",
                   GameType = EGameType.Cartel,
                   Photo = @"/Images/3/image (1).jpg",
                   Description = "Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui"
               },
               new Event
               {
                   City = "������",
                   Country = "������",
                   Address = "�������, 23",
                   Date = new DateTime(2016, 09, 18, 15, 20, 00),
                   EventId = 4,
                   Name = "������ ������",
                   GameType = EGameType.Tourney,
                   Beginner = true,
                   Photo = @"/Images/4/image (1).jpg",
                   Description = "Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui"
               });
            context.SaveChanges();

        }
    }
}