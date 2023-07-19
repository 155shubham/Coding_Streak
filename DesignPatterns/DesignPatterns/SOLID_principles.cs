using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class SOLID_principles
    {
    }


    abstract class Bird 
    {
        //public abstract void fly();
        public abstract void eat();
    }

    abstract class IFly
    {
        public abstract void fly();
        //public abstract void glide();
    }

    abstract class IGlide // abstractions
    {
        public abstract void glide();
    }

    //abstract class IGlide
    //{
    //    public abstract void flyHigh();
    //}

    class Bird1 : Bird
    {
        public override void eat()
        {
            throw new NotImplementedException();
        }
    class Bird2 : Bird
    {
        public override void eat()
        {
            Console.WriteLine("Bird2 fly");
        }
    }

    class Bird3 : Bird, IFly // lowlevel
    {
        public override void eat()
        {
            // main implementation
        }

        public override void fly()
        {
            throw new NotImplementedException();
        }
    }
        //DIP:
        // high level should not depend on low level implementation
        // high level should  depend on abstraction
    //class client 
    //{
    //    Bird1 b1 = new Bird1();
    //    Bird2 b2 = new Bird2();
    //    Bird3 b3 = new Bird3();
    //}

    class client
    {
            public client()// Autofac
            {
                
            }

            Bird1 b1 = new Bird1();
        Bird2 b2 = new Bird2();
        Bird3 b3 = new Bird3();
    }
    }
