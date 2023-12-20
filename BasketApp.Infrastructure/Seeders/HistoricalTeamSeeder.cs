using BasketApp.Domain.Entities;
using BasketApp.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketApp.Infrastructure.Seeders
{
    public  class HistoricalTeamSeeder
    {


        private readonly BasketAppDbContext _dbContext;
        public HistoricalTeamSeeder(BasketAppDbContext dbContext)
        {

            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.HistoricalTeams.Any())
                {
                    var historicalteamsData = new List<HistoricalTeam>
                    {
                        new HistoricalTeam { 
                            TeamID = 26,
                            Name = "2016-17 Golden State Warriors",
                            SeasonStartDate = new DateTime(2016,10,25),
                            SeasonEndDate = new DateTime(2017,06,18),
                            SuperStarPlayer = "Kevin Durant",
                            Description = "Golden State Warriors sezonu 2016-17 byli siłą, jakiej NBA dotąd nie widziała." +
                            "\r\n\r\nPrzed rozpoczęciem tego sezonu Kevin Durant i Stephen Curry zajmowali trzecie i piąte miejsce z kolei w karierowym wskaźniku ofensywnego box plus/minus (obecnie zajmują praktycznie wspólne trzecie miejsce)." +
                            "\r\n\r\nMając obu graczy w jednym zespole, do którego dołączyli również Klay Thompson, Draymond Green i Andre Iguodala, sprawiło, że słowo \"niesprawiedliwe\" wydawało się niewystarczające.\r\n\r\n" +
                            "Ci Warriors nie doświadczyli trudności, które większość superteamów przeżywa w pierwszym roku." +
                            " Zdobyli 67 zwycięstw, co było czwartym najlepszym wynikiem w historii ligi według prostego systemu ratingowego," +
                            " a także mieli najlepszy efektywny wskaźnik celności rzutów (do tamtego momentu)." +
                            "\r\n\r\nSiedmiu graczy uzyskało średnio co najmniej 22 punkty i miało skuteczność rzutów powyżej 56% w tym sezonie. Trzech z nich było z Golden State (Curry, Durant i Thompson)." +
                            "\r\n\r\nPierwszy sezon Duranta w Warriors był może najbardziej płynną integracją nowego superstara w historii NBA.\r\n\r\nGry wszystkich graczy zdawały się doskonale uzupełniać. " +
                            "I osiągnęli szczyt dokładnie w odpowiednim momencie.\r\n\r\nZwycięstwo Cleveland Cavaliers w czwartym meczu finałów było jedyną skazą na ich nieskazitelnej karierze w fazie play-off, " +
                            "gdzie osiągnęli imponujące +230 różnicy punktów w ciągu 17 gier – najlepszy wynik punktowy w historii jednego sezonu play-off. Od momentu ogłoszenia przez Duranta swoich zamiarów dołączenia do Golden State" +
                            ", aż po zakończenie finału w piątym meczu przeciwko Cleveland, wynik końcowy sezonu 2016-17 wydawał się nieuchronny." },
                    
                        new HistoricalTeam { 
                            TeamID = 6,
                            Name = "1971-72 Los Angeles Lakers",
                            SeasonStartDate = new DateTime(1971,10,12),
                            SeasonEndDate = new DateTime(1972, 05, 07),
                            SuperStarPlayer = "Jerry West",
                            Description = "Lata 1971-72 to okres, w którym Los Angeles Lakers prowadzeni byli przez trzech doświadczonych i głodnych koszykarzy Hall of Fame.\r\n\r\nWilt Chamberlain zdobył tytuł z 76ers w lat 60., ale poświęcił większość swojej kariery na ściganie Billa Russella, i zdobycie kolejnego tytułu z pewnością dodawałoby splendoru jego dziedzictwu." +
                            "\r\n\r\nJerry West, z kolei, dominował w NBA jako zdobywca punktów przez 11 sezonów przed 1971-72 (miał szóstą najwyższą średnią zdobywanych punktów w karierze do tego czasu), ale nigdy nie zdobył tytułu. Jego największym wyróżnieniem w fazie play-off było zdobycie MVP Finałów jako jedyny gracz w przegranej drużynie (do dzisiaj jest jedyny na tej liście)." +
                            "\r\n\r\nMimo że Gail Goodrich nie grał tak długo jak West i Chamberlain, także poszukiwał swojego pierwszego mistrzostwa.\r\n\r\n(Elgin Baylor również był częścią tego zespołu, chociaż tylko przez dziewięć meczów.)" +
                            "\r\n\r\nJim McMillian i Happy Hairston nie zdobyli takich samych laurów w trakcie swoich karier, ale z pewnością odegrali kluczową rolę w sukcesie tego konkretnego zespołu." +
                            "\r\n\r\nCi pięciu liderów poprowadziło zespół Lakersów (69-13), który ma trzeci najlepszy system prostego ratingu w historii NBA. Zniszczyli swoją konkurencję, notując rekord NBA z 33 kolejnymi zwycięstwami od 5 listopada do 7 stycznia." +
                            "\r\n\r\nDzięki Goodrichowi (25.9 punktów i 4.5 asysty), Westowi (25.8 punktów i prowadzącą ligę 9.7 asyst) oraz McMillianowi (18.8 punktów), byli liderami ligi pod względem punktów na 100 posiadanych piłek. " +
                            "Chamberlain (19.2 punktów i 14.8 zbiórek w swoim przedostatnim sezonie) i Hairston (13.1 punktów i 13.1 zbiórek) byli filarami drugiej najlepszej obrony sezonu." +
                            "\r\n\r\nDominacja zarówno w ataku, jak i w obronie przeniosła się do fazy play-off, gdzie Lakersi uzyskali bilans 12-3 i prześcigali rywali o 10.5 punktu na 100 posiadanych piłek (siódmy najlepszy wynik wszech czasów w play-off)."
                        },
                        
                        new HistoricalTeam { 
                            TeamID = 8,
                            Name = "1985-86 Boston Celtics",
                            SeasonStartDate = new DateTime(1985, 10, 25),
                            SeasonEndDate = new DateTime(1986, 06, 08),
                            SuperStarPlayer = "Larry Bird",
                            Description = "Lata 1985-86 mogą być bez wątpienia określone jako najlepszy okres dla Boston Celtics w koszykówce lat 80." +
                            " Nie tylko mieli najlepszy system prostego ratingu tej dekady, ale również mogli się poszczycić MVP w osobie Larry'ego Birda, Sixth Man of the Year i byłego MVP, Billa Walta, a także Kevina McHale'a i Roberta Parisha, którzy wciąż byli w swoich szczytowych formach lub bardzo blisko nich, wspieranych solidnym zespołem wokół gwiazd." +
                            "\r\n\r\nBird, oczywiście, był jednoznacznie numerem jeden. Prowadził zespół w punktach (25.8), zbiórkach (9.8), asystach (6.8) i przechwytach (2.0) na mecz, jednocześnie będąc liderem całej ligi pod względem box plus/minus (zdecydowanie). " +
                            "Również trafił 42.3 procenta rzutów z głębi i trafiając średnio 1.0 trójek na mecz, wynik, który ustępował tylko 1.1 Craigowi Hodgesowi.\r\n\r\nBył bezsprzecznie najlepszym graczem NBA tamtego sezonu. Zaczęły się pojawiać rozmowy o jeszcze wyższym wyróżnieniu." +
                            "\r\n\r\n\"To najlepszy gracz wszech czasów\", powiedział Don Nelson, wówczas szkoleniowiec Milwaukee Bucks, w 1986 roku. \"Celtics grają na innym poziomie. Bird? Cóż, on jest na swoim własnym poziomie.\"\r\n\r\nTen poziom, na którym grali pozostali Celtics, również nie był zły." +
                            "\r\n\r\nMcHale był dziesiątym zawodnikiem w lidze pod względem box plus/minus. Walton i Parish zajmowali odpowiednio 23. i 33. miejsce. Stawienie czoła tej trójce wysokich zawodników było zniechęcające dla przeciwników.\r\n\r\nMcHale notował średnio 21.3 punktów, 8.1 zbiórek i 2.0 bloków. " +
                            "Parish dodawał 16.1 punktów, 9.5 zbiórek i 1.4 bloku w 31.7 minuty. Walton, w zaledwie 19.3 minuty na mecz, dorzucał 7.6 punktów, 6.8 zbiórek, 2.1 asysty i 1.3 bloku." +
                            "\r\n\r\nZ tymi trójką nie dziwi fakt, że Boston zakończył sezon na czwartym miejscu pod względem średniej bloków na mecz (za Washington Wizards z Manute Bol'em, Utah Jazz z Markiem Eatonem i Houston Rockets z Hakeemem Olajuwonem)." +
                            "\r\n\r\nRównież obrońcy w tej drużynie wnieśli sporo. Dennis Johnson, który przed sezonem 1985-86 zdobył pięć nominacji do All-Star, notował średnio 15.6 punktów i 5.8 asyst. Danny Ainge dodawał 10.7 punktów i 5.1 asyst." +
                            "\r\n\r\nCała rotacja wydawała się być niemal bez skazy. Celtics miażdżyli resztę NBA, osiągając 67 zwycięstw w sezonie regularnym i 15-3 triumf w drodze po mistrzostwo."
                        },
                        new HistoricalTeam { 
                            TeamID = 11,
                            Name = "1990-91 Chicago Bulls",
                            SeasonStartDate = new DateTime(1990,11,02),
                            SeasonEndDate = new DateTime(1991,06,12),
                            SuperStarPlayer = "Michael Jordan",
                            Description = "Drużyna Chicago Bulls sezonu 1990-91, pierwsza drużyna, która zdobyła tytuł pod wodzą Michaela Jordana, nie była tak dominująca w sezonie regularnym jak drużyna z sezonu 1996-97, ale ich panowanie w fazie play-off daje im przewagę." +
                            "\r\n\r\nPlay-off drużyny z 1991 roku: .882 procent wygranych, 6.3 względny wskaźnik ofensywny, minus-6.9 względny wskaźnik defensywny (minus jest tutaj korzystny), 13.2 wskaźnik netto" +
                            "\r\nPlay-off drużyny z 1997 roku: .789 procent wygranych, 0.8 względny wskaźnik ofensywny, minus-5.7 względny wskaźnik defensywny, 6.5 wskaźnik netto" +
                            "\r\n\r\nSkład z 1990-91 roku zmiótł zespół New York Knicks, Philadelphia 76ers i Detroit Pistons, osiągając imponujący wynik 11-1 w Konferencji Wschodniej. W finale zdominowali Magic'a Johnsona i Los Angeles Lakers w pięciu meczach." +
                            "\r\n\r\nRóżnica wynosząca 49 punktów w trakcie serii jest zrównana z osiągnięciem zespołu Milwaukee Bucks z sezonu 1970-71 i zajmuje ósme miejsce pod względem największych różnic punktowych w historii finałów (jest to także największa różnica dla jakiejkolwiek drużyny Bulls)." +
                            "\r\n\r\nJeśli chodzi o indywidualne występy, Jordan, jak można się było spodziewać, był absurdalny. W sezonie regularnym notował średnio 31.5 punktu, 6.0 zbiórki, 5.5 asysty, 2.7 przechwytu i 1.0 bloku. Podniósł średnią asyst do 8.4 w fazie play-off." +
                            "\r\n\r\nScottie Pippen rozwijał się w dominującego rzucającego forda, którego kiedyś stał się. W sezonie regularnym notował średnio 17.8 punktu, 7.3 zbiórki, 6.2 asysty, 2.4 przechwytu i 1.1 bloku.\r\n\r\nOczywiście, ci dwaj stanowili fundament, ale było wiele wkładów od innych zawodników Bulls." +
                            " Grant był obrończym kotwicą i pewnym strzelcem. Armstrong był iskrzącym ogniwem z ławki. John Paxson i Craig Hodges byli dwoma z najlepszych rozstawiaczy na boisku.\r\n\r\nJordan był fenomenem już długo przed 1991 rokiem, ale to dopiero dzięki temu konkretnemu zespołowi wsparcia udało mu się zdobyć tytuł."
                        },

                        new HistoricalTeam { 
                            TeamID = 11,
                            Name = "1995-96 Chicago Bulls",
                            SeasonStartDate = new DateTime(1995, 11, 03),
                            SeasonEndDate = new DateTime(1996, 06, 16),
                            SuperStarPlayer = "Michael Jordan",
                            Description = "Przed sezonem 2015-16 drużyna Golden State Warriors, zdobywcy 72 zwycięstw przez Chicago Bulls w sezonie 1995-96, wydawała się być jednym z tych niepobitych rekordów sportowych." +
                            "\r\n\r\nW tamtym sezonie prowadzili ligę NBA pod względem prostego systemu ratingu (ich 11.8 to drugi najlepszy wynik w historii NBA), wskaźnika ofensywnego i defensywnego" +
                            ".\r\n\r\nJordan notował średnio 30.4 punktu, 4.3 asysty i 2.2 przechwytu. Pippen zapewniał 19.4 punktu, 6.4 zbiórki i 5.9 asysty. Kukoc dodawał 13.1 punktu i 3.5 asysty, trafiając 40.3 procent trójek w ciągu 26.0 minut z ławki. Kerr trafiał 51.5 procent trójek przy 2.9 próbach na mecz." +
                            " A Rodman dominował na tablicach, zdobywając średnio 14.9 zbiórki.\r\n\r\nJordan był główną atrakcją, z Pippenem jako godnym aktorem wspierającym. Ale talent i precyzyjne wykonanie w całym składzie trwały długo po zakończeniu sezonu z rekordową liczbą zwycięstw." +
                            "\r\n\r\n\"Mieliśmy bardzo wyjątkowy sukces w tym roku, i myślę, że mamy świetny zespół\", powiedział Jordan po uzyskaniu rekordu zwycięstw w sezonie regularnym. \"Ale wciąż mamy wiele do przygotowania. Sezon regularny naprawdę nie ma znaczenia od tego momentu." +
                            "\"\r\n\r\nW fazie play-off Chicago było niemal równie dominujące, przewyższając rywali o 12.1 punktu na 100 posiadanych piłek (czwarty najlepszy wskaźnik netto w historii play-off) i uzyskując bilans 15-3 w drodze po tytuł." +
                            "\r\n\r\nFani mogą pamiętać pewne drużyny Bulls bardziej niż inne. Statystycznie, sezon 1995-96 był kulminacją dynastii pod wodzą Phila Jacksona."
                        },

                        new HistoricalTeam { 
                            TeamID = 6,
                            Name = "1986-87 Los Angeles Lakers",
                            SeasonStartDate = new DateTime(1986, 10, 31),
                            SeasonEndDate = new DateTime(1987, 06, 14),
                            SuperStarPlayer = "Magic Jhonson",
                            Description = "Po latach raczej równorzędnej współpracy między Magic'em a Kareemem (a w końcu również Worthy'm), Los Angeles Lakers sezonu 1986-87 byli w dużej mierze drużyną Magica." +
                            "\r\n\r\nW tym sezonie zdobył swój pierwszy z trzech tytułów MVP ligi przy rekordzie 65-17 oraz średnich 23.9 punktu, 12.2 asysty i 6.3 zbiórki. Miał niemal tyle samo zwycięstw nad zastępstwem gracza co reszta składu L.A. razem wzięta." +
                            "\r\n\r\nRola głównej opcji była nowością dla Magica, ale sprostał zadaniu znakomicie.\r\n\r\n\"Byłem gotów zostać strzelcem\", powiedział, cytowany przez Jacka McCalluma z Sports Illustrated. \"Jestem jednym z tych graczy, którzy potrafią włączać i wyłączać zdobywanie punktów." +
                            "\"\r\n\r\nSłowo \"włączać\" to pewne niedoprecyzowanie, gdy opisujemy własną ofensywę Magica w sezonie 1986-87. Był dziesiąty w lidze pod względem punktów na mecz, ale gdy ograniczymy próbkę do tych, którzy dorównali lub przekroczyli jego 60.2 procentową celność rzutów za dwa punkty, ustępował tylko Birdowi i McHale'owi. " +
                            "Ci dwaj, oczywiście, pozostawali daleko w tyle jeśli chodzi o liczbę asyst Magica (razem osiągnęli 10.2 na mecz)." +
                            "\r\n\r\nMimo że Magic był wyraźnie silnikiem tej drużyny, wciąż otrzymywał solidne wsparcie od swoich kolegów. " +
                            "Worthy był drugi w drużynie pod względem zdobywanych punktów, średnio 19.4 na mecz. Kareem, w kampanii z 39 latami na karku, dodawał 17.5. A dynamicznie rozwijający się Byron Scott dorzucał kolejne 17.0." +
                            "\r\n\r\nW tej drużynie występował również Michael Cooper, jeden z najwybitniejszych obrońców gry. W trakcie swojej kariery ośmiokrotnie znalazł się w drużynie All-Defense, ale sezon 1986-87 mógł być jego szczytem." +
                            "\r\n\r\n\"Oto zawodnik, który broni Larry'ego Birda jak nikt inny\", napisał Ralph Wiley z Sports Illustrated o Cooperze krótko przed ogłoszeniem go Obrońcą Roku. \"...którego idea Nirwany to obrona jedno na jedno przeciwko Birdowi lub Michaelowi Jordanowi." +
                            "\"\r\n\r\nDzięki jego obronie na zewnątrz, wspierającej absurdalną ofensywę Magica, Lakers byli potęgą. I dokładnie tak grali w fazie play-off, gdzie uzyskali bilans 15-3, w tym zwycięstwo w finałach z Celtami w sześciu meczach."

                        },

                        new HistoricalTeam { 
                            TeamID = 6,
                            Name = "2000-01 Los Angeles Lakers",
                            SeasonStartDate = new DateTime(2000, 10, 31),
                            SeasonEndDate = new DateTime(2001, 06, 15),
                            SuperStarPlayer = "Shaquille O'Neal",
                            Description = "Tuż po zdobyciu razem pierwszego tytułu NBA, Shaq i Kobe poprowadzili zespół Los Angeles Lakers sezonu 2000-01, który wydawał się nieco zwalniać podczas sezonu regularnego." +
                            "\r\n\r\nWśród drużyn przeanalizowanych w latach 2000-2009, ta plasuje się na 20. miejscu lub niżej pod względem procenta zwycięstw w sezonie regularnym, prostego systemu ratingu, względnego wskaźnika defensywnego i wskaźnika netto." +
                            " Nawet nie mieli najlepszego bilansu na Zachodzie po zakończeniu sezonu 2000-01.\r\n\r\nAle nic z tego nie miało znaczenia w fazie play-off, gdy Lakers stworzyli jedno z najbardziej dominujących post-season w historii NBA." +
                            "\r\n\r\nL.A. zniszczyli każdy zespół na swojej drodze, rozprawiając się z Portland Trail Blazers, Sacramento Kings i najlepszym zespołem San Antonio Spurs podczas marszu przez Zachód. " +
                            "W pierwszym meczu finałów Allen Iverson zdobył 48 punktów, dając Philadelphia 76ers zwycięstwo, ale Lakers szybko wrócili na właściwe tory, wygrywając kolejne cztery gry średnio różnicą 10 punktów." +
                            "\r\n\r\nW finałach Shaq notował średnio 33.0 punktu, 15.8 zbiórki, 4.8 asysty i 3.4 bloku. (W ciągu trzech lat zdobywania tytułów, średnio osiągał 35.9 punktu, 15.2 zbiórki, 3.5 asysty i 2.9 bloku w 15 meczach finałowych.)" +
                            "\r\n\r\nTen sezon można również uznać za moment, w którym Kobe osiągnął prawdziwy status supergwiazdy.\r\n\r\nW sezonie 1999-00 był 12. pod względem wskaźnika BPM w lidze, ale jego średnia 22.5 punktu sugerowała, że jest wyraźnym numerem 2 po Shaquille'u." +
                            " W sezonie 2000-01 jego średnia wzrosła do 28.5 punktu, zaledwie dwie dziesiąte punktu mniej niż O'Neal. Zajmował także miejsce w czołowej dziesiątce głosowania na MVP po raz pierwszy z 12 późniejszych wystąpień." +
                            "\r\n\r\nShaq i Kobe byli zdecydowanie dynamicznym duetem w drodze do swojego pierwszego mistrzostwa. Ale naprawdę zaczęli umacniać swoją pozycję jako jednego z najlepszych duetów wszech czasów w sezonie 2000-01."
                        },

                        new HistoricalTeam {
                            TeamID = 13,
                            Name = "1988-89 Detroit Pistons",
                            SeasonStartDate = new DateTime(1988, 11, 04),
                            SeasonEndDate = new DateTime(1989, 06, 13),
                            SuperStarPlayer = "Isiah Thomas",
                            Description = "14 lutego 1989 roku drużyna Detroit Pistons sezonu 1988-89 pokonała Los Angeles Lakers, poprawiając swój bilans na 32-13 w sezonie." +
                            "\r\n\r\nNajlepszy strzelec Detroit, Adrian Dantley, zdobył 19 punktów w swoim ostatnim meczu w barwach drużyny, którą wspomógł, prowadząc do 45 spotkań z wynikiem 58-22." +
                            "\r\n\r\nKeith Langlois z oficjalnej strony drużyny opisał wydarzenia poprzedzające wymianę, która wstrząsnęła ligą i jej fanami:" +
                            "\r\n\r\n\"Mowa ciała Bad Boys była niepokojąca. Chuck Daly powiedział [menedżerowi generalnemu Jackowi McCloskey'emu], że Adrian Dantley stał się ponury, i obaj byli zaniepokojeni, że jego nastrój zagrażał toksyczną atmosferą w szatni." +
                            "\r\n\r\n\"McCloskey wziął Dantleya na bok po jednym z treningów Pistons. Spotkali się w małej szatni dla sędziów w The Palace, przy wejściu do tunelu, i McCloskey naciskał na wyjaśnienie. Dantley unikał rozmowy." +
                            "\r\n\r\n\"McCloskey w końcu powiedział mu dosadnie: 'Adrianie, jeśli nie chcesz o tym rozmawiać, to zamierzam cię wymienić, i nie żartuję. Zamierzam cię wymienić. Nie pozwolę, żebyś rozbił tę drużynę. " +
                            "Nie mówię, że jesteś winny, ale wiesz coś, czego ja nie wiem. Powiedziałem mu dosłownie, 'Zamierzam cię wymienić,' i chyba to był zaledwie drugi dzień, kiedy polecieliśmy do Dallas i dokonaliśmy wymiany.'" +
                            "\"\r\n\r\nDetroit właśnie dotarł do finałów z Dantleyem w 1988 roku. Pistons przegrali z Lakers w siedmiu meczach. I gdy wszystko zdawało się iść sprawnie, wymiana Dantleya była, delikatnie mówiąc, śmiałym posunięciem." +
                            "\r\n\r\nAle przez resztę sezonu Pistons osiągnęli bilans 31-6. Isiah Thomas, Joe Dumars i Mark Aguirre (nabyty w wymianie za Dantleya) prowadzili w ataku. Bill Laimbeer, Dennis Rodman, Rick Mahorn i John Salley głównie reprezentowali filozofię \"Bad Boys\". " +
                            "I wszyscy zespolili się, aby dominować w fazie play-off.\r\n\r\nDetroit zakończył ten sezon play-off z bilansem 15-2, jedynie dwie porażki miały miejsce przeciwko Chicago Bulls Michaela Jordana w Finale Konferencji Wschodniej." +
                            " W kolejnej serii, przeciwko drużynie Lakers, która pokonała ich rok wcześniej, Pistons odnieśli zwycięstwo bez straty meczu.\r\n\r\n"

                        },

                         new HistoricalTeam {
                            TeamID = 9,
                            Name = "1982-83 Philadelphia 76ers",
                            SeasonStartDate = new DateTime(1982, 10, 29), 
                             SeasonEndDate = new DateTime(1983, 05, 31),
                            SuperStarPlayer = "Moses Malone",
                            Description = "Szesnaście lat po zdobyciu mistrzostwa z organizacją w 1967 roku, Billy Cunningham poprowadził Philadelphia 76ers sezonu 1982-83 z powrotem na szczyt. Oczywiście miał do dyspozycji dużo talentu." +
                            "\r\n\r\nMoses Malone został MVP tego sezonu dzięki imponującym średnim wynikom 24,5 punktu, 15,3 zbiórki i 2,0 bloku w swoim pierwszym sezonie w Philly." +
                            "\r\n\r\nJulius Erving w swoim 32. sezonie życia dorzucił 21,4 punktu, 6,8 zbiórki, 3,7 asysty, 1,8 bloku i 1,6 przechwytu. Andrew Toney dorzucił 19,7 punktu. A Maurice Cheeks był pewną ręką na sterze, osiągając średnio 12,5 punktu, 6,9 asysty i 2,3 przechwytu." +
                            "\r\n\r\nCi czterej, z wprowadzanym z ławki dołączającym do Sali Sław Bobby Jonesem, dali Sixers dominującą rotację, która doprowadziła do najlepszego wyniku w NBA - 65 zwycięstw i mnóstwa pewności siebie dla Malone'a przed play-offami." +
                            "\r\n\r\nJego przewidywania na fazę play-off? \"Fo', Fo', Fo'\", czyli trzy kolejne serie z wynikiem 4-0.\r\n\r\nPhiladelphia nie do końca potwierdziła przepowiednię Malone'a, ale była blisko. " +
                            "Po rozprawieniu się z New York Knicks w pierwszej rundzie, Sixers prowadzili 3-0 przeciwko Milwaukee Bucks, którzy ukradli jeden mecz, zanim przegrali serię trzy dni później." +
                            "\r\n\r\nOstatecznie Philly zakończyło fazę play-off z bilansem 12-1 po dominującym przejściu, które obejmowało także wymazanie z mapy Lakers Magic'a i Kareema."

                         },

                          new HistoricalTeam {
                            TeamID = 33,
                            Name = "2013-14 San Antonio Spurs",
                            SeasonStartDate = new DateTime(2013, 10, 29),
                              SeasonEndDate = new DateTime(2014, 05, 31),
                            SuperStarPlayer = "Tony Parker",
                            Description = "Po historycznym rzucie Raya Allena, cała drużyna Spurs była zdewastowana." +
                            " Ale uczucia, które seria ta zaszczepiła w San Antonio Spurs sezonu 2013-14, napędziły jedną z największych historii zemsty w NBA." +
                            "\r\n\r\nZach Lowe z Grantland zestawił kilka z tych tematów w jednym akapicie:" +
                            "\r\n\r\n\"Piąte mistrzostwo Spurs symbolizuje wszystko, o czym rozmawialiśmy przez cały rok: tryumf pięknej gry NBA; koronny sukces trzech gwiazd, które zgodziły się na mniejsze pieniądze, aby pozostać razem; katartyczna odpowiedź na być może najdotkliwszą porażkę w historii NBA;" +
                            " i punkt końcowy ewolucji franczyzy od gry w brutalny sposób do szybkiego, trójkowego stylu, który postawił ich ponad niemal każdym innym zespołem w dostosowaniu się do nowych zasad NBA." +
                            "\"\r\n\r\nPiękne, oparte na drużynie podejście Spurs doprowadziło do najlepszego bilansu (62-20) i systemu ratingowego (8.0) w NBA w sezonie 2013-14." +
                            "\r\n\r\nPrzy zachodzącym już zmierzchu ich karier, Tony Parker (16,7) i Tim Duncan (15,1) byli wciąż głównymi strzelcami zespołu. Manu Ginobili dorzucił 12,3 punktu w 22,8 minuty z ławki. A Kawhi Leonard (12,8) zaczynał wyłaniać się jako prawdopodobny następca Wielkiej Trójki." +
                            "\r\n\r\nZnakomitość tego zespołu może być zobaczyć w równowadze, która jawiła się w średnich punktowych. Spurs mieli dziewięciu graczy między 16,7 a 8,2 punktu na mecz. Nikt w zespole nie przekraczał 30 minut gry na mecz. A ich średnia 25,2 asysty na spotkanie prowadziła w NBA." +
                            "\r\n\r\nChemizm tych Spurs był namacalny. Osiągnął swoje apogeum w finałach, gdy doszło do rewanżu przeciwko Heat LeBrona.\r\n\r\nTam San Antonio zemściło się w sposób przekonujący. Spurs mieli wynik plus-70 w tej serii, najlepszy wynik w historii finałów."

                          },

                          new HistoricalTeam {
                            TeamID = 18,
                            Name = "2012-13 Miami Heat",
                            SeasonStartDate = new DateTime(2012, 10, 30), 
                              SeasonEndDate = new DateTime(2013, 04, 17),
                            SuperStarPlayer = "Lebron James",
                            Description = "Mistrzowie NBA z sezonu 2012-13, Miami Heat, korzystając z dynamiki zdobytej podczas triumfu w 2012 roku, zdominowali sezon regularny, w którym ustanowili rekordową serię 27 zwycięstw z rzędu (druga najdłuższa w historii ligi w jednym sezonie)." +
                            "\r\n\r\nZakończyli sezon z najlepszym wynikiem w lidze - 66 zwycięstw, LeBron zdobył swoją drugą z rzędu nagrodę MVP, a Wade zajął 10. miejsce w głosowaniu na MVP." +
                            "\r\n\r\nWszystkie mankamenty wymagające wygładzenia z pierwszych paru lat ery Heat teraz były już wyeliminowane. Dodatkowo, dołączenie Raya Allena sprawiło, że drużyna stała się jeszcze bardziej płynna." +
                            "\r\n\r\nW swoim 37. sezonie Allen notował średnio 10,9 punktu i 1,8 trójki z ławki, trafiając przy tym 41,9 procent zza łuku. W finałach trafił jeden z największych i najbardziej pamiętnych rzutów w historii ligi." +
                            "\r\n\r\nW ostatnich chwilach szóstego meczu przeciwko San Antonio Spurs, Allen pędził na róg po ofensywnym zbiórce Chrisa Bosha. Odepchnął nogami tuż po złapaniu podania. Piłka wydawała się opuszczać jego ręce w tej samej chwili, co złapanie. I nie mogła lepiej przejść przez obręcz." +
                            "\r\n\r\nTrójka skutecznie przesunęła szósty mecz do dogrywki. Miami kontynuowało zwycięstwa w dogrywce i siódmym meczu, dając Heatles swoje powtórzone mistrzostwo." +
                            "\r\n\r\nOczywiście nie było to łatwe. Miami było kilkakrotnie stawiane przed szereg wyzwań i czasem nawet je przekraczano podczas tej ery. Ta konkretna drużyna zajęła 11. miejsce wśród zespołów dekady lat 2010-2019 pod względem wskaźnika netto w fazie play-off."

                          },

                           new HistoricalTeam {
                            TeamID = 12,
                            Name = "2015-16 Cleveland Cavaliers",
                            SeasonStartDate = new DateTime(2015, 10, 27), 
                               SeasonEndDate = new DateTime(2016, 06, 19),
                            SuperStarPlayer = "Lebron James",
                            Description = "Mistrzowie NBA z sezonu 2015-16, Cleveland Cavaliers, mają kilka roszczeń do sławy." +
                            "\r\n\r\nZakończyli znaczącą suszę po tytułach mistrzowskich dla miasta, która sięgała 1964 roku, kiedy Browns zdobyli mistrzostwo NFL." +
                            "\r\n\r\nDokonali historycznego powrotu w serii, mimo że przegrywali 1-3, co było jeszcze bardziej imponujące, biorąc pod uwagę, że dokonali tego przeciwko drużynie, która osiągnęła rekordową liczbę 73 zwycięstw." +
                            "\r\n\r\nDali także LeBronowi tytuł, który on i niektórzy z jego zwolenników uznają za ten, który go wywindował na szczyt debaty o najlepszego zawodnika wszech czasów (GOAT)." +
                            "\r\n\r\nW finałach LeBron prowadził Cavs pod względem wszystkich głównych statystyk, notując średnio 29,7 punktu, 11,3 zbiórki, 8,9 asysty, 2,6 przechwytu i 2,3 bloku. Jego 13,7 box plus/minus to trzeci najwyższy wynik w historii finałów." +
                            "\r\n\r\nOczywiście LeBron nie dokonał tego sam. Kyrie Irving miał wyższą średnią punktów na mecz niż którykolwiek z zawodników Warriors w serii. I to on trafił być może najważniejszy rzut w meczu nr 7." +
                            "\r\n\r\nNależy też wspomnieć o Kevinie Love'u, który był czasem zmuszany do opuszczenia parkietu przez szybką grę Golden State. Jednak jego kluczowa obrona w ostatnich chwilach rzutu Curry'ego w meczu nr 7 to jedno z trwałych wspomnień tego sezonu." +
                            "\r\n\r\nPodobnie jak każdy inny zespół na tej liście, Cavs byli o wiele więcej niż tylko swoimi gwiazdami. JR Smith, Tristan Thompson, Richard Jefferson, Iman Shumpert i Channing Frye, wszyscy wnieśli istotny wkład."

                           },

                           new HistoricalTeam {
                            TeamID = 8,
                            Name = "2007-08 Boston Celtics",
                            SeasonStartDate = new DateTime(2007, 10, 30),
                            SeasonEndDate = new DateTime(2008, 06, 17),
                            SuperStarPlayer = "Kevin Garnet",
                            Description = "Niewiele superzespołów w historii NBA zgrało się ze sobą tak płynnie jak Boston Celtics w sezonie 2007-08." +
                            "\r\n\r\nPoprzednie przedsezonowe miesiące były pełne wydarzeń dla Celtics." +
                            "\r\n\r\n28 czerwca 2007 roku Boston dokonał wymiany w trakcie draftu, wysyłając Jeffa Greena, Wally'ego Szczerbiaka, Delonte'a Westa i drugorundowego wyboru do Seattle Supersonics za Glenna Davisa i Raya Allena." +
                            " Ten ostatni po sezonie 2006-07, mając 31 lat, notował średnio 26,4 punktu i 3,0 trójki, trafiając 37,2 procent z dystansu." +
                            "\r\n\r\nAle Boston nie zatrzymał się na tym. Nieco ponad miesiąc później wymienił Ryana Gomesa, Gerlada Greena, Al'a Jeffersona, Theo Ratliffa, Sebastiana Telfaira i dwie pierwszorundowe wybory za Kevina Garnetta." +
                            " MVP sezonu 2003-04 średnio notował 22,4 punktu, 12,8 zbiórki, 4,1 asysty i 1,7 bloku w barwach Minnesota Timberwolves." +
                            "\r\n\r\n\"Nie mogłem prosić o lepszą sytuację\" - powiedział Garnett po wymianie. \"Prosiłem o doświadczonych graczy, nie spodziewałem się zdobyć siedmiokrotnego All-Stara ani dziesięciokrotnego All-Stara. To spełnienie marzeń." +
                            " Czuję się jak ponownie debiutujący zawodnik.\"\r\n\r\nDziesięciokrotnym All-Starem, o którym mówił, był oczywiście Paul Pierce, długoletni gracz Celtics, do którego Garnett i Allen dołączyli w Bostonie. " +
                            "Od samego początku wszyscy trzej zdawali się doskonale ze sobą współgrać." +
                            "\r\n\r\nW sezonie 2007-08 Boston osiągnął rekord 66-16. Spośród drużyn badanych w latach 2000-2009 w ramach tego zestawienia Celtics zajęli pierwsze miejsce pod względem prostej systemu ratingowego, wskaźnika netto i stosunku obrony, a to ostatnie kryterium naprawdę wyróżniało tę drużynę." +
                            "\r\n\r\nCi Celtics byli potęgą obronną. Jedynie drużyny z lat 1963-64 i 1964-65, Milwaukee Bucks z 2019-20 oraz San Antonio Spurs z 2003-04 miały lepsze stosunki defensywne w historii ligi." +
                            "\r\n\r\nGdy KG był na boisku, przeciwnicy Bostonu zdobywali średnio 97,6 punktu na 100 possesji, a efektywność rzutów przeciwników wynosiła 45,0 procent. Średnie ligowe w sezonie 2007-08 to odpowiednio 107,5 punktu i 49,7 procent." +
                            "\r\n\r\nWydawało się, że każda rotacja była perfekcyjnie zgrana. KG był werbalnym środkowym linebackrem, który wszystkim kierował, a wszyscy na liście zdawali się być oddani swoim zadaniom." +
                            " Leon Powe był jedynym zawodnikiem z co najmniej 500 minutami, który miał poniżej przeciętnego defensywnego box plus/minus." +
                            "\r\n\r\nZ przeciwnej strony boiska Celtics nie byli tak dominujący, ale trzej supergwiazdorzy i drugoroczny rozgrywający Rajon Rondo zrobili wystarczająco dużo, by udźwignąć ofensywę. Gdy wszyscy czterej byli na boisku, Boston zdobywał średnio 112,5 punktu na 100 possesji." +
                            "\r\n\r\nZ gwiazdorską piątką i solidną obroną Boston pohulał przez NBA, kończąc sezon mistrzostwem po zwycięstwie 4-2 nad Lakers w finałach, gdzie występowali Kobe, Pau i reszta."

                           },

                           new HistoricalTeam {
                            TeamID = 8,
                            Name = "1964-65 Boston Celtics",
                            SeasonStartDate = new DateTime(1964, 10, 16),
                            SeasonEndDate = new DateTime(1965, 04, 25),
                            SuperStarPlayer = "Bill Russel",
                            Description = "Przez ponad dekadę Bill Russell i Celtics praktycznie własnie posiadali NBA w czasach jego kształtowania się. Wygrał swoje pierwsze mistrzostwo w 1957 roku, a jedenaste w 1969 roku. Wybór jednego zespołu spośród tej grupy jest trudny." +
                            "\r\n\r\nGdybyśmy uczynili kryteria statystyczne, które już przedstawiliśmy, ostatecznym arbiterem tych rankingów, zespół z sezonu 1963-64 znalazłby się w pierwszej dziesiątce przed 1990 rokiem." +
                            "\r\n\r\nAle trzy dodatkowe zwycięstwa w sezonie regularnym, lepszy system prostego oceniania, szczytowy sezon Sama Jonesa i pokonanie potężnego występu Wilt Chamberlaina w fazie play-off dały przewagę zespołowi z 1964-65 Boston Celtics." +
                            "\r\n\r\nW tamtym sezonie Russell zdobył swoje piąte i ostatnie nagrody MVP, notując średnio 24,1 zbiórki, 14,1 punktu i 5,3 asysty. " +
                            "Jak wspomniano, Jones był równie fenomenalny. Zdobył średnio 25,9 punktu. John Havlicek dorzucił kolejne 18,3. A obsada, w skład której wchodzili Tom Heinsohn, Tom Sanders, Willie Naulls i K.C. Jones, dostarczała dużej pomocy w trakcie sezonu." +
                            "\r\n\r\nW pierwszej rundzie play-off Celtics spotkali się z Chamberlainem i Philadelphia 76ers. Legendarny wielki gracz notował średnio 31,4 zbiórki i 30,1 punktu, ale zrównoważone, drużynowe podejście Celtics doprowadziło do zwycięstwa Bostonu w siódmym meczu, który był jednym z najbardziej legendarnych momentów w historii gry." +
                            "\r\n\r\nGdy było pięć sekund do końca, a Celtics prowadzili jednym punktem, Hal Greer z Philadelphia próbował wrzucić piłkę z boku do skrzydła. Havlicek przechwycił podanie i podał piłkę do Sama Jonesa, który poprowadził ją i zużył czas." +
                            "\r\n\r\n\"Wystarczyło Havlicek ukradł piłkę!\" Johnnya Mosta pozostaje jednym z najbardziej znanych komentarzy w historii NBA." +
                            "\r\n\r\nBoston następnie zdominował finały przeciwko Los Angeles Lakers, kończąc tym samym być może najlepszy pojedynczy sezon w erze Russella dla drużyny."

                           },

                           new HistoricalTeam {
                            TeamID = 7,
                            Name = "1972-73 New York Knicks",
                            SeasonStartDate = new DateTime(1972, 10, 10),
                            SeasonEndDate = new DateTime(1973, 05, 10),
                            SuperStarPlayer = "Walt Frazier",
                            Description = "Trzy lata po pokonaniu Lakersów dla pierwszego tytułu NBA w historii organizacji, drużyna New York Knicks w sezonie 1972-73 ponownie stanęła na szczycie. W tym momencie zespół należał do Walta Fraziera." +
                            "\r\n\r\nFrazier był liderem drużyny pod względem zdobywanych punktów (21.1) i asyst (5.9), zajmując trzecie miejsce w zbiórkach (7.3) za DeBusscherem i Reedem. Był motorem napędowym zespołu, który był pełen talentu." +
                            "\r\n\r\nDeBusschere, Bradley, Jerry Lucas i Reed stanowili rotację skrzydłowych i środkowych (wszyscy ostatecznie trafili do Galerii Sław), a Earl Monroe dawał Frazierowi partnera z tylnej linii, który wcześniej udowodnił swoją wartość jako jeden z najlepszych strzelców ligi w barwach Baltimore Bullets." +
                            "\r\n\r\nMonroe przyjął mniejszą rolę w Knicks, ale nadal zdobywał średnio 15.5 punktu i miał skuteczność rzutów znacznie powyżej średniej ligowej. Dzięki tym dwóm zawodnikom atakującym z obwodu, a jednocześnie DeBusschere (16.3 punktu na mecz) i Bradley (16.1) sprawiali problemy pod koszem, Knicks mieli trzecią najlepszą ofensywę w lidze." +
                            "\r\n\r\nByli także w czołówce pod względem obrony, głównie dzięki obecności Reeda i Lucasa pod koszem, a także walecznego Phila Jacksona." +
                            "\r\n\r\nCała drużyna świetnie współpracowała w fazie play-off, pokonując Westa, Chamberlaina i Lakersów po raz drugi w finałach."

                           },

                           new HistoricalTeam {
                            TeamID = 29,
                            Name = "2010-11 Dallas Mavericks",
                            SeasonStartDate = new DateTime(2010, 10, 26),
                            SeasonEndDate = new DateTime(2011, 04, 13),
                            SuperStarPlayer = "Dirk Nowitzki",
                            Description = "Przed rozpoczęciem Finałów NBA 2011 roku 15 z 22 ekspertów przepytanych przez ESPN typowało, że LeBron James, Dwyane Wade, Chris Bosh i Miami Heat pokonają Dallas Mavericks w sezonie 2010-11." +
                            "\r\n\r\nTo nie było nic nowego dla Mavs. Ekspertom zależało w 50% na tym, czy uda im się wyjść z pierwszej rundy. I każdy z nich wybrał Los Angeles Lakers w drugiej rundzie." +
                            "\r\n\r\nW tym sezonie, Dirk Nowitzki i jego koledzy z zespołu z Dallas zaskakiwali rywali. Pomogli również ustanowić trend, który dominował przez całą dekadę." +
                            "\r\n\r\nDrużyny opierające się na rzutach za trzy mogą zdobywać tytuły.\r\n\r\nJason Kidd i Jason Terry byli pierwszymi dwoma zawodnikami pod względem liczby trafionych rzutów za trzy punkty w tych rozgrywkach. Peja Stojakovic, Deshawn Stevenson i Dirk znaleźli się w pierwszej dwunastce." +
                            "\r\n\r\nPrzestrzeń stworzona przez nowoczesną grę zespołową w ataku Dallas pozostawiała środek boiska otwarty dla rzutów Tysona Chandlera w kierunku kosza lub kliniki rzutów średniodystansowych Nowitzkiego." +
                            "\r\n\r\nW ciągu 559 minut, które dwójka ta spędziła razem w fazie play-off, Dallas miało bilans plus-minus wynoszący 12.3 punktu na 100 posiadanych piłek. Sam Nowitzki miał bilans plus-minus wynoszący 10.6 (Dallas miał minus 9.3, gdy odpoczywał)." +
                            "\r\n\r\nOstatecznie rozgrywki w 2011 roku należały do Dirka.\r\n\r\nLeBron, Wade i Bosh utworzyli Heatles poprzedniego lata. " +
                            "Byli głównym tematem całego sezonu. Potem Dirk przejął kontrolę nad narracją, zdobywając średnio 27.7 punktu, 8.1 zbiórki, 2.5 asysty i 1.1 trójki, przy skuteczności 48.5 procenta z gry i 46.0 procenta za trzy punkty w trakcie całych rozgrywek." +
                            "\r\n\r\nBył to triumf, który przyszedł po latach trudów.\r\n\r\n\"Jeśli jesteś w tej lidze przez 13 lat i zawsze walczysz w play-offach i zawsze wychodzisz na krótko, to jest naprawdę wyjątkowe\" - powiedział Nowitzki po pokonaniu Heat, zgodnie z Tomem D'Angelo z Palm Beach Post." +
                            "\r\n\r\nTen zespół Mavericks może nie być najlepszą drużyną lat 2010-2019, ale ma argument na rzecz najlepszej historii."

                            },

                            new HistoricalTeam {
                            TeamID = 13,
                            Name = "2003-04 Detroit Pistons",
                            SeasonStartDate = new DateTime(2003, 10, 28), 
                            SeasonEndDate = new DateTime(2004, 04, 14),
                            SuperStarPlayer = "Ben Wallace",
                            Description = "Drużyna Detroit Pistons z sezonu 2003-04 często jest uznawana za najlepszy przykład zespołu, który zdobył mistrzostwo bez gwiazdy, ale przyjrzyjmy się tej koncepcji trochę dokładniej." +
                            "\r\n\r\nOczywiście nie mieli nikogo na poziomie Kobe Bryanta, Shaquille'a O'Neala czy Tima Duncana, ale kilku zawodników Pistons grało na poziomie gwiazdorskim (nawet jeśli tylko jeden, Ben Wallace, został wybrany do All-Star)." +
                            "\r\n\r\nChauncey Billups, Ben Wallace i Rasheed Wallace zakończyli sezon 2003-04 odpowiednio na 16., 21. i 47. miejscu w BPM. Tayshaun Prince i Richard Hamilton znaleźli się również w pierwszej setce." +
                            "\r\n\r\nJednak jest powód, dla którego o drużynie mówi się tak, jak mówi. W pełni uosabiała koncepcję \"więcej niż suma jej części\"." +
                            "\r\n\r\nPrzez 523 minuty fazy play-off, w których Billups, Hamilton, Prince i obaj Wallace dzielili boisko, Detroit miało imponujący bilans plus-minus wynoszący 14.6 punktu na 100 posiadanych piłek. Przeciwko samym Los Angeles Lakers, ten pięcioosobowy skład miał bilans plus-41 przy 121 minutach w Finale." +
                            "\r\n\r\nPistons zdominowali zespół, który obejmował wielu legendarnych graczy.\r\n\r\n\"Miałeśmy zespół i graliśmy jako jedność\" - powiedział Ben Wallace dla ABC Mike'a Lacetta. \"Gdy się zjednoczyliśmy i wszyscy odegraliśmy swoją rolę, to było jak idealna piosenka i taniec\"."

                            },

                           new HistoricalTeam {
                            TeamID = 10,
                            Name = "2018-19 Toronto Raptors",
                            SeasonStartDate = new DateTime(2018, 10, 16),
                            SeasonEndDate = new DateTime(2019, 04, 10),
                            SuperStarPlayer = "Kawhi Leonard",
                            Description = "W przyszłości zdanie \"Ale Kevin Durant i Klay Thompson nie grali...\" może stać się powszechnym powiedzeniem, gdy ludzie będą rozmawiać o Toronto Raptors z sezonu 2018-19." +
                            "\r\n\r\nJednak ta drużyna zasługuje na uznanie nie tylko za zakończenie ery Kevina Duranta w Golden State, ale także za to, co osiągnęła przez cały sezon." +
                            "\r\n\r\nW poprzednim okresie międzysezonowym Raptors wymienili DeMar DeRozana i Jakoba Poeltla do San Antonio Spurs na Kawhiego Leonarda i Danny'ego Greena. Ten ruch natychmiast wprowadził ich do grona pretendentów do tytułu." +
                            "\r\n\r\nChociaż Leonard miał około jednej czwartej sezonu przerwy z powodu \"zarządzania obciążeniem\", zajął dziewiąte miejsce w głosowaniu na MVP. A gdy dzielił boisko z Greenem i Kyle'em Lowrym, Toronto miało wynik plus-14.0 punktu na 100 posiadanych piłek (98. percentyl)." +
                            "\r\n\r\nRaptors prezentowali koszykówkę na poziomie mistrzowskim przez cały sezon 2018-19, a ich supergwiazda wzmocniła swoją grę w fazie play-off." +
                            "\r\n\r\nLeonard średnio zdobywał 30.5 punktu, 9.1 zbiórki, 3.9 asysty, 2.3 trójki i 1.7 przechwytu na mecz w fazie play-off. Miał 61.9-procentową skuteczność rzutów, a łączna wartość 7.8 zwycięstw nad graczem zastępczym (wartość nad graczem zastępczym pomnożona przez 2.7)." +
                            "\r\n\r\nLeBron James (trzy razy), Larry Bird i Tim Duncan to jedyni gracze w historii ligi, którzy zgromadzili więcej zwycięstw nad graczem zastępczym w jednych rozgrywkach play-off." +
                            "\r\n\r\nPrzez całą drogę do tytułu towarzyszyło Kawhiemu uczucie nieuchronności. Każda penetracja i rzucony jumper zdawały się być przeznaczone do dolnej siatki. Jego brutalna obrona przyczyniła się częściowo do ogromnego skoku w play-off w net ratingu wynoszącego plus-15.9." +
                            "\r\n\r\nZimna, wyważona dominacja doprowadziła po sezonie do określenia go mianem Terminatora.\r\n\r\n\"Wygląda na robota stworzonego do zniszczenia NBA\" - napisali Ben Cohen i Andrew Beaton dla Wall Street Journal. \"Jeden trener kiedyś spekulował, że krwawi płynem chłodniczym." +
                            "\"\r\n\r\nSezon 2018-19 niewiele zrobił, aby temu zaprzeczyć."

                           },

                           new HistoricalTeam {
                            TeamID = 24,
                            Name = "1976-77 Portland Trail Blazers",
                            SeasonStartDate = new DateTime(1976, 10, 21),
                            SeasonEndDate = new DateTime(1977, 06, 05),
                            SuperStarPlayer = "Bill Walton",
                            Description = "Drużyna Portland Trail Blazers z sezonu 1976-77 to bardziej baśniowa opowieść niż mistrzowski zespół NBA." +
                            "\r\n\r\nIch najlepszy zawodnik, członek Galerii Sław Bill Walton, był pionierem ofensywy dla dzisiejszych środkowych, ale jego wpływ na obronę mógł być jeszcze większy. W Portland robił wiele szkód, prezentując zarazem brodę, rudą czuprynę i otwarte poglądy polityczne, charakterystyczne dla lat 70." +
                            "\r\n\r\nJednak nic nie przemawiało głośniej niż jego gra.\r\n\r\n\"Jeśli porozmawiasz z ludźmi, którzy są wokół ligi\", powiedział w 2017 roku długoletni komentator play-by-play w Portland, Bill Schonely, \"powiedzą ci, że gdyby Bill Walton pozostał zdrowy przez dłuższy czas, mógłby zostać uznany za najlepszego środkowego wszech czasów\"." +
                            "\r\n\r\nW sezonie 1976-77 Walton zdobywał średnio 18,6 punktu, 14,4 zbiórki, 3,8 asysty, 3,2 bloku i 1,0 przechwytu. Był drugi tylko za Kareemem Abdul-Jabbarem i Bobbym Jonesem pod względem box plus/minus. Zachował swoją dominującą formę przez całe rozgrywki play-off." +
                            "\r\n\r\nW rzeczywistości jego średnia dla asyst wzrosła do 5,5 w fazie play-off. W finałach z 1977 roku przeciwko Juliusowi Ervingowi i Philadelphia 76ers, zaprezentował absurdalne statystyki - 18,5 punktu, 19,0 zbiórki, 5,2 asysty, 3,7 bloku i 1,0 przechwytu, zdobywając tytuł MVP Finałów." +
                            "\r\n\r\nTo nie była jednak gra jednego zawodnika. Ośmiu zawodników Blazers miało średnią co najmniej 8,0 punktu na mecz w tamtym sezonie. " +
                            "Siedmiu miało co najmniej 2,0 asysty. Maurice Lucas i Lionel Hollins byli wielokrotnie wybieranymi obrońcami zespołu. Walton był zdecydowanie główną gwiazdą, ale to była zrównoważona drużyna z obroną, która zatrzymała rywali przez całe play-off."

                           },

                           new HistoricalTeam {
                            TeamID = 33,
                            Name = "2006-07 San Antonio Spurs",
                            SeasonStartDate = new DateTime(2006, 10, 31), 
                            SeasonEndDate = new DateTime(2007, 06, 14),
                            SuperStarPlayer = "Tim Duncan",
                            Description = "Sezon 2006-07 San Antonio Spurs to czas legendarnego trójki - Tim Duncan, Manu Ginobili i Tony Parker - którzy byli blisko szczytu swoich umiejętności." +
                            "\r\n\r\nDuncan notował średnio 20,0 punktu, 10,6 zbiórki, 3,4 asysty i 2,4 bloku. Tony Parker dodawał 18,6 punktu i 5,5 asysty na mecz, a Manu Ginobili z ławki oferował 16,5 punktu, 4,4 zbiórki, 3,5 asysty i 1,7 trafienia za trzy punkty, jednocześnie prowadząc drużynę w statystyce BPM." +
                            "\r\n\r\nCałkiem jak w sztuce Jedi, zachowywana była równowaga między tymi trójką przez cały sezon i w czasie playoffów. W ciągu wszystkich minut sezonu regularnego i fazy play-off, San Antonio miało różnicę plus-13,8 punktu na 100 posiadanych piłką, gdy wszyscy trzej gracze byli na boisku." +
                            "\r\n\r\nAle, zgodnie z typowym stylem zespołów prowadzonych przez Gregga Popovicha, gwiazdy miały również wsparcie zespołu.\r\n\r\nBruce Bowen został wybrany do drużyny All-Defensive i trafił 38,4 procent zza linii trzech. Michael Finley zdobywał średnio 9,0 punktu z ławki. Brent Barry miał sezon strzelecki na miarę legendy." +
                            "\r\n\r\nSpośród 1 294 sezonów indywidualnych, w których zawodnik oddał co najmniej tyle samo rzutów za trzy punkty co Barry (287), skuteczność jego rzutów wynosząca 62,6 procent jest siódmą najlepszą wszech czasów." +
                            "\r\n\r\nDzięki zgraniu trójki gwiazd i wsparciu od zawodników pełniących role, Spurs z łatwością osiągnęli rekord 16-4 w fazie play-off (w tym zmiatanie w finałach)." +
                            "\r\n\r\nAle, podobnie jak w przypadku Lakers w sezonie 2001-02, ta kampania nie była tak łatwa, jak wynik sugeruje." +
                            "\r\n\r\nW meczu 4 drugiej rundy przeciwko Phoenix Suns, Robert Horry uderzył Steve'a Nasha \"hokejowym\" checkiem, co skłoniło Amar'e Stoudemire'a i Borisa Diawa do obrony swojego rozgrywającego, co oznaczało zawieszenie ich w meczu nr 5. Spurs wygrali dwie ostatnie gry tej serii, a następnie pewnie przeszli przez resztę play-offów."

                           },

                           new HistoricalTeam {
                            TeamID = 6,
                            Name = "2008-09 Los Angeles Lakers",
                            SeasonStartDate = new DateTime(2008, 10, 28),
                            SeasonEndDate = new DateTime(2009, 06, 14),
                            SuperStarPlayer = "Kobe Bryant",
                            Description = "Kobe i jego 5.9 BPM w tym sezonie było lepsze niż cokolwiek, co osiągnął podczas trzech tytułów z rzędu, a jego skuteczność rzutów za trzy punkty wynosząca 50.2 procent była trzecią najwyższą w karierze (ledwie ustępując kampaniom z 2012-13 i 2007-08)." +
                            "\r\n\r\nW fazie play-off Kobe był jeszcze lepszy. Tak naprawdę, play-offy w 2009 roku mogą być uważane za najlepszy okres w jego karierze." +
                            "\r\n\r\nOsiągnął rekordy kariery w ofensywnym i defensywnym box plus/minus oraz odsetku strat dzięki średnim 30,2 punktu, 5,5 asyst, 5,3 zbiórek, 2,6 straty i 1,7 przechwytu. " +
                            "W trakcie tych play-offów, L.A. miała różnicę plus-9,7 punktu na 100 posiadanych piłką, gdy Kobe był na boisku, i minus-2,7, gdy go zabrakło." +
                            "\r\n\r\nAle ta drużyna to było coś więcej niż tylko Kobe w swoim prime. Z Pau Gasolem, Trevor'em Arizą, Lamarem Odomem, Andrew Bynumem, Derek'em Fisherem i innymi, była może głębsza niż którakolwiek z drużyn Lakersów, która zdobyła trzy tytuły z rzędu. " +
                            "W drużynie z 2008-09 było ośmiu graczy z ponad 500 minutami i dodatnim BPM. L.A. miała średnio sześciu takich graczy od 1999-00 do 2001-02." +
                            "\r\n\r\nNa mniej matematycznym poziomie warto zauważyć, jak dobrzy byli Odom i Ariza w tamtym okresie. Oboje mieli umiejętności, które były przed swoim czasem. " +
                            "Odom był czwórką, która potrafiła kreować grę i dominować na tablicy, a Ariza był uniwersalnym skrzydłowym zdolnym do obrony i rzutów za trzy punkty, na które drużyny zawsze polują." +
                            "\r\n\r\nAktualne wkłady innych graczy, których z pewnością pamiętasz, jak Sasha Vujacic i Jordan Farmar, pomogły gwiazdom na szczycie tego składu przejść przez stosunkowo komfortowy sezon play-off. " +
                            "W drugiej rundzie stanęli przed decydującym meczem, ale ich wskaźnik netto w play-offach wynoszący 7,9 to trzeci najlepszy wynik spośród zespołów z lat 1999-2000 do 2008-09."

                           },

                           new HistoricalTeam {
                            TeamID = 26,
                            Name = "2017-18 Golden State Warriors",
                            SeasonStartDate = new DateTime(2017, 10, 17), 
                            SeasonEndDate = new DateTime(2018, 06, 17),
                            SuperStarPlayer = "Kevin Durant",
                            Description = "Golden State Warriors z sezonu 2017-18 znajdowali się głęboko w okresie regularnego sezonu, który można określić jako swego rodzaju mini-dynastię. " +
                            "Zakończyli ten sezon na trzecim miejscu w systemie prostego ratingu, ustępując Houston Rockets i Toronto Raptors." +"\r\n\r\nRakiety prowadzone przez Chrisa Paula i Jamesa Hardena stanowiły poważne zagrożenie dla obrońców tytułu podczas Konferencyjnych Finałów Zachodnich. Gdyby CP3 nie doznał kontuzji w piątym meczu tej serii, być może nie rozmawialibyśmy teraz o Warriors z sezonu 2017-18." +
                            "\r\n\r\nJednak w pozostałych trzech seriach tych play-offów Warriors byli absolutnie dominujący. Golden State zanotowało bilans 12-2 w starciach z San Antonio Spurs, New Orleans Pelicans i Cleveland Cavaliers, w tym zwycięstwo 4-0 w Finałach przeciwko Cavaliers. " +
                            "Ostatecznie ta drużyna Warriors miała drugi najlepszy wskaźnik netto w fazie play-off spośród wszystkich drużyn lat 2010." +
                            "\r\n\r\nTo był również sezon, który mógł przyczynić się do powszechniejszych opinii, że \"KD przewyższył LeBrona\". " +
                            "Był to drugi z rzędu rok, w którym Durant zdołał prześcignąć LeBrona w finałach. Dodatkowo zdobył tytuł MVP Finałów po obu tych seriach. Jego wskaźnik box plus/minus wynoszący 12,7 w tych dziewięciu grach był wyższy niż 11,8 LeBrona."

                           },

                            new HistoricalTeam {
                            TeamID = 31,
                            Name = "1993-94 Houston Rockets",
                            SeasonStartDate = new DateTime(1993, 11, 05),
                            SeasonEndDate = new DateTime(1994, 06, 22),
                            SuperStarPlayer = "Hakeem Olajuwon",
                            Description = "Drużyna Houston Rockets z sezonu 1993-94 zajmuje szczególne miejsce w historii NBA, ponieważ przerwała niezdobytą dotąd dominację Michaela Jordana. " +
                            "W tym sezonie, gdy Jordan zaskakująco zdecydował się na przerwę od koszykówki, Hakeem Olajuwon stanął na czele swojego zespołu, zdobywając nie tylko tytuł MVP ligi, ale przede wszystkim poprowadzając Rockets do triumfu w NBA. " +
                            "Olajuwon prezentował jedno z najlepszych osiągnięć w swojej karierze, a jego zdolności zarówno w ataku, jak i obronie, uczyniły go niekwestionowanym liderem. " +
                            "Mimo że liga była pozbawiona Jordana, to zwycięstwo Rockets w tym sezonie nie traci na swojej wartości, ukazując, że potęga Jordanowskiej ery nie była absolutnie nieprzezwyciężona." +
                            "\r\n\r\nTa konkretna drużyna Houston była świadkiem jedynego sezonu, w którym Olajuwon zdobył tytuł MVP, a także drugiego najlepszego sezonu pod względem indywidualnego wskaźnika box plus/minus. Averages to 41,0 minut, 27,3 punktów, 11,9 zbiórek, 3,6 asyst, 3,7 bloków i 1,6 przechwytów." +
                            "\r\n\r\nNastępnie w playoffach Olajuwon stał się jeszcze lepszy, notując średnio 28,9 punktów, 11,0 zbiórek, 4,3 asyst, 4,0 bloków i 1,7 przechwytów na mecz przez 43,0 minuty.\r\n\r\nZ Michaelem Jordanem zajętym grą w baseballu liga nagle stała się królestwem The Dream." +
                            "\r\n\r\n\"To żart, jak dobry jest\", powiedział prezydent Indiana Pacers, Donnie Walsh, przed finałami z 1994 roku. \"To najlepszy zawodnik ligi, i nie ma nic, co można z nim zrobić\".\r\n\r\nZ Jordanem poza grą, to było trudne uczucie do zakwestionowania, zwłaszcza po zdobyciu przez Rockets mistrzostwa w 1994 roku." +
                            "\r\n\r\nTo jednak nie była całkowicie solowa akcja. Houston otrzymał także solidne wkłady młodego Roberta Horry'ego, Otisa Thorpe'a, Kenny'ego Smitha, Vernona Maxwella, Mario Elie i Sama Cassella w tamtym sezonie." +
                            "\r\n\r\nI, jak to bywa w przypadku współczesnych Rockets, byli przed kursem analitycznym, prowadząc NBA w liczbie prób rzutów za trzy punkty na 100 posiadaniach." +
                            "\r\n\r\nAtak nie był tak bardzo zdominowany przez rzuty za trzy, jak dzisiejsze zespoły, ale filozofia otaczania dominującego gracza rzucającymi wciąż pozostaje aktualna."

                            },

                            new HistoricalTeam {
                            TeamID = 15,
                            Name = "1970-71 Milwaukee Bucks",
                            SeasonStartDate = new DateTime(1970, 10, 13),
                            SeasonEndDate = new DateTime(1971, 04, 30),
                            SuperStarPlayer = "Kareem Abdul-Jabbar",
                            Description = "Zbyt często debata o największym koszykarzu wszech czasów w NBA ogranicza się jedynie do Michaela Jordana i LeBrona Jamesa." +
                            "\r\n\r\n\"Może nie umieścisz go na szczycie swojej listy\", napisał William C. Rhoden dla The Undefeated. \"...ale jeśli Abdul-Jabbar nie jest częścią tej dyskusji, to prowadzisz niewłaściwą rozmowę." +
                            "\"\r\n\r\nJako członek Milwaukee Bucks z sezonu 1970-71, w zaledwie swoim drugim sezonie NBA, Kareem zdobył swój pierwszy z sześciu tytułów i pierwszą z sześciu nagród MVP. Z średnimi 31,7 punktu, 16,0 zbiórki i 3,3 asysty było jasne, że ten wielki człowiek na długo zagości w gronie wielkich postaci NBA." +
                            "\r\n\r\nMiał jednak mnóstwo pomocy w tej kampanii. Choć Robertson był już daleko po swoim zenicie, to nadal notował średnio 19,4 punktu, 8,2 asysty i 5,7 zbiórki." +
                            "\r\n\r\nBob Dandridge, który później został czterokrotnym uczestnikiem meczu gwiazd, jednokrotnie znalazł się w All-NBA Team i jednokrotnie w All-Defensive Team, dodawał 18,4 punktu, 8,0 zbiórki i 3,5 asysty." +
                            "\r\n\r\nJon McGlocklin i Greg Smith obaj średnio osiągali wynik dwucyfrowy.\r\n\r\nPod wodzą Kareema ci Bucks osiągnęli najlepszy w historii jednosezonowy prosty system oceny. Zanotowali bilans 12-2 i pokonali rywali różnicą 10,8 punktu na 100 possesji w fazie play-off." +
                            "\r\n\r\nOd początku do końca to było kompletnie i absolutnie dominujące widowisko drużynowe."

                            },

                            new HistoricalTeam {
                            TeamID = 25,
                            Name = "1996-97 Utah Jazz",
                            SeasonStartDate = new DateTime(1996, 11, 01),
                            SeasonEndDate = new DateTime(1997, 06, 13),
                            SuperStarPlayer = "Karl Malone",
                            Description = "\r\nDrużyna Utah Jazz z sezonu 1996-97 była potęgą, która przypadkowo osiągnęła swój szczyt w trakcie drugiego trzykrotnego zwycięstwa Michaela Jordana." +
                            "\r\n\r\nKarl Malone zdobył tytuł MVP tego sezonu, notując średnie 27,4 punktu, 9,9 zbiórki, 4,5 asysty i 1,4 przechwytu. Jazz, którzy osiągnęli bilans 64-18, mieli wynik plus-11,7 punktu na 100 posiadanych piłek, gdy Malone był na boisku, a minus-10,2, gdy go nie było." +
                            "\r\n\r\nJohn Stockton był już kilka lat po swoim zenicie, ale wciąż miał duży wpływ. Jego 14,4 punktu i 10,5 asysty dały mu dziesiąty z rzędu sezon z przeciętną double-double (notował 15,6 punktu, 12,8 asysty i 2,6 przechwytu w tym dziesięcioletnim okresie)." +
                            "\r\n\r\nJeff Hornacek (14,5 punktu i 4,4 asysty przy 59,6-procentowej skuteczności rzutów) oraz Bryon Russell (10,8 punktu przy 60,0-procentowej skuteczności rzutów) również stanowili solidne wsparcie." +
                            " Zajmowali odpowiednio 22. i 48. miejsce w box plus/minus w tym sezonie, co dawało Utah czterech graczy w pierwszej pięćdziesiątce (Malone i Stockton zajmowali trzecie i piąte miejsce)." +
                            "\r\n\r\nAle po stosunkowo bezbolesnym przejściu przez pierwsze trzy rundy play-offów z wynikiem 11-3, Utah stanęła naprzeciwko Jordana, Pippena, Dennisa Rodmana i aktualnych mistrzów - Bulls." +
                            "\r\n\r\nChicago wygrało serię w sześciu meczach, ale Jazz przegrali tylko cztery punkty ogółem."

                            }




                    };
                    _dbContext.HistoricalTeams.AddRange(historicalteamsData);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
