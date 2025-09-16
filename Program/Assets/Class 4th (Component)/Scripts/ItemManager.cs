using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] Item [] items;

    [SerializeField] int count = 0;

    void Start()
    {
        Initialize();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Swap();
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (items[count].gameObject.activeSelf == true)
            {
                items[count].Activate();
            }
        }
    }

    private void Initialize()
    {
        for (int i = 0; i < items.Length; i++)
        {
            items[i].gameObject.SetActive(false);
        }
    }

    private void Swap()
    {      
        items[count].gameObject.SetActive(false);

        count = (count + 1) % items.Length;

        items[count].gameObject.SetActive(true);
    }
}
