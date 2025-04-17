//Single inheritNCE example:
using System;
class Example{
    public void Display(){
        Console.WriteLine("Hello");
    }
}
class SingleInherit:Example{ //":" refers to Inheritance i.e like to inherit class
    public void Add(){
        Console.WriteLine("hii");
    }
    static void Main(string[] args){
        SingleInherit si=new SingleInherit();
        si.Display();
        si.Add();
    }
}