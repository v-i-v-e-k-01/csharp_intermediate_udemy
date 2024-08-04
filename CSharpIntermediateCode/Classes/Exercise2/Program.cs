using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exercise2
{
    // ************************** StackOverFlow Post **************************
    public class Program
    {
        static void Main(string[] args)
        {

            Post post = null;
            while (true)
            {
                Console.WriteLine("Enter option from below \n1.Create Post \n2.UpVote \n3.DownVote \n4.View Votes \n5.View Post \n6.Exit: ");
                var userInput = Console.ReadLine();
                try
                {
                    switch (Convert.ToInt32(userInput))
                    {
                        case 1:
                            Console.WriteLine("Enter title: ");
                            var titlePost = Console.ReadLine();
                            post = new Post(titlePost);
                            Console.WriteLine("Enter Description: ");
                            post.Description = Console.ReadLine();
                            break;
                        case 2:
                            if (post == null)
                            {
                                throw new Exception("Post isnt created");
                            }
                            post.UpVote();
                            Console.WriteLine("Upvoted");
                            break;
                        case 3:
                            if (post == null)
                            {
                                throw new Exception("Post isnt created");
                            }
                            post.DownVote();
                            Console.WriteLine("Downvoted");
                            break;
                        case 4:
                            if (post == null)
                            {
                                throw new Exception("Post isnt created");
                            }
                            int votes = post.GetVoteCount();
                            Console.WriteLine("Votes: " + votes);
                            break;
                        case 5:
                            if (post == null)
                            {
                                throw new Exception("Post isnt created");
                            }
                            Console.WriteLine(post.GetTitle() + "\n" + post.Description + "\n" + post.GetDateTime().ToString());
                            break;
                        case 6:
                            Console.WriteLine("Exiting");
                            break;
                        default:
                            throw new Exception("Invalid input.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " Enter valid input");
                }

                if (Convert.ToInt32(userInput) == 6)
                {
                    break;
                }
            }

        }
    }
}
