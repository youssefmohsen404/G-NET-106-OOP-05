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
            #endregion
        }
    }
}
