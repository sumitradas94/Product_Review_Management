﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ProductReviewManagement
{
    public class Datatable
    {
        public static void Main(string[] args)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID");
            table.Columns.Add("UserID");
            table.Columns.Add("Rating");
            table.Columns.Add("Review");
            table.Columns.Add("isLike");

            table.Rows.Add(5, 8, 4, "Good", true);
            table.Rows.Add(4, 2, 2, "Bad", false);
            table.Rows.Add(33, 10, 5, "Good", true);
            table.Rows.Add(5, 3, 2, "Bad", false);
            table.Rows.Add(12, 1, 3, "Nice", true);
            table.Rows.Add(6, 10, 4, "Good", true);
            table.Rows.Add(11, 2, 5, "Good", true);
            table.Rows.Add(9, 4, 3, "Nice", true);
            table.Rows.Add(3, 7, 4, "Good", true);
            table.Rows.Add(2, 10, 1, "Bad", false);
            table.Rows.Add(5, 3, 5, "Good", true);
            table.Rows.Add(1, 1, 4, "Good", true);
            table.Rows.Add(4, 10, 2, "Bad", false);
            table.Rows.Add(3, 9, 5, "Good", true);
            table.Rows.Add(5, 3, 2, "Bad", false);
            table.Rows.Add(1, 1, 3, "Nice", true);
            table.Rows.Add(6, 6, 4, "Good", true);
            table.Rows.Add(11, 2, 5, "Good", true);
            table.Rows.Add(9, 4, 3, "Nice", true);
            table.Rows.Add(3, 7, 4, "Good", true);
            table.Rows.Add(2, 10, 1, "Bad", false);
            table.Rows.Add(5, 3, 5, "Good", true);
            table.Rows.Add(9, 10, 4, "Good", true);
            table.Rows.Add(1, 1, 4, "Good", true);
            table.Rows.Add(5, 2, 2, "Bad", false);

            Display(table);
        }
        public static void Display(DataTable data)
        {
            var Records = from pd in data.AsEnumerable()
                          select new
                          {
                              productid = pd.Field<string>("ProductID"),
                              userid = pd.Field<string>("UserID"),
                              rating = pd.Field<string>("Rating"),
                              review = pd.Field<string>("Review"),
                              islike = pd.Field<string>("isLike")
                          };

            foreach (var element in Records)
            {
                if (element.userid == "10")
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}