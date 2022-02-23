using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public  class PlayerFollowers : Singleton<PlayerFollowers>
{
    // Start is called before the first frame update
    List<Transform> Followers = new List<Transform>();
    public GameObject followGod;
    public static event Action<int> pointsEv = delegate { };
    int points;
    public override void Awake()
    {
        base.Awake();
        Followers.Clear();
    }



    // Update is called once per frame

    public void AddFollower(Transform box)
    {
        BoxFollow BoxFollow = box.GetComponent<BoxFollow>();


        if (Followers.Count == 0)
        {

            Debug.Log("Starting to follow the player.");
            BoxFollow.follow = transform;
        }
        else
        {
            Debug.Log("Starting to follow last box.");
            BoxFollow.follow = Followers[Followers.Count - 1];
        }
        points += 5;
        pointsEv(points);
        Debug.Log(Followers);
        Followers.Add(box);

    }

    public void RemoveFollower(Transform box)
    {
        Followers.Remove(box);
        points -= 5;
        pointsEv(points);
        var BoxFollow = box.GetComponent<BoxFollow>();
        Destroy(box.gameObject,.1f);
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.F1))
        {

            Instantiate(followGod, transform.position, transform.rotation);
        }
        if(Input.GetKeyDown(KeyCode.F2))
        {
            if (Followers.Count > 0)
            {
                RemoveFollower(Followers[Followers.Count-1]);

            }

        }
    }
}


