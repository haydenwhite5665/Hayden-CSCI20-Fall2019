using System;
class MainClass 
{
  public static void Main (string[] args) {  
      double deducted,centsback,dollars;
      string total,taxedtotal;

      //total amount of coins is 315 cents worth 

    
      //tax= 10.9;
      centsback= 315%100;
      deducted=(315/10.9);
      dollars= (315/100);
      total= (dollars + " and " + centsback);
      taxedtotal= (total-deducted )
      Console.WriteLine(total);
      Console.WriteLine ("You shall receive "+ total +" cents back");
      Console.WriteLine (deducted +" Will be deducted for using the ultimate CoinStar");

  
  }
}