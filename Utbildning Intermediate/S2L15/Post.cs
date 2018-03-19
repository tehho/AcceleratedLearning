using System;


namespace S2L15
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Posted { get; private set; }
        public string PostedBy { get; private set; }
        public int Counter { get; private set; }

        public Post()
        {
            this.Title = "";
            this.Description = "";
            this.PostedBy = "";
            this.Counter = 0;
        }

        public void VoteUp()
        {
            Counter++;
        }
        public void VoteDown()
        {
            Counter--;
        }

        public void Present()
        {
            Console.WriteLine(this.Title);
            Console.WriteLine(this.Description);
            Console.WriteLine("This post was posted by: {0} on {1}", this.PostedBy, this.Posted);
            if (this.Counter > 0)
            {
                Console.WriteLine("It has {0} likes.", this.Counter);
            }
            else if (this.Counter < 0)
            {
                Console.WriteLine("It has {0} dislikes.", abs(this.Counter));
            }
        }

        int abs(int input)
        {
            if (input < 0)
                return input * -1;
            return input;
        }

        static public Post Create(string title, string desc, string postedBy)
        {
            return new Post
            {
                Title = title,
                Description = desc,
                Posted = DateTime.Now,
                PostedBy = postedBy
            };
        }
    }
}
