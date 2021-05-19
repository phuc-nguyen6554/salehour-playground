using SalesHourTranslate.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesHourTranslate.Mocks
{
    public static class HourOfOperationMock
    {
        public static HourOfOperationData SaleHours = new HourOfOperationData
        {
            Monday = new HourOfOperation
            {
                Day = "Monday",
                OpenTime = DateTime.Parse("2021-04-26T01:33:00Z"),
                CloseTime = DateTime.Parse("2021-04-26T08:33:00Z")
            },
            Tuesday = new HourOfOperation
            {
                Day = "Tuesday",
                OpenTime = DateTime.Parse("2021-04-26T06:33:00Z"),
                CloseTime = DateTime.Parse("2021-04-26T18:33:00Z")
            },
            Wednesday = new HourOfOperation
            {
                Day = "Wednesday",
                OpenTime = DateTime.Parse("2021-04-26T09:33:00Z"),
                CloseTime = DateTime.Parse("2021-04-26T08:33:00Z")
            },
            Thursday = new HourOfOperation
            {
                Day = "Thursday",
                OpenTime = DateTime.Parse("2021-04-26T09:33:00Z"),
                CloseTime = DateTime.Parse("2021-04-26T08:33:00Z")
            },
            Friday = new HourOfOperation
            {
                Day = "Friday",
                OpenTime = DateTime.Parse("2021-04-26T09:33:00Z"),
                CloseTime = DateTime.Parse("2021-04-26T08:33:00Z")
            },
            Saturday = new HourOfOperation
            {
                Day = "Saturday",
                OpenTime = DateTime.Parse("2021-04-26T08:33:00Z"),
                CloseTime = DateTime.Parse("2021-04-26T11:33:00Z")
            },
            Sunday = new HourOfOperation
            {
                Day = "Sunday",
                OpenTime = DateTime.Parse("2021-04-26T08:33:00Z"),
                CloseTime = DateTime.Parse("2021-04-26T11:33:00Z")
            },
        };
    }
}
