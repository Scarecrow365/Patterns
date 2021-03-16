using System;
using UnityEngine;

namespace Decorator.Ex2
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            var book = new Book("qwe", "123", 5);
            book.Display();

            var disc = new Disc("qewq", "q23", 5, 2);
            disc.Display();

            var borrowable = new Borrowable(book);
            borrowable.BorrowItem("Customer 1");
            borrowable.BorrowItem("Customer 2");

            borrowable.Display();

            borrowable.ReturnItem("Customer 1");
        }
    }
}