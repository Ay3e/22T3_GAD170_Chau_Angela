using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AngelaChau
{
    public class WeekTwoActivities : MonoBehaviour
    {
        //Debugging: 10mins
        private string favouriteGame = "ML:BB";
        private int hourPlayed = 864;
        private float costOfGame = 0f;
        private float dollarsPerHour = 0f;
        //IF statements: 15mins
        private float randomFloat = 5f;
        //Create Some Stats!: 15mins
        private int strength = 0;
        private int agility = 5;
        private int intelligence = 8;
        private int statPool = 20;

        // Start is called before the first frame update
        void Start()
        {
            //Debugging
            dollarsPerHour = costOfGame/hourPlayed;
            Debug.Log("My Favourite game is, " + favouriteGame + "I have played it for " + hourPlayed + "hours, and it cost me " + costOfGame + ". Therefore, my value of dollars per hour is: " + dollarsPerHour);
            //IF statements
            if (randomFloat == 1)
            {
                Debug.Log("The number was exactly one.");
            }
            if (randomFloat > 3)
            {
                Debug.Log("The number was greater than three.");
            }
            if (randomFloat<3 || randomFloat > 5)
            {
                Debug.Log("The number was less than three or greather than 5.");
            }
            else
            {
                Debug.Log("The number is not 4.");
            }
            if(randomFloat>1 & randomFloat<5 || randomFloat>5)
            {
                Debug.Log("The number was greather than one and less than 5; or the number was greater than 5.");
            }
            //Create Some Stats!: 15mins
            
    }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

