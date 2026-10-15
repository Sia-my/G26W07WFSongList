using Microsoft.EntityFrameworkCore;

namespace G26W07WFSongList
{

    public record Song(int Id, string Title, string Artist, int Rating)
    {
        public override string ToString() => $"{Title} - [{Artist}] (⭐{Rating})";
    }

    public class AppDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // songs.db 파일로 저장
            optionsBuilder.UseSqlite("Data Source=songs.db");
        }
    }


    public partial class Form1 : Form
    {
        //private List<Song> _songs = [];
        private AppDbContext _db = new AppDbContext();

        public Form1()
        {
            InitializeComponent();

            _db.Database.EnsureCreated();

            // Songs 테이블이 비어있으면 초기 데이터 추가
            if (!_db.Songs.Any())
            {
                List<Song> initialSongs = [
                    new(1, "Blue Hour", "LUNA8", 5),
                    new(2, "도깨비불 (Ghostfire)", "X-CROSS", 4),
                    new(3, "Spicy Love", "Cherry Bomb", 5),
                    new(4, "신기루 (Mirage)", "ONE-WAY", 3),
                    new(5, "Hypnotized", "NEXUS", 4),
                    new(6, "첫사랑 법칙 (First Love Rule)", "Pureum", 5),
                    new(7, "Black Out", "Viper", 4),
                    new(8, "한여름 밤의 꿈 (Midsummer)", "SOLO", 5),
                    new(9, "Cyberpunk", "GLITCH", 4),
                    new(10, "별자리 (Constellation)", "Aura", 3),
                    new(11, "Bad Boy, Good Girl", "TRIGGER", 5),
                    new(12, "소리쳐 (Shout Out)", "ZEAL", 4),
                    new(13, "Velvet Dress", "Siren", 5),
                    new(14, "그림자놀이 (Shadow)", "ECLIPSE", 4),
                    new(15, "Neon City", "Beat Runners", 3),
                    new(16, "비밀정원 (Secret)", "Fairy Tale", 5),
                    new(17, "Crash Landing", "Sledge", 4),
                    new(18, "눈이 부시게 (Blinding)", "DAWN", 5),
                    new(19, "Wildfire", "ASHE", 4),
                    new(20, "시간을 달려서 (Time Warp)", "Nova", 4)
                ];

                _db.Songs.AddRange(initialSongs);
                _db.SaveChanges();
            }

            var filteredSongs = _db.Songs
                .Where(s => s.Rating >= 4)
                .OrderByDescending(s => s.Rating);

            foreach (var song in filteredSongs)
            {
                listSong.Items.Add(song);
            }
        }
    }
}
