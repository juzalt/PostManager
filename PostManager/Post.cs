using System;
namespace PostManager
{
	public class Post
	{
		private string title;
		private string description;
		private int votes;

		public void upvote()
		{
			votes = votes++;
		}

		public void downvote()
		{
			votes = votes--;
		}

		//public Post createPost(string title, string description)
		//{
		//}

		public Post(string title, string description)
		{
			title = title;
			description = description;
			votes = 0;
		}

		//public Post()
		//{
		//	if (post == null)
		//	{
		//		Console.WriteLine("You need to send a title and a description for the post");
		//	} else
		//	{
		//		Console.WriteLine(title);
		//		Console.WriteLine("");
		//		Console.WriteLine(description);
		//		Console.WriteLine("");
		//		Console.WriteLine("Vote count:" + votes);
		//	}
		//}
	}

}
