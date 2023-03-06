using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRooms : MonoBehaviour
{

    public Transform self;
    public Vector3 spawn_offset;

    public GameObject[] spawnlist;

    public int selected_item;
    public int max_item;

    public int special_room_time;
    public float timer;
    public float max_time;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomRoom();
    }
    
    void SpawnRandomRoom()
    {
        Mind.room_generated += 1;
        max_item = spawnlist.Length;
        selected_item = Random.Range(0, max_item);

        Instantiate(spawnlist[selected_item], self.position, self.localRotation);

        self.position += spawn_offset;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > max_time) 
        {
            timer = 0f;
            SpawnRandomRoom();
        }
        
    }
}
