using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;

namespace process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
          

            Process[] processCollection = Process.GetProcesses();
            dataGridView1.DataSource = processCollection.ToList();



        }

        private void button2_Click(object sender, EventArgs e)
        {   ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            string strID = null;
            foreach (ManagementObject mo in moc)
            {
                strID = mo.Properties["NumberOfLogicalProcessors"].Value.ToString();
                //  break;
            }

            MessageBox.Show("Total Number of CPUs " + strID);
            int a = Int16.Parse(strID);
            for (int i = 0; i <a; i++)
            {
                MessageBox.Show("CPU" + i);
               
            }
           
        }


        #region trycode



        //            textBox2.Text += "CPU ID:" + strID;




        //            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_Processor");

        //            foreach (ManagementObject obj in myVideoObject.Get())
        //            {
        //              //  object[] ass = new object[];

        //               // MessageBox.Show("Name  -  " + obj["ProcessorCount"]);
        //                MessageBox.Show("Status  -  " + obj["Name"]);
        //                MessageBox.Show("Caption  -  " + obj["NumberOfLogicalProcessors"]);
        //                MessageBox.Show("DeviceID  -  " + obj["DeviceID"]);
        //                MessageBox.Show("AdapterRAM  -  " + obj["ProcessorId"]);
        //                MessageBox.Show("AdapterDACType  -  " + obj["UniqueId"]);

        //            }



        //           // ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_Processor");
        //List<object> list = new List<object>();
        //            foreach (ManagementObject obj in myVideoObject.Get())
        //            {



        //                //list.Add(obj["ProcessorCount"]);
        //                list.Add(obj["Name"]);
        //                list.Add(obj["NumberOfLogicalProcessors"]);
        //                list.Add(obj["DeviceID"]);
        //                list.Add(obj["ProcessorId"]);
        //                list.Add(obj["UniqueId"]);

        //            }
        //            dataGridView1.DataSource = list;

        //            var procs = Process.GetProcesses();
        //            var found = false;
        //            foreach (var proc in procs)
        //            {
        //                if ("chrome" == proc.ProcessName)
        //                {
        //                    found = true;
        //                    break;
        //                }
        //            }
        //            //Console.WriteLine(found ? "run" : "nothing");

        //        }
        //        //System.Diagnostics.Process.GetCurrentProcess().ProcessorAffinity = (System.IntPtr)1;
        //        //System.Diagnostics.Process.GetCurrentProcess().ProcessorAffinity = (System.IntPtr)2;
        //        //System.Diagnostics.Process.GetCurrentProcess().ProcessorAffinity = (System.IntPtr)3;
        //        //System.Diagnostics.Process.GetCurrentProcess().ProcessorAffinity = (System.IntPtr)4;






        ////int a = Environment.ProcessorCount;





        //            //foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_ComputerSystem").Get())
        //            //{
        //            //    List<object> aba = new List<object>();
        //            //   int.Parse(item["NumberOfProcessors"].ToString()));
        //            //    aba.Add(item["NumberOfLogicalProcessors"]);

        //            //  ///  MessageBox.Show("Number Of Logical Processors: {0}", item["NumberOfLogicalProcessors"]);
        //            //}


        //            //ManagementObjectSearcher mgtObj = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_ComputerSystem");
        //            //foreach (ManagementObject item in mgtObj.Get())
        //            //{ List<object> aba = new List<object>();
        //            //   aba.Add(item["NumberOfProcessors"]);

        //            //    MessageBox.Show(aba.ToString());


        //            //}
        //            //ManagementObjectSearcher mgtObj = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_ComputerSystem");   // Win32_OPeratingSystem");
        //            //ManagementObjectCollection mgtColl = mgtObj.Get();

        //            //// foreach (ManagementObject obj in  mgtObj.Get())
        //            //if (mgtColl.Count != 0)
        //            //{
        //            //    foreach (ManagementBaseObject mgtBaseObj in mgtColl)
        //            //    {
        //            //        int [] data = mgtBaseObj["NumberOfProcessors"] as int[];

        //            //        if (data != null)
        //            //        {
        //            //            MessageBox.Show(data.ToString());
        //            //        }
        //            //    }
        //            //}

        //            //// Start the process.
        //            //using (Process myProcess = Process.Start("NotePad.exe"))
        //            //{
        //            //    // Display the process statistics until
        //            //    // the user closes the program.
        //            //    do
        //            //    {
        //            //        if (!myProcess.HasExited)
        //            //        {
        //            //            // Refresh the current process property values.
        //            //            myProcess.Refresh();

        //            //            Console.WriteLine();

        //            //            // Display current process statistics.

        //            //            //Console.WriteLine($"{myProcess} -");
        //            //            //Console.WriteLine("-------------------------------------");

        //            //            //Console.WriteLine($"  Physical memory usage     : {myProcess.WorkingSet64}");
        //            //            var  ab = myProcess.BasePriority;




        //            //            var cc = myProcess.PriorityClass;
        //            //            var p = Process.GetCurrentProcess().SessionId;


        //            //            //Console.WriteLine($"  User processor time       : {myProcess.UserProcessorTime}");
        //            //            //Console.WriteLine($"  Privileged processor time : {myProcess.PrivilegedProcessorTime}");
        //            //            //Console.WriteLine($"  Total processor time      : {myProcess.TotalProcessorTime}");
        //            //            //Console.WriteLine($"  Paged system memory size  : {myProcess.PagedSystemMemorySize64}");
        //            //            //Console.WriteLine($"  Paged memory size         : {myProcess.PagedMemorySize64}");

        //            //            // Update the values for the overall peak memory statistics.


        //            //            if (myProcess.Responding)
        //            //            {
        //            //                Console.WriteLine("Status = Running");
        //            //            }
        //            //            else
        //            //            {
        //            //                Console.WriteLine("Status = Not Responding");
        //            //            }
        //            //        }
        //            //    }
        //            //    while (!myProcess.WaitForExit(1000));

        //            //    Console.WriteLine();
        //            //    Console.WriteLine($"  Process exit code          : {myProcess.ExitCode}");

        //            //    // Display peak memory statistics for the process.

        //            //}



        //            //SelectQuery Sq = new SelectQuery("Win32_Processor");
        //            //ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(Sq);
        //            //ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
        //            //StringBuilder sb = new StringBuilder();





        //            //ManagementClass managClass = new ManagementClass("win32_processor");
        //            //ManagementObjectCollection managCollec = managClass.GetInstances();

        //            //foreach (ManagementObject managObj in managCollec)
        //            //{
        //            //  string  cpuInfo = managObj.Properties["processorID"].Value.ToString();
        //            //    MessageBox.Show(cpuInfo);
        //   // break;
        //}



        //int cpuCount = Environment.ProcessorCount;
        //MessageBox.Show(cpuCount.ToString());
        //ManagementObjectSearcher mo = new ManagementObjectSearcher("select * from Win32_Processor");



        //foreach (ManagementObject mob in mo.Get())

        //{

        ////    dataGridView2.DataSource = mob["ProcessorId"].ToString();

        //    listBox1.Items.Add(mob["ProcessorId"].ToString()+ Environment.NewLine);



        #endregion

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnset_Click(object sender, EventArgs e) {
            #region code
            //var procs = Process.GetProcesses();
            //////var found = false;
            //////foreach (var proc in procs)
            //////{
            //////    if ("chrome" == proc.ProcessName)
            //////    {
            //////        found = true;
            //////        break; 

            //////    }
            //////  //  MessageBox.Show($"ProcessorAffinity: { proc.ProcessName}");
            //////}

            ////MessageBox.Show(found ? "run" : "nothing");
            #endregion
            if (checkBox1.Checked && checkBox3.Checked && !checkBox4.Checked && !checkBox2.Checked)
            { Process myProcess = Process.Start("NotePad.exe");
               
                myProcess.ProcessorAffinity = (System.IntPtr)5;
                MessageBox.Show(myProcess.ProcessorAffinity.ToString());
              

            }
            if (checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked)
            { Process myProcess = Process.Start("NotePad.exe");
             

                myProcess.ProcessorAffinity = (System.IntPtr)3;
                MessageBox.Show(myProcess.ProcessorAffinity.ToString());


            }
           

            if (checkBox1.Checked && !checkBox4.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {  Process myProcess = Process.Start("NotePad.exe");
                myProcess.ProcessorAffinity = (System.IntPtr)1;
                MessageBox.Show(myProcess.ProcessorAffinity.ToString());

                  
            }
            else if (checkBox2.Checked && !checkBox4.Checked && !checkBox1.Checked && !checkBox3.Checked)
            {
                Process myProcess = Process.Start("NotePad.exe");
               

                myProcess.ProcessorAffinity = (System.IntPtr)2;
                MessageBox.Show(myProcess.ProcessorAffinity.ToString());

            }
            else if (checkBox3.Checked && !checkBox4.Checked && !checkBox2.Checked && !checkBox1.Checked)
            {
                Process myProcess = Process.Start("NotePad.exe");
                 myProcess.ProcessorAffinity = (System.IntPtr)4;
                MessageBox.Show(myProcess.ProcessorAffinity.ToString());
              
            }
            else if (checkBox4.Checked && !checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
               Process myProcess = Process.Start("NotePad.exe");
                myProcess.ProcessorAffinity = (System.IntPtr)8;
                MessageBox.Show(myProcess.ProcessorAffinity.ToString());

            }
            else if (checkBox4.Checked && checkBox3.Checked && checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                Process eByName = Process.Start("NotePad.exe");
                long AffinityMask = (long)eByName.ProcessorAffinity;
                AffinityMask &= 0x000F; // use only any of the first 4 available processors
               

                eByName.ProcessorAffinity = (System.IntPtr)AffinityMask;
            
                MessageBox.Show(eByName.ProcessorAffinity.ToString());

            }
            else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && !checkBox4.Checked)
            {

                Process myProcess = Process.Start("NotePad.exe");

                myProcess.ProcessorAffinity = (System.IntPtr)7;
                MessageBox.Show(myProcess.ProcessorAffinity.ToString());
                

            }
            else if (checkBox1.Checked && checkBox4.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                 Process myProcess = Process.Start("NotePad.exe"); 
                long AffinityMask = (long)myProcess.ProcessorAffinity; AffinityMask &= 0x0009;
                // use only any of the first 4 available processors
                myProcess.ProcessorAffinity = (System.IntPtr)AffinityMask;
                MessageBox.Show(myProcess.ProcessorAffinity.ToString());

            }
            else if (checkBox3.Checked && checkBox2.Checked && !checkBox1.Checked && ! checkBox4.Checked)
            {
                Process myProcess = Process.Start("NotePad.exe");
                  myProcess.ProcessorAffinity = (System.IntPtr)6;
                
                MessageBox.Show(myProcess.ProcessorAffinity.ToString());

            }
            else if (checkBox3.Checked && checkBox4.Checked && !checkBox1.Checked && !checkBox2.Checked)
            {
                Process myProcess = Process.Start("NotePad.exe");


                long AffinityMask = (long)myProcess.ProcessorAffinity;
                AffinityMask &= 0x000C; // use only any of the first 4 available processors


                myProcess.ProcessorAffinity = (System.IntPtr)AffinityMask;
                MessageBox.Show(myProcess.ProcessorAffinity.ToString());

            }
            else if (checkBox3.Checked && checkBox4.Checked && !checkBox1.Checked && checkBox2.Checked)
            {
                Process myProcess = Process.Start("NotePad.exe");


                long AffinityMask = (long)myProcess.ProcessorAffinity;
                AffinityMask &= 0x000E; // use only any of the first 4 available processors


                myProcess.ProcessorAffinity = (System.IntPtr)AffinityMask;
             MessageBox.Show(myProcess.ProcessorAffinity.ToString());

            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

            

