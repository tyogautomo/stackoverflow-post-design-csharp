# Stackoverflow Post Design (OOP).

A stackoverflow post design with csharp, including upvote and downvoting a post.

This is just a simple example of designing a stackoverflow posting system on OOP Concept.
As we know, in Stackoverflow there are **User** that can create a **Post**, and each User can vote to someone post. In this example a user also can vote to their post. If a user already upvoted to a post and they try to upvotes the post again, their upvote will removed and back to neither upvote nor downvote.

# User

#### Properties
 - Id (`int`)
 - Name (`string`)
 - Posts (`List<Post>`)

#### Methods
- CreatePost (`Post post`)

# Post

#### Properties
 - Title (`int`)
 - Description (`string`)
 - CreatedAt (`DateTime`)
 - Upvotes (`List<User>`)
 - Downvotes (`List<User>`)
 - TotalDownvotes (`int`)

#### Methods
- UpvotePost (`User user`)
- DownvotePost (`User user`)
