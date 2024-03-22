using BasketApp.Domain.Entities;
using BasketApp.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Infrastructure.Seeders
{
    public class HistoricalPlayerSeeder
    {
        private readonly BasketAppDbContext _dbContext;
        public HistoricalPlayerSeeder(BasketAppDbContext dbContext)
        {

            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.HistoricalPlayers.Any())
                {
                    var playerData = new List<HistoricalPlayer>
                    {
                            new HistoricalPlayer
    {
                                PlayerID = 527,
                                DraftDate = new DateTime(1984, 6, 19),
                                EndOfCareerDate = new DateTime(2003, 4, 16),
                                Description = "Michael Jordan, znany jako największy koszykarz wszech czasów, zdobywca sześciu mistrzostw NBA z Chicago Bulls."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 528,
                                DraftDate = new DateTime(1986, 6, 16),
                                EndOfCareerDate = new DateTime(2006, 5, 8),
                                Description = "Dennis Rodman, legenda obrony, zdobywca pięciu mistrzostw NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 529,
                                DraftDate = new DateTime(1987, 6, 22),
                                EndOfCareerDate = new DateTime(2004, 4, 19),
                                Description = "Scottie Pippen, partner Michela Jordana w Chicago Bulls, zdobywca sześciu tytułów mistrzowskich."
                            },

                            new HistoricalPlayer
                            {
                                PlayerID = 530,
                                DraftDate = new DateTime(1987, 6, 22),
                                EndOfCareerDate = new DateTime(2004, 4, 19),
                                Description = "Horace Grant, wielokrotny mistrz NBA z Chicago Bulls oraz Orlando Magic."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 531,
                                DraftDate = new DateTime(1983, 6, 28),
                                EndOfCareerDate = new DateTime(1994, 3, 18),
                                Description = "John Paxson, zdobywca trzech mistrzostw NBA z Chicago Bulls."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 532,
                                DraftDate = new DateTime(1996, 6, 26),
                                EndOfCareerDate = new DateTime(2016, 4, 13),
                                Description = "Kobe Bryant, ikona Los Angeles Lakers, zdobywca pięciu mistrzostw NBA."
                            },

                            new HistoricalPlayer
                            {
                                PlayerID = 533,
                                DraftDate = new DateTime(1992, 6, 24),
                                EndOfCareerDate = new DateTime(2011, 6, 3),
                                Description = "Shaquille O'Neal, znany jako Shaq, był jednym z najbardziej dominujących graczy w historii NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 534,
                                DraftDate = new DateTime(1996, 6, 26),
                                EndOfCareerDate = new DateTime(2014, 8, 4),
                                Description = "Derek Fisher, znany ze swojego przywództwa i zdolności do trafiania kluczowych rzutów."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 535,
                                DraftDate = new DateTime(1986, 6, 17),
                                EndOfCareerDate = new DateTime(2001, 4, 18),
                                Description = "Ron Harper, wszechstronny gracz, który zdobył wiele mistrzostw NBA z różnymi drużynami."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 536,
                                DraftDate = new DateTime(1979, 6, 25),
                                EndOfCareerDate = new DateTime(1996, 11, 7),
                                Description = "Magic Johnson, legendarny rozgrywający Los Angeles Lakers, pięciokrotny mistrz NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 537,
                                DraftDate = new DateTime(1969, 4, 9),
                                EndOfCareerDate = new DateTime(1989, 6, 13),
                                Description = "Kareem Abdul-Jabbar, jedna z największych legend NBA, rekordzista w liczbie zdobytych punktów."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 538,
                                DraftDate = new DateTime(1982, 6, 29),
                                EndOfCareerDate = new DateTime(1994, 9, 14),
                                Description = "James Worthy, członek Klubu Mistrzów NBA, wielokrotny mistrz z Los Angeles Lakers."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 539,
                                DraftDate = new DateTime(1968, 4, 8),
                                EndOfCareerDate = new DateTime(1990, 4, 20),
                                Description = "Michael Cooper, wszechstronny obrońca znany z ciężkiej pracy w obronie i rzutach za trzy punkty."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 540,
                                DraftDate = new DateTime(1978, 6, 9),
                                EndOfCareerDate = new DateTime(1992, 8, 18),
                                Description = "Larry Bird, legendarny gracz Boston Celtics, zdobywca wielu tytułów mistrzowskich."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 541,
                                DraftDate = new DateTime(1980, 6, 10),
                                EndOfCareerDate = new DateTime(1993, 8, 22),
                                Description = "Kevin McHale, wszechstronny gracz Celtics, uznawany za jednego z najlepszych silnych skrzydłowych w historii NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 542,
                                DraftDate = new DateTime(1974, 6, 4),
                                EndOfCareerDate = new DateTime(1987, 10, 14),
                                Description = "Bill Walton, legendarny ośmiokrotny mistrz NBA, zdobywca tytułu MVP w 1978 roku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 543,
                                DraftDate = new DateTime(1976, 6, 8),
                                EndOfCareerDate = new DateTime(1997, 8, 22),
                                Description = "Robert Parish, z przydomkiem 'The Chief', jeden z najwybitniejszych centrów w historii ligi."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 544,
                                DraftDate = new DateTime(1997, 6, 25),
                                EndOfCareerDate = new DateTime(2016, 7, 11),
                                Description = "Tim Duncan, zaliczany do grona najlepszych graczy w historii, zdobywca pięciu mistrzowskich pierścieni z San Antonio Spurs."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 545,
                                DraftDate = new DateTime(2001, 6, 27),
                                EndOfCareerDate = new DateTime(2016, 4, 9),
                                Description = "Tony Parker, francuski rozgrywający, wielokrotny mistrz NBA z San Antonio Spurs, znany ze swojej szybkości i umiejętności kierowania grą."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 546,
                                DraftDate = new DateTime(1999, 6, 30),
                                EndOfCareerDate = new DateTime(2018, 9, 10),
                                Description = "Manu Ginóbili, argentyński rzucający, ikona San Antonio Spurs, znany z nieprzewidywalnej gry i widowiskowych akcji."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 547,
                                DraftDate = new DateTime(2003, 6, 26),
                                EndOfCareerDate = new DateTime(2016, 6, 30),
                                Description = "Boris Diaw, francuski skrzydłowy, mistrz NBA z San Antonio Spurs, charakteryzujący się wszechstronnością i grą zespołową."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 548,
                                DraftDate = new DateTime(1984, 6, 19),
                                EndOfCareerDate = new DateTime(2002, 6, 12),
                                Description = "Hakeem Olajuwon, nigeryjski środkowy, mistrz NBA z Houston Rockets, uznawany za jednego z najlepszych graczy w historii ligi."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 549,
                                DraftDate = new DateTime(1987, 6, 22),
                                EndOfCareerDate = new DateTime(1997, 6, 30),
                                Description = "Kenny Smith, amerykański rozgrywający, mistrz NBA z Houston Rockets, późniejszy komentator sportowy."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 550,
                                DraftDate = new DateTime(1993, 6, 30),
                                EndOfCareerDate = new DateTime(2008, 4, 15),
                                Description = "Sam Cassell, amerykański rozgrywający, mistrz NBA z Houston Rockets, znany z umiejętności przywódczych i zdolności strzeleckich."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 551,
                                DraftDate = new DateTime(1982, 6, 29),
                                EndOfCareerDate = new DateTime(2008, 4, 17),
                                Description = "Robert Horry, amerykański skrzydłowy, zdobył 7 tytułów mistrza NBA z różnymi drużynami, znany z decydujących rzutów w kluczowych momentach."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 552,
                                DraftDate = new DateTime(1956, 4, 30),
                                EndOfCareerDate = new DateTime(1969, 4, 9),
                                Description = "Bill Russell, legenda koszykówki, uznawany za jednego z najlepszych środkowych w historii NBA, zdobył 11 tytułów mistrza NBA z Boston Celtics."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 553,
                                DraftDate = new DateTime(1957, 2, 14),
                                EndOfCareerDate = new DateTime(1969, 5, 4),
                                Description = "Sam Jones, amerykański rzucający, zdobył 10 tytułów mistrza NBA z Boston Celtics, uznawany za jednego z najlepszych strzelców w historii ligi."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 554,
                                DraftDate = new DateTime(1962, 4, 23),
                                EndOfCareerDate = new DateTime(1978, 4, 9),
                                Description = "John Havlicek, amerykański skrzydłowy i rzucający, wielokrotny mistrz NBA z Boston Celtics, uznawany za jednego z najlepszych obrońców w historii ligi."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 555,
                                DraftDate = new DateTime(1960, 4, 22),
                                EndOfCareerDate = new DateTime(1973, 4, 7),
                                Description = "Tom Sanders, amerykański skrzydłowy, wielokrotny mistrz NBA z Boston Celtics, znany ze swojej obrony i wszechstronności."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 556,
                                DraftDate = new DateTime(1956, 4, 30),
                                EndOfCareerDate = new DateTime(1965, 4, 13),
                                Description = "Tom Heinsohn, amerykański skrzydłowy, wielokrotny mistrz NBA z Boston Celtics, późniejszy trener i komentator."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 556, // Tom Heinsohn
                                DraftDate = new DateTime(1956, 1, 1),
                                EndOfCareerDate = new DateTime(1965, 1, 1),
                                Description = "Amerykański skrzydłowy, który grał dla Boston Celtics w latach 50. i 60."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 557, // Oscar Robertson
                                DraftDate = new DateTime(1960, 1, 1),
                                EndOfCareerDate = new DateTime(1974, 1, 1),
                                Description = "Amerykański rozgrywający, który uznawany jest za jednego z najlepszych graczy w historii NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 558, // Jerry West
                                DraftDate = new DateTime(1960, 1, 1),
                                EndOfCareerDate = new DateTime(1974, 1, 1),
                                Description = "Amerykański rzucający obrońca, który spędził całą swoją karierę w Los Angeles Lakers."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 559, // Elgin Baylor
                                DraftDate = new DateTime(1958, 1, 1),
                                EndOfCareerDate = new DateTime(1972, 1, 1),
                                Description = "Amerykański skrzydłowy, który grał dla Minneapolis/Los Angeles Lakers przez większość swojej kariery."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 560, // Wilt Chamberlain
                                DraftDate = new DateTime(1959, 1, 1),
                                EndOfCareerDate = new DateTime(1973, 1, 1),
                                Description = "Amerykański środkowy, który jest uznawany za jednego z największych graczy w historii koszykówki."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 561, // Karl Malone
                                DraftDate = new DateTime(1985, 1, 1),
                                EndOfCareerDate = new DateTime(2004, 1, 1),
                                Description = "Amerykański silny skrzydłowy, który przez większość swojej kariery grał dla Utah Jazz."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 562,
                                DraftDate = new DateTime(1984, 6, 19),
                                EndOfCareerDate = new DateTime(2003, 5, 2),
                                Description = "John Stockton, amerykański rozgrywający, legenda Utah Jazz, lider w asystach i przechwytach w historii NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 563,
                                DraftDate = new DateTime(1993, 6, 30),
                                EndOfCareerDate = new DateTime(2006, 4, 10),
                                Description = "Bryon Russell, amerykański skrzydłowy, znany z gry w Utah Jazz, wicemistrz NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 564,
                                DraftDate = new DateTime(1981, 6, 29),
                                EndOfCareerDate = new DateTime(1994, 4, 28),
                                Description = "Isiah Thomas, amerykański rozgrywający, wielokrotny mistrz NBA z Detroit Pistons, członek Hall of Fame."
                            },
                            new HistoricalPlayer
                            {
                               PlayerID = 565,
                                DraftDate = new DateTime(1979, 6, 8),
                                EndOfCareerDate = new DateTime(1993, 4, 18),
                                Description = "Bill Laimbeer, amerykański skrzydłowy i środkowy, legenda Detroit Pistons, znany z ostrej gry i rywalizacji z Chicago Bulls."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 566,
                                DraftDate = new DateTime(1981, 6, 8),
                                EndOfCareerDate = new DateTime(1994, 5, 10),
                                Description = "Mark Aguirre, amerykański skrzydłowy i niski skrzydłowy, dwukrotny mistrz NBA z Detroit Pistons, silny gracz w ataku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 567,
                                DraftDate = new DateTime(1985, 6, 19),
                                EndOfCareerDate = new DateTime(1999, 5, 13),
                                Description = "Joe Dumars, amerykański rzucający i rozgrywający, legenda Detroit Pistons, dwukrotny mistrz NBA i MVP finałów."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 568, // David Robinson
                                DraftDate = new DateTime(1987, 1, 1),
                                EndOfCareerDate = new DateTime(2003, 1, 1),
                                Description = "Amerykański środkowy, który spędził całą swoją karierę w San Antonio Spurs."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 569, // Dirk Nowitzki
                                DraftDate = new DateTime(1998, 1, 1),
                                EndOfCareerDate = new DateTime(2019, 1, 1),
                                Description = "Niemiecki silny skrzydłowy, który przez całą swoją karierę grał dla Dallas Mavericks."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 570, // Jason Kidd
                                DraftDate = new DateTime(1994, 1, 1),
                                EndOfCareerDate = new DateTime(2013, 1, 1),
                                Description = "Amerykański rozgrywający, uznawany za jednego z najlepszych rozgrywających w historii NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 571, // Jason Terry
                                DraftDate = new DateTime(1999, 1, 1),
                                EndOfCareerDate = new DateTime(2018, 1, 1),
                                Description = "Amerykański rzucający, który znany jest z swojego rzutu z trójki i roli w mistrzowskim zespole Dallas Mavericks w 2011 roku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 572, // Tyson Chandler
                                DraftDate = new DateTime(2001, 1, 1),
                                EndOfCareerDate = new DateTime(2019, 1, 1),
                                Description = "Amerykański koszykarz, który grał na pozycji środkowego i był ceniony za swoje umiejętności defensywne i zbiórkowe."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 573, // Dwyane Wade
                                DraftDate = new DateTime(2003, 1, 1),
                                EndOfCareerDate = new DateTime(2019, 1, 1),
                                Description = "Trzykrotny mistrz NBA z Miami Heat, uważany za jednego z najlepszych strażników w historii ligi."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 574, // Ray Allen
                                DraftDate = new DateTime(1996, 1, 1),
                                EndOfCareerDate = new DateTime(2014, 1, 1),
                                Description = "Znany jako jedno z największych trafień w historii NBA, trzykrotny mistrz NBA i lider wszech czasów w liczbie trafionych rzutów za trzy punkty."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 575, // Chris Bosh
                                DraftDate = new DateTime(2003, 1, 1),
                                EndOfCareerDate = new DateTime(2017, 1, 1),
                                Description = "Wielokrotny uczestnik meczów gwiazd NBA, dwukrotny mistrz NBA z Miami Heat, znany z wszechstronności i zdolności strzeleckich."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 576, // Mario Chalmers
                                DraftDate = new DateTime(2008, 1, 1),
                                EndOfCareerDate = new DateTime(2018, 1, 1),
                                Description = "Znany z gry w zespole Miami Heat w latach triumfów LeBrona Jamesa, Dwyane'a Wade'a i Chrisa Bosha. Dwukrotny mistrz NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 577, // Charles Barkley
                                DraftDate = new DateTime(1984, 1, 1),
                                EndOfCareerDate = new DateTime(2000, 1, 1),
                                Description = "Jeden z najbardziej wszechstronnych graczy w historii NBA, wielokrotny uczestnik All-Star, MVP ligi w sezonie 1992-1993."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 578, // Allen Iverson
                                DraftDate = new DateTime(1996, 1, 1),
                                EndOfCareerDate = new DateTime(2010, 1, 1),
                                Description = "Znany z niezwykłej szybkości, dryblingu i zdolności strzeleckich, który zdobył nagrodę MVP w 2001 roku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 579, // Patrick Ewing
                                DraftDate = new DateTime(1985, 1, 1),
                                EndOfCareerDate = new DateTime(2002, 1, 1),
                                Description = "Jeden z najwybitniejszych centrów w historii NBA, wielokrotny uczestnik All-Star i mistrz NCAA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 580, // Clyde Drexler
                                DraftDate = new DateTime(1983, 1, 1),
                                EndOfCareerDate = new DateTime(1998, 1, 1),
                                Description = "Wspaniały skrzydłowy, dwukrotny mistrz NBA, MVP finałów, uczestnik Dream Teamu."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 581, // George Gervin
                                DraftDate = new DateTime(1974, 1, 1),
                                EndOfCareerDate = new DateTime(1986, 1, 1),
                                Description = "Pseudonim 'The Iceman', znany z niezwykłej umiejętności strzeleckich, wielokrotny lider ligi w punktacji."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 581, // George Gervin
                                DraftDate = new DateTime(1974, 1, 1),
                                EndOfCareerDate = new DateTime(1986, 1, 1),
                                Description = "Znany jako Iceman, Gervin był jednym z najbardziej widowiskowych strzelców w historii ligi. Czterokrotny król strzelców NBA i siedmiokrotny All-Star."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 582, // Bob Cousy
                                DraftDate = new DateTime(1950, 1, 1),
                                EndOfCareerDate = new DateTime(1963, 1, 1),
                                Description = "Uważany za jednego z najlepszych rozgrywających w historii NBA. Ośmiokrotny mistrz ligi z Boston Celtics."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 583, // George Mikan
                                DraftDate = new DateTime(1948, 1, 1),
                                EndOfCareerDate = new DateTime(1956, 1, 1),
                                Description = "Pionier gry w koszykówkę. Pierwsza prawdziwa gwiazda NBA. Pięciokrotny mistrz NBA i sześciokrotny lider strzelców ligi."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 584, // Bob Pettit
                                DraftDate = new DateTime(1954, 1, 1),
                                EndOfCareerDate = new DateTime(1965, 1, 1),
                                Description = "Jeden z najwybitniejszych koszykarzy w historii ligi. Dwukrotny MVP NBA i dziesięciokrotny All-Star."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 585, // Dave Cowens
                                DraftDate = new DateTime(1970, 1, 1),
                                EndOfCareerDate = new DateTime(1983, 1, 1),
                                Description = "Zdobywca dwóch tytułów mistrzowskich NBA z Boston Celtics. MVP NBA w 1973 roku i dwunastokrotny uczestnik All-Star Game."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 586, // Gary Payton
                                DraftDate = new DateTime(1990, 1, 1),
                                EndOfCareerDate = new DateTime(2007, 1, 1),
                                Description = "Znany jako The Glove, był jednym z najlepszych obrońców w historii NBA. Mistrz NBA z Miami Heat w 2006 roku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 587, // Dikembe Mutombo
                                DraftDate = new DateTime(1991, 1, 1),
                                EndOfCareerDate = new DateTime(2009, 1, 1),
                                Description = "Jeden z najwybitniejszych obrońców w historii ligi. Czterokrotny obrońca roku NBA i ośmiokrotny uczestnik All-Star Game."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 588, // Chris Webber
                                DraftDate = new DateTime(1993, 1, 1),
                                EndOfCareerDate = new DateTime(2008, 1, 1),
                                Description = "Znany z gry w zespole Sacramento Kings, gdzie osiągnął największe sukcesy w karierze. Pięciokrotny uczestnik All-Star Game."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 589, // Steve Nash
                                DraftDate = new DateTime(1996, 1, 1),
                                EndOfCareerDate = new DateTime(2014, 1, 1),
                                Description = "Dwukrotny MVP NBA w 2005 i 2006 roku. Znany z widowiskowej gry i doskonałego rozdawania asyst."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 590, // Allen Houston
                                DraftDate = new DateTime(1993, 1, 1),
                                EndOfCareerDate = new DateTime(2005, 1, 1),
                                Description = "Znany z gry w zespole New York Knicks, gdzie był jednym z najlepszych strzelców ligi w latach 90."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 591, // Manu Ginobili
                                DraftDate = new DateTime(1999, 1, 1),
                                EndOfCareerDate = new DateTime(2018, 1, 1),
                                Description = "Jeden z najwybitniejszych graczy spoza USA w historii NBA. Czterokrotny mistrz NBA z San Antonio Spurs."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 591, // Manu Ginobili
                                DraftDate = new DateTime(1999, 1, 1),
                                EndOfCareerDate = new DateTime(2018, 1, 1),
                                Description = "Jeden z najwybitniejszych graczy spoza USA w historii NBA. Czterokrotny mistrz NBA z San Antonio Spurs."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 592, // Shawn Kemp
                                DraftDate = new DateTime(1989, 1, 1),
                                EndOfCareerDate = new DateTime(2003, 1, 1),
                                Description = "Znany z potężnych wsadów i współpracy z Gary Paytonem w drużynie Seattle SuperSonics."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 593, // Vince Carter
                                DraftDate = new DateTime(1998, 1, 1),
                                EndOfCareerDate = DateTime.Now,
                                Description = "Jeden z najbardziej spektakularnych wsadzających w historii NBA. Dwukrotny mistrz olimpijski z reprezentacją USA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 594, // Gilbert Arenas
                                DraftDate = new DateTime(2001, 1, 1),
                                EndOfCareerDate = new DateTime(2012, 1, 1),
                                Description = "Znany jako Agent Zero, był jednym z najlepszych strzelców ligi w latach 2000."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 595, // Alonzo Mourning
                                DraftDate = new DateTime(1992, 1, 1),
                                EndOfCareerDate = new DateTime(2008, 1, 1),
                                Description = "Znany z doskonałej gry obronnej i blokowania rzutów. Dwukrotny mistrz olimpijski z reprezentacją USA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 596, // Moses Malone
                                DraftDate = new DateTime(1974, 1, 1),
                                EndOfCareerDate = new DateTime(1995, 1, 1),
                                Description = "Jeden z najlepszych centerów w historii ligi. Trzykrotny MVP NBA i mistrz NBA z Philadelphia 76ers w 1983 roku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 597, // Julius Erving
                                DraftDate = new DateTime(1972, 1, 1),
                                EndOfCareerDate = new DateTime(1987, 1, 1),
                                Description = "Znany jako Dr. J, był jednym z najbardziej spektakularnych graczy w historii NBA. Mistrz NBA z Philadelphia 76ers w 1983 roku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 598, // Maurice Cheeks
                                DraftDate = new DateTime(1978, 1, 1),
                                EndOfCareerDate = new DateTime(1993, 1, 1),
                                Description = "Uważany za jednego z najlepszych obrońców w historii ligi. Czterokrotny mistrz NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 599, // Bobby Jones
                                DraftDate = new DateTime(1974, 1, 1),
                                EndOfCareerDate = new DateTime(1986, 1, 1),
                                Description = "Jeden z najlepszych obrońców w historii ligi. Czterokrotny mistrz NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 600, // Billy Cunningham
                                DraftDate = new DateTime(1965, 1, 1),
                                EndOfCareerDate = new DateTime(1976, 1, 1),
                                Description = "Mistrz NBA z Philadelphia 76ers w 1967 roku. Osiągał średnio ponad 20 punktów na mecz."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 601, // Earl Monroe
                                DraftDate = new DateTime(1967, 1, 1),
                                EndOfCareerDate = new DateTime(1980, 1, 1),
                                Description = "Znany jako Pearl, był jednym z najbardziej widowiskowych graczy w historii NBA. Mistrz NBA z New York Knicks w 1973 roku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 601, // Earl Monroe
                                DraftDate = new DateTime(1967, 1, 1),
                                EndOfCareerDate = new DateTime(1980, 1, 1),
                                Description = "Znany jako Pearl, był jednym z najbardziej widowiskowych graczy w historii NBA. Mistrz NBA z New York Knicks w 1973 roku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 602, // Bob McAdoo
                                DraftDate = new DateTime(1972, 1, 1),
                                EndOfCareerDate = new DateTime(1986, 1, 1),
                                Description = "Jeden z najlepszych strzelców w historii ligi. Dwukrotny mistrz NBA i MVP w latach 1975 i 1976."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 603, // Nate Thurmond
                                DraftDate = new DateTime(1963, 1, 1),
                                EndOfCareerDate = new DateTime(1977, 1, 1),
                                Description = "Jeden z najlepszych obrońców w historii ligi. Czterokrotny lider w blokowaniu rzutów."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 604, // Artis Gilmore
                                DraftDate = new DateTime(1971, 1, 1),
                                EndOfCareerDate = new DateTime(1988, 1, 1),
                                Description = "Jeden z najlepszych centrów w historii ligi. Mistrz ABA w 1975 roku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 605, // Neil Johnston
                                DraftDate = new DateTime(1951, 1, 1),
                                EndOfCareerDate = new DateTime(1959, 1, 1),
                                Description = "Pięciokrotny lider ligi w punktach na mecz. Dwukrotny mistrz NBA z Philadelphia Warriors."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 606, // Lenny Wilkens
                                DraftDate = new DateTime(1960, 1, 1),
                                EndOfCareerDate = new DateTime(1975, 1, 1),
                                Description = "Znany jako gracz-kluczownik, który potrafił kierować grą drużyny. W późniejszych latach odniósł sukces jako trener."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 607, // George Yardley
                                DraftDate = new DateTime(1950, 1, 1),
                                EndOfCareerDate = new DateTime(1960, 1, 1),
                                Description = "Pierwszy zawodnik, który zdobył ponad 2000 punktów w jednym sezonie."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 608, // Wes Unseld
                                DraftDate = new DateTime(1968, 1, 1),
                                EndOfCareerDate = new DateTime(1981, 1, 1),
                                Description = "Jeden z najlepszych środkowych w historii ligi. Dwukrotny mistrz NBA z Washington Bullets."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 609, // Paul Arizin
                                DraftDate = new DateTime(1950, 1, 1),
                                EndOfCareerDate = new DateTime(1962, 1, 1),
                                Description = "Jeden z najlepszych strzelców w historii NBA. Mistrz NBA w 1956 roku z Philadelphia Warriors."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 610, // Elvin Hayes
                                DraftDate = new DateTime(1968, 1, 1),
                                EndOfCareerDate = new DateTime(1984, 1, 1),
                                Description = "Jeden z najlepszych silnych skrzydłowych w historii NBA. Dwukrotny lider w liczbie punktów zdobytych w sezonie."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 611, // Clyde Lovellette
                                DraftDate = new DateTime(1952, 1, 1),
                                EndOfCareerDate = new DateTime(1964, 1, 1),
                                Description = "Jeden z najwszechstronniejszych graczy w historii NBA. Dwukrotny mistrz NBA z Minneapolis Lakers."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 612, // Joe Dumars
                                DraftDate = new DateTime(1985, 1, 1),
                                EndOfCareerDate = new DateTime(1999, 1, 1),
                                Description = "Jeden z najlepszych obrońców w historii NBA. Trzykrotny mistrz NBA z Detroit Pistons."
                            },
                             new HistoricalPlayer
                            {
                                PlayerID = 613, // Rick Barry
                                DraftDate = new DateTime(1965, 1, 1),
                                EndOfCareerDate = new DateTime(1980, 1, 1),
                                Description = "Wielokrotny mistrz i lider ligi w punktach. Znany ze swojego charakterystycznego rzutu swobodnego."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 614, // Hal Greer
                                DraftDate = new DateTime(1958, 1, 1),
                                EndOfCareerDate = new DateTime(1973, 1, 1),
                                Description = "Jeden z najlepszych strzelców i obrońców w historii NBA. Wielokrotny uczestnik meczu gwiazd NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 615, // Robert Pettit
                                DraftDate = new DateTime(1954, 1, 1),
                                EndOfCareerDate = new DateTime(1965, 1, 1),
                                Description = "Jeden z najwybitniejszych graczy w historii NBA. Dwukrotny MVP ligi i mistrz NBA w 1958 roku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 616, // Dave Cowens
                                DraftDate = new DateTime(1970, 1, 1),
                                EndOfCareerDate = new DateTime(1983, 1, 1),
                                Description = "Jeden z najbardziej wszechstronnych centrów w historii NBA. Dwukrotny mistrz NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 617, // Walt Frazier
                                DraftDate = new DateTime(1967, 1, 1),
                                EndOfCareerDate = new DateTime(1980, 1, 1),
                                Description = "Znany jako 'Clyde', był jednym z najlepszych obrońców w historii ligi. Dwukrotny mistrz NBA z New York Knicks."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 618, // Willis Reed
                                DraftDate = new DateTime(1964, 1, 1),
                                EndOfCareerDate = new DateTime(1974, 1, 1),
                                Description = "Ikoniczna postać dla New York Knicks. Dwukrotny mistrz NBA, MVP finałów w 1970 roku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 619, // Dave DeBusschere
                                DraftDate = new DateTime(1962, 1, 1),
                                EndOfCareerDate = new DateTime(1974, 1, 1),
                                Description = "Jeden z najlepszych obrońców w historii NBA. Dwukrotny mistrz NBA z New York Knicks."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 620, // Paul Pierce
                                DraftDate = new DateTime(1998, 1, 1),
                                EndOfCareerDate = new DateTime(2017, 1, 1),
                                Description = "Ikoniczna postać dla Boston Celtics. Mistrz NBA i MVP finałów w 2008 roku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 621, // Kevin Garnett
                                DraftDate = new DateTime(1995, 1, 1),
                                EndOfCareerDate = new DateTime(2016, 1, 1),
                                Description = "Jeden z najlepszych obrońców w historii NBA. Mistrz NBA i MVP w 2004 roku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 622, // Tony Allen
                                DraftDate = new DateTime(2004, 1, 1),
                                EndOfCareerDate = new DateTime(2018, 1, 1),
                                Description = "Znany jako 'Grindfather', był jednym z najlepszych obrońców w NBA. Sześciokrotny członek All-Defensive First Team."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 623, // Rajon Rondo
                                DraftDate = new DateTime(2006, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Znany ze swojego geniuszu koszykarskiego i zdolności do prowadzenia drużyny. Mistrz NBA z Boston Celtics."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 624, // Tracy McGrady
                                DraftDate = new DateTime(1997, 1, 1),
                                EndOfCareerDate = new DateTime(2013, 1, 1),
                                Description = "Jeden z najwybitniejszych skrzydłowych w historii ligi. Dwukrotny lider ligi w zdobytych punktach."
                            },
                             new HistoricalPlayer
                            {
                                PlayerID = 625, // Reggie Miller
                                DraftDate = new DateTime(1987, 1, 1),
                                EndOfCareerDate = new DateTime(2005, 1, 1),
                                Description = "Jeden z najwybitniejszych strzelców za trzy punkty w historii NBA. Ikona Indiana Pacers."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 626, // Yao Ming
                                DraftDate = new DateTime(2002, 1, 1),
                                EndOfCareerDate = new DateTime(2011, 1, 1),
                                Description = "Dominujący chiński center, który stał się jednym z najbardziej rozpoznawalnych graczy w historii ligi."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 627, // Grant Hill
                                DraftDate = new DateTime(1994, 1, 1),
                                EndOfCareerDate = new DateTime(2013, 1, 1),
                                Description = "Znakomity skrzydłowy, którego kariera została naznaczona kontuzjami, ale który nadal był gwiazdą NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 628, // J.R. Smith
                                DraftDate = new DateTime(2004, 1, 1),
                                EndOfCareerDate = new DateTime(2019, 1, 1),
                                Description = "Znany ze swojego talentu do rzutów za trzy punkty oraz niekonwencjonalnego stylu gry."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 629, // Richard Jefferson
                                DraftDate = new DateTime(2001, 1, 1),
                                EndOfCareerDate = new DateTime(2018, 1, 1),
                                Description = "Doświadczony skrzydłowy, który w swojej karierze występował w wielu znaczących zespołach NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 630, // Ben Wallace
                                DraftDate = new DateTime(1996, 1, 1),
                                EndOfCareerDate = new DateTime(2012, 1, 1),
                                Description = "Jeden z najlepszych obrońców w historii NBA. Czterokrotny obrońca roku NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 631, // Chauncey Billups
                                DraftDate = new DateTime(1997, 1, 1),
                                EndOfCareerDate = new DateTime(2014, 1, 1),
                                Description = "Znany jako 'Mr. Big Shot', był kluczowym graczem w zdobyciu mistrzostwa NBA przez Detroit Pistons w 2004 roku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 632, // Rasheed Wallace
                                DraftDate = new DateTime(1995, 1, 1),
                                EndOfCareerDate = new DateTime(2013, 1, 1),
                                Description = "Wielokrotny mistrz NBA znany ze swojej wszechstronności i zdolności do gry w obronie."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 633, // Tayshaun Prince
                                DraftDate = new DateTime(2002, 1, 1),
                                EndOfCareerDate = new DateTime(2016, 1, 1),
                                Description = "Skuteczny i wszechstronny skrzydłowy, który był ważnym członkiem mistrzowskiego zespołu Detroit Pistons w 2004 roku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 634, // Maurice Lucas
                                DraftDate = new DateTime(1974, 1, 1),
                                EndOfCareerDate = new DateTime(1988, 1, 1),
                                Description = "Znany z twardej gry i zdolności do zdobywania punktów. Mistrz NBA z Portland Trail Blazers w 1977 roku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 635, // Lionel Hollins
                                DraftDate = new DateTime(1975, 1, 1),
                                EndOfCareerDate = new DateTime(1985, 1, 1),
                                Description = "Doświadczony rozgrywający, który w swojej karierze występował w kilku znaczących zespołach NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 636, // Bob Gross
                                DraftDate = new DateTime(1975, 1, 1),
                                EndOfCareerDate = new DateTime(1983, 1, 1),
                                Description = "Weteran ligi NBA, który znany był z ciężkiej pracy i skuteczności na boisku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 637, // Pau Gasol
                                DraftDate = new DateTime(2001, 1, 1),
                                EndOfCareerDate = new DateTime(2019, 1, 1),
                                Description = "Jeden z najlepszych hiszpańskich graczy w historii NBA. Mistrz NBA z Los Angeles Lakers."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 638, // Lamar Odom
                                DraftDate = new DateTime(1999, 1, 1),
                                EndOfCareerDate = new DateTime(2013, 1, 1),
                                Description = "Wszechstronny gracz, który był kluczowym elementem sukcesu Los Angeles Lakers w latach 2000-2010."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 639, // Trevor Ariza
                                DraftDate = new DateTime(2004, 1, 1),
                                EndOfCareerDate = new DateTime(2022, 1, 1),
                                Description = "Silny obrońca i skrzydłowy, który odgrywał istotną rolę w zdobyciu mistrzostwa NBA przez różne zespoły."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 640, // Andre Iguodala
                                DraftDate = new DateTime(2004, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Wszechstronny skrzydłowy znany ze swojej zdolności do gry zarówno w ataku, jak i w obronie. Mistrz NBA z Golden State Warriors."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 7, 
                                DraftDate = new DateTime(2007, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Wszechstronny koszykarz znany z inteligentnej gry i przywództwa, który przyczynił się do zdobycia przez Florida Gators dwóch mistrzostw NCAA, zanim rozpoczął swoją zawodową karierę w NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 92, 
                                DraftDate = new DateTime(2009, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Uznawany zawodnik NBA, znany z dynamicznej gry ofensywnej i zdolności do zdobywania punktów, który rozpoczął swoją karierę w Toronto Raptors przed przejściem do innych drużyn ligi."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 110, 
                                DraftDate = new DateTime(2009, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Pochodzący z Hiszpanii rozgrywający, jest znany w NBA ze swoich niezwykłych umiejętności podawania i obrony, a także za swój wpływ na dynamikę drużyny zarówno na parkiecie, jak i poza nim."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 163, 
                                DraftDate = new DateTime(2012, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Gwiazda Milwaukee Bucks, wyróżnia się jako wszechstronny skrzydłowy, znany z precyzyjnego rzutu za trzy punkty, umiejętności w kluczowych momentach meczów oraz solidnej obrony, będąc kluczowym elementem drużyny w drodze do zdobycia mistrzostwa NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 167, 
                                DraftDate = new DateTime(2013, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Znany jako 'Greek Freak', to dominujący zawodnik Milwaukee Bucks, który zyskał uznanie dzięki swojej wszechstronności na parkiecie, niezwykłej zdolności do przechodzenia przez obronę, siły oraz atletyzmu, co przyniosło mu tytuły MVP NBA oraz kluczową rolę w zdobyciu mistrzostwa ligi."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 211, 
                                DraftDate = new DateTime(2006, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Znany ze swojej niezachwianej determinacji i umiejętności przywódczych, to doświadczony rozgrywający, który odegrał kluczową rolę w zdobyciu mistrzostwa NBA przez Toronto Raptors, ceniony za swój wszechstronny wkład w grę, zarówno w ofensywie, jak i defensywie."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 357,
                                DraftDate = new DateTime(2011, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Elitarny strzelec i obrońca, znany z rekordowych występów w rzutach za trzy punkty, kluczowy zawodnik Golden State Warriors."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 365, 
                                DraftDate = new DateTime(2009, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Rewolucjonista gry, uznawany za najlepszego strzelca za trzy punkty w historii NBA, dwukrotny MVP ligi i lider Golden State Warriors."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 363, 
                                DraftDate = new DateTime(2012, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Serce obrony Golden State Warriors, znany z wszechstronności, intensywnej gry i zdolności do gry na wielu pozycjach."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 398, 
                                DraftDate = new DateTime(2003, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Jeden z najwybitniejszych graczy w historii NBA, zdobywca wielu tytułów MVP i mistrzostw, znany ze swojej siły, inteligencji na boisku i wszechstronności."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 444, 
                                DraftDate = new DateTime(2011, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Znakomity rozgrywający, mistrz dryblingu, który słynie z niezwykłej zdolności kończenia akcji pod koszem i decydujących rzutów."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 271, 
                                DraftDate = new DateTime(2014, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Serbski center, zdobywca MVP NBA, znany z wyjątkowych umiejętności podawania i wszechstronnego wpływu na grę Denver Nuggets."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 223, 
                                DraftDate = new DateTime(2008, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Skrzydłowy/pivot, który zdobył uznanie dzięki swoim umiejętnościom w zbiórkach i rzutach za trzy punkty, kluczowy zawodnik w mistrzowskim sezonie Cleveland Cavaliers."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 154, 
                                DraftDate = new DateTime(2012, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Niezwykle zdolny rozgrywający Portland Trail Blazers, znany z dalekosiężnych rzutów i zdolności do przejmowania kontroli nad grą w decydujących momentach."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 219, 
                                DraftDate = new DateTime(2011, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Twardy i wszechstronny skrzydłowy, lider Miami Heat, ceniony za swoją obronę, etykę pracy i umiejętność gry pod presją."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 275,
                                DraftDate = new DateTime(2016, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Dynamiczny rozgrywający Denver Nuggets, który zyskał uznanie za swoje imponujące występy w playoffach NBA."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 368,
                                DraftDate = new DateTime(2009, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Jeden z najlepszych strzelców ligi, znany z umiejętności zdobywania punktów, zwłaszcza poprzez rzuty za trzy i gry jeden na jednego."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 369,
                                DraftDate = new DateTime(2011, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Dwukrotny MVP finałów NBA, ceniony za swoje umiejętności defensywne i spokojne, ale skuteczne podejście do gry ofensywnej."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 376,
                                DraftDate = new DateTime(2010, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Wszechstronny skrzydłowy, który potrafi zdobywać punkty, bronić i wpływać na grę na wielu poziomach."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 388,
                                DraftDate = new DateTime(2012, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Jeden z najbardziej dominujących zawodników pod koszem w NBA, znany z obrony i wszechstronnej gry ofensywnej."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 417,
                                DraftDate = new DateTime(2007, 1, 1),
                                EndOfCareerDate = null,
                                Description = "Jeden z najbardziej płodnych strzelców w historii NBA, zdolny do gry na wielu pozycjach i wpływania na mecz na obu końcach parkietu."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 354,
                                DraftDate = new DateTime(2005, 1, 1),
                                EndOfCareerDate = null,
                                Description = "'Point God', znany z genialnych umiejętności rozgrywającego, kontroli gry i zdolności lidera na boisku."
                            },
                            new HistoricalPlayer
                            {
                                PlayerID = 487,
                                DraftDate = new DateTime(2008, 1, 1),
                                EndOfCareerDate = null,
                                Description = " Były MVP ligi, którego karierę naznaczyły kontuzje, ale który zachował zdolność do dynamicznej gry i zdobywania punktów."
                            }

                };
                    _dbContext.HistoricalPlayers.AddRange(playerData);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
