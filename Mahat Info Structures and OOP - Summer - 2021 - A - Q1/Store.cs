using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mahat_Info_Structures_and_OOP___Summer___2021___A___Q1
{
        internal class Store
        {
            private Tablet[] tablets;
            private int[] systems;

            public Store()
            {
                tablets = new Tablet[1000];
                systems = new int[3];
            }


        public bool AddTablet(Tablet tab)
        {
            for (int i = 0; i < tablets.Length; i++)
            {
                if (tablets[i] == null)
                {
                    if (i == tablets.Length - 1)
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (tablets[i].IsSame(tab))
                {
                    tablets[i].Price = Math.Max(tablets[i].Price, tab.Price);
                    return true;
                }
            }

            for (int i = 0; i < tablets.Length; i++)
            {
                if (tablets[i] == null)
                {
                    tablets[i] = tab;
                    if (tab.Kind[0] == 'I')
                    {
                        systems[2]++;
                    }
                    else if (tab.Kind[0] == 'A')
                    {
                        systems[1]++;
                    }
                    else if (tab.Kind[0] == 'W')
                    {
                        systems[0]++;
                    }
                    return true;
                }
            }
            return false;
        }



        public int SortStore()
        {
            int count = 0;

            // Count the number of non-null items in the array
            for (int i = 0; i < tablets.Length; i++)
            {
                if (tablets[i] != null)
                {
                    count++;
                }
            }

            // Sort the array based on the System property
            Array.Sort(tablets, 0, count, new TabletComparer());

            return count;
        }

        private class TabletComparer : IComparer<Tablet>
        {
            public int Compare(Tablet x, Tablet y)
            {
                if (x.System == y.System)
                {
                    return 0;
                }
                else if (x.System == 'W')
                {
                    return -1;
                }
                else if (x.System == 'A' && y.System == 'I')
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }




    }

}
