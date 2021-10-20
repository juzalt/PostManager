using System;

public class Post
{
	private string title;
	private string description;
	private int votes;
	private Post post;

	public void upvote()
	{
		post.votes = post.votes++;
	}

	public void downvote()
	{
		post.votes = post.votes--;
	}

	public Post createPost(string title, string description)
	{
		post = new Post(title, description);
		post.title = title;
		post.description = description;
		post.votes = 0;
		return post;
	}

	public Post(string title, string description)
	{
		if (post == null)
		{
			post = createPost(title, description);
		}
	}

	public Post()
	{
		if (post == null)
		{
			Console.WriteLine("You need to send a title and a description for the post");
		} else
		{
			Console.WriteLine(title);
			Console.WriteLine("");
			Console.WriteLine(description);
			Console.WriteLine("");
			Console.WriteLine("Vote count:" + votes);
		}
	}
}
