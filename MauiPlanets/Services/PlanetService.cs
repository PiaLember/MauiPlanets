using MauiPlanets.Models;

namespace MauiPlanets.Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and communication, and the messenger of the gods. ",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://images-assets.nasa.gov/image/PIA11406/PIA11406~orig.jpg?w=720&h=486&fit=clip&crop=faces%2Cfocalpoint",
                    "https://science.nasa.gov/wp-content/uploads/2023/05/pia19285-mercury-jpg.webp?w=1536&format=webp"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Of all the planets, Venus is the one most similar to Earth. In fact, Venus is often called Earth's “sister” planet. As similar as it is in some ways, however, it is also very different in others. ",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://images-assets.nasa.gov/image/PIA00271/PIA00271~large.jpg?w=1920&h=1920&fit=clip&crop=faces%2Cfocalpoint",
                    "https://science.nasa.gov/wp-content/uploads/2023/05/pia00159-venus.jpg?w=1536&format=webp"
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "The Earth is the only planet known where life exists. Almost 1.5 million species of animals and plants have been discovered so far, and many more have yet to be found. While other planets may have small amounts of ice or steam, the Earth is 2/3 water. Earth has perfect conditions for a breathable atmosphere. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://images-assets.nasa.gov/image/GSFC_20171208_Archive_e001016/GSFC_20171208_Archive_e001016~large.jpg?w=1920&h=1080&fit=clip&crop=faces%2Cfocalpoint",
                    "https://images-assets.nasa.gov/image/GSFC_20171208_Archive_e001591/GSFC_20171208_Archive_e001591~large.jpg?w=1920&h=1920&fit=clip&crop=faces%2Cfocalpoint"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much as Mars. It may be the reddish color of Mars, or the fact that it can often be easily seen in the night sky, that has caused people to wonder about this close neighbor of ours. Tales of “Martians” invading Earth have been around for well over fifty years. But is it likely that any kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://images-assets.nasa.gov/image/PIA02653/PIA02653~large.jpg?w=1920&h=1920&fit=clip&crop=faces%2Cfocalpoint",
                    "https://images-assets.nasa.gov/image/PIA25680/PIA25680~orig.jpg?w=1024&h=1024&fit=clip&crop=faces%2Cfocalpoint",
                }
            },

            new()
            {
                Name = "Jupiter",
                Subtitle = " The Largest Planet",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. " +
                "It is a gas giant with a mass more than two and a half times that of all the other planets in" +
                " the Solar System combined, and slightly less than one one-thousandth the mass of the Sun. Jupiter" +
                " orbits the Sun at a distance of 5.20 AU (778.5 Gm) with an orbital period of 11.86 years. Jupiter " +
                "is the third brightest natural object in the Earth's night sky after the Moon and Venus, and it has" +
                " been observed since prehistoric times. It was named after Jupiter, the chief deity of ancient Roman religion. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2024/04/pia00459.jpg?w=1536&format=webp",
                    "https://science.nasa.gov/wp-content/uploads/2024/04/pia02277.jpg?w=1536&format=webp"
                }

            },

            new()
            {
                Name = "Saturn",
                Subtitle = " The Ring Planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and the second-largest in the Solar System," +
                " after Jupiter. It is a gas giant with an average radius of about nine-and-a-half times that of Earth. " +
                "It has only one-eighth the average density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2024/04/pia03152.jpg?w=1536&format=webp",
                    "https://science.nasa.gov/wp-content/uploads/2024/04/pia01486.jpg?w=1536&format=webp"
                }

            },

            new()
            {
                Name = "Uranus",
                Subtitle = " The Herschel Planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. It is a gaseous cyan-coloured ice giant. " +
                "Most of the planet is made of water, ammonia, and methane in a supercritical phase of matter, which in " +
                "astronomy is called 'ice' or volatiles. The planet's atmosphere has a complex layered cloud structure and " +
                "has the lowest minimum temperature of 49 K (−224 °C; −371 °F) out of all the Solar System's planets. It " +
                "has a marked axial tilt of 97.8° with a retrograde rotation rate of 17 hours. This means that in an " +
                "84-Earth-year orbital period around the Sun, its poles get around 42 years of continuous sunlight, followed " +
                "by 42 years of continuous darkness. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://images-assets.nasa.gov/image/PIA18182/PIA18182~orig.jpg?w=1720&h=1720&fit=clip&crop=faces%2Cfocalpoint",
                    "https://science.nasa.gov/wp-content/uploads/2024/04/pia00041.jpg?w=1536&format=webp",
                    "https://science.nasa.gov/wp-content/uploads/2024/04/pia00032.jpg?w=1536&format=webp"
                }

            },

            new()
            {
                Name = "Neptune",
                Subtitle = " The God of the Sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth and farthest planet from the Sun. It is the fourth-largest planet " +
                "in the Solar System by diameter, the third-most-massive planet, and the densest giant planet. It is 17" +
                " times the mass of Earth, and slightly more massive than its near-twin Uranus. Neptune is denser and " +
                "physically smaller than Uranus because its greater mass causes more gravitational compression of its " +
                "atmosphere. Being composed primarily of gases and liquids, it has no well-defined solid surface. The " +
                "planet orbits the Sun once every 164.8 years at an orbital distance of 30.1 astronomical units (4.5 " +
                "billion kilometres; 2.8 billion miles). It is named after the Roman god of the sea and has the astronomical " +
                "symbol ♆, representing Neptune's trident.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2023/09/PIA01492-1.jpg?w=1536&format=webp",
                    "https://images-assets.nasa.gov/image/PIA00057/PIA00057~orig.jpg?w=780&h=780&fit=clip&crop=faces%2Cfocalpoint"
                }

            },


             new()
            {
                Name = "Pluto",
                Subtitle = "Pluto was named by an 11-year-old girl.",
                HeroImage = "pluto.png",
                Description = "Pluto, discovered in 1930 by Clyde Tombaugh,"+
                "is a dwarf planet in the outer solar system."+
                "Originally considered the ninth planet, it was reclassified in 2006."+
                "With a diameter of about 1,473 miles,"+
                "Pluto has a thin atmosphere and a complex system of moons, including Charon."+
                "NASA's New Horizons mission in 2015 provided detailed images,"+
                "revealing diverse and geologically active features like icy mountains and plains."+
                "The exploration of Pluto offers insights into the outer solar system.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA21863_modest.jpg",
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA11709_modest.jpg",
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA21026_modest.jpg"
                }
            },

            new()
            {
                Name = "Ceres",
                Subtitle = "Ceres is named for the Roman goddess of corn and harvests.",
                HeroImage = "ceres.png",
                Description = "Ceres is the largest object in the asteroid belt between"+
                "Mars and Jupiter and is classified as a dwarf planet."+
                "Discovered by Italian astronomer Giuseppe Piazzi in 1801,"+
                "Ceres has a diameter of about 590 miles (940 kilometers)."+
                "It was the first dwarf planet to be visited by a spacecraft"+
                "when NASA's Dawn mission orbited and studied it from 2015 to 2018."+
                "Ceres is unique for hosting a large, bright area known as Occator Crater,"+
                "which contains bright deposits believed to be composed of sodium carbonate,"+
                "possibly originating from subsurface water."+
                "The dwarf planet is of particular interest to scientists as it provides"+
                "insights into the early solar system and the potential presence of water ice on its surface.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA23017_modest.jpg",
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA21918_modest.jpg",
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA21906_modest.jpg"
                }
            },

            new()
            {
                Name = "Haumea",
                Subtitle = "Haumea is named after the Hawaiian goddess of fertility.",
                HeroImage = "haumea.png",
                Description = "Haumea is another dwarf planet in the Kuiper Belt,"+
                "discovered in 2004 by a team of astronomers led by Mike Brown."+
                "It is named after the Hawaiian goddess of fertility."+
                "Haumea is distinctive due to its elongated shape, resembling a flattened ellipsoid,"+
                "possibly the result of a rapid rotation. It has two known moons, Hi'iaka and Namaka,"+
                "named after Hawaiian goddesses and discovered in 2005."+
                "Haumea's surface is thought to be composed of crystalline water ice,"+
                "and it displays a relatively high albedo, making it one of the brighter objects in the Kuiper Belt."+
                "The discovery of Haumea and its unique characteristics has contributed to"+
                "our understanding of the diversity of objects in the outer solar system.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://static.wikia.nocookie.net/expanse/images/1/1f/Haumea_in_Celestia.jpg/revision/latest?cb=20200206143331"
                }
            },
            new()
            {
                Name = "MakeMake",
                Subtitle = "Makemake was named after the Rapanui god of fertility.",
                HeroImage = "makemake.png",
                Description = "Makemake is another dwarf planet located in the Kuiper Belt,"+
                "a region of the outer solar system beyond Neptune."+
                "It was discovered in 2005 by astronomers using the Palomar Observatory."+
                "Similar to Pluto and Eris, Makemake is part of the group of trans-Neptunian objects known as dwarf planets."+
                "It is notable for its lack of a significant atmosphere and its relatively high albedo,"+
                "indicating a bright and reflective surface, likely composed of a mixture of frozen methane"+
                "ethane, and nitrogen. Makemake is the second-brightest dwarf planet after Pluto and"+
                "is recognized as one of the largest objects in the Kuiper Belt."+
                "Its discovery contributed to the ongoing understanding and classification of objects in the outer solar system.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/2/29/Makemake_and_its_moon.jpg"
                }
            },

            new()
            {
                Name = "Eris",
                Subtitle = "Eris is named for the ancient Greek goddess of discord and strife.",
                HeroImage = "eris.png",
                Description = "Eris, a dwarf planet situated in the scattered disk of the outer solar system,"+
                "was identified in 2005 by astronomers at the Palomar Observatory."+
                "Smaller than Pluto but more massive, Eris ranks among the largest dwarf planets."+
                "Its orbit, more elliptical than Pluto's, places it at a greater average distance from the Sun."+
                "Eris boasts a highly reflective surface, likely comprising a mix of water ice and frozen methane."+
                "The discovery of Eris played a crucial role in the reclassification of Pluto and similar objects,"+
                "leading to the establishment of the \"dwarf planet\" category by the International Astronomical Union (IAU).",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA17307_modest.jpg",
                    "https://photojournal.jpl.nasa.gov/jpegMod/PIA03034_modest.jpg"
                }
            },
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizedPlanets = planets.OrderBy(item => random.Next());

            return randomizedPlanets.Take(2).ToList();
        }

        public static List<Planet> GetAllPlanets() => planets;

    }
}