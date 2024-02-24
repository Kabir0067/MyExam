List<Post> post1 = new List<Post>();
post1.Comments = "1""Gap nest";
post1.Comments = "2""Gap nest";
post1.Comments = "3""Gap nest";
post1.Comments = "4""Gap nest";
post1.Comments = "5""Gap nest";

post1[0].Publish();
post1[1].Like();
post1[2].Like();
post1[3].Like();


foreach (var item in post1)
{
    System.Console.WriteLine($"{item.Title}\n - {item.Description}\n - number of Likes: {item.LikeCount}");
}


public class Post
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int LikeCount { get; private set; }
    public List<string> Comments { get; set; }
    public bool IsPublished { get; set; }

    public Post(string title, string description)


    public void Publish()
    {
        Console.WriteLine("The post is published.");
        IsPublished = true;
    }

    public void Like()
    {
        LikeCount++;
    }

    public void Comment(string message)
    {
        Comments.Add(message);
    }
}