using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static System.Collections.Specialized.BitVector32;

namespace Lesson_13
{
    internal class Player : IPlayable, IRecordable
    {
        private bool _play = false;
        private bool _record = false;
        private int action;

        public Player()
        {
            Gui();
        }

        private void Gui()
        {
            while (!_play || !_record)
            {
                Console.WriteLine("Player");
                Console.WriteLine(new string('_', 50));
                Console.WriteLine("\nChose action:\n1 - Play track\n2 - Start recording\n3 - Exit\n");
                action = int.Parse(Console.ReadLine());

                if (action == 1)
                {
                    Play();
                    GuiPause();
                }
                else if (action == 2)
                {
                    Record();
                    GuiPause();
                }
                else if (action == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Unknown action");
                    Console.ReadKey();
                    continue;
                }
            }
        }

        private void GuiPause()
        {
            while (_play || _record)
            {
                Console.WriteLine("\nChose action:\n1 - Pause\n2 - Stop\n");
                action = int.Parse(Console.ReadLine());

                if (action == 1)
                {
                    Pause();

                    Console.WriteLine("\nChose action:\n1 - Play\n2 - Stop\n");
                    action = int.Parse(Console.ReadLine());

                    if (action == 1)
                    {
                        Play();
                        continue;
                    }
                    else if (action == 2)
                    {
                        Stop();
                    }
                }

                else if (action == 2)
                {
                    Stop();
                }
                else
                {
                    Console.WriteLine("Unknown action");
                }
            }
        }

        public void Play()
        {
            Console.WriteLine("Started to play track...");
            _play = true;
        }

        public void Record()
        {
            Console.WriteLine("Started to record sounds...");
            _record = true;
        }

        public void Pause()
        {
            if (_play)
            {
                Console.WriteLine("Pause playing a track...");
                _play = false;
            }
            else if (_record)
            {
                Console.WriteLine("Pause recording...");
                _record = false;
            }
            else
            {
                Console.WriteLine("Plese turn on the track of record first");
            }
        }

        public void Stop()
        {
            if (_play)
            {
                Console.WriteLine("Stop playing a track...");
                _play = false;
            }
            else if (_record)
            {
                Console.WriteLine("Stop recording...");
                _record = false;
            }
            else
            {
                Console.WriteLine("Plese turn on the track of record first");
            }
        }
    }
}
