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
            Console.WriteLine("Would you like to [list] the posts, [select] a post, or [exit]?");
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

                case "select":
                    SelectPost();
                    break;

                case "exit":
                    Exit();
                    break;
            }
        }

        public void ViewPosts()
        {
            Console.WriteLine("Viewing Posts");
            Console.WriteLine("");

            foreach (Post i in listOfPosts)
            {
                Console.WriteLine(i);
                Console.WriteLine("************");
            }

            AwaitForACommand();
        }

        public void SelectPost()
        {
            Console.WriteLine("Viewing an individual post");
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