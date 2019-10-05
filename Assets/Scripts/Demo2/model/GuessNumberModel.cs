using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo2
{

    public class GuessNumberModel : IGuessNumberModel
    {
        public int Card1Number { get; set; }
        public int Card2Number { get; set; }
        public int Card3Number { get; set; }
    }

}
