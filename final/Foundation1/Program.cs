class Program
{
    static void Main()
    {
        // Create videos and add comments
        Video video1 = new Video("Introduction to C#", "John Doe", 300);
        video1.AddComment("Alice", "Great tutorial!");
        video1.AddComment("Bob", "I learned a lot.");
        video1.AddComment("Charlie", "Could you explain the last part again?");

        Video video2 = new Video("Web Development Basics", "Jane Smith", 400);
        video2.AddComment("David", "Awesome content!");
        video2.AddComment("Eve", "I wish there were more examples.");
        video2.AddComment("Frank", "This helped me a lot.");

        Video video3 = new Video("Machine Learning Fundamentals", "Chris Johnson", 500);
        video3.AddComment("Grace", "Very informative.");
        video3.AddComment("Henry", "Could you recommend more resources?");
        video3.AddComment("Isabel", "I enjoyed the explanations.");

        // Put videos in a list
        List<Video> videoList = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (Video video in videoList)
        {
            Console.WriteLine("Title: {0}", video.Title);
            Console.WriteLine("Author: {0}", video.Author);
            Console.WriteLine("Length: {0} seconds", video.Length);
            Console.WriteLine("Number of comments: {0}", video.GetNumberOfComments());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine("\n");
        }
    }
}