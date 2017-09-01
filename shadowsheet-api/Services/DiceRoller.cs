using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShadowAPI.Services
{
    //public enum DiceResult :byte
    //{
    //    CriticalGlitch
    //}

    public interface IShadowRunRoller
    {

        int[] Roll(int dice);
        int[] Roll(int dice, int faces);
    }


    public class ShadowRunRoller : IShadowRunRoller
    {
        private int _defaultDieFace;
        private Random _random;
        private int[] _lastRoll;

        public ShadowRunRoller()
        {
            _defaultDieFace = 6;
            _random = new Random();
            _lastRoll = new int[0];
        }


        public int[] Roll(int dice)
        {
            return Roll(dice, _defaultDieFace);
        }

        public int[] Roll(int dice, int face)
        {
            int[] result = new int[dice];

            for (int i = 0; i < dice; i++)
            {
                result[i] = _random.Next(6) + 1;
            }

            return result;
        }

    }
}
