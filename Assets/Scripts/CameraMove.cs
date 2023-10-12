using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject[] Positions;
    public float switchInterval = 1.0f; // 카메라 위치를 변경하는 간격 (1초로 설정)

    private int currentIndex = 0; // 현재 인덱스
    private Transform currentTarget; // 현재 타겟

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
            // 다음 위치 인덱스 계산
            currentIndex = (currentIndex + 1) % Positions.Length;
            currentTarget = Positions[currentIndex].transform;

            // 카메라 위치 변경
            transform.position = currentTarget.position;

            // 카메라가 (0, 0, 0)을 향하도록 방향을 설정
            transform.LookAt(Vector3.zero);

            yield return new WaitForSeconds(switchInterval);
        }
    }
}
