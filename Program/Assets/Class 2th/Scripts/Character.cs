using UnityEngine;

public class Character : MonoBehaviour
{
    public Ability Ability;

    void Start()
    {
        Debug.Log(Ability.strength);
    }
}
