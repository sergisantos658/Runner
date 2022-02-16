using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class PlayerFollowers : Singleton<PlayerFollowers>
{
    // Start is called before the first frame update
    List<Transform> Followers = new List<Transform>();
    public override void Awake()
    {
        base.Awake();
        Followers.Clear();
    }



    // Update is called once per frame

    public void AddFollower(Transform box)
    {
        BoxFollow BoxFollow = box.GetComponent<BoxFollow>();
        
        if(Followers.Count == 0)
        {

            Debug.Log("Starting to follow the player.");
            BoxFollow.follow = transform;
        }
        else
        {
            Debug.Log("Starting to follow last box.");
            BoxFollow.follow = Followers[Followers.Count - 1];
        }

        Debug.Log(Followers);
        Followers.Add(box);

    }

    public void RemoveFollower(Transform box)
    {
        Followers.Remove(box);
        var BoxFollow = box.GetComponent<BoxFollow>();
    }
}
