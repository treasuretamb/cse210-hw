class Video : MediaItem
{
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public int GetNumComments()
    {
        return Comments.Count;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
}