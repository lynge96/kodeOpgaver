using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Coin
/// </summary>
public class Coin
{
    // a private variable (member) to hold the coin's present value
    // 1 = Heads, 0 = Tails
    private Int32 _side;

    public Coin()
    {
        // the constructor will make certain that _side has a value,
        // as a coin must be either Heads or Tails
        Throw();
    }

    public string Throw()
    {
        // initiating a Random-object
        Random rand = new Random();

        // The Next-method of a Random-object returns a random number >= 0 and < the method's parameter
        // (we call the method with the value 2, i.e. the return value will be 0 or 1
        _side = rand.Next(2);
        if (_side == 1)
            return "Heads";
        else
            return "Tails";
    }
}
