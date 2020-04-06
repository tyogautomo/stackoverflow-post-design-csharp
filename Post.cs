using System;
using System.Collections.Generic;

namespace Stackoverflow {

  public class Post {
    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public List<User> Upvotes { get; private set; }
    public List<User> Downvotes { get; private set; }
    public int TotalVotes {
      get {
        return Upvotes.Count - Downvotes.Count;
      }
    }

    public Post(string title, string description) {
      this.Title = title;
      this.Description = description;
      this.CreatedAt = DateTime.Now;
      this.Upvotes = new List<User>();
      this.Downvotes = new List<User>();
    }

    public void UpvotePost(User user) {
      var isUpvoted = Upvotes.Contains(user);

      if (!isUpvoted) {
        Upvotes.Add(user);
        if (Downvotes.Contains(user)) {
          var index = Downvotes.IndexOf(user);
          Downvotes.RemoveAt(index);
        }
      } else {
        var index = Upvotes.IndexOf(user);
        Upvotes.RemoveAt(index);
      }
    }

    public void DownvotePost(User user) {
      var isDownvoted = Downvotes.Contains(user);

      if (!isDownvoted) {
        Downvotes.Add(user);
        if (Upvotes.Contains(user)) {
          var index = Upvotes.IndexOf(user);
          Upvotes.RemoveAt(index);
        }
      } else {
        var index = Downvotes.IndexOf(user);
        Downvotes.RemoveAt(index);
      }
    }

  }
}