using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

public class SayaMusikTrack
{
    private int id = 9999;
    private string playCount;
    private string title;


    public SayaMusikTrack(string title)
    {
        this.id = id;
        this.title = title;
        this.playCount = "0";



        Contract.Requires(!string.IsNullOrEmpty(title), "Title cannot be null or empty.");
        Contract.Requires(title.Length <= 100, "Max title length is 100.");
    }

    void IncreasePlayCount(int count)
    {
        Debug.Assert(count >= 0 && count <= 10000000, "Input penambahan maksimal 10.000.000");
        try
        {
            int currentCount = int.Parse(this.playCount);
            checked
            {
                currentCount = currentCount + count;
            }

            this.playCount = currentCount.ToString();
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Terjadi overflow! Play count melebihi batas maksimum integer.");
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    void PrintTrackInfo()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }

    class Program
    {
        static void Main(string[] args)
        {
            SayaMusikTrack track = new SayaMusikTrack("Shape Of My Hearth");
            do
            {
                try
                {
                    Console.WriteLine("\nsePotipay");
                    

                    Console.WriteLine("Masukan PlayCount:");
                    int playTest = Convert.ToInt32(Console.ReadLine());
                    for (int j = 0; j < 300; j++)
                    {
                        track.IncreasePlayCount(playTest);
                    }

                    track.PrintTrackInfo();
                }
                catch (Exception ex)
                {
                    track.PrintTrackInfo();
                    Console.WriteLine($"\nProgram stop karena: {ex.GetType().Name}");
                    break;
                }
            } while (true);
            
            Console.WriteLine();
        }
    }
}