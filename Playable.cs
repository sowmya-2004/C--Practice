using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_assignment
{
    interface Iplayable
    {
        abstract public void  Play();
    }
    class MusicPlayer :Iplayable
    {
       public void Play()
        {
            Console.WriteLine("Music player class play method");
        }
    }

    class Videoplayer : Iplayable
    {
        public void Play()
        {
            Console.WriteLine("video player class play method");
        }
    }

    //class program
    //{
    //    public static void Main(string[] args)
    //    {
    //        MusicPlayer ms = new MusicPlayer();
    //        ms.Play();
    //        Videoplayer vc = new Videoplayer();
    //        vc.Play();
    //    }
    //}
}
