using BenchmarkDotNet.Running;
using System;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace LinqDemo
{    
    class Program
    {        
        static async Task Main(string[] args)
        {
            using HttpClient client = new HttpClient();

            var users = await GetData<User>(client, "users");
            var posts = await GetData<Post>(client, "posts");
            var comments = await GetData<Comment>(client, "comments");
            var albums = await GetData<Album>(client, "albums");
            var photos = await GetData<Photo>(client, "photos");
            var todos = await GetData<Todo>(client, "todos");

            
            //RunBasicExamples(users, posts, comments, todos,albums,photos);


            AdditionalLinqExamples(users, posts, comments, todos,albums,photos);
        }

        static void RunBasicExamples(
            List<User> users,
            List<Post> posts,
            List<Comment> comments,
            List<Todo> todos,
            List<Album> albums,
            List<Photo> photos)
        {
            //Kullanıcı Analizleri
            //-->En çok post atan 3 kullanıcı
            //var topPosters= users
            //    .Join(posts,
            //    user=>user.Id,
            //    post=>post.UserId,
            //    (user,post)=>new {user.Name,post.Id})
            //    .GroupBy(x=>x.Name)
            //    .Select(g=>new {User=g.Key,PostCount=g.Count()})
            //    .OrderByDescending(x=>x.PostCount)
            //    .Take(3);

            //Console.WriteLine("En çok post atan kullanıcılar:");
            //foreach (var item in topPosters)
            //{
            //    Console.WriteLine($"{item.User}: {item.PostCount} post");
            //}

            //Post-Yorum İlişkisi
            //-->Her post için yorum sayısı (En çok yorum alan 5 post)
            //var postComments = posts
            //    .GroupJoin(comments,
            //    post => post.Id,
            //    comment => comment.PostId,
            //    (post, commentList) => new
            //    {
            //        PostTitle = post.Title,
            //        CommentCount = commentList.Count()
            //    })
            //    .OrderByDescending(x => x.CommentCount)
            //    .Take(5);
            //Console.WriteLine("En çok yorum alan postlar:");
            //foreach (var item in postComments)
            //{
            //    Console.WriteLine($"{item.PostTitle}: {item.CommentCount} comment");
            //}

            //Albüm-Fotoğraf Analizi
            //-->Kullanıcı başına fotoğraf sayısı
            //var userPhotos = users
            //    .Join(albums,
            //    user => user.Id,
            //    album => album.UserId,
            //    (user, album) => new { user.Name, album.Id })
            //    .Join(photos,
            //    temp => temp.Id,
            //    photo => photo.AlbumId,
            //    (temp, photo) => new { temp.Name })
            //    .GroupBy(x => x.Name)
            //    .Select(g => new { User = g.Key, PhotoCount = g.Count() });
            //Console.WriteLine("Kullanıcı fotoğraf sayıları:");
            //foreach (var item in userPhotos)
            //{
            //    Console.WriteLine($"{item.User}: {item.PhotoCount} fotoğraf");
            //}

            //Todo Analizi
            //-->Tamamlanmamış görevlerin kullanıcı dağılımı
            //var incompleteTodos = todos
            //    .Where(t => !t.Completed)
            //    .Join(users,
            //    todo => todo.UserId,
            //    user => user.Id,
            //    (todo, user) => new { user.Name, todo.Title })
            //    .GroupBy(x => x.Name)
            //    .Select(g => new { User = g.Key, TaskCount = g.Count() });
            //Console.WriteLine("Tamamlanmamış görevler:");
            //foreach (var item in incompleteTodos)
            //{
            //    Console.WriteLine($"{item.User}: {item.TaskCount} task");
            //}

            //Coğrafi Analiz
            //-->Aynı şehirde yaşayan kullanıcı grupları
            //var usersByCity = users
            //    .Where(u=>!string.IsNullOrEmpty(u.Address?.City))
            //    .GroupBy(u => u.Address.City)
            //    .Select(g => new { City = g.Key, Users = g.Select(u => u.Name) });
            //Console.WriteLine("Şehirlere göre kullanıcı dağılımı:");
            //foreach (var item in usersByCity)
            //{
            //    Console.WriteLine($"{item.City}: {string.Join(",",item.Users)}");
            //}

        }

        static void AdditionalLinqExamples(
            List<User> users,
            List<Post> posts,
            List<Comment> comments,
            List<Todo> todos,
            List<Album> albums,
            List<Photo> photos)
        {
            //1.Select-Veri Projeksiyonu
            //var userSummaries = users
            //    .Select(u => new
            //    {
            //        u.Id,
            //        ShortName=u.Name.Substring(0,3).ToUpper(),
            //        City=u.Address?.City??"Bilinmiyor"
            //    });

            //Console.WriteLine("Kullanıcı Özetleri:");
            //foreach (var userSummary in userSummaries)
            //{
            //    Console.WriteLine($"{userSummary.ShortName} ({userSummary.City})");
            //}

            //2.OrderBy/ThenBy-Çoklu Sıralama
            //var sortedPosts = posts
            //    .OrderBy(p => p.UserId)
            //    .ThenByDescending(p => p.Title.Length);

            //Console.WriteLine("Sıralanmış Postlar:");
            //foreach (var post in sortedPosts)
            //{
            //    Console.WriteLine($"{post.UserId} ({post.Title})");
            //}

            //3.Count-Koşullu Sayım
            //var criticalComments = comments
            //    .Count(c => c.Body.Contains("occaecati"));

            //Console.WriteLine($"Kritik Yorum Sayısı:{ criticalComments}");

            //4.Take/Skip-Sayfalama
            //var secondPage = posts
            //    .OrderBy(x => x.Id)
            //    .Skip(5)
            //    .Take(5);
            //Console.WriteLine("2. Sayfa Postları:");
            //foreach (var post in secondPage)
            //{
            //    Console.WriteLine($"{post.Id}");
            //}

            //5.Any/All-Varoluş Kontrolü
            //var hasIncompleteTasks = users
            //    .Any(u => todos
            //        .Where(t => t.UserId == u.Id)
            //        .All(t => !t.Completed));

            //Console.WriteLine($"Tüm görevleri tamamlanmamış olan kullanıcı var mı? {hasIncompleteTasks}");

            //6.FirstOrDefault - Güvenli Erişim
            //var firstSpecialPost = posts
            //    .FirstOrDefault(p => p.Title.StartsWith("A") && p.Body.Length > 200);

            //Console.WriteLine(firstSpecialPost?.Title??"Bulunamadı");

            //7.Distinct - Benzersiz Değerler
            //var uniqueZipCodes = users
            //    .Select(u => u.Address?.Zipcode?.Split("-").FirstOrDefault())
            //    .Distinct()
            //    .Where(z => !string.IsNullOrEmpty(z));

            //Console.WriteLine("Benzersiz Posta Kodları:");
            //foreach (var zip in uniqueZipCodes)
            //{
            //    Console.WriteLine(zip);
            //}

            //8.Group - Özel Gruplama
            //var postsByLength = posts
            //    .GroupBy(p => p.Body.Length / 100)
            //    .Select(g => new
            //    {
            //        LengthCategory = $"{g.Key * 100}-{(g.Key + 1) * 100} karakter",
            //        Count = g.Count()
            //    });

            //Console.WriteLine("Post Uzunluk Dağılımı");
            //foreach (var item in postsByLength)
            //{
            //    Console.WriteLine($"{item.LengthCategory}: {item.Count} post");
            //}

            //9.Aggregate - Toplamsal İşlemler
            //var longestEmail = users
            //    .Select(u => u.Email)
            //    .Aggregate("", (max, current) =>
            //    current.Length > max.Length ? current : max);

            //Console.WriteLine($"En Uzun E-posta: {longestEmail}");

            //10.SelectMany - İç İçe Koleksiyonlar
            //var allPhotoUrls = users
            //    .Join(albums,
            //    u => u.Id,
            //    a => a.UserId,
            //    (u, a) => new { u.Name, AlbumId = a.Id })
            //    .Join(photos,
            //    temp => temp.AlbumId,
            //    p => p.AlbumId,
            //    (temp, p) => new { temp.Name, p.Url });

            //Console.WriteLine("Kullanıcıların Fotoğraf URl'leri:");
            //foreach (var item in allPhotoUrls)
            //{
            //    Console.WriteLine($"{item.Name}: {item.Url}");
            //}
        }

        static async Task<List<T>> GetData<T>(HttpClient client, string endpoint)
        {
            var response = await client.GetAsync($"https://jsonplaceholder.typicode.com/{endpoint}");
            response.EnsureSuccessStatusCode();
            return JsonSerializer.Deserialize<List<T>>(
                await response.Content.ReadAsStringAsync(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }      
    }
}