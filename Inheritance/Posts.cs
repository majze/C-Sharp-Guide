using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Objects
{
    class Post
    {
        private static int postID;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string FromUser { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "General Post Title";
            IsPublic = true;
            FromUser = "Anon";
        }

        public Post(string title, bool isPublic, string fromUser)
        {
            this.ID = 0;
            this.Title = title;
            this.FromUser = fromUser;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++postID;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.FromUser);
        }
    }

    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }
        public ImagePost(string title, string fromUser, string url, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.FromUser = fromUser;
            this.IsPublic = isPublic;
            this.ImageURL = url;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - ({2}) by {3}", this.ID, this.Title, this.ImageURL, this.FromUser);
        }
    }

    class VideoPost : Post
    {
        // fields
        protected bool isPlaying = false;
        protected int position = 0;
        Timer timer;

        // properties
        protected string VideoURL { set; get; }
        protected double Length { set; get; }

        public VideoPost() { }
        public VideoPost(string title, string fromUser, string url, bool isPublic, int length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.FromUser = fromUser;
            this.IsPublic = isPublic;
            this.VideoURL = url;
            this.Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing video of length {0}", Length);
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object obj)
        {
            if (position < Length)
            {
                position++;
                Console.WriteLine("Video at {0}s", position);
                GC.Collect();
            } else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}", position);
                timer.Dispose();
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - ({2}) [{3}]s by {4}", this.ID, this.Title, this.VideoURL, this.Length, this.FromUser);
        }
    }
}
