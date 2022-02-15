using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class PlayerFollowers : Singleton<PlayerFollowers>
{
    // Start is called before the first frame update
    List<GameObject> Followers = new List<GameObject>();
    public override void Awake()
    {
        base.Awake();
        Followers.Clear();
    }



    // Update is called once per frame

    public void AddFollower(GameObject box)
    {
        BoxFollow BoxFollow = box.GetComponent<BoxFollow>();
        
        if(Followers.Count == 0)
        {
            BoxFollow.follow = gameObject;
        }
        else
        {
            BoxFollow.follow = Followers[Followers.Count - 1];
        }
        Debug.Log(Followers);
        Followers.Add(box);

    }

    public void RemoveFollower(GameObject box)
    {
        Followers.Remove(box);
        var BoxFollow = box.GetComponent<BoxFollow>();
    }
}
