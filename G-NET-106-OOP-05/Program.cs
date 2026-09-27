
using G_NET106_OOP_02.part2;
using G_NET106_OOP_03;

namespace G_NET_106_OOP_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Q1  Object Copying
            //a) What happens when you assign one object variable to another object variable?
            //when u assign one object variable to another u copy the reference of the object to the another object 
            // in the heap so ur not copying the object itself 

            //b) Does assigning one object to another create a new object? Explain.
            // not it is not creating another object it's just create a var that points to the same object in the heap

            //c) What is the difference between copying an object and copying its reference?
            //copying object : is copying the object with it's fields values and u get 2 objects here
            //copying it's reference : it just assigns the address of the object in the heap to the variable and 
            // u get one object here
            #endregion
            #region Q2  Shallow Copy vs Deep Copy
            //a) What is a Shallow Copy?
            //shallow  copy : is copying the object except reference types (copying top level fields)(it isn't copying fields that are arrays or objects)
            //a) What is a deep Copy?
            //deep copy: is copying the object with all fields the copy is independent so it's copy the nested objects and 
            // the arrays too
            //c) What happens to reference-type members when a Shallow Copy is created?
            // they are not duplicated only their references duplicate 
            //d) What happens to reference-type members when a Deep Copy is created?
            // they duplicate cause the deep copy creates an independent copy of the object
            //e) Give one situation where Deep Copy would be safer than Shallow Copy.
            // when u want to create a copier that copies any class whether it contains reference types or not
            // so when the copier start copying the shallow copy only copies the top statements fields and it will not 
            // duplicate the reference type fields on the other hand if the copier is a deep copy it will duplicate every
            //field in the class whether it is a top level statement or not cause deep copy creates an independent copy
            //of the object

            #endregion
            #region Q3  Static Members
            //a) What is a static field, and how is it different from an instance field?
            // u can access the static field by the class name on the other hand u access the instance field
            // by creating an object from the class using . operator
            // and the static filed only got 1 copy in the memory shared by every instance of the class it belongs to the class
            // instance field creates new object every time in the memory every time  u create an instance field  

            //b) What is a static method? Can a static method directly access instance members?
            // static methods belong to the class not any specific object u call it using class name 
            // no it can't access instance members and u cant use this keyword in the static functions , 
            // it can access static fields
            //c) What is a static constructor, and when is it executed?
            // it is a special type of constructors and it runs automatic once u create an instance from the class 
            // it used to initialize static fields  too 
            //it excutes when u  create an instance of the class once 
            //What is a static class? Can you create an object from a static class?
            // it is a class that contains only static members  , no u can't create an object from static class
            // we use it when creating utility or helper classes
            // u can't inherit it we can say it's sealed implicitly

            #endregion
            #region Q4  Extension Methods
            //a) What is an Extension Method?
            // lets u add a new functions to an exsisting types like Person class 
            // it is a static method in a static class and adding this keyword to the first parameter
            //b) What keyword must be used in the first parameter of an extension method?
            // this
            //c) Where must an extension method be declared?
            // inside a static class
            //d) Can an extension method access private members of the class it extends?
            // no it can't 

            #endregion
            #region Q5  Partial Classes and Partial Methods
            //a) What is a Partial Class?
            //a partial class is a class that let's u create the implementation of the class in multiple files 
            //same class with it's same name using partial key word in multiple files so it makes the huge implementations
            // readable and maintainable
            //b) Why would a developer split one class into multiple files?
            //cause it's good when the implementation of the class is so big so it improves readability
            // easy to maintain improves maintainability 
            // when a team works in the same class to avoid conflicts 

            //c) What is a Partial Method?
            //  is a method declaration without an implementation in the class it can implemented in another part  
            // every part must use partial keyword , with the same signature 
            //it is  implicitly private

            //d) What happens if a declared partial method has no implementation?
            // the compiler removes it as it is not called 

            #endregion
            #endregion
            #region Part 02 — Practical
            //object copy
            DeliveryAddress address = new DeliveryAddress("cairo" , "tahrir" , 10);
            Shipment shipment = new Shipment("Phone", 1, 40, address);
            
           Shipment shipment1 = shipment.CopyShipment();
            Console.WriteLine(shipment);
            Console.WriteLine();
            Console.WriteLine(shipment1);

            // after changing 
            shipment1.Weight = 5;
            
            Console.WriteLine();
            Console.WriteLine("after changing weight");
            Console.WriteLine(shipment);
            Console.WriteLine();
            Console.WriteLine(shipment1);
            //shallow copying 
            Console.WriteLine();
            Console.WriteLine("shallow copying ");
            Console.WriteLine("before editing address");
            Console.WriteLine(shipment);
            Console.WriteLine();
            Console.WriteLine(shipment1);
            Shipment shallow = shipment.ShallowCopying();
            Console.WriteLine();
            Console.WriteLine("after changing copied  address street");
            shallow.destination.street = "syria";
            Console.WriteLine();
            Console.WriteLine(shipment);
            Console.WriteLine();
            Console.WriteLine(shallow);
            Console.WriteLine();
            //deep copy
            Console.WriteLine("address before changing in deep copy ");
            Shipment deepCopy = shipment.DeepCopy();
            Console.WriteLine();
            Console.WriteLine(shipment);
            Console.WriteLine();
            Console.WriteLine(deepCopy);
            Console.WriteLine("after changing street in deep copy");
            deepCopy.destination.street = "el gesh road";

            Console.WriteLine();
            Console.WriteLine(shipment);
            Console.WriteLine();
            Console.WriteLine(deepCopy);
            Console.WriteLine();
            // static 
            Console.WriteLine("static");
            Console.WriteLine(Shipment.TotalShipmentsCreated);
            // 3 / 1- shipment 2- object copy -3 deep copy
            Console.WriteLine();
            // static method 
            Console.WriteLine($"total shipment created : {Shipment.TotalShipmentsCreated}");
            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle();

            DeliveryUtilities.PrintSeparator();
            //extension methods
            shipment.GetSummary();
            shipment.IsDelivered();
            // partial methods
            DeliveryUtilities.PrintSeparator() ;
            shipment.UpdateTrackingStatus("Out For Delivery");

            #endregion
        }
    }
}
