using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {
        // 1) declare enum ComputerType


        // 2) declare struct Computer
        enum ComputerType
        {
          desktop
        , laptop
        , tablet
        , server
                }


        struct Computer
        {
            public string Name;
            public int ComputerTypes;
            public float CpuFreq;
            public int HddStorage;
            public int Memory;

        }

        static void Main(string[] args)
        {


            // 3) declare jagged array of computers size 4 (4 departments)
            Computer[][] jagged = new Computer[4][];
            Random rnd = new Random();
            Computer[] jj;
            int vv = 0;
            // 4) set the size of every array in jagged array (number of computers)
            // 5) initialize array
            // Note: use loops and if-else statements
            for (int i = 0; i < jagged.Length; i++)
            {
                jj = new Computer[i + 2];

                for (int j = 0; j < jj.Length; j++)
                {
                    jj[j] = new Computer() {
                        Name = "com_" + (i + 1).ToString() + "_" + (j + 1).ToString()
                        , ComputerTypes = rnd.Next(4)
                        , HddStorage = rnd.Next(500,1000)
                        , Memory = rnd.Next(4,16)
                        , CpuFreq = rnd.Next(0, 5) + (float)0.5
                    };
                }
                jagged[i] = jj;
            }



            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {

                    int value = jagged[i][j].ComputerTypes;
                    ComputerType dt = (ComputerType)value;
                    string compDesc = jagged[i][j].Name + "(" + dt.ToString()
                                                        + "/ cpu:" + jagged[i][j].CpuFreq.ToString()
                                                        + "/ memory:" + jagged[i][j].Memory.ToString()
                                                        + "/ hdd:" + jagged[i][j].HddStorage.ToString()
                                                        + ")";

                    Console.WriteLine(compDesc);
                    //  Console.Write(" | ");
                }

                //  Console.Write("\n");
            }
            Console.Write("\n");

            // 6) count total number of every type of computers
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)
            int s0 = 0, s1 = 0, s2 = 0, s3 = 0, s_all = 0;
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {

                    switch (jagged[i][j].ComputerTypes)
                    {
                        case 0:
                            s0++;
                            break;
                        case 1:
                            s1++;
                            break;
                        case 2:
                            s2++;
                            break;
                        case 3:
                            s3++;
                            break;

                    }
                    s_all++;
                }
            }

            Console.WriteLine("desktop = " + s0.ToString());
            Console.WriteLine("laptop = " + s1.ToString());
            Console.WriteLine("tablet = " + s2.ToString());
            Console.WriteLine("server = " + s3.ToString());
            Console.WriteLine("all = " + s_all.ToString());

            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            int mi = -1;
            int mj = -1;
            int maxStorage = 0;
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    if (jagged[i][j].HddStorage > maxStorage)
                    {
                        maxStorage = jagged[i][j].HddStorage;
                        mi = i;
                        mj = j;
                    }
                }
            }
            if (mi >= 0 && mj >= 0)
            {
                int value = jagged[mi][mi].ComputerTypes;
                ComputerType dt = (ComputerType)value;
                string compDesc = jagged[mi][mj].Name + "(" + dt.ToString()
                                                    + "/ cpu:" + jagged[mi][mj].CpuFreq.ToString()
                                                    + "/ memory:" + jagged[mi][mj].Memory.ToString()
                                                    + "/ hdd:" + jagged[mi][mj].HddStorage.ToString()
                                                    + ") position i:" + mi.ToString() + ",j:" + mj.ToString();
                Console.WriteLine("Computer with the largest storage (HDD):");
                Console.WriteLine(compDesc);
            }
                else
            {
                Console.WriteLine("Error");
            }

            Console.WriteLine("\n");
            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions
            // 
            mi = -1;
            mj = -1;
            int minMem = int.MaxValue;
            float minCPU = float.MaxValue;
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    //if (jagged[i][j].Memory < minMem || jagged[i][j].CpuFreq < minCPU)
                    if (jagged[i][j].CpuFreq < minCPU)
                    {
                        minCPU = jagged[i][j].CpuFreq;
                        //minMem = jagged[i][j].Memory;
                        //mi = i;
                        //mj = j; 
                    }
                }
            }
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    //if (jagged[i][j].Memory < minMem || jagged[i][j].CpuFreq < minCPU)
                    if (jagged[i][j].Memory < minMem && jagged[i][j].CpuFreq == minCPU )
                    {
                        minMem = jagged[i][j].Memory;
                        mi = i;
                        mj = j;
                    }
                }
            }




            if (mi >= 0 && mj >= 0)
            {
                int value = jagged[mi][mi].ComputerTypes;
                ComputerType dt = (ComputerType)value;
                string compDesc = jagged[mi][mj].Name + "(" + dt.ToString()
                                                    + "/ cpu:" + jagged[mi][mj].CpuFreq.ToString()
                                                    + "/ memory:" + jagged[mi][mj].Memory.ToString()
                                                    + "/ hdd:" + jagged[mi][mj].HddStorage.ToString()
                                                    + ") position i:" + mi.ToString() + ",j:" + mj.ToString();
                Console.WriteLine("Computer with the lowest productivity (CPU and memory):");
                Console.WriteLine(compDesc);
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.WriteLine("\n");

            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements

        

            bool notFind = true;

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    ComputerType computerType = (ComputerType)jagged[i][j].ComputerTypes;   
                    string computerTypeS = computerType.ToString();

                    if (jagged[i][j].Memory < 8)
                    {
                        if (computerTypeS == "desktop")
                        {
                            if (notFind) 
                            {
                             Console.WriteLine("Changed (desktop up memory to 8)");
                            }
                            notFind = false;
                            jagged[i][j].Memory = 8;

                            string compDesc = jagged[i][j].Name + "(" + computerTypeS
                                                                + "/ cpu:" + jagged[i][j].CpuFreq.ToString()
                                                                + "/ memory:" + jagged[i][j].Memory.ToString()
                                                                + "/ hdd:" + jagged[i][j].HddStorage.ToString()
                                                                + ")";

                            Console.WriteLine(compDesc);
                        }
                    }


                }
            }





            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    for (int j = 0; j < jagged[i].Length; j++)
            //    {

            //        int value = jagged[i][j].ComputerTypes;
            //        ComputerType dt = (ComputerType)value;
            //        string compDesc = jagged[i][j].Name + "(" + dt.ToString()
            //                                            + "/ cpu:" + jagged[i][j].CpuFreq.ToString()
            //                                            + "/ memory:" + jagged[i][j].Memory.ToString()
            //                                            + "/ hdd:" + jagged[i][j].HddStorage.ToString()
            //                                            + ")";

            //        Console.WriteLine(compDesc);
            //        //  Console.Write(" | ");
            //    }

            //    //  Console.Write("\n");
            //}


            Console.ReadKey();

        }


       










        
 
    }
}
