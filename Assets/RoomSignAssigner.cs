using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSignAssigner : MonoBehaviour
{

    public TMPro.TextMeshPro my_text;

    // Start is called before the first frame update
    void Start()
    {
        my_text.text = Mind.room_generated.ToString();
    }

}
