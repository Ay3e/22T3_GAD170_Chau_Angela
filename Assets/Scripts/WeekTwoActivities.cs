using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AngelaChau
{
    public class WeekTwoActivities : MonoBehaviour
    {
        private string favouriteGame = "ML:BB";
        private int hourPlayed = 864;
        private float costOfGame = 0;

        // Start is called before the first frame update
        void Start()
        {

            Debug.Log("My Favourite game is, " + favouriteGame + "I have played it for " + hourPlayed + "hours, and it cost me " + costOfGame + ". Therefore, my value of dollars per hour is: ");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

