using System;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();
        }
    }
}