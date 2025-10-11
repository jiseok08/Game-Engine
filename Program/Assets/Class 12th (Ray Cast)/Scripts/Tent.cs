using UnityEngine;

public class Tent : Encampment
{
    public override void Describe()
    {
        title = "Tent";
        description = "A tent is a shelter consisting of sheets of fabric or other material draped over or attached to a frame of poles or a supporting rope." +
            " While smaller tents may be free-standing or attached to the ground, large tents are usually anchored using guy ropes tied to stakes or tent pegs. " +
            "First used as portable homes by nomads, tents are now more often used for recreational camping and as temporary shelters.";
    }
}
