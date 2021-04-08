using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models {
    public class SeedingService {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context) {
            _context = context;
        }

        public void Seed() {
            if (_context.Department.Any() || _context.SalesRecord.Any() || _context.Seller.Any()) return;

            Department d1 = new Department(1, "Eletronics");
            Department d2 = new Department(2, "TI");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Moses", "maria@gmail.com", new DateTime(1995, 4, 21), 2000.0, d2);
            Seller s3 = new Seller(3, "Alex Alexson", "alex@gmail.com", new DateTime(1993, 4, 21), 3000.0, d1);
            Seller s4 = new Seller(4, "Martha Martin", "martha@gmail.com", new DateTime(1997, 4, 21), 4000.0, d3);
            Seller s5 = new Seller(5, "Donald Duck", "donald@gmail.com", new DateTime(1992, 4, 21), 5000.0, d4);
            Seller s6 = new Seller(6, "Richard Rasmusen", "richard@gmail.com", new DateTime(1990, 4, 21), 6000.0, d2);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(1990, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(1993, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(1992, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(1991, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(1991, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(1997, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(1996, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(1994, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(1995, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(1997, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr11 = new SalesRecord(11, new DateTime(1997, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr12 = new SalesRecord(12, new DateTime(1992, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr13 = new SalesRecord(13, new DateTime(1993, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr14 = new SalesRecord(14, new DateTime(1991, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr15 = new SalesRecord(15, new DateTime(1992, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr16 = new SalesRecord(16, new DateTime(1994, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr17 = new SalesRecord(17, new DateTime(1998, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr18 = new SalesRecord(18, new DateTime(1991, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr19 = new SalesRecord(19, new DateTime(1990, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr20 = new SalesRecord(20, new DateTime(1991, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr21 = new SalesRecord(21, new DateTime(1994, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr22 = new SalesRecord(22, new DateTime(1994, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr23 = new SalesRecord(23, new DateTime(1992, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr24 = new SalesRecord(24, new DateTime(1994, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr25 = new SalesRecord(25, new DateTime(1994, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr26 = new SalesRecord(26, new DateTime(1992, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr27 = new SalesRecord(27, new DateTime(1991, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr28 = new SalesRecord(28, new DateTime(1992, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr29 = new SalesRecord(29, new DateTime(1995, 4, 21), 11000.0, SaleStatus.Billed, s4);
            SalesRecord sr30 = new SalesRecord(30, new DateTime(1997, 4, 21), 11000.0, SaleStatus.Billed, s4);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10, 
                sr11, sr12, sr13, sr14, sr15, sr16, sr17, sr18, sr19, 
                sr20, sr21, sr22, sr23, sr24, sr25, sr26, sr27, sr28, sr29, sr30
            );

            _context.SaveChanges();
        }
    }
}
