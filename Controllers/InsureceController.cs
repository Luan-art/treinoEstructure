using Models;
using Repositories;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class InsureceController
    {
        private InsureceService insureceService;

        public InsureceController()
        {
            insureceService = new InsureceService();
        }
        public int Insert(Insurance insurance)
        {

             return insureceService.Insert(insurance);

        }
    }
}
