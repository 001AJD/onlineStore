using OnlineStoreRestApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OnlineStoreRestApi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Customer" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Customer.svc or Customer.svc.cs at the Solution Explorer and start debugging.
    public class Customer : ICustomer
    {
     

        public List<CustomerList> GetAllCustomer()
        {
            List<CustomerList> custList;
            using (var ctx = new db_onlineStoreEntities())
            {
                custList = ctx.sp_getAllUser1().ToList<CustomerList>();
                
            }
            return custList;
        }

        public string RegisterCustomer(string email, string password)
        {
            string response = "success";

            if (email == null && password == null)
            {
                response = "invalid data";
            }
            else
            {
                using (var ctx = new db_onlineStoreEntities())
                {
                    int num;
                    num = ctx.registerCustomer(email, password);

                    response = num.ToString();
                }
            }
            return response;
        }
    }
}
