using UnityEngine;

public class Pilot : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;

   void Start()
    {

    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.x = Input.GetAxisRaw("Vertical");

        direction.Normalize();

        // Time.deltaTime
        // ���� �������� �Ϸ�Ǵ� �������� ���� �÷����� ���۵Ǳ����
        // ���� �ð��� ��ȯ�ϴ� ���Դϴ�.
        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}
