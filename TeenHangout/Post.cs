namespace TeenHangout;

public class Post {
   //Attributes - variables to store data for the social media post
    public string UserName { get; set; }
    public string Content { get; set; }
    public int Likes { get; set; }

    // Constructor method to make a new Post object
    public Post(string username, string content, int likes)
    {
    // Set the values of the object's attributes to be the values
    // that are passed into the constructor
    UserName = username;
    Content = content;
    Likes = likes;
    }
}