using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AngelaChau
{
    public enum CardSuit {Undefined, Spades, Clubs, Diamonds, Hearts}
    public class Card : MonoBehaviour
    {
        [SerializeField] private CardSuit chosenSuit = CardSuit.Undefined;
        [SerializeField] private string[] cardValue = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        private int buttonPressed;
        public void OnButtonPress()
        {
            //Initialise a random card number and suit
            buttonPressed++;
            //Display the card
            Debug.Log("Card displayed");
        }
    }    
}