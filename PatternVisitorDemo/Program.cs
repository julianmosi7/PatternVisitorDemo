using ElementLib;
using System;
using System.Collections.Generic;
using System.Linq;
using VisitorLib;

List<Element> elements = CreateElements(10);
//LoopWithoutVisitors();
LoopWithVisitors();
Console.ReadLine();

List<Element> CreateElements(int nr)
{
  var elements = new List<Element>();
  for (int i = 0; i < nr; i++)
  {
    string name = $"Ele_{i}";
    if (i % 2 == 0) elements.Add(new ElementA { Name = name });
    else elements.Add(new ElementB { Name = name });
  }
  return elements;
}

void LoopWithoutVisitors()
{
  //int value = 0;
  //foreach (var item in elements)
  //{
  //  int val = item.OperationX();
  //  value += val;
  //}
  //Console.WriteLine($"OperationX: {value}");
  //Console.WriteLine("---------------------------------------------");

  //var names = new List<string>();
  //foreach (var item in elements)
  //{
  //  string s = item.OperationY();
  //  names.Add(s);
  //}
  //string result = string.Join(";", names);
  //Console.WriteLine($"OperationY: {result}");
}

void LoopWithVisitors()
{
    var visitorX = new VisitorX();
    foreach (var item in elements)
    {
        item.Accept(visitorX);
    }
    int value = visitorX.Value;
    Console.WriteLine($"OperationX: {value}");
    Console.WriteLine("---------------------------------------------");

    var visitorY = new VisitorY();
    elements.ForEach(x => x.Accept(visitorY));
    string result = visitorY.Result;
    Console.WriteLine($"OperationY: {result}");

    var visitorZ = new VisitorZ();
    elements.ForEach(x => x.Accept(visitorZ));
    Console.WriteLine($"OperationZ: {visitorZ.Sum}");
}

