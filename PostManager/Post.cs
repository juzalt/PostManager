using System;
namespace PostManager
{
	public class Post
	{
		public string title;
		public string description;
		public int votes;

		public void upvote()
		{
			votes = votes++;
		}

		public void downvote()
		{
			votes = votes--;
		}

		public Post(string title2, string description2)
		{
			title = title2;
			description = description2;
			votes = 0;
		}

	}

}
