﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    public static class Songs
    {
        private static string CurrentSong { get; set; }
        #region HappyBirthday
        private static Note[] Happy =
        {
        new Note(Duration.D1200),
            new Note(Tone.T264, Duration.D125),
            new Note(Duration.D250),
            new Note(Tone.T264, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T300, Duration.D500),
            new Note(Duration.D125),
            new Note(Tone.T264, Duration.D500),
            new Note(Duration.D125),
            new Note(Tone.T352, Duration.D500),
            new Note(Duration.D125),
            new Note(Tone.T330, Duration.D1000),
            new Note(Duration.D250),
            new Note(Tone.T264, Duration.D125),
            new Note(Duration.D250),
            new Note(Tone.T264, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T300, Duration.D500),
            new Note(Duration.D125),
            new Note(Tone.T264, Duration.D500),
            new Note(Duration.D125),
            new Note(Tone.T392, Duration.D500),
            new Note(Duration.D125),
            new Note(Tone.T352, Duration.D1000),
            new Note(Duration.D250),
            new Note(Tone.T264, Duration.D125),
            new Note(Duration.D250),
            new Note(Tone.T264, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T264, Duration.D500),
            new Note(Duration.D125),
            new Note(Tone.T440, Duration.D500),
            new Note(Duration.D125),
            new Note(Tone.T352, Duration.D250),
            new Note(Duration.D125),
            new Note(Tone.T352, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T330, Duration.D500),
            new Note(Duration.D125),
            new Note(Tone.T300, Duration.D1000),
            new Note(Duration.D250),
            new Note(Tone.T466, Duration.D125),
            new Note(Duration.D250),
            new Note(Tone.T466, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T440, Duration.D500),
            new Note(Duration.D125),
            new Note(Tone.T352, Duration.D500),
            new Note(Duration.D125),
            new Note(Tone.T392, Duration.D500),
            new Note(Duration.D125),
            new Note(Tone.T352, Duration.D1000)
        };
        public static void PlayHappyBirthday()
        {
            var s = new Song("Happy Birthday", Happy);
            s.PlaySong();
        }
        #endregion
        #region Beethoven
        private static Note[] Bee =
{
          new Note(Tone.T659, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T622, Duration.D120),
            new Note(Duration.D120),

            new Note(Tone.T659, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T622, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T659, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T494, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T587, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T523, Duration.D120),
            new Note(Duration.D120),

            new Note(Tone.T440, Duration.D120),
            new Note(Duration.D150),
            new Note(Tone.T264, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T330, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T440, Duration.D120),
            new Note(Duration.D120),

            new Note(Tone.T494, Duration.D120),
            new Note(Duration.D150),
            new Note(Tone.T330, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T415, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T494, Duration.D120),
            new Note(Duration.D120),

            new Note(Tone.T523, Duration.D120),
            new Note(Duration.D150),
            new Note(Tone.T330, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T659, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T622, Duration.D120),
            new Note(Duration.D120),

            new Note(Tone.T659, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T622, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T659, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T494, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T587, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T523, Duration.D120),
            new Note(Duration.D120),

            new Note(Tone.T440, Duration.D120),
            new Note(Duration.D150),
            new Note(Tone.T264, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T330, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T440, Duration.D120),
            new Note(Duration.D120),

            new Note(Tone.T494, Duration.D120),
            new Note(Duration.D150),
            new Note(Tone.T330, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T523, Duration.D120),
            new Note(Duration.D120),
            new Note(Tone.T494, Duration.D120),
            new Note(Duration.D150),
            new Note(Tone.T440, Duration.D120)
        };

        public static void PlayBeethoven()
        {
            var s = new Song("Fur Elise", Bee);
            s.PlaySong();

        }
        #endregion
        #region SuperMario Theme
        private static Note[] mario =
        {
      new Note(Tone.T659, Duration.D125),
            new Note(Tone.T659, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T659, Duration.D125),
            new Note(Duration.D150),
            new Note(Tone.T523, Duration.D125),
            new Note(Tone.T659, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T784, Duration.D125),
            new Note(Duration.D300),
            new Note(Tone.T392, Duration.D125),
            new Note(Duration.D300),
            new Note(Tone.T523, Duration.D125),
            new Note(Duration.D250),
            new Note(Tone.T392, Duration.D125),
            new Note(Duration.D250),
            new Note(Tone.T330, Duration.D125),
            new Note(Duration.D250),
            new Note(Tone.T440, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T494, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T466, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T440, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T392, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T659, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T784, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T880, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T698, Duration.D125),
            new Note(Tone.T784, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T659, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T523, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T587, Duration.D125),
            new Note(Tone.T494, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T523, Duration.D125),
            new Note(Duration.D250),
            new Note(Tone.T392, Duration.D125),
            new Note(Duration.D250),
            new Note(Tone.T330, Duration.D125),
            new Note(Duration.D250),
            new Note(Tone.T440, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T494, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T466, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T440, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T392, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T659, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T784, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T880, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T698, Duration.D125),
            new Note(Tone.T784, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T659, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T523, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T587, Duration.D125),
            new Note(Tone.T494, Duration.D125),
            new Note(Duration.D300),
            new Note(Tone.T784, Duration.D125),
            new Note(Tone.T740, Duration.D125),
            new Note(Tone.T698, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T622, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T659, Duration.D125),
            new Note(Duration.D150),
            new Note(Tone.T415, Duration.D125),
            new Note(Tone.T440, Duration.D125),
            new Note(Tone.T523, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T440, Duration.D125),
            new Note(Tone.T523, Duration.D125),
            new Note(Tone.T587, Duration.D125),
            new Note(Duration.D250),
            new Note(Tone.T784, Duration.D125),
            new Note(Tone.T740, Duration.D125),
            new Note(Tone.T698, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T622, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T659, Duration.D125),
            new Note(Duration.D150),
            new Note(Tone.T698, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T698, Duration.D125),
            new Note(Tone.T698, Duration.D125),
            new Note(Duration.D600),
            new Note(Tone.T784, Duration.D125),
            new Note(Tone.T740, Duration.D125),
            new Note(Tone.T698, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T622, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T659, Duration.D125),
            new Note(Duration.D150),
            new Note(Tone.T415, Duration.D125),
            new Note(Tone.T440, Duration.D125),
            new Note(Tone.T523, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T440, Duration.D125),
            new Note(Tone.T523, Duration.D125),
            new Note(Tone.T587, Duration.D125),
            new Note(Duration.D250),
            new Note(Tone.T622, Duration.D125),
            new Note(Duration.D250),
            new Note(Tone.T587, Duration.D125),
            new Note(Duration.D250),
            new Note(Tone.T523, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T784, Duration.D125),
            new Note(Tone.T740, Duration.D125),
            new Note(Tone.T698, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T622, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T659, Duration.D125),
            new Note(Duration.D150),
            new Note(Tone.T415, Duration.D125),
            new Note(Tone.T440, Duration.D125),
            new Note(Tone.T523, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T440, Duration.D125),
            new Note(Tone.T523, Duration.D125),
            new Note(Tone.T587, Duration.D125),
            new Note(Duration.D250),
            new Note(Tone.T784, Duration.D125),
            new Note(Tone.T740, Duration.D125),
            new Note(Tone.T698, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T622, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T659, Duration.D125),
            new Note(Duration.D150),
            new Note(Tone.T698, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T698, Duration.D125),
            new Note(Tone.T698, Duration.D125),
            new Note(Duration.D600),
            new Note(Tone.T784, Duration.D125),
            new Note(Tone.T740, Duration.D125),
            new Note(Tone.T698, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T622, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T659, Duration.D125),
            new Note(Duration.D150),
            new Note(Tone.T415, Duration.D125),
            new Note(Tone.T440, Duration.D125),
            new Note(Tone.T523, Duration.D125),
            new Note(Duration.D125),
            new Note(Tone.T440, Duration.D125),
            new Note(Tone.T523, Duration.D125),
            new Note(Tone.T587, Duration.D125),
            new Note(Duration.D250),
            new Note(Tone.T622, Duration.D125),
            new Note(Duration.D250),
            new Note(Tone.T587, Duration.D125),
            new Note(Duration.D250),
            new Note(Tone.T523, Duration.D125),
            new Note(Duration.D600)
        };
        public static void PlaySuperMario()
        {
            var s = new Song("Super Mario Theme", mario);
            s.PlaySong();
        }
        #endregion
        #region StarWars Theme
        private static Note[] wars =
        {
            new Note(Tone.T300, Duration.D500),
            new Note(Duration.D100),
            new Note(Tone.T300, Duration.D500),
            new Note(Duration.D100),
            new Note(Tone.T300, Duration.D500),
            new Note(Duration.D100),
            new Note(Tone.T247, Duration.D500),
            new Note(Duration.D100),
            new Note(Tone.T300, Duration.D250),
            new Note(Tone.T300, Duration.D500),
            new Note(Duration.D100),
            new Note(Tone.T247, Duration.D500),
            new Note(Duration.D100),
            new Note(Tone.T300, Duration.D250),
            new Note(Tone.T300, Duration.D500),
            new Note(Duration.D100)
        };
        public static void PlayStarWars()
        {
            var s = new Song("Star Wars Theme", wars);
            s.PlaySong();
        }
        #endregion
        #region MissionImpossible
        private static Note[] mission =
        {
                 new Note(Tone.T784, Duration.D150),
            new Note(Duration.D300),
            new Note(Tone.T784, Duration.D150),
            new Note(Duration.D300),
            new Note(Tone.T932, Duration.D150),
            new Note(Duration.D150),
            new Note(Tone.T932, Duration.D150),
            new Note(Duration.D150),
            new Note(Tone.T784, Duration.D150),
            new Note(Duration.D300),
            new Note(Tone.T784, Duration.D150),
            new Note(Duration.D300),
            new Note(Tone.T698, Duration.D150),
            new Note(Duration.D150),
            new Note(Tone.T740, Duration.D150),
            new Note(Duration.D150),
            new Note(Tone.T784, Duration.D150),
            new Note(Duration.D300),
            new Note(Tone.T784, Duration.D150),
            new Note(Duration.D300),
            new Note(Tone.T932, Duration.D150),
            new Note(Duration.D150),
            new Note(Tone.T932, Duration.D150),
            new Note(Duration.D150),
            new Note(Tone.T784, Duration.D150),
            new Note(Duration.D300),
            new Note(Tone.T784, Duration.D150),
            new Note(Duration.D300),
            new Note(Tone.T698, Duration.D150),
            new Note(Duration.D150),
            new Note(Tone.T740, Duration.D150),
            new Note(Duration.D150),
            new Note(Tone.T932, Duration.D150),
            new Note(Tone.T784, Duration.D150),
            new Note(Tone.T587, Duration.D1200),
            new Note(Duration.D100),
            new Note(Tone.T932, Duration.D150),
            new Note(Tone.T784, Duration.D150),
            new Note(Tone.T523, Duration.D1200),
            new Note(Duration.D100),
            new Note(Tone.T932, Duration.D150),
            new Note(Tone.T784, Duration.D150),
            new Note(Tone.T523, Duration.D1200),
            new Note(Duration.D150),
            new Note(Tone.T466, Duration.D150),
            new Note(Tone.T523, Duration.D150)
        };
        public static void PlayMissionImpossible()
        {
            var s = new Song("Mission Impossible", mission);
            s.PlaySong();
        }
        #endregion
        #region Tannenbaum
        private static Note[] Tan =
        {
                 new Note(Tone.T247, Duration.D500),
            new Note(Tone.T417, Duration.D500),
            new Note(Tone.T417, Duration.D500),
            new Note(Tone.T392, Duration.D500),
            new Note(Tone.T417, Duration.D500),
            new Note(Tone.T329, Duration.D500),
            new Note(Tone.T247, Duration.D500),
            new Note(Tone.T247, Duration.D500),
            new Note(Tone.T247, Duration.D500),
            new Note(Tone.T417, Duration.D500),
            new Note(Tone.T417, Duration.D500),
            new Note(Tone.T392, Duration.D500),
            new Note(Tone.T417, Duration.D500),
            new Note(Tone.T494, Duration.D500),
            new Note(Duration.D500),
            new Note(Tone.T494, Duration.D500),
            new Note(Tone.T264, Duration.D500),
            new Note(Tone.T264, Duration.D500),
            new Note(Tone.T440, Duration.D500),
            new Note(Tone.T440, Duration.D500),
            new Note(Tone.T417, Duration.D500),
            new Note(Tone.T392, Duration.D500),
            new Note(Tone.T329, Duration.D500),
            new Note(Tone.T247, Duration.D500),
            new Note(Tone.T417, Duration.D500),
            new Note(Tone.T417, Duration.D500),
            new Note(Tone.T352, Duration.D500),
            new Note(Tone.T417, Duration.D500),
            new Note(Tone.T329, Duration.D500)
        };
        public static void PlayTannenbaum()
        {
            var s = new Song("Tannenbaum", Tan);
            s.PlaySong();
        }
        #endregion
        #region Grasshoper
        private static Note[] Grass =
        {
            new Note(Tone.T440, Duration.D300),
        new Note(Tone.T330, Duration.D300),
        new Note(Tone.T440, Duration.D300),
        new Note(Tone.T330, Duration.D300),
        new Note(Tone.T440, Duration.D300),
        new Note(Tone.T415, Duration.D300),
        new Note(Tone.T415, Duration.D300),
        new Note(Duration.D600),
        new Note(Tone.T415, Duration.D300),
        new Note(Tone.T330, Duration.D300),
        new Note(Tone.T415, Duration.D300),
        new Note(Tone.T330, Duration.D300),
        new Note(Tone.T415, Duration.D300),
        new Note(Tone.T440, Duration.D300),
        new Note(Tone.T440, Duration.D300),
        new Note(Duration.D600),
        new Note(Tone.T440, Duration.D300),
        new Note(Tone.T494, Duration.D300),
        new Note(Tone.T494, Duration.D100),
        new Note(Tone.T494, Duration.D100),
        new Note(Tone.T494, Duration.D300),
        new Note(Tone.T494, Duration.D300),
        new Note(Tone.T523, Duration.D300),
        new Note(Tone.T523, Duration.D100),
        new Note(Tone.T523, Duration.D100),
        new Note(Tone.T523, Duration.D300),
        new Note(Tone.T523, Duration.D300),
        new Note(Tone.T523, Duration.D300),
        new Note(Tone.T494, Duration.D300),
        new Note(Tone.T440, Duration.D300),
        new Note(Tone.T415, Duration.D300),
        new Note(Tone.T440, Duration.D800)
    };
        public static void PlayGrasshoper()
        {
            var s = new Song("Grasshoper", Grass);
            s.PlaySong();
        }
        #endregion
        #region Jingle Bells
        public static void PlayJingle()
        {
            var s = new Song("Jingle Bells", refrenSolo);
            var st = new Song("Jingle Bells", coupleSolo);
            s.PlaySong();
            st.PlaySong();
            s.PlaySong();
        }
        //Jingle Bells
        private static Note[] refrenSolo =
        {
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T783, Duration.D300),
            new Note(Tone.T523, Duration.D300),
            new Note(Tone.T587, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T264, Duration.D300),
            new Note(Tone.T300, Duration.D300),
            new Note(Tone.T329, Duration.D300),
            new Note(Tone.T698, Duration.D300),
            new Note(Tone.T698, Duration.D300),
            new Note(Tone.T698, Duration.D300),
            new Note(Duration.D300),
            new Note(Tone.T698, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T587, Duration.D300),
            new Note(Tone.T587, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T587, Duration.D300),
            new Note(Duration.D300),
            new Note(Tone.T783, Duration.D300),
            new Note(Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T783, Duration.D300),
            new Note(Tone.T523, Duration.D300),
            new Note(Tone.T587, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T264, Duration.D300),
            new Note(Tone.T300, Duration.D300),
            new Note(Tone.T329, Duration.D300),
            new Note(Tone.T698, Duration.D300),
            new Note(Tone.T698, Duration.D300),
            new Note(Tone.T698, Duration.D300),
            new Note(Duration.D300),
            new Note(Tone.T698, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Duration.D300),
            new Note(Tone.T783, Duration.D300),
            new Note(Tone.T783, Duration.D300),
            new Note(Tone.T698, Duration.D300),
            new Note(Tone.T587, Duration.D300),
            new Note(Tone.T523, Duration.D600),
            new Note(Duration.D600)
        };
        private static Note[] coupleSolo =
        {
            new Note(Tone.T392, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T587, Duration.D300),
            new Note(Tone.T523, Duration.D300),
            new Note(Tone.T392, Duration.D600),
            new Note(Duration.D600),
            new Note(Tone.T392, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T587, Duration.D300),
            new Note(Tone.T523, Duration.D300),
            new Note(Tone.T440, Duration.D600),
            new Note(Duration.D600),
            new Note(Tone.T440, Duration.D300),
            new Note(Tone.T698, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T587, Duration.D300),
            new Note(Tone.T783, Duration.D600),
            new Note(Duration.D600),
            new Note(Tone.T880, Duration.D300),
            new Note(Tone.T880, Duration.D300),
            new Note(Tone.T783, Duration.D300),
            new Note(Tone.T622, Duration.D300),
            new Note(Tone.T659, Duration.D600),
            new Note(Duration.D600),
            new Note(Tone.T392, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T587, Duration.D300),
            new Note(Tone.T523, Duration.D300),
            new Note(Tone.T392, Duration.D600),
            new Note(Duration.D600),
            new Note(Tone.T392, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T587, Duration.D300),
            new Note(Tone.T523, Duration.D300),
            new Note(Tone.T440, Duration.D600),
            new Note(Duration.D600),
            new Note(Tone.T440, Duration.D300),
            new Note(Tone.T698, Duration.D300),
            new Note(Tone.T659, Duration.D300),
            new Note(Tone.T587, Duration.D300),
            new Note(Tone.T783, Duration.D600),
            new Note(Duration.D600),
            new Note(Tone.T880, Duration.D300),
            new Note(Tone.T783, Duration.D300),
            new Note(Tone.T698, Duration.D300),
            new Note(Tone.T587, Duration.D300),
            new Note(Tone.T523, Duration.D600),
            new Note(Duration.D600)
        };
        #endregion
        #region Mary

        private static Note[] Mary =
         {
        new Note(Tone.T264,Duration.D300),
        new Note(Tone.T264,Duration.D300),
        new Note(Tone.T300,Duration.D300),
        new Note(Tone.T247,Duration.D300),
        new Note(Tone.T264,Duration.D300),
        new Note(Tone.T264,Duration.D300),
        new Note(Tone.T264,Duration.D600),
        new Note(Tone.T247,Duration.D300),
        new Note(Tone.T247,Duration.D300),
        new Note(Tone.T247,Duration.D600),
        new Note(Tone.T264,Duration.D300),
        new Note(Tone.T329,Duration.D300),
        new Note(Tone.T329,Duration.D600)
        };
        public static void PlayMary()
        {
            var s = new Song("Mary", Mary);
            s.PlaySong();
        }
        #endregion
    }
}
