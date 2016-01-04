using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LazyLoading.Ghost
{
    public class Blog : DomainObject
    {
        public int ID { get; set; }

        public string Title
        {
            get
            {
                Load();
                return title;
            }
        }

        public List<Post> Posts
        {
            get
            {
                Load();
                return posts;
            }
        }

        private string title;

        private List<Post> posts;

        public Blog(int id)
        {
            ID = id;
            Status = LoadStatus.Ghost;
        }

        protected override void Load()
        {
            if (IsGhost)
            {
                Status = LoadStatus.Loading;

                Console.WriteLine("Lazy loading the Blog (ghost) object with ID: {0}.", ID);
                Thread.Sleep(3000);

                title = "Lazy loading";
                posts = new List<Post>();
                posts.Add(new Post(2));
                posts.Add(new Post(4));

                Status = LoadStatus.Loaded;
            }
        }
    }
}
