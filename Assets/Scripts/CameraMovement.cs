using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public float zDecreaseRate = 0.01f; // 매 프레임마다 z 값을 줄이는 비율

    private Vector3 offset; // 카메라와 플레이어 사이의 초기 오프셋

    // Start is called before the first frame update
    void Start()
    {
        // 플레이어와 카메라 사이의 초기 오프셋을 계산합니다.
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // 카메라의 x, y 위치를 플레이어의 x, y 위치에 맞춥니다.
        Vector3 newPosition = player.transform.position + offset;
        newPosition.z = transform.position.z - zDecreaseRate * Time.deltaTime;

        // 카메라의 위치를 새로운 위치로 업데이트합니다.
        transform.position = newPosition;
    }
}
