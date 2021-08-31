using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrewFloater : MonoBehaviour
{
    [SerializeField] private GameObject prefab; // 소환해서 날려보낼 
    [SerializeField] private List<Sprite> sprites;  // 크루원 이미지를 바꿔줄 리스트

    private bool[] crewStates = new bool[12];    // 떠다니는 크루원의 색 중복을 방지할
    private float timer = 0.5f;    // 크루원을 소환할 간격
    private float distance = 11f;    // 중심으로부터 소환될 위치를 지정

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<12; i++)
        {
            SpawnFloatingCrew((EPlayerColor)i, Random.Range(0f, distance));
            timer = 1f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0f)
        {
            SpawnFloatingCrew((EPlayerColor)Random.Range(0, 12), distance);
            timer = 1f;
        }
    }

    public void SpawnFloatingCrew(EPlayerColor playerColor, float dist) // 크루원을 소환
    {
        if (!crewStates[(int)playerColor])
        {
            crewStates[(int)playerColor] = true;

            float angle = Random.Range(0f, 360f);
            Vector3 spawnPos = new Vector3(Mathf.Sin(angle), Mathf.Cos(angle), 0f) * dist;
            Vector3 direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f);
            float floatingSpeed = Random.Range(1f, 4f);
            float rotateSpeed = Random.Range(-3f, 3f);

            var crew = Instantiate(prefab, spawnPos, Quaternion.identity).GetComponent<FloatigCrew>();
            crew.SetFloatingCrew(sprites[Random.Range(0, sprites.Count)], playerColor, direction, floatingSpeed, rotateSpeed, Random.Range(0.5f, 1f));
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        var crew = collision.GetComponent<FloatigCrew>();
        if (crew != null)
        {
            crewStates[(int)crew.playerColor] = false;
            Destroy(crew.gameObject);
        }
    }
}
