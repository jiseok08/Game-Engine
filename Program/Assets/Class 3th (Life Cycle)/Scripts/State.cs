using UnityEngine;

public class Bear : MonoBehaviour
{
    private void Awake()
    {
        // Awake : ��ü�� ������ �� ȣ��Ǹ�, ��ũ��Ʈ�� ��Ȱ��ȭ�Ǿ� ���� ������
        //         ȣ��ǰ�, �� �� ���� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        // OnEnable : ��ü�� Ȱ��ȭ �Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnEnable");
    }

    private void Start()
    {
        // Start : ��ü�� �����Ǿ��� �� ȣ��Ǹ�, �� �� ���� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        // FixedUpdate : timestep�� ������ ���� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("Fixed Update");
    }

    private void Update()
    {
        // Update : ��ü�� Ȱ��ȭ�Ǵ� ����, �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // LateUpdate : �� �������� ������ �ܰ迡�� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("Late Update");
    }

    private void OnDisable()
    {
        // OnDisable : ��ü�� ��Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        // OnDestroy : ��ü�� �����Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnDestroy");
    }
}
