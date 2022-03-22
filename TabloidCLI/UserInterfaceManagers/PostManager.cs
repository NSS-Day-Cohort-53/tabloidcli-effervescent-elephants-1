using System;
using System.Collections.Generic;
using TabloidCLI.Models;
using TabloidCLI.Repositories;


namespace TabloidCLI.UserInterfaceManagers
{
    public class PostManager : IUserInterfaceManager
    {
        private readonly IUserInterfaceManager _parentUI;
        private PostRepository _postRepository;
        private string _connectionString;
        public PostManager(IUserInterfaceManager parentUI, string connectionString)
        {
            _parentUI = parentUI;
            _postRepository = new PostRepository(connectionString);
            _connectionString = connectionString;
        }
        public IUserInterfaceManager Execute()
        {
            Console.WriteLine("Search Menu");
            Console.WriteLine(" 1) List Posts");
        //    Console.WriteLine(" 2) Add Post");
         //   Console.WriteLine(" 3) Edit Post");
        //    Console.WriteLine(" 4) Note Management");
         //   Console.WriteLine(" 5) Remove Post");
         //   Console.WriteLine(" 6) Post Details");
            Console.WriteLine(" 0) Go Back");
            Console.Write("> ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    List();
                    return this;
                case "0":
                    return _parentUI;
                default:
                    Console.WriteLine("Invalid Selection");
                    return this;
            }
        }
        private void List()
        {
            List<Post> posts = _postRepository.GetAll();
            foreach (Post post in posts)
            {
                Console.WriteLine($"\nTitle:{post.Title}\nUrl: {post.Url}\nDate Published:{post.PublishDateTime}\nAuthor:{post.Author.Id}\nBlog:{post.Blog.Id}");
            }
        }
    }

}

