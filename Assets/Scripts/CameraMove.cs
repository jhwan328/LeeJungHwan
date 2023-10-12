using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject[] Positions;
    public float switchInterval = 1.0f; // ī�޶� ��ġ�� �����ϴ� ���� (1�ʷ� ����)

    private int currentIndex = 0; // ���� �ε���
    private Transform currentTarget; // ���� Ÿ��

    void Start()
    {
        if (Positions.Length > 0)
        {
            currentTarget = Positions[currentIndex].transform;
            StartCoroutine(SwitchCameraPositionCoroutine());
        }
    }

    IEnumerator SwitchCameraPositionCoroutine()
    {
        while (true)
        {
            // ���� ��ġ �ε��� ���
            currentIndex = (currentIndex + 1) % Positions.Length;
            currentTarget = Positions[currentIndex].transform;

            // ī�޶� ��ġ ����
            transform.position = currentTarget.position;

            // ī�޶� (0, 0, 0)�� ���ϵ��� ������ ����
            transform.LookAt(Vector3.zero);

            yield return new WaitForSeconds(switchInterval);
        }
    }
}
