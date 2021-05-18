using SalesHourTranslate.Mocks;
using SalesHourTranslate.Model;
using System;
using System.Collections.Generic;

namespace SalesHourTranslate
{
    class Program
    {
        private static List<TranslateModel> TranslateDataList = new List<TranslateModel>();
        static void Main(string[] args)
        {
            var saleHour = HourOfOperationMock.SaleHours;
            ProgressHour(saleHour);
            Console.WriteLine(ShowHour(TranslateDataList));
        }

        static string ShowHour(List<TranslateModel> data)
        {
            var str = "";

            foreach(var item in data)
            {
                str += $"From {item.Start.Day} to {item.End.Day} {item.Start.OpenTime.Value.ToShortTimeString()} {item.Start.CloseTime.Value.ToShortTimeString()}";
            }

            return str;
        }

        static void ProgressHour(HourOfOperationData data)
        {
            var days = data.GetType().GetProperties();

            TranslateModel translateData = new TranslateModel();

            TranslateDataList.Add(translateData);

            HourOfOperation firstDay = null;

            var index = 0;

            foreach (var day in days)
            {
                // Find the first day is not null 
                if(firstDay == null && day.GetValue(data) != null)
                {
                    firstDay = (HourOfOperation)day.GetValue(data);
                    TranslateDataList[index].Start = firstDay;
                }
                else
                {
                    var secondDay = (HourOfOperation)day.GetValue(data);

                    if(secondDay.OpenTime.Equals(firstDay.OpenTime) && secondDay.CloseTime.Equals(firstDay.CloseTime))
                    {
                        TranslateDataList[index].End = secondDay;
                    }
                    else
                    {
                        //TranslateDataList.Add(translateData);

                        translateData = new TranslateModel();
                        TranslateDataList.Add(translateData);
                        index += 1;
                        firstDay = null;
                    }
                }

            }
        }
    }
}
