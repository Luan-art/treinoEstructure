using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class InsureceService
    {
        private InsureceRepository ensureRepository;
        public InsureceService()
        {

            ensureRepository = new InsureceRepository();
        }
        public int Insert(Insurance insurece)
        {
            Console.WriteLine("Service");
            return ensureRepository.Insert(insurece);
        }
    }
}
