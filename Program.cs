using System;
using Demo;

namespace session1_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            #region question1
            //var products = ListGenerator.ProductList;
            //var result = from x in products where x.UnitsInStock == 0 select x;
            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region Question2
            //var products = ListGenerator.ProductList;
            //var result = from x in products where x.UnitsInStock != 0 && x.UnitPrice>3.00m select x;
            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region Question3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where((value,index)=>value.Length < index);
            //foreach (var item in result)
            //{ 
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
            #region MyRegion
            //var products = ListGenerator.ProductList;
            //var customer = ListGenerator.CustomerList;
            #region Question1

            //var result = from product in products select product.ProductName;
            //foreach (var item in result) 
            //{ 
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Question2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(word => new
            //{
            //    lower = word.ToLower(),
            //    upper = word.ToUpper(),
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.upper);
            //    Console.WriteLine(item.lower);

            //}

            #endregion
            #region question3
            //var result = products.Select(x => new { x.ProductName, x.ProductID, price=x.UnitPrice,});
            //foreach (var item in result) { Console.WriteLine(item); }
            #endregion
            #region question4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var re = Arr.Select((num, Index) => new
            //{
            //    Num = num,
            //    valid = num.Equals(Index)
            //});
            ////var result= Arr.Where((value,index)=> value.Equals(index)) .ToList();

            //foreach (var item in re)
            //{ 
            //   Console.WriteLine($"{item.Num}: {item.valid}");
            //}


            #endregion
            #region question5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select (a, b);

            //foreach (var pair in result)
            //{
            //    Console.WriteLine($"({pair.a}, {pair.b})");
            //}
            #endregion
            #region question6
            //var result = customer.SelectMany(c=>c.Orders).Where(c=>c.Total<500);
            //foreach (var item in result) {
            //    Console.WriteLine(item);
            //}
            #endregion
            #region question7
            //var result = customer.SelectMany(c => c.Orders).Where(c => c.OrderDate.Year>=1998);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion


        }
    }
}
