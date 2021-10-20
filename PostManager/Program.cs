using System;

namespace PostManager
{
    class Program
    {
        private Program postManager;
        private object[] listOfPosts;

        public void ViewPosts()
        {
            Console.WriteLine("Viewing Posts");
            postManager.AwaitForACommand();
        }

        public void SelectPost()
        {
            Console.WriteLine("Viewing an individual post");
            postManager.AwaitForACommand();
        }

        public void Exit()
        {
            Environment.Exit(0);
        }

        private void GiveIntroduction()
        {
            Console.WriteLine("Welcome to the post manager! :)");
            Console.WriteLine("");
            Console.WriteLine("");
            postManager.AwaitForACommand();
        }

        private void AwaitForACommand()
        {
            Console.WriteLine("");
            Console.WriteLine("Would you like to [list] the posts, [select] a post, or [exit]?");
            string command = Console.ReadLine();
            postManager.ActUponACommand(command);
        }

        private void ActUponACommand(string command)
        {
            switch (command)
            {
                case "list":
                    postManager.ViewPosts();
                    break;

                case "select":
                    postManager.SelectPost();
                    break;

                case "exit":
                    postManager.Exit();
                    break;
            }
        }
        static void Main(string[] args)
        {
            Program instanceOfProgram = new Program();
            instanceOfProgram.postManager = instanceOfProgram;

            instanceOfProgram.postManager.GiveIntroduction();
        }
    }
}
