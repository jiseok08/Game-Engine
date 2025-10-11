using UnityEngine;
using UnityEngine.UI;

public class Manual : MonoBehaviour
{
    [SerializeField] Text titleText;
    [SerializeField] Text descriptionText;

    public void Bind(string title, string description)
    {
        titleText.text = title;
        descriptionText.text = description;
    }
}
