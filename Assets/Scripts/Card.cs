using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AngelaChau
{
    public enum CardSuit {Spades, Clubs, Diamonds, Hearts}
    public class Card : MonoBehaviour
    {
        [SerializeField] private Card cardPrefab;
        [SerializeField] private List<Card> deck;
        private string[] cardValue = new string[13] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        private int buttonPressed;
        public void OnButtonPress()
        {
            //Initialise a random card number and suit
            buttonPressed++;
            //Display the card
            Debug.Log("Card displayed");
        }
        void Start()
        {
            for(int i=0; i<4; i++)
            {
            }   
        }
    }    
}