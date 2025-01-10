using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carshering2
{
    public class Catalog
    {
        List<Car> list = new List<Car>();
        public void LoadFromFile(string filename = "C:/Users/ADMIN/source/repos/Carshering2/Carshering2/Data/Data.txt")
        {
            ICarClass type = null;

            StreamReader fileData = new StreamReader(filename);
            while (!fileData.EndOfStream)
            {
                string s = fileData.ReadLine();
                if (s.Contains(":"))
                {
                    string[] temp = s.Split(':');
                    Car car = new Car(temp[0], temp[1], temp[2], Convert.ToDecimal(temp[3]), (CarClass)type);
                    list.Add(car);
                }
                else
                {
                    type = new CarClass(s);
                }
            }
        }

        public ListViewItem[] ConvertToListView()
        {
            List<ListViewItem> tempList = new List<ListViewItem>();
            foreach (var cr in list)
            {
                ListViewItem product1 = new ListViewItem(cr.Name);
                product1.SubItems.Add(cr.Specifications.ToString());
                product1.SubItems.Add(cr.RentTime.ToString() + "/" + cr.Price.ToString());
                product1.SubItems.Add(cr.Number.ToString());
                product1.SubItems.Add(cr.CarClass.ToString());
                tempList.Add(product1);
            }
            return tempList.ToArray();
        }

        public Car FindCarNumber(string number)
        {
            return list.FirstOrDefault(item => item.Number == number);
        }
    }
}

