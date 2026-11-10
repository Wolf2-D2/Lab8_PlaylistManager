class program
{
    public static void Main(string[] args)
    {
        List<string> songs = new List<string>
            {"Yellow", "Halo", "Believer"};

        List<string> removedSong = new List<string>();

        Console.WriteLine("Checking work with git graph");
        

        while (true)
        {
            Console.WriteLine("====Playlist Manager====");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1.Show Playlist");
            Console.WriteLine("2.Add song to the end");
            Console.WriteLine("3.Insert a song at a position");
            Console.WriteLine("4.Remove Song");
            Console.WriteLine("5.Move song to a new position");
            Console.WriteLine("6.Search for a song");
            Console.WriteLine("7.Sort A to Z");
            Console.WriteLine("8.Reverse the order");
            Console.WriteLine("9.Quit");

            Console.WriteLine("Please choose an option by #");
            string user = Console.ReadLine();

            if (user != null && user == "1")
            {
                Console.WriteLine("===Playlist===");
                Console.WriteLine();
                PrintPlaylist(songs);
            }

            else if (user != null && user == "2")
            {
                Console.WriteLine("What song would you like to add?");
                string song = Console.ReadLine();
                addSong(songs, song );
            }

            else if (user != null && user == "3")
            {
                Console.WriteLine("Please give us a song");
                string song = Console.ReadLine();
                Console.WriteLine("Please enter the position you want that song starting with position 0\n Make sure the position you are trying to insert into exists.");
                int position = int.Parse(Console.ReadLine());
                InsertSong(songs,song,position);
            }

            else if (user != null && user == "4")
            {
                Console.WriteLine("What song would you like to remove\n be careful with your spelling");
                string song = Console.ReadLine();
                Remove(songs,removedSong, song);
            }

            else if (user != null && user == "5")
            {
                Console.WriteLine("Please give us a song");
                string song = Console.ReadLine();
                Console.WriteLine("Please enter the position you want that song starting with position 0\n Make sure the position you are trying to insert into exists.");
                int Newposition = int.Parse(Console.ReadLine());
                MoveSong(songs,song,Newposition);
            }

            else if (user != null && user == "6")
            {
                Console.WriteLine("Please give us a song to search for");
                string song = Console.ReadLine();
                SearchSong(songs,song);
            }

            else if (user !=null && user == "7")
            {
                SortSong(songs);
            }

            else if (user != null && user == "8")
            {
                ReverseSong(songs);
            }

            else if (user != null && user == "9")
            {
                Console.WriteLine("Thanks for using our playlist manager!");
                break;
                
            }

            else
            {
                Console.WriteLine("Invalid option please try again\n Thank You");
            }
        }
    }

    public static void PrintPlaylist(List<string> songs)
    {
        foreach( string song in songs)
        {
            
            Console.WriteLine(song);
            Console.WriteLine();
        }
    }

    public static void addSong(List<string> songs, string song)
    {
        
        songs.Add(song);
    }

    public static void InsertSong(List<string> songs, string song, int position)
    {
        songs.Insert(position, song);
    }

    public static void Remove(List<string> songs, List<string> removedSong, string song)
    {
        removedSong.Add(song);
        songs.Remove(song);
    }

    public static void MoveSong(List<string> songs, string song, int Newposition)
    {
        int oldposition = songs.IndexOf(song);
        songs.Insert(Newposition, song);
        songs.RemoveAt(oldposition+1);
        
    }

    public static void SearchSong(List<string> songs, string song)
    {
        bool found = songs.Contains(song);

        if( found == true)
        {
            int position = songs.IndexOf(song);
            Console.WriteLine($"{song} Was found at index {position}");
        }

        else if (found == false)
        {
            Console.WriteLine("Song wasn't found");
        }
    }

    public static void SortSong(List<string> songs)
    {
        songs.Sort();
    }

    public static void ReverseSong(List<string> songs)
    {
        songs.Reverse();
    }


}
