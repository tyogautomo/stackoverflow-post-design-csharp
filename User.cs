using System.Collections.Generic;

namespace Stackoverflow {

  public class User {
    public int Id { get; private set; }
    public string Name { get; private set; }
    public List<Post> Posts { get; private set; }

    public User(int id, string name) {
      this.Id = id;
      this.Name = name;
      this.Posts = new List<Post>();
    }

    public void CreatePost(Post post) {
      Posts.Add(post);
    }

  }

}