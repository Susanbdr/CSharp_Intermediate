using System;

namespace CSharp_Intermediate
{
    public class Upload : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video to a cloud storage... ");
        }
    }
}