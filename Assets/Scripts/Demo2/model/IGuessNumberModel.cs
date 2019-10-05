using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo2
{

    public interface IGuessNumberModel
    {
        int Card1Number { get; set; }
        int Card2Number { get; set; }
        int Card3Number { get; set; }
    }

}
