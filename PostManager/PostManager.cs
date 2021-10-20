using System;
using System.Collections.Generic;

namespace PostManager
    {
    public class PostManager
    {
        private List<Post> listOfPosts;

        private void GiveIntroduction()
        {
            Console.WriteLine("Welcome to the post manager! :)");
            Console.WriteLine("");
            Console.WriteLine("");
            AwaitForACommand();
        }

        private void AwaitForACommand()
        {
            Console.WriteLine("");
            Console.WriteLine("Would you like to [list] the posts, [create] a post, [select] a post, or [exit]?");
            string command = Console.ReadLine();
            ActUponACommand(command);
        }

        private void ActUponACommand(string command)
        {
            switch (command)
            {
                case "list":
                    ViewPosts();
                    break;

                case "create":
                    CreatePost();
                    break;

                case "select":
                    SelectAPost();
                    break;

                case "exit":
                    Exit();
                    break;

                default:
                    Console.WriteLine("Choose an option: select, list, create or exit.");
                    break;
            }
            AwaitForACommand();
        }

        public void ViewPosts()
        {
            Console.WriteLine("Viewing Posts");
            Console.WriteLine("");

            foreach (Post i in listOfPosts)
            {
                Console.WriteLine("Title: "+i.title);
                Console.WriteLine("Description: "+i.description);
                Console.WriteLine("Votes: "+i.votes);
                Console.WriteLine("************");
                Console.WriteLine("");
            }

            AwaitForACommand();
        }
        
        public void CreatePost()
        {
            Console.WriteLine("What name should the post have?");
            Console.WriteLine("");
            string title = Console.ReadLine();

            Console.WriteLine("What description should the post have?");
            Console.WriteLine("");
            string description = Console.ReadLine();
            Post newPost = new Post(title, description);
            listOfPosts.Add(newPost);

            Console.WriteLine("");
            Console.WriteLine("Title: " + newPost.title);
            Console.WriteLine("Description: " + newPost.description);
            Console.WriteLine("Votes: " + newPost.votes);
            Console.WriteLine("************");
            Console.WriteLine("");

            AwaitForACommand();
        }

        public void SelectAPost()
        {
            Console.WriteLine("What's the name of the post");
            string name = Console.ReadLine();
            Post post = listOfPosts.Find(x => x.title == name);

            Console.WriteLine("");
            Console.WriteLine("Title: " + post.title);
            Console.WriteLine("Description: " + post.description);
            Console.WriteLine("Votes: " + post.votes);
            Console.WriteLine("************");
            Console.WriteLine("");

            Console.WriteLine("Do you wish to [upvote] it, [downvote] it or [exit] to the main menu?");

            
            switch (Console.ReadLine())
            {
                case "upvote":
                    post.upvote();
                    Console.WriteLine("Votes: " + post.votes);
                    break;
                case "downvote":
                    post.downvote();
                    break;
                case "exit":
                    break;
                default:
                    break;
            }

            AwaitForACommand();
        }

        public void Exit()
        {
            Environment.Exit(0);
        }

        public PostManager()
        {
            listOfPosts = new List<Post>();
            listOfPosts.Add(new Post("First Post", "First post's description"));

            GiveIntroduction();
        }
    }
}