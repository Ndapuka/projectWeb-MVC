using ProjectWebMVC.Models;
using ProjectWebMVC.Models.Enums;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;

namespace ProjectWebMVC.Data
{
    public class SeedingService
    {
        private ProjectWebMVCContext _context; //Ijection of dependency

        public SeedingService(ProjectWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Electronics");
            Department d2 = new Department(2, "Streaming");
            Department d3 = new Department(3, "Books");
            Department d4 = new Department(4, "Fashion");

            Seller s1 = new Seller(1, "Bob Brown", "bob@hotmail,com", new DateTime(1988, 12, 11), 1000.00, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@hotmail,com", new DateTime(1986, 11, 11), 1100.00, d1);
            Seller s3 = new Seller(3, "Alex Grey", "alexgrey@hotmail,com", new DateTime(1998, 1, 12), 2000.00, d1);
            Seller s4 = new Seller(4, "Martha Red", "martha@hotmail,com", new DateTime(1988, 7, 9), 3500.00, d1);
            Seller s6 = new Seller(6, "Alex Pin", "alex@hotmail,com", new DateTime(1995, 4, 6), 9000.00, d1);
            Seller s7 = new Seller(7, "Frncisc Machine", "franc@hotmail,com", new DateTime(1986, 10, 8), 1150.00, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 24), 11000.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 24), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s3);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 22), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 22), 11000.0, SaleStatus.Billed, s3);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 20), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 09, 21), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 09, 22), 11000.0, SaleStatus.Billed, s4);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 09, 22), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 09, 27), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 09, 29), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2018, 09, 28), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 09, 20), 11000.0, SaleStatus.Billed, s6);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s6);

            SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s6);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2018, 09, 23), 11000.0, SaleStatus.Billed, s4);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2018, 09, 24), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s2);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2018, 09, 22), 11000.0, SaleStatus.Billed, s2);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2018, 09, 27), 11000.0, SaleStatus.Billed, s7);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2018, 09, 28), 11000.0, SaleStatus.Billed, s4);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4,  s6, s7 );
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13,r14, 
                r15, r16,r17, r18, r19, r20, r21, r22, r23, r24, r25);

            _context.SaveChanges();

            Console.WriteLine("Sedding on");
        }
    } 
}
