using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{

    public class Name
    {
        public string name { get; set; }

    }
    public abstract class Details : Name
    {

        public int phone { get; set; }
        public string id { get; set; }
        public int NoOfTrips { get; set; }
        public string email { get; set; }

        public virtual void Display() { }
    }

    public class _TourGuide : Details
    {
        private static int noOfTourGuides = 100;
        private _TripDetails[] arr = new _TripDetails[100];
        public int salary{get; set;}
        public void AssignEachTrip(string n)
        {
           // _TripDetails T = new _TripDetails();
            for (int i = 0; i < fileManager.TripDetails.Count; i++)
            {
                if (fileManager.TripDetails[i].name == n)
                {
                    if (noOfTourGuides > 0)
                    {
                        arr[noOfTourGuides - 1] = fileManager.TripDetails[i];
                        noOfTourGuides--;
                        Int32.Parse(fileManager.tmpTG[4] += 1);
                    }
                    /*else
                    {
                        MessageBox.Show("NO Tour Guides Avilable");
                    }*/
                }
            }
        }
        //tour guide salary is based on number of trips made monthly
        
        public int CalculateSalary()
        {
            int NumberOfTrips = Int32.Parse(fileManager.tmpTG[4]);
            salary = NumberOfTrips * 30;
            int salary_1 = Int32.Parse(fileManager.tmpTG[5]);
            salary_1 = salary;
            return salary;
        }

        //number of tour guides available should be maintained
        public int NoOfAvailableTG()
        {
            return noOfTourGuides;
        }
    }
    public class _Customer : Details
    {
       // int i = 0;
        public List<_TripDetails> bookedTrips;
        public bool discount()
        {
            if (NoOfTrips >= 2)
            {
                MessageBox.Show("You've made more than 2 trips! you will recive a discount");
                return true;
            }
            else
                return false;
        }
        public void bookAtrip(string tripName)
        {
            _TripDetails t = new _TripDetails();
            for (int i = 0; i < fileManager.TripDetails.Count; i++)
            {
                if (fileManager.TripDetails[i].name == tripName)
                {
                    t = fileManager.TripDetails[i];
                    break;
                }
                
            }

            bookedTrips[NoOfTrips] = t;
            NoOfTrips++;
            //fileManager.tmpC[3] = NoOfTrips.ToString();
            fileManager._CustomerR[3].NoOfTrips = NoOfTrips;
            fileManager._CustomerR[5].bookedTrips.Add(t);
          
        }
    }
    public class _Ticket : Name
    {
        _Customer c = new _Customer();
        _TripDetails t = new _TripDetails();
        public int silverNum = 50;
        public int goldNum = 30;
        public int platinumNum = 20;
        //public int numOfSeats { get; set; }
        public string color { get; set; }
        public int price { get; set; }
        public string type { get; set; }
        public int bookingTicket(int num,string type)
        {
            price = 0;
            if (type == "gold" && num<=goldNum)
            {
                price = 70;
                t.NoOfSeats -= num;
                goldNum-=num;
            }
            else if (type == "silver" && num<=silverNum)
            {
                price = 150;
                t.NoOfSeats -= num;
                silverNum -= num;
            }
            else if (type == "platinum" && num <= platinumNum)
            {
                price = 250;
                t.NoOfSeats -= num;
                platinumNum -= num;
            }
            else
            {
                MessageBox.Show("The Ticket is not available");
                return 0;
            }
            return price * num;
        }
        public void checkingDiscount()
        {
            if (c.discount() == true)
            {
       
                price -= 20;
                fileManager.tmpT[1] = price.ToString();
            }
        }
    }
    public class _TripDetails : Name
    {
        public static int NumOfSeats=100;
        public int Id { get; set; }
        public string location { get; set; }
        public string destination { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string type { get; set; }
        public int NoOfSeats { get; set; }

        //public _Ticket ticket { get; set; }
        int trackingNoOfSeats()
        {
            fileManager.tmpTD[7] = NumOfSeats.ToString();
            return NumOfSeats;
        }

    }
    
    public class x
    {
        public void addTourGuide(string n,int p,string i,string e, int s)
        {
            _TourGuide  tourG= new _TourGuide() ;
            tourG.name=n;
            tourG.phone=p;
            tourG.id = i;
            tourG.NoOfTrips=0;
            tourG.email=e;
            tourG.salary=s;
            fileManager.TourGuide.Add(tourG);
            

        }
        public void addCustomer(string n, int p, string i, string e)
        {
            _Customer c = new _Customer();
            c.name = n;
            c.phone = p;
            c.id = i;
            c.NoOfTrips = 0;
            c.email = e;
            c.bookedTrips = new List<_TripDetails>();//yep >_<
            fileManager._CustomerR.Add(c);
        }
        public void editTourGuide(string idtemp , string n, int p ,string idd , int num, string e,int s)
        {
            for (int i = 0;i< fileManager.TourGuide.Count; i++)
            {
                if (i == fileManager.TourGuide.Count - 1 && fileManager.TourGuide[i].id != idtemp)
                {
                    MessageBox.Show("Tour Guide is not found");
                }
                if (fileManager.TourGuide[i].id == idtemp)
                {
                      fileManager.TourGuide[i].name=n;
                    fileManager.TourGuide[i].id = idd;
                    fileManager.TourGuide[i].phone = p;
                    fileManager.TourGuide[i].NoOfTrips = num;
                    fileManager.TourGuide[i].email = e;
                    fileManager.TourGuide[i].salary = s;
                }
            }

        }

        public void editCustomer(string id, string n, int p, string i, int num, string e)
        {

            for (int j = 0; j < fileManager._CustomerR.Count(); j++)
            {             

                if (fileManager._CustomerR[j].id == id)
                {

                    fileManager._CustomerR[j].name = n;
                    fileManager._CustomerR[j].id = i;
                    fileManager._CustomerR[j].phone = p;
                    fileManager._CustomerR[j].NoOfTrips = num;
                    fileManager._CustomerR[j].email = e;
                    break;

                }
                if (j==fileManager._CustomerR.Count()-1)
                {
                    MessageBox.Show("Customer Not found");
                }
            }
        }
        public void deleteTourGuide( string n)
        {
            for (int i = 0; i < fileManager.TourGuide.Count; i++)
            {
                fileManager.TourGuide.RemoveAt(i);
                fileManager.TourGuide.RemoveAt(i + 1);
                fileManager.TourGuide.RemoveAt(i + 2);
                fileManager.TourGuide.RemoveAt(i + 3);
                fileManager.TourGuide.RemoveAt(i + 4);
                fileManager.TourGuide.RemoveAt(i + 5);
                //fileManager.TourGuide.RemoveAt(i + 6);
                MessageBox.Show("Tour guide is Removed");
            }

        }
        public void deleteCustomer(string n) {

            for (int i = 0; i < fileManager._CustomerR.Count; i++)
            {
                if (fileManager._CustomerR[i].name == n)
                {
                    fileManager._CustomerR.RemoveAt(i);
                    fileManager._CustomerR.RemoveAt(i + 1);
                    fileManager._CustomerR.RemoveAt(i + 2);
                   fileManager. _CustomerR.RemoveAt(i + 3);
                    /*fileManager._CustomerR.RemoveAt(i + 4);
                    fileManager._CustomerR.RemoveAt(i + 5);*/
                }
                if (i == fileManager._CustomerR.Count - 1 && fileManager._CustomerR[i].name != n)
                {
                    MessageBox.Show(" Name not found to be deleted ! ");
                }

            }
        }
        public void displayTourGuide(string t2,Label dt)
        {
            string dis = " ";
            for(int i=0;i< fileManager.TourGuide.Count; i++){
                if (t2 == fileManager.TourGuide[i].name)
                {
                    dis += (fileManager.TourGuide[i].name + "\n");
                    dis += (fileManager.TourGuide[i].id + "\n");
                    dis += (fileManager.TourGuide[i].phone + "\n");
                    dis += (fileManager.TourGuide[i].NoOfTrips + "\n");
                    dis += (fileManager.TourGuide[i].email + "\n");
                    dis += (fileManager.TourGuide[i].salary + "\n");
                    break;
                }
            }

            if (dt.InvokeRequired)
                dt.Invoke(new MethodInvoker(delegate
                {
                    dt.Text = dis;
                }));
            else
                dt.Text = dis;
             

        }
        public void displayCustomer(Label dC, string t1) {
            string dis = "";
          
            
            for (int i = 0; i < fileManager._CustomerR.Count; i++)
            {
                if (t1 == fileManager._CustomerR[i].name)
                {
                    dis += (fileManager._CustomerR[i].name + "\n");
                    dis += (fileManager._CustomerR[i].id + "\n");
                    dis += (fileManager._CustomerR[i].phone + "\n");
                    dis += (fileManager._CustomerR[i].NoOfTrips + "\n");
                    dis += (fileManager._CustomerR[i].email + "\n");

                    break;
                }

            }

            if (dC.InvokeRequired)
                dC.Invoke(new MethodInvoker(delegate
                {
                    dC.Text = dis;
                }));
            else
                dC.Text = dis;
            }






       /* internal void addCustomer(string n, int p1, int m, int p2, string u)
        {
            throw new NotImplementedException();
        */
    }
    public static class fileManager
    {
        public static List<string> tmpC = File.ReadAllLines("Customer.txt").ToList();
        public static List<string> tmpTG = File.ReadAllLines("TourGuide.txt").ToList();
        public static List<string> tmpTD = File.ReadAllLines("TripDetails.txt").ToList();
        public static List<string> tmpT = File.ReadAllLines("Ticket.txt").ToList();
        public static List<_Customer> _CustomerR = new List<_Customer>();
        public static List<_TourGuide> TourGuide = new List<_TourGuide>();
        public static List<_TripDetails> TripDetails = new List<_TripDetails>();
        public static List<_Ticket> Ticket = new List<_Ticket>();
        //public fileManager() { }
        public static void GetData()
        {
            for (int i = 0; i < tmpC.Count; i++)
            {
                if (i % 6 == 0)
                {
                    _Customer tmpc = new _Customer();
                    tmpc.name = tmpC[i];
                    tmpc.phone = Int32.Parse(tmpC[i + 1]);
                    tmpc.id = tmpC[i + 2];
                    tmpc.NoOfTrips =Int32.Parse(tmpC[i + 3]);
                    tmpc.email = tmpC[i + 4];
                    string[] trips = tmpC[i + 5].Split(',');

                    for (int j = 0; j < trips.Count(); j++)
                    {
                        _TripDetails TD = new _TripDetails();
                        string[] boga = trips[j].Split('.');
                        if (i % 7 == 0)
                        {
                            TD.Id = Int32.Parse(boga[j]);
                            TD.location = boga[j + 1];
                            TD.destination = boga[j + 2];
                            TD.StartDate = boga[j + 3];
                            TD.EndDate = boga[j + 4];
                            TD.type = boga[j + 5];
                            TD.NoOfSeats = Int32.Parse(boga[j + 6]);
                        }
                        tmpc.bookedTrips.Add(TD);

                    }

                    /*
                     Ahmed
                     555555555
                     98156645752
                     7
                     ggizi@bots.aa
                     ID.location.destenation.4.5.6.7,--------,--------
                     * 
                     * * 
                     * 
                     id+.+location+.+aaaa+a++++end+,+
                         
                     habd  habd  habd habd habd habd habd habd habd habd habd habd
                     */
                    _CustomerR.Add(tmpc);
                }
            }
            for (int i = 0; i < tmpTG.Count; i++)
            {
                if (i % 6 == 0)
                {
                    _TourGuide tmpt = new _TourGuide();

                    tmpt.name = tmpTG[i];
                    tmpt.phone = Int32.Parse(tmpTG[i + 1]);
                    tmpt.id = tmpTG[i + 2];
                    tmpt.NoOfTrips = Int32.Parse(tmpTG[i + 3]);
                    tmpt.email = tmpTG[i + 4];
                    tmpt.salary = Int32.Parse(tmpTG[i + 5]);
                    TourGuide.Add(tmpt);
                }
            }

            for (int i = 0; i < tmpTD.Count; i++)
            {
                if (i % 8 == 0)
                {
                    _TripDetails tmpd = new _TripDetails();

                    tmpd.name = tmpTD[i];
                    tmpd.Id = Int32.Parse(tmpTD[i + 1]);
                    tmpd.location = tmpTD[i + 2];
                    tmpd.destination = tmpTD[i + 3];
                    tmpd.StartDate = tmpTD[i + 4];
                    tmpd.EndDate = tmpTD[i + 5];
                    tmpd.type = tmpTD[i + 6];
                    tmpd.NoOfSeats = Int32.Parse(tmpTD[i + 7]);

                }
            }
            for (int i = 0; i < tmpT.Count; i++)
            {
                if (i % 4 == 0)
                {
                    _Ticket tmp = new _Ticket();

                    tmp.name = tmpT[i];
                    tmp.color = tmpT[i + 1];
                    tmp.price = Int32.Parse(tmpT[i + 2]);
                    tmp.type = tmpT[i + 3];

                }
            }

        }

        /*public class _Customer : Details
        {

            public List<_TripDetails> bookedTrips;
            public bool discount()
            {
                if (NoOfTrips >= 2)
                {
                    MessageBox.Show("You've made more than 2 trips! you will recive a discount");
                    return true;
                }
                else
                    return false;
            }
        }*/
           /* public void add();
            public void edit();
            public _Customer delete();
            public override void Display()
            {

            }*/

        


        public static void saveData()
        {
            List<string> newTourGuide = new List<string>();
            List<string> newTripDetails = new List<string>();
            List<string> newCustomer = new List<string>();
            List<string> newTicket = new List<string>();
            /*...................................................................................*/
            for (int i = 0; i < fileManager.Ticket.Count; i++)
            {
                newTicket.Add(fileManager.Ticket[i].name);
                newTicket.Add(fileManager.Ticket[i].color);
                newTicket.Add(fileManager.Ticket[i].price.ToString());
                newTicket.Add(fileManager.Ticket[i].type);
            }
            File.Delete("Ticket.txt");
            using (StreamWriter newTask = new StreamWriter("Ticket.txt", false))
            {
                for (int i = 0; i < newTicket.Count; i++)
                {
                    newTask.WriteLine(newTicket[i].ToString());
                }
                newTask.Close();
                newTask.Dispose();

            }
            /*......................................................................................*/
            for (int i = 0; i < fileManager.TourGuide.Count; i++)
            {
                newTourGuide.Add(fileManager.TourGuide[i].name);
                newTourGuide.Add(fileManager.TourGuide[i].phone.ToString());
                newTourGuide.Add(fileManager.TourGuide[i].id.ToString());
                newTourGuide.Add(fileManager.TourGuide[i].NoOfTrips.ToString());
                newTourGuide.Add(fileManager.TourGuide[i].email.ToString());
                newTourGuide.Add(fileManager.TourGuide[i].salary.ToString());
            }
            File.Delete("TourGuide.txt");
            using (StreamWriter newTask = new StreamWriter("TourGuide.txt", false))
            {
                for (int i = 0; i < newTourGuide.Count; i++)
                {
                    newTask.WriteLine(newTourGuide[i].ToString());
                }
                newTask.Close();
                newTask.Dispose();


            }

            /*....................................................................................................*/
            for (int i = 0; i < fileManager.TripDetails.Count; i++)
            {
                newTripDetails.Add(fileManager.TripDetails[i].name);
                newTripDetails.Add(fileManager.TripDetails[i].Id.ToString());
                newTripDetails.Add(fileManager.TripDetails[i].location);
                newTripDetails.Add(fileManager.TripDetails[i].destination);
                newTripDetails.Add(fileManager.TripDetails[i].StartDate);
                newTripDetails.Add(fileManager.TripDetails[i].EndDate);
                newTripDetails.Add(fileManager.TripDetails[i].type);
                newTripDetails.Add(fileManager.TripDetails[i].NoOfSeats.ToString());
            }
            File.Delete("TripDetails.txt");
            using (StreamWriter newTask = new StreamWriter("TripDetails.txt", false))
            {
                for (int i = 0; i < newTripDetails.Count; i++)
                {
                    newTask.WriteLine(newTripDetails[i].ToString());
                }
                newTask.Close();
                newTask.Dispose();


            }
            /*...........................................................................................................*/
            for (int i = 0; i < fileManager._CustomerR.Count; i++)
            {
                newCustomer.Add(fileManager._CustomerR[i].name);
                newCustomer.Add(fileManager._CustomerR[i].phone.ToString());
                newCustomer.Add(fileManager._CustomerR[i].id.ToString());
                newCustomer.Add(fileManager._CustomerR[i].NoOfTrips.ToString());
                newCustomer.Add(fileManager._CustomerR[i].email);
                
                string Line = "Null";
                for (int j = 0; j < fileManager._CustomerR[i].bookedTrips.Count; j++)
                {
                    string name = fileManager._CustomerR[i].bookedTrips[j].name.ToString();
                    string id = fileManager._CustomerR[i].bookedTrips[j].Id.ToString();
                    string Location = fileManager._CustomerR[i].bookedTrips[j].location.ToString();
                    string dest = fileManager._CustomerR[i].bookedTrips[j].destination.ToString();
                    string SD = fileManager._CustomerR[i].bookedTrips[j].StartDate.ToString();
                    string ED = fileManager._CustomerR[i].bookedTrips[j].EndDate.ToString();
                    string t = fileManager._CustomerR[i].bookedTrips[j].type.ToString();
                    string seats = fileManager._CustomerR[i].bookedTrips[j].NoOfSeats.ToString();
                    Line +=name +"." + id + "." + Location + "." + dest + "." + SD + "." + ED + "." + t + "." + seats;
                    if (j == fileManager._CustomerR[i].bookedTrips.Count - 1)
                    {
                        Line += ",";
                    }
                }
              //  MessageBox.Show(Line + "\n");
              ////  Line.Remove(Line.Count() - 1);
              //  MessageBox.Show(Line);
                newCustomer.Add(Line);

            }
            File.Delete("Customer.txt");
            using (StreamWriter newTask = new StreamWriter("Customer.txt", false))
            {
                for (int i = 0; i < newCustomer.Count; i++)
                {
                    newTask.WriteLine(newCustomer[i].ToString());
                }
                newTask.Close();
                newTask.Dispose();


            }

        }
    }
}