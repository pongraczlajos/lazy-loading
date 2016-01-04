using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LazyLoading.Ghost
{
    public class Post : DomainObject
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

        private string title;

        public Post(int id)
        {
            ID = id;
            Status = LoadStatus.Ghost;
        }

        protected override void Load()
        {
            if (IsGhost)
            {
                Status = LoadStatus.Loading;

                Console.WriteLine("Lazy loading the Post (ghost) object with ID: {0}.", ID);
                Thread.Sleep(3000);

                title = "Post title for " + ID;

                Status = LoadStatus.Loaded;
            }
        }
    }
}
