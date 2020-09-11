//  ---------------------------------------------------------------------------
//  Author:     Marc Ochsenmeier
//  Email:      info@winssential.net
//  Web:        www.winssential.net
//  Project:    "Performance Counters Enumerator" for www.codeproject.com
//
//  Date        11.Feb.2010
//  ---------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//  Integrate the Performance counters class.
using System.Diagnostics;
namespace Performance_Counters_Enumerator
{
    class CPerformanceCountersManager
    {
        PerformanceCounterCategory[] categories = null;
        PerformanceCounter[] counters = null;
        string machine = "";

        public PerformanceCounterCategory[] Categories
        {
            get
            {
                return categories;
            }
        }

        public PerformanceCounter[] Counters
        {
            get
            {
                return counters;
            }
        }
        public void GetPerformanceCountersCategories(string machine)
        {
            try
            {
                this.machine = machine;

                categories = null;
                categories = PerformanceCounterCategory.GetCategories(machine);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get categories on " + machine);
                Console.WriteLine(ex.Message);
                categories = null;
            }
        }

        public PerformanceCounter[] GetPerformanceCounters(PerformanceCounterCategory category)
        {
            try
            {
                counters = null;

                PerformanceCounterCategoryType type = category.CategoryType;
                if (type == PerformanceCounterCategoryType.SingleInstance)
                {
                    counters = category.GetCounters();
                    //for (int i = 0; i < counters.Length; i++)
                    //{
                    //    Console.WriteLine("{0,4} - {1}", i + 1, counters[i].CounterName);
                    //}
                }
                
                if (type == PerformanceCounterCategoryType.MultiInstance)
                {
                    string[] instances = category.GetInstanceNames();
                    
                    for (int i = 0; i < instances.Length; i++)
                    {
                        //Console.WriteLine("{0,4} - {1}", i + 1, instances[i].ToString());
                        counters = category.GetCounters(instances[i].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get categories on " + machine);
                Console.WriteLine(ex.Message);
                counters = null;
            }
            return counters;
        }
    };
}
