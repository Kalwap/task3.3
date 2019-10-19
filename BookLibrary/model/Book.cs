using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary
{
    public class Book
    {
        //attribiutes
        private string _title;
        private string _author;
        private int _pagenum;
        private string _lsbn13;

        //properties

        public string Title
        {
            get { return _title; }

            //condition
            set

            {
                if (value.Length >= 2)
                    _title = value;
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }


        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int PageNum
        {

            get { return _pagenum; }

            //condition
            set
            {
                if (value > 10 && value < 1000)
                    _pagenum = value;
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }


        }

        public string Lsbn13
        {
            get { return _lsbn13; }

            //condition
            set
            {
                if (value.Length == 13)
                    _lsbn13 = value;
                else
                {
                    throw new ArgumentOutOfRangeException();

                }
            }



        }

        //constructor


        public Book(string title, string author, int pagenum, string lsbn13)
        {
            Title = title;
            Author = author;
            PageNum = pagenum;
            Lsbn13 = lsbn13;
            
        }

        //json book constuctor
        public Book()
         {

         }

        //ovveride to string 
        public override string ToString()
        {
            return base.ToString();
        }



    }


}
