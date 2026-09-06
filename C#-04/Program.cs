namespace C__04
{
    internal class Program
    {
        #region q3
        //static void PrintWelcomeMessage()
        //{
        //    Console.WriteLine("Welcome to the Library!");
        //}
        #endregion
        #region q4
        //static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine($"Book title : {title}");
        //}
        #endregion
        #region q5 
        //static void AddBonusPages(int pages)
        //{
        //    pages = pages + 50 ;

        //}
        #endregion
        #region q6 
        //static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] -= 5;
        //}
        #endregion
        #region q7 
        //static void AddBonusPages(ref int pages)
        //{
        //    pages = pages + 50;
        //}
        #endregion
        static void Main(string[] args)
        {
            #region q1 
            //double[] price = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(price[1]); 
            #endregion
            #region q2 
            //int[,] a = { { 3 , 5 } ,
            //    { 1 , 4 } };
            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    Console.Write($"copies on  shelf {i}:");
            //    for (int j = 0;  j < a.GetLength(1); j++)
            //    {
            //        Console.Write($" {a[i , j]}  ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region q3
            //PrintWelcomeMessage();
            #endregion
            #region q4 
            //string title = "Clean Code";
            //PrintBookTitle(title);
            #endregion
            #region q5 
            //int Pages = 400;
            //AddBonusPages(Pages);
            //Console.Write(Pages);
            //// i expect to see 400 , cuz we did use passing by value - value type "copy of the value ".
            #endregion
            #region q6 
            //double[] prices = { 25.5, 40.0 };
            //Console.WriteLine($"before : {prices[0]}");
            //ApplyDiscount(prices);
            //Console.WriteLine($"after : {prices[0]}");
            //Console.WriteLine($"after : {prices[0]}");

            ////i expect to see 20.5 , cuz we did use passing by value - reference type "copy of the referece ".
            #endregion
            #region q7 
            //int pages = 400;
            //AddBonusPages(ref pages);
            //Console.WriteLine(pages);
            ////it is diff cuz here we did use passing by reference - value type 
            #endregion


        }
    }
}
