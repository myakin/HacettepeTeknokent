﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public Transform player;
    

    // Update is called once per frame
    void Update() {
        transform.position = new Vector3 (player.transform.position.x, transform.position.y, player.transform.position.z);
    }
}
