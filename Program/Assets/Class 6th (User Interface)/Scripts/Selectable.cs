using UnityEngine;
using UnityEngine.UI;

public class Selectable : MonoBehaviour
{
    [SerializeField] Button button;

    void Start()
    {
        button = button.GetComponent<Button>(); 
    }

    public void Enter()
    {
        button.GetComponentInChildren<Text>().fontSize = 100;
        button.GetComponentInChildren<Text>().color = Color.yellow;
    }

    public void Exit()
    {
        button.GetComponentInChildren<Text>().fontSize = 100;
        button.GetComponentInChildren<Text>().color = Color.green;
    }

    public void Down()
    {
        button.GetComponentInChildren<Text>().fontSize = 50;
    }
}
