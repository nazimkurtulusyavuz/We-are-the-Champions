namespace Watc.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Watc.Data.WatcContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Watc.Data.WatcContext context)
        {
            if (!context.Colors.Any())
            {
                context.Colors.Add(new Color() { ColorName = "Red", Red = 255, Green = 0, Blue = 0 });
                context.Colors.Add(new Color() { ColorName = "Yellow", Red = 255, Green = 255, Blue = 0 });
                context.Colors.Add(new Color() { ColorName = "NavyBlue", Red = 0, Green = 0, Blue = 128 });
                context.Colors.Add(new Color() { ColorName = "White", Red = 255, Green = 255, Blue = 255 });
                context.Colors.Add(new Color() { ColorName = "Black", Red = 0, Green = 0, Blue = 0 });
                context.Colors.Add(new Color() { ColorName = "Blue", Red = 0, Green = 0, Blue = 255 });
                context.Colors.Add(new Color() { ColorName = "ClaretRed", Red = 129, Green = 19, Blue = 49 });
            }

            if (!context.Players.Any())
            {
                context.Players.Add(new Player() { PlayerName = "Muslera" });
                context.Players.Add(new Player() { PlayerName = "Boey" });
                context.Players.Add(new Player() { PlayerName = "Nelsson" });
                context.Players.Add(new Player() { PlayerName = "Marcao" });
                context.Players.Add(new Player() { PlayerName = "Aanholt" });
                context.Players.Add(new Player() { PlayerName = "Berkan" });
                context.Players.Add(new Player() { PlayerName = "Morutan" });
                context.Players.Add(new Player() { PlayerName = "Cicaldau" });
                context.Players.Add(new Player() { PlayerName = "Kerem" });
                context.Players.Add(new Player() { PlayerName = "Muhammet" });
                context.Players.Add(new Player() { PlayerName = "Halil" });

                context.Players.Add(new Player() { PlayerName = "Altay" });
                context.Players.Add(new Player() { PlayerName = "Tisserand" });
                context.Players.Add(new Player() { PlayerName = "Min" });
                context.Players.Add(new Player() { PlayerName = "Attila" });
                context.Players.Add(new Player() { PlayerName = "Muhammet" });
                context.Players.Add(new Player() { PlayerName = "Mesut" });
                context.Players.Add(new Player() { PlayerName = "Luiz" });
                context.Players.Add(new Player() { PlayerName = "Miha" });
                context.Players.Add(new Player() { PlayerName = "Osayi" });
                context.Players.Add(new Player() { PlayerName = "Pelkas" });
                context.Players.Add(new Player() { PlayerName = "Enner" });

                context.Players.Add(new Player() { PlayerName = "Mert" });
                context.Players.Add(new Player() { PlayerName = "Valentin" });
                context.Players.Add(new Player() { PlayerName = "Welinton" });
                context.Players.Add(new Player() { PlayerName = "Domago" });
                context.Players.Add(new Player() { PlayerName = "Rıdvan" });
                context.Players.Add(new Player() { PlayerName = "Josef" });
                context.Players.Add(new Player() { PlayerName = "Atiba" });
                context.Players.Add(new Player() { PlayerName = "Ghezzal" });
                context.Players.Add(new Player() { PlayerName = "Can" });
                context.Players.Add(new Player() { PlayerName = "Güven" });
                context.Players.Add(new Player() { PlayerName = "Batshuayi" });

                context.Players.Add(new Player() { PlayerName = "Ugurcan" });
                context.Players.Add(new Player() { PlayerName = "Bruno" });
                context.Players.Add(new Player() { PlayerName = "Edgar" });
                context.Players.Add(new Player() { PlayerName = "Vitor" });
                context.Players.Add(new Player() { PlayerName = "Densvil" });
                context.Players.Add(new Player() { PlayerName = "Abdulkadir" });
                context.Players.Add(new Player() { PlayerName = "Berat" });
                context.Players.Add(new Player() { PlayerName = "Bakasetas" });
                context.Players.Add(new Player() { PlayerName = "Gervinho" });
                context.Players.Add(new Player() { PlayerName = "Cornelius" });
                context.Players.Add(new Player() { PlayerName = "Nwakaeme" });
            }

            if (!context.Teams.Any())
            {
                context.Teams.Add(new Team() { Name = "Galatasaray" });
                context.Teams.Add(new Team() { Name = "Fenerbahçe" });
                context.Teams.Add(new Team() { Name = "Beşiktaş" });
                context.Teams.Add(new Team() { Name = "TrabzonSpor" });
            }
        }
    }
}
