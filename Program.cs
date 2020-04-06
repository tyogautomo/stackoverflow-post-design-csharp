using System;

namespace Stackoverflow {

  class Program {

    static void Main(string[] args) {

      var john = new User(1, "John");
      var dany = new User(2, "Dany");
      var bono = new User(3, "Bono");
      var woody = new User(4, "Woody");

      var post1 = new Post("First Post", "This is the description of the post");

      Console.WriteLine(john.Name);
      Console.WriteLine($"This post created at {post1.CreatedAt.ToString()}");

      john.CreatePost(post1);

      Console.WriteLine(john.Posts[0].Title);

      post1.UpvotePost(dany);
      post1.UpvotePost(bono);

      Console.WriteLine($"Post1 total votes: {post1.TotalVotes}");

      post1.DownvotePost(woody);

      Console.WriteLine($"Post1 total votes: {post1.TotalVotes}");

    }
  }
}
