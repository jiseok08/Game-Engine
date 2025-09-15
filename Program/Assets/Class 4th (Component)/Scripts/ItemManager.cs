using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] Item [] items;

    private int count = 0;

    void Start()
    {
        Initialize();
    }

    void Update()
    {
        Swap();
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            items[count++].gameObject.SetActive(false);

            count %= items.Length;

            items[count].gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (items[count].gameObject.activeSelf == true)
            {
                items[count].Activate();
            }
        }
    }
}
