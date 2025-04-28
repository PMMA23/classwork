namespace PlayingCard; 

public class PlayingCard
{
    /**********************************************
     * Data for the class - Instance data
     *
     * Instance data means every object has its own copy of the data
     **********************************************/

    private string suit;
    private string color;
    //                      Ace                 Jack, Queen, King
    private int value;   // 1,2,3,4,5,6,7,8,9,10,11,  12,    13
    
    public PlayingCard(string suitName, string theColor, int theValue)
        {
        suit  = suitName;
        color = theColor;
        value = theValue;
        }
    // Create a ToString method so we can use a playing card as a string 
    public override string ToString()
    {
        return $"Value: {value}, Suit: {suit}, Color: {color}";
    }
}