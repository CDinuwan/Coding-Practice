using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    static class UsefullTools
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
    class Novel : Book//Novel Inherite from Books 
    {
        public override void ItMust()
        {
            Console.WriteLine("It is Inherited");
        }
    }
    class Book//Blue print
    {
        public string tittle;
        public string author;
        public int pages;
        private int bookNum;
        public static int yearCount=0;//static attributes belongs to the class

        public Book()//string tittle,string author,int pages,int bookNum)//Constuctor
        {
            this.tittle = tittle;
            this.author = author;
            this.pages = pages;
            this.bookNum = bookNum;
            yearCount++;
        }
        //If we want to call satatic attribute we should call that on method.
        public bool BigBook()//Method in Class
        {
            if(pages>=400)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Boring()
        {
            Console.Write("Boring");
        }
        public virtual void ItMust()
        {
            Console.WriteLine("Knowledgefull");
        }
        public int BookNum
        {
            get
            {
                return bookNum;
            }
            set
            {
                if (value == 1)
                {
                    bookNum = value;
                }
                else
                {
                    bookNum = 0;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Book b1 = new Book();//"Harry","Chanuka",123,90);
                                 //Book b2 = new Book("Load of the rings", "Dinuwan", 456,2);
                                 //Can not create object with static class

            //Console.WriteLine(b2.BigBook());

            //Console.WriteLine(b1.tittle+" "+b1.pages+" "+b1.author);
            //Console.WriteLine(Book.yearCount);

            //Console.WriteLine(b2.BookNum);


            Novel n1 = new Novel();
            n1.ItMust();
            b1.ItMust();

            Console.ReadLine();
        }
    }
}
