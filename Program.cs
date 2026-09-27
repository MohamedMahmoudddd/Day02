using System;


using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

using day02;
using static day02.ListGenerators;
using static day02.Customer;
using static day02.Product;
using static day02.Order;
using System.Net.WebSockets;
namespace day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // use Restriction
            #region pro 1
            //var result = ProductList.Where(p => p.UnitsInStock == 0);
            //foreach(var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}
            #endregion

            #region pro 2
            //var result = ProductList.Where((p) => p.UnitsInStock > 0 && p.UnitPrice > 3);

            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}
            #endregion

            #region pro 3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where((P, I) => P.Length <I);
            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}
            #endregion

            //Element Operator
            #region pro 1
            //var result = ProductList.First((P)=>P.UnitsInStock==0);
            //Console.WriteLine(result);
            #endregion

            #region pro 2
            //var result = ProductList.FirstOrDefault((P) => P.UnitPrice>1000);

            //Console.WriteLine(result?.ProductName??"Nu");
            #endregion

            #region pro 3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(P => P > 5).Skip(1).First();
            //Console.WriteLine(result);
            #endregion

            // Aggregate
            #region pro 1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(P => P % 2 == 1);
            //Console.WriteLine(result);
            #endregion

            #region pro2
            //var result = CustomerList.Select(C =>new { C.Name,C.Orders});
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region pro 3
            //var result = ProductList.GroupBy(P => P.Category).Select(G => new { G.Key, Count=G.Count() });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region pro 4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);
            #endregion

            #region pro 5
            //string[] words = File.ReadAllLines("dictinary_english.txt");
            //var result = words.Sum(x => x.Length);
            //Console.WriteLine(result);
            #endregion

            //Ordering Operators
            #region pro 1
            //var result = ProductList.OrderBy(P => P.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region pr02
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" }; 

            //var result = Arr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region pro 3
            //var result = ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}
            #endregion

            #region pro4
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.OrderBy(x => x.Length).ThenBy(p=>p);
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region pro5
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.OrderBy(x => x.Length).ThenBy(b =>b.ToLower() );
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region pro 6
            //var result = ProductList.OrderBy(P => P.Category).ThenByDescending(C => C.UnitPrice);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region pro 7
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(x => x.Length).ThenByDescending(P=>P.ToLower());
            #endregion

            #region pro 8
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where(P => P[1]== 'i').Reverse();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            // ListGen
            #region pro 1
            //var result = ProductList.Select(x => x.ProductName);
            #endregion

            #region pro 2
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.Select(P=>new {Lower =P.ToLower(),Upper=P.ToUpper()});
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region pro3
            //var result = ProductList.Select(P => new
            //{
            //    P.ProductName,
            //    P.ProductID,
            //    price = P.UnitPrice
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region pro 4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((P, I) => new
            //{
            //    x=(P==I)
            //});
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region pro 5
            //Ai
            //    int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //    int[] numbersB = { 1, 3, 5, 7, 8 };

            //    var result = numbersA.SelectMany(
            //    a => numbersB.Where(b => b < a),
            //    (a, b) => new { A = a, B = b }
            //    );
            //}
            #endregion

            #region pro 6
            //var result = CustomerList.SelectMany(C => C.Orders).Where(P =>P.Total < 500);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region pro 7
            //var result = CustomerList.SelectMany(P => P.Orders).Where(O => O.OrderDate.Year >=1998);
            #endregion

            //Aggregate 
            #region pro1
            // int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            // var result = Arr.Count(P => P % 2 == 1);
            //Console.WriteLine(result);
            #endregion

            // Partioning
            #region pro 1
            //var result = CustomerList.Where(c => c.City == "Washington")
            //             .SelectMany(c => c.Orders)
            //             .Take(3);
            //foreach (var order in result)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion

            #region pro2
            //var result = CustomerList.Where(C => C.City == "Washington").SelectMany(P => P.Orders).Skip(2);
            #endregion

            #region pro3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.TakeWhile((P, I) =>  P >= I);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region pro 4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.SkipWhile((P) => P %3!=0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region pro 5
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.SkipWhile((P,I) => P >=I);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            //Quantifiers
            #region pro2
            //var result = ProductList.GroupBy(p => p.Category)
            //            .Where(g => g.Any(p => p.UnitsInStock == 0));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region pro 3
            //var result = ProductList.GroupBy(p => p.Category)
            //            .Where(g => g.All(p => p.UnitsInStock > 0));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

        }

    }
}
