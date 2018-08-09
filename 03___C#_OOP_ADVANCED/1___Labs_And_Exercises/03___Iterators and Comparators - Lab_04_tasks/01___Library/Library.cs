﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Library:IEnumerable<Book>
{
    private List<Book> books;
    public Library(params Book[] books)
    {
        this.books = new List<Book>(books);
    }

    public IEnumerator<Book> GetEnumerator()
    {
       return new LibraryIterator(books);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    private class LibraryIterator : IEnumerator<Book>
    {
        

        private IReadOnlyList<Book> books;
        private int index;
        public LibraryIterator(IReadOnlyList<Book> books)
        {
            this.books = books;
            this.index = -1;
        }
        public Book Current => books[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            index++;
            return index < books?.Count;
        }

        public void Reset()
        {
            throw new NotSupportedException();
        }
    }
}

