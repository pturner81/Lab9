using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Students
    {
        //Fields
        private string studentName;
        private string favoriteFood;
        private string hometown;
        

        //Properties
        public string StudentName
        {
            set { studentName = value; }
            get { return studentName; }
        }
        public string FavoriteFood
        {
            set { favoriteFood = value; }
            get { return favoriteFood; }
        }
        public string Hometown
        {
            set { hometown = value; }
            get { return hometown; }
        }
        //Methods
    }
}
