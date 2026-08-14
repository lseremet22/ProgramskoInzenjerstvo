using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RentacarioProject
{
    public class Employee
    {
        private String username;

        public String getUsername()
        {
            return username;
        }

        private String password;
        public String getPassword()
        {
            return password;
        }
        private int position { get; set; }

        public Employee(String username, String password, int position)
        {
            this.username = username;
            this.password = password;
            this.position = position;
        }

        public override string ToString()
        {
            return $"Username: {username}, Password: {password}, Position: {position}";
        }

    }
}
